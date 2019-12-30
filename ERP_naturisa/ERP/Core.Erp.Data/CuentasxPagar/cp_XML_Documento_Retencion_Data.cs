using Core.Erp.Info.class_sri;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri.Retencion;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_XML_Documento_Retencion_Data
    {
        public List<cp_XML_Documento_Retencion_Info> GetList(int IdEmpresa, decimal IdDocumento)
        {
            try
            {
                List<cp_XML_Documento_Retencion_Info> Lista = new List<cp_XML_Documento_Retencion_Info>();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var lst = db.cp_XML_Documento_Retencion.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new cp_XML_Documento_Retencion_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdDocumento = item.IdDocumento,
                            Secuencia = item.Secuencia,
                            re_tipoRet = item.re_tipoRet,
                            re_baseRetencion = item.re_baseRetencion,
                            IdCodigo_SRI = item.IdCodigo_SRI,
                            re_Codigo_impuesto = item.re_Codigo_impuesto,
                            re_Porcen_retencion = item.re_Porcen_retencion,
                            re_valor_retencion = item.re_valor_retencion,
                        });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<comprobanteRetencion> GenerarXmlRetencion(List<cp_XML_Documento_Info> consulta, int IdEmpresa, decimal IdDocumento)
        {

            try
            {
                string secuencia_aux = "";
                string secuencia = "";

                List<comprobanteRetencion> lista = new List<comprobanteRetencion>();
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();
               

                foreach (var item in consulta)
                {
                    comprobanteRetencion myObjectRete = new comprobanteRetencion();

                    myObjectRete.version = "1.0.0";
                    myObjectRete.idSpecified = true;
                    myObjectRete.infoTributaria = new infoTributaria();
                    myObjectRete.infoCompRetencion = new comprobanteRetencionInfoCompRetencion();
                    myObjectRete.impuestos = new List<Info.class_sri.Retencion.impuesto>();
                    myObjectRete.infoTributaria.ambiente = "1";
                    myObjectRete.infoTributaria.tipoEmision = "1";
                    myObjectRete.infoTributaria.razonSocial = item.RazonSocial.Trim();  //empresa validar
                    myObjectRete.infoTributaria.nombreComercial = item.NombreComercial.Trim(); //empresa validar
                    myObjectRete.infoTributaria.ruc = item.em_ruc.Trim(); //empresa validar
                    myObjectRete.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                    myObjectRete.infoTributaria.codDoc = "07";


                    //validar secuencial retencion
                    secuencia_aux = "";
                    secuencia = "";

                    if (!String.IsNullOrEmpty(item.ret_NumeroDocumento))
                    {
                        if (item.ret_NumeroDocumento.Length < 9)
                        {
                            int conta = item.ret_NumeroDocumento.Length;
                            int diferencia = 9 - conta;

                            secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                            secuencia = secuencia_aux + item.ret_NumeroDocumento;

                            item.ret_NumeroDocumento = secuencia;

                        }

                    }

                    string[] serie = Convert.ToString(item.serie).Split('-');

                    myObjectRete.infoTributaria.estab = serie[0].Trim();  // retencion
                    myObjectRete.infoTributaria.ptoEmi = serie[1].Trim(); ; // retencion


                    myObjectRete.infoTributaria.secuencial = item.ret_NumeroDocumento; // retencion validar ceros a la izquierda

                    myObjectRete.infoTributaria.dirMatriz = item.em_direccion.Trim();  //empresa validar


                    myObjectRete.infoCompRetencion.fechaEmision = Convert.ToDateTime(item.ret_Fecha).Date.ToString("dd/MM/yyyy"); // factura


                    myObjectRete.infoCompRetencion.dirEstablecimiento = item.em_direccion; ///sucursal
                    myObjectRete.infoCompRetencion.contribuyenteEspecial = item.ContribuyenteEspecial; //empresa   
                    myObjectRete.infoCompRetencion.obligadoContabilidad = (item.ObligadoAllevarConta == "S" || item.ObligadoAllevarConta == "SI") ? "SI" : "NO";

                    switch (item.IdTipoDocumento)
                    {
                        case "CED":
                            myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "05";
                            break;
                        case "PAS":
                            myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "06";
                            break;

                        case "RUC":
                            myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "04";
                            break;
                        default:
                            break;
                    }

                    myObjectRete.infoCompRetencion.razonSocialSujetoRetenido = item.pe_nombreCompleto.Replace('*',' ').Trim(); // proveedor
                    myObjectRete.infoCompRetencion.identificacionSujetoRetenido = item.emi_Ruc.Trim();  // cedula o ruc
                    myObjectRete.infoCompRetencion.periodoFiscal = Convert.ToString(myObjectRete.infoCompRetencion.fechaEmision).Substring(3, 7); // factura


                    // consultar detalle Retencion

                    List<cp_XML_Documento_Retencion_Info> listaDetReten = new List<cp_XML_Documento_Retencion_Info>();

                    listaDetReten = GetList(IdEmpresa, IdDocumento);

                    if (listaDetReten.Count != 0)
                    {

                        foreach (var itemDET in listaDetReten)
                        {
                            Info.class_sri.Retencion.impuesto imp = new Info.class_sri.Retencion.impuesto();

                            if (itemDET.re_tipoRet == "IVA")
                            {
                                imp.codigo = "2";


                                switch (Convert.ToString(itemDET.re_Porcen_retencion))
                                {

                                    case "0":
                                        imp.codigoRetencion = "8";
                                        imp.porcentajeRetener = 0;
                                        break;
                                    case "10":
                                        imp.codigoRetencion = "9";
                                        imp.porcentajeRetener = 10;
                                        break;
                                    case "20":
                                        imp.codigoRetencion = "10";
                                        imp.porcentajeRetener = 20;
                                        break;
                                    case "30":
                                        imp.codigoRetencion = "1";
                                        imp.porcentajeRetener = 30;
                                        break;
                                    case "50":
                                        imp.codigoRetencion = "11";
                                        imp.porcentajeRetener = 50;
                                        break;
                                    case "70":
                                        imp.codigoRetencion = "2";
                                        imp.porcentajeRetener = 70;
                                        break;
                                    case "100":
                                        imp.codigoRetencion = "3";
                                        imp.porcentajeRetener = 100;
                                        break;
                                    default:
                                        break;
                                }
                            }

                            if (itemDET.re_tipoRet == "RTF")
                            {
                                imp.codigo = "1";
                                imp.codigoRetencion = itemDET.re_Codigo_impuesto;
                                imp.porcentajeRetener = Convert.ToDecimal(itemDET.re_Porcen_retencion);

                            }

                            imp.baseImponible = Math.Round(Convert.ToDecimal(itemDET.re_baseRetencion), 2);
                            imp.valorRetenido = Math.Round(Convert.ToDecimal(itemDET.re_valor_retencion), 2);
                            imp.codDocSustento = item.CodDocumento;   //si factura es 01 y 

                            // validar secuencial factura
                            secuencia_aux = "";
                            secuencia = "";

                            if (!String.IsNullOrEmpty(item.NumeroDocumento))
                            {
                                if (item.NumeroDocumento.Length < 9)
                                {
                                    int conta = item.NumeroDocumento.Length;
                                    int diferencia = 9 - conta;

                                    secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                                    secuencia = secuencia_aux + item.NumeroDocumento;

                                    item.NumeroDocumento = secuencia;
                                }
                            }

                            string[] serieFact = Convert.ToString(item.co_serie).Split('-');

                            imp.numDocSustento = serieFact[0].Trim() + serieFact[1].Trim() + Convert.ToString(item.NumeroDocumento).Trim();
                            imp.fechaEmisionDocSustento = Convert.ToDateTime(item.FechaEmision).ToString("dd/MM/yyyy");

                            // myObjectRete.infoCompRetencion.fechaEmision = item.co_FechaFactura.ToString(format);
                            myObjectRete.impuestos.Add(imp);


                            if (!String.IsNullOrEmpty(item.pe_correo.Trim()))
                            {
                                string campoAdicional = item.pe_correo.Trim();
                                // campos adicionales               
                                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                                if (!String.IsNullOrEmpty(campoAdicional))
                                {
                                    if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                    {
                                        comprobanteRetencionCampoAdicional compoadicional = new comprobanteRetencionCampoAdicional();
                                        compoadicional.nombre = "MAIL";
                                        compoadicional.Value = campoAdicional;
                                        myObjectRete.infoAdicional = new List<comprobanteRetencionCampoAdicional>();
                                        myObjectRete.infoAdicional.Add(compoadicional);
                                    }

                                }

                            }

                        }

                    }

                    lista.Add(myObjectRete);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
