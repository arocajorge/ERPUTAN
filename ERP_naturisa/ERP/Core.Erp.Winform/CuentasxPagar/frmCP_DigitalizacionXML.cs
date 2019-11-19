﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.IO;
using Core.Erp.Business.CuentasxPagar;
using System.Diagnostics;
using Core.Erp.Info.CuentasxPagar;
using System.Xml.Linq;
using System.Xml;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_DigitalizacionXML : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_RutaPorEmpresaPorUsuario_Bus bus_ruta;
        BindingList<cp_XML_Documento_Info> blst;
        cp_XML_Documento_Bus bus_xml;
        tb_sis_impuesto_Bus bus_impuesto;
        #endregion

        public frmCP_DigitalizacionXML()
        {
            InitializeComponent();
            bus_ruta = new cp_RutaPorEmpresaPorUsuario_Bus();
            blst = new BindingList<cp_XML_Documento_Info>();
            bus_xml = new cp_XML_Documento_Bus();
            bus_impuesto = new tb_sis_impuesto_Bus();
        }

        private void txtRutaXml_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Reset();
                folder.Description = " Seleccionar una carpeta ";
                folder.SelectedPath = txtRutaXml.Text;

                folder.ShowNewFolderButton = false;
                DialogResult ret = new DialogResult();
                ret = folder.ShowDialog();
                txtRutaXml.Text = folder.SelectedPath + @"\";
                folder.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnVerificarCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                bus_ruta.GuardarDB(new cp_RutaPorEmpresaPorUsuario_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdUsuario = param.IdUsuario,
                    RutaXML = txtRutaXml.Text
                });

                blst = new BindingList<cp_XML_Documento_Info>();
                string folder = txtRutaXml.Text;
                string filter = "*.XML*";
                string[] files = Directory.GetFiles(folder, filter);

                foreach (var item in files)
                {
                    string readText = File.ReadAllText(item);
                    XmlDocument xmlComprobanteOrigen = new XmlDocument();
                    xmlComprobanteOrigen.Load(new StringReader(readText));
                    string mensajeErrorOut = string.Empty;
                    string sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml, ref mensajeErrorOut);

                    var rootElement = XElement.Parse(sXml_a_descerializar);
                    var infoFactura = rootElement.Element("infoFactura");
                    var infoTributaria = rootElement.Element("infoTributaria");
                    var IdentificacionComprador = infoFactura.Element("identificacionComprador").Value;

                    if (IdentificacionComprador == param.InfoEmpresa.em_ruc)
                    {
                        var Documento = new cp_XML_Documento_Info
                        {
                            XML = sXml_a_descerializar,
                            Tipo = infoTributaria.Element("codDoc").Value == "01" ? "FACTURA" : "NOTA DE CREDITO",
                            emi_Ruc = infoTributaria.Element("ruc").Value,
                            emi_RazonSocial = infoTributaria.Element("razonSocial").Value,
                            emi_NombreComercial = infoTributaria.Element("nombreComercial") == null ? infoTributaria.Element("razonSocial").Value : infoTributaria.Element("nombreComercial").Value,
                            ClaveAcceso = infoTributaria.Element("claveAcceso").Value,
                            
                            CodDocumento = infoTributaria.Element("codDoc").Value,
                            Establecimiento = infoTributaria.Element("estab").Value,
                            PuntoEmision = infoTributaria.Element("ptoEmi").Value,
                            NumeroDocumento = infoTributaria.Element("secuencial").Value,
                            emi_DireccionMatriz = infoTributaria.Element("dirMatriz").Value,


                            FechaEmision = DateTime.ParseExact(infoFactura.Element("fechaEmision").Value, "dd/MM/yyyy",System.Globalization.CultureInfo.CurrentCulture),
                            rec_RazonSocial = infoFactura.Element("razonSocialComprador").Value,
                            rec_Identificacion = infoFactura.Element("identificacionComprador").Value    
                        };
                        Documento.FormaPago = infoFactura.Element("pagos") == null ? null : infoFactura.Element("pagos").Element("pago") == null ? null : (infoFactura.Element("pagos").Element("pago").Element("formaPago") == null ? null : infoFactura.Element("pagos").Element("pago").Element("formaPago").Value);
                        Documento.Plazo = infoFactura.Element("pagos").Element("pago").Element("plazo") == null ? 0 : Convert.ToInt32(Convert.ToDecimal(infoFactura.Element("pagos").Element("pago").Element("plazo").Value));

                        var list = infoFactura.Element("totalConImpuestos").Elements("totalImpuesto")
                           .Select(element => element)
                           .ToList();
                        Documento.SubtotalIVA = 0;
                        Documento.Subtotal0 = 0;
                        Documento.ValorIVA = 0;

                        foreach (var Impuesto in list)
                        {
                            Documento.Porcentaje = Convert.ToDouble(Impuesto.Element("valor").Value);

                            if (Documento.Porcentaje == 0)
                            {
                                Documento.Subtotal0 += Convert.ToDouble(Impuesto.Element("baseImponible").Value);
                            }
                            else
                            {
                                Documento.SubtotalIVA += Convert.ToDouble(Impuesto.Element("baseImponible").Value);
                                Documento.ValorIVA += Convert.ToDouble(Impuesto.Element("valor").Value);
                                Documento.Porcentaje = bus_impuesto.Get_Info_impuesto(param.Get_Parametro_Info(tb_parametro_enum.P_IVA).Valor).porcentaje;
                            }
                        }
                        Documento.Total = Documento.Subtotal0 + Documento.SubtotalIVA + Documento.ValorIVA;
                        Documento.Comprobante = Documento.Establecimiento + "-" + Documento.PuntoEmision + "-" + Documento.NumeroDocumento;
                        Documento.Imagen = bus_xml.Existe(param.IdEmpresa, Documento.emi_Ruc, Documento.CodDocumento, Documento.Establecimiento, Documento.PuntoEmision, Documento.NumeroDocumento);
                        blst.Add(Documento);
                        gcDetalle.DataSource = null;
                        gcDetalle.DataSource = blst;
                    }
                }

                gcDetalle.DataSource = blst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Quitar_a_xml_CDATA_y_Signature(string InnerXml_Cbte, ref string msgError)
        {
            try
            {

                string sXml_a_descerializar = InnerXml_Cbte;
                string sValor_a_Reemplezar_cdata = "<![CDATA[";

                sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");
                sValor_a_Reemplezar_cdata = "]]>";
                sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");

                XmlDocument xml_valido = new System.Xml.XmlDocument();
                xml_valido.LoadXml(sXml_a_descerializar);

                // removiendo los datos de la firma 
                XmlNodeList nodeFirma = xml_valido.GetElementsByTagName("ds:Signature");
                nodeFirma.Item(0).RemoveAll();

                string valorareem = "<ds:Signature xmlns:ds=\"http://www.w3.org/2000/09/xmldsig#\"></ds:Signature>";

                sXml_a_descerializar = xml_valido.InnerXml;
                sXml_a_descerializar = sXml_a_descerializar.Replace(valorareem, "");


                return sXml_a_descerializar;

            }
            catch (Exception ex)
            {
                msgError = ex.Message;
                return "";
            }
        }

        private void frmCP_DigitalizacionXML_Load(object sender, EventArgs e)
        {
            try
            {
                var Ruta = bus_ruta.GetInfo(param.IdEmpresa, param.IdUsuario);
                txtRutaXml.Text = Ruta == null ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : Ruta.RutaXML;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gcDetalle.ShowPrintPreview();
        }

        private void btnDigitalizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in blst)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    bus_xml.GuardarDB(item);
                    item.Imagen = 2;
                }
                gcDetalle.Refresh();
                gcDetalle.RefreshDataSource();
                gcDetalle.DataSource = blst;
                MessageBox.Show("Registros digitalizados exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

    }
}
