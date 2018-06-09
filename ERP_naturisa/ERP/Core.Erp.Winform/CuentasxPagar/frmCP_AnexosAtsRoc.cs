using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using refere = Microsoft.VisualBasic.Devices;
using System.Globalization;


using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar.xmlREOC;
using Core.Erp.Business.Facturacion;

using Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_AnexosAtsRoc : Form
    {
        public frmCP_AnexosAtsRoc()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_Mes_Bus mes_D = new tb_Mes_Bus();
        ct_AnioFiscal_Bus AnoF_B = new ct_AnioFiscal_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<cp_retencion_det_Info> ListaRetencion = new List<cp_retencion_det_Info>();
        cp_retencion_Bus Retencion_B = new cp_retencion_Bus();
        tb_Empresa_Info Empresa_I = new tb_Empresa_Info();
        tb_Empresa_Bus Empresa_B = new tb_Empresa_Bus();
        Funciones F = new Funciones();
        refere.ServerComputer Cp = new refere.ServerComputer();
        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();

        cp_retencion_Info info_Retencion_x_RF = new cp_retencion_Info();
        cp_retencion_Info info_Retencion_x_RIVA = new cp_retencion_Info();

        iva DS_Iva_REOC_XML = new iva();



        string direcDoc = "";
      
        
        private iva CargaDatos()
        {
             iva iva= new iva();

            try
            {
             
                progressBar1.Value = 40;

                cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
                List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
                List<cp_codigo_SRI_Info> ListCodigoSustento = new List<cp_codigo_SRI_Info>();
                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa);

                ListCodigoSustento = ListCodigoSRI.FindAll(c => c.co_estado == "A" && c.IdTipoSRI == "COD_IDCREDITO");

                List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();
                cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
                LstTipDoc = TipDoc_B.Get_List_TipoDocumento();

               
                    cp_orden_giro_pagos_sri_Bus formasPago_B = new cp_orden_giro_pagos_sri_Bus();
                    cp_orden_giro_Bus OGB = new cp_orden_giro_Bus();
                    cp_proveedor_Autorizacion_Bus Autorizacion_B = new cp_proveedor_Autorizacion_Bus();
                    cp_proveedor_Bus Proveedor_B = new cp_proveedor_Bus();
                    tb_persona_bus Persona_B = new tb_persona_bus();

                    List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras> lstDetalleCompras = new List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras>();
                    List<cp_orden_giro_Info> listaOG = new List<cp_orden_giro_Info>();
                    listaOG = OGB.Get_List_orden_giro_SRI(param.IdEmpresa, Convert.ToInt32(cmb_anio.Text), Convert.ToInt32(cmb_periodo.SelectedValue));

                    


                    iva.IdInformante = Empresa_I.em_ruc;
                    iva.razonSocial = Empresa_I.RazonSocial.Replace(".", " ");
                    iva.Anio = cmb_anio.Text;
                    iva.Mes = (cmb_periodo.SelectedValue.ToString().Length == 1) ? "0" + cmb_periodo.SelectedValue.ToString() : cmb_periodo.SelectedValue.ToString();

                    tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
                    int numEstablecimiento = bus_sucursal.Get_numEstablecimiento_x_empresa_SRI(param.IdEmpresa);
                    iva.numEstabRuc = numEstablecimiento.ToString("000");
                

                    iva.TipoIDInformante = ivaTypeTipoIDInformante.R;
                    iva.codigoOperativo = codigoOperativoType.IVA;
                    iva.totalVentas = 0;




                    foreach (cp_orden_giro_Info item in listaOG)
                    {
                        try
                        {
                            Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras itemDetalleCompras = new Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras();
                            if (item.IdCbteCble_Ogiro == 9)
                            {
                                
                            }
                            info_Retencion_x_RF = Retencion_B.Get_Info_retencion_X_Retecion_FT(param.IdEmpresa, item.IdCbteCble_Ogiro, item.IdTipoCbte_Ogiro);
                            info_Retencion_x_RIVA = Retencion_B.Get_Info_retencion_X_Retecion_RTIVA(param.IdEmpresa, item.IdCbteCble_Ogiro, item.IdTipoCbte_Ogiro);
                                                        
                            string secuenci_numReten = "";
                            List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAir> LstdetalleAir = new List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAir>();
                            string fecRet = info_Retencion_x_RF.fecha.ToString("dd/MM/yyyy");


                            if (info_Retencion_x_RF.ListDetalle.Count != 0)
                            {
                             
                                foreach (var item2 in info_Retencion_x_RF.ListDetalle)
                                {
                                    Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAir detalleAir = new Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAir();
                                    detalleAir.codRetAir = item2.CodigoSRI.Trim();

                                    detalleAir.porcentajeAir = Convert.ToDecimal(item2.re_Porcen_retencion).ToString();
                                    detalleAir.baseImpAir = Convert.ToDecimal(item2.re_baseRetencion).ToString();

                                    fecRet = info_Retencion_x_RF.fecha.ToString("dd/MM/yyyy");
                                    detalleAir.valRetAir = Convert.ToDecimal(item2.re_valor_retencion).ToString();
                                    LstdetalleAir.Add(detalleAir);
                                }
                            }


                                    itemDetalleCompras.valRetBien10 = "0";
                                    itemDetalleCompras.valRetServ20 = "0";
                                    itemDetalleCompras.valRetServ50 = "0";
                                    itemDetalleCompras.valRetServ100 = "0";
                                    itemDetalleCompras.valorRetBienes = "0";
                                    itemDetalleCompras.valorRetServicios = "0";
                                    itemDetalleCompras.totbasesImpReemb = "0";


                            if (info_Retencion_x_RIVA.ListDetalle.Count != 0)
                            {

                                foreach (var item_iva in info_Retencion_x_RIVA.ListDetalle)
                                {
                                    if (item_iva.re_Porcen_retencion == 10)
                                    {
                                        itemDetalleCompras.valRetBien10 = Convert.ToDecimal(item_iva.re_valor_retencion).ToString();
                                    }

                                    if (item_iva.re_Porcen_retencion == 20)
                                    {
                                        itemDetalleCompras.valRetServ20 = Convert.ToDecimal(item_iva.re_valor_retencion).ToString();
                                    }

                                    if (item_iva.re_Porcen_retencion == 30)
                                    {
                                        itemDetalleCompras.valorRetBienes = Convert.ToDecimal(item_iva.re_valor_retencion).ToString();
                                    }

                                    if (item_iva.re_Porcen_retencion == 50)
                                    {
                                        itemDetalleCompras.valRetServ50 = Convert.ToDecimal(item_iva.re_valor_retencion).ToString();
                                    }

                                    if (item_iva.re_Porcen_retencion == 70)
                                    {
                                        itemDetalleCompras.valorRetServicios = Convert.ToDecimal(item_iva.re_valor_retencion).ToString();
                                    }


                                    if (item_iva.re_Porcen_retencion == 100)
                                    {
                                        itemDetalleCompras.valRetServ100 = Convert.ToDecimal(item_iva.re_valor_retencion).ToString();
                                    }
                                    
                                    
                                }
                            }



                            if (item.IdIden_credito != 0)
                            {
                                var sustento = ListCodigoSustento.First(c => c.IdCodigo_SRI == item.IdIden_credito);
                                itemDetalleCompras.codSustento = sustento.codigoSRI;
                            }


                            if (!String.IsNullOrEmpty(item.co_serie))
                            {
                                string[] serie = Convert.ToString(item.co_serie).Split('-');

                                itemDetalleCompras.establecimiento = serie[0];
                                itemDetalleCompras.puntoEmision = serie[1];
                            }


                            itemDetalleCompras.secuencial = item.co_factura;

                            //if (item.co_factura == "000002133") { MessageBox.Show(""); }

                        

                            itemDetalleCompras.fechaRegistro = Convert.ToDateTime(item.co_FechaContabilizacion).ToString("dd/MM/yyyy");
                            itemDetalleCompras.idProv = item.InfoProveedor.Persona_Info.pe_cedulaRuc.Trim();
                            itemDetalleCompras.tpIdProv = (item.InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "RUC") ? "01" : ((item.InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "CED") ? "02" : "03");
                            itemDetalleCompras.parteRel = (item.InfoProveedor.es_empresa_relacionada == true) ? parteRelType.SI : parteRelType.NO;
                            itemDetalleCompras.autorizacion = (item.Num_Autorizacion == null) ? "" : item.Num_Autorizacion;
                            


                            if (itemDetalleCompras.tpIdProv == "03")
                            {
                                itemDetalleCompras.tipoProv = (item.InfoProveedor.Persona_Info.pe_Naturaleza == "NATUR") ? "01" : "02";

                                if (item.InfoProveedor.es_empresa_relacionada == true)
                                {
                                    itemDetalleCompras.parteRel = parteRelType.SI;
                                }
                                else
                                {
                                    itemDetalleCompras.parteRel = parteRelType.NO;
                                }


                            }


                            var tipD = LstTipDoc.First(c => c.CodTipoDocumento == item.IdOrden_giro_Tipo);
                            itemDetalleCompras.tipoComprobante = tipD.CodSRI;
                            itemDetalleCompras.fechaEmision = item.co_FechaFactura.ToString("dd/MM/yyyy");
                            itemDetalleCompras.autorizacion = item.Num_Autorizacion;

                            itemDetalleCompras.baseNoGraIva = "0";//base NO objeto de IVA
                            itemDetalleCompras.baseImponible = Math.Round(Convert.ToDecimal(item.co_subtotal_siniva), 2, MidpointRounding.AwayFromZero).ToString(); // sin iva
                            itemDetalleCompras.baseImpGrav = Math.Round(Convert.ToDecimal(item.co_subtotal_iva), 2, MidpointRounding.AwayFromZero).ToString(); //con iva
                            itemDetalleCompras.baseImpExe = "0";

                            itemDetalleCompras.montoIce = Math.Round(Convert.ToDecimal(item.co_Ice_valor), 2, MidpointRounding.AwayFromZero).ToString();
                            itemDetalleCompras.montoIva = Math.Round(Convert.ToDecimal(item.co_valoriva), 2, MidpointRounding.AwayFromZero).ToString();

                            itemDetalleCompras.valRetBien10Specified = true;
                            itemDetalleCompras.valRetServ20Specified = true;
                            itemDetalleCompras.valRetServ50Specified = true;
                            itemDetalleCompras.totbasesImpReembSpecified = true;

                            if (tipD.CodSRI == "05")
                            {
                                itemDetalleCompras.docModificado = item.Tipodoc_a_Modificar;
                                itemDetalleCompras.estabModificado = item.estable_a_Modificar;
                                itemDetalleCompras.ptoEmiModificado = item.ptoEmi_a_Modificar;
                                itemDetalleCompras.secModificado = item.num_docu_Modificar;
                                itemDetalleCompras.autModificado = item.aut_doc_Modificar;

                            }

                            if (LstdetalleAir.Count > 0)
                                itemDetalleCompras.air  = LstdetalleAir;//AREGLAR 

                            if (!string.IsNullOrEmpty(info_Retencion_x_RF.NAutorizacion))
                            {
                                secuenci_numReten = info_Retencion_x_RF.NumRetencion.ToString();
                                string sSerieRetencion = "";
                                sSerieRetencion = info_Retencion_x_RF.serie1 + '-'+ info_Retencion_x_RF.serie2;
                                if (!string.IsNullOrEmpty(sSerieRetencion))
                                {
                                    itemDetalleCompras.estabRetencion1 = info_Retencion_x_RF.serie1;
                                    itemDetalleCompras.ptoEmiRetencion1 = info_Retencion_x_RF.serie2;
                                }
                                itemDetalleCompras.secRetencion1 = secuenci_numReten;
                                itemDetalleCompras.autRetencion1 = info_Retencion_x_RF.NAutorizacion;
                                itemDetalleCompras.fechaEmiRet1 = fecRet;
                            }

                            lstDetalleCompras.Add(itemDetalleCompras);

                            pagoExterior Item_pagoExterior = new pagoExterior();
                            
                            if (item.PagoLocExt == "LOC")
                            {
                                Item_pagoExterior.pagoLocExt = pagoLocExtType.Item01;
                            }
                            else
                            {
                                Item_pagoExterior.pagoLocExt = pagoLocExtType.Item02;
                            }
                            

                            Item_pagoExterior.paisEfecPago = (Item_pagoExterior.pagoLocExt == pagoLocExtType.Item01) ? "NA" : (item.PaisPago != null || item.PaisPago != "") ? item.PaisPago : "NA";

                            Item_pagoExterior.aplicConvDobTrib = (item.ConvenioTributacion == "S") ? aplicConvDobTribType.SI : (item.ConvenioTributacion == "N") ? aplicConvDobTribType.NO :aplicConvDobTribType.NA;
                            Item_pagoExterior.pagExtSujRetNorLeg = (item.PagoSujetoRetencion == "S") ? aplicConvDobTribType.SI : (item.PagoSujetoRetencion == "N") ? aplicConvDobTribType.NO : aplicConvDobTribType.NA;



                            itemDetalleCompras.pagoExterior = Item_pagoExterior;



                            List<cp_orden_giro_pagos_sri_Info> formasDePagoOG = new List<cp_orden_giro_pagos_sri_Info>();
                            formasDePagoOG = formasPago_B.Get_List_orden_giro_pagos_sri(item.IdEmpresa, item.IdCbteCble_Ogiro, item.IdTipoCbte_Ogiro);

                            string cadena = "";
                            string coma = "";
                            Boolean Hay_registros_de_pagos = false;


                            if (formasDePagoOG.Count > 0)
                            {
                                foreach (var itemfp in formasDePagoOG)
                                {
                                    if (itemfp.check == true)
                                    {
                                        cadena = cadena + coma + itemfp.codigo_pago_sri;
                                        coma = ",";
                                        Hay_registros_de_pagos = true;
                                    }

                                }
                                if (Hay_registros_de_pagos)
                                {
                                    itemDetalleCompras.formasDePago = cadena.Split(',');
                                }
                            }


                            if (Hay_registros_de_pagos ==false)
                            { 
                                decimal Total=0;
                                Total = Convert.ToDecimal(itemDetalleCompras.baseNoGraIva) + Convert.ToDecimal(itemDetalleCompras.baseImpGrav);

                                if (Total >= 1000)
                                {
                                    string[] arr1 = new string[] { "01"};
                                    itemDetalleCompras.formasDePago = arr1;
                                }
                            }



                        }
                        catch (Exception ex)
                        {
                            
                            MessageBox.Show(ex.ToString());
                        }
                     
                    }

// Para las notas de debito y credito cxp
//*************************************
                    
                    cp_nota_DebCre_Bus nota_B = new cp_nota_DebCre_Bus();
                    List<cp_nota_DebCre_Info> listaNotaDC = new List<cp_nota_DebCre_Info>();
                    listaNotaDC = nota_B.Get_List_nota_DebCre(param.IdEmpresa, Convert.ToInt32(cmb_anio.Text), Convert.ToInt32(cmb_periodo.SelectedValue));



                    progressBar1.Value = 70;
                    foreach (cp_nota_DebCre_Info item in listaNotaDC)
                    {
                        Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras itemDetalleCompras = new Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras();

                        

                        List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAir> LstdetalleAir = new List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAir>();

                        cp_proveedor_Autorizacion_Info Autorizacion_I = new cp_proveedor_Autorizacion_Info();

                        var sustento = ListCodigoSustento.First(c => c.IdCodigo_SRI == item.IdIden_credito);
                        itemDetalleCompras.codSustento = sustento.codigoSRI;

                        itemDetalleCompras.establecimiento = item.cn_serie1;
                        itemDetalleCompras.puntoEmision = item.cn_serie2;
                        itemDetalleCompras.secuencial = item.cn_Nota;
                        itemDetalleCompras.autorizacion = item.cn_Autorizacion;

                        

                        //if ("000002133" == item.cn_Nota) { MessageBox.Show(""); }
                        
                        if (item.Fecha_contable != null)
                        {
                            itemDetalleCompras.fechaRegistro = Convert.ToDateTime(item.Fecha_contable).ToString("dd/MM/yyyy");
                            itemDetalleCompras.fechaEmision =  Convert.ToDateTime(item.Fecha_contable).ToString("dd/MM/yyyy");
                        }

                        if (String.IsNullOrEmpty(itemDetalleCompras.fechaRegistro))
                        {
                            itemDetalleCompras.fechaRegistro = Convert.ToDateTime(item.cn_fecha).ToString("dd/MM/yyyy");
                            itemDetalleCompras.fechaEmision = Convert.ToDateTime(item.cn_fecha).ToString("dd/MM/yyyy");
                        }

                        


                        itemDetalleCompras.idProv = item.InfoProveedor.Persona_Info.pe_cedulaRuc.Trim();
                        itemDetalleCompras.tpIdProv = (item.InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "RUC") ? "01" : ((item.InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "CED") ? "02" : "03");

                        if (itemDetalleCompras.tpIdProv == "03")
                        {
                            itemDetalleCompras.tipoProv = (item.InfoProveedor.Persona_Info.pe_Naturaleza == "NATUR") ? "01" : "02";
                            if (item.InfoProveedor.es_empresa_relacionada == true)
                            {
                                itemDetalleCompras.parteRel = parteRelType.SI;
                            }
                            else
                            {
                                itemDetalleCompras.parteRel = parteRelType.NO;
                            }
                        }

                        

                        itemDetalleCompras.tipoComprobante = (item.DebCre == "C" || item.DebCre == "Credito") ? "04" : "05";
                        if (item.Fecha_contable != null)
                        { itemDetalleCompras.fechaEmision = Convert.ToString(item.Fecha_contable); }

                        itemDetalleCompras.baseNoGraIva = "0";
                        itemDetalleCompras.baseImponible = Math.Round(Convert.ToDecimal(item.cn_subtotal_siniva), 2, MidpointRounding.AwayFromZero).ToString();//sin iva
                        itemDetalleCompras.baseImpGrav = Math.Round(Convert.ToDecimal(item.cn_subtotal_iva), 2, MidpointRounding.AwayFromZero).ToString();
                        itemDetalleCompras.baseImpExe = "0";


                        itemDetalleCompras.montoIce = Math.Round(Convert.ToDecimal(item.cn_Ice_valor), 2, MidpointRounding.AwayFromZero).ToString();
                        itemDetalleCompras.montoIva = Math.Round(Convert.ToDecimal(item.cn_valoriva), 2, MidpointRounding.AwayFromZero).ToString();
                        

                        itemDetalleCompras.valRetBien10 = "0.00";
                        itemDetalleCompras.valRetServ20 = "0.00";
                        itemDetalleCompras.valorRetBienes = "0.00";
                        itemDetalleCompras.valRetServ50 = "0.00";
                        itemDetalleCompras.valorRetServicios = "0.00";
                        itemDetalleCompras.valRetServ100 = "0.00";
                        itemDetalleCompras.totbasesImpReemb = "0.00";

                        itemDetalleCompras.valRetBien10Specified = true;
                        itemDetalleCompras.valRetServ20Specified = true;
                        itemDetalleCompras.valRetServ50Specified = true;
                        itemDetalleCompras.totbasesImpReembSpecified = true;


                        if (LstdetalleAir.Count > 0)
                            itemDetalleCompras.air = LstdetalleAir;


                        itemDetalleCompras.docModificado = item.docModificado;
                        itemDetalleCompras.estabModificado = item.estabModificado;
                        itemDetalleCompras.ptoEmiModificado = item.ptoEmiModificado;
                        itemDetalleCompras.secModificado = item.secModificado;
                        itemDetalleCompras.autModificado = item.autModificado;

                        lstDetalleCompras.Add(itemDetalleCompras);

                        pagoExterior Item_pagoExterior = new pagoExterior();
                        Item_pagoExterior.pagoLocExt =  (item.PagoLocExt == "LOC") ? pagoLocExtType.Item01 : pagoLocExtType.Item02;
                        Item_pagoExterior.paisEfecPago = (Item_pagoExterior.pagoLocExt == pagoLocExtType.Item01 ) ? "NA"  : (item.PaisPago != null || item.PaisPago != "") ? item.PaisPago : "NA";

                        Item_pagoExterior.aplicConvDobTrib =  (item.ConvenioTributacion == "S") ? aplicConvDobTribType.SI : (item.ConvenioTributacion == "N") ? aplicConvDobTribType.NO :aplicConvDobTribType.NA;
                        Item_pagoExterior.pagExtSujRetNorLeg = (item.PagoSujetoRetencion == "S") ? aplicConvDobTribType.SI : (item.PagoSujetoRetencion == "N") ? aplicConvDobTribType.NO : aplicConvDobTribType.NA;

                        itemDetalleCompras.pagoExterior = Item_pagoExterior;


                    }

                    iva.compras = lstDetalleCompras;
                    progressBar1.Value = 85;

//*****ANULADOS*******
//********************

                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus DocAnu_B = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus();
                    List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> LstDocAnu = new List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info>();

                    LstDocAnu = DocAnu_B.ConsultaPorMesAnio(param.IdEmpresa, Convert.ToInt32(cmb_anio.Text), Convert.ToInt32(cmb_periodo.SelectedValue));

                    List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAnulados> lstDetalleDocAnu = new List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleAnulados>();
                    foreach (var itemDA in LstDocAnu)
                    {
                        if (itemDA.Autorizacion != null)
                        {
                            detalleAnulados info = new detalleAnulados();
                            info.autorizacion = itemDA.Autorizacion;
                            info.establecimiento = itemDA.Serie1;
                            info.puntoEmision = itemDA.Serie2;
                            info.secuencialInicio = itemDA.Documento;
                            info.secuencialFin = itemDA.DocumentoFin;
                            var tipD = LstTipDoc.First(c => c.CodTipoDocumento == itemDA.codDocumentoTipo);
                            info.tipoComprobante = tipD.CodSRI;
                            lstDetalleDocAnu.Add(info);
                        }                        
                    }

                    if (lstDetalleDocAnu.Count > 0)
                        iva.anulados = lstDetalleDocAnu;

                //// FACTURAS

                    fa_factura_Bus fac_B = new fa_factura_Bus();

                    List<detalleVentas> LstDV = new List<detalleVentas>();
                    LstDV = fac_B.Get_List_VentasParaATS(param.IdEmpresa, Convert.ToInt32(cmb_anio.Text), Convert.ToInt32(cmb_periodo.SelectedValue));

                    int IdPeriodo = (Convert.ToInt32(iva.Anio) * 100) + Convert.ToInt32(iva.Mes);

                    foreach (var item in LstDV)
                    {
                        item.montoIce = 0;
                        item.montoIceSpecified = true;

                        #region Personalizacion de cliente Grafinpren 
                        
                        /// el cliente nos pide q enceremos el valor de la retencion de estos meses junio y julio 2016
                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                        {

                            if (IdPeriodo >= 201606 && IdPeriodo <= 201611)
                            {
                                item.valorRetIva = "0.00";
                                item.valorRetRenta = "0.00";
                            }

                        }
                        #endregion
                        

                    }





                    if (LstDV.Count() > 0)
                        iva.ventas = LstDV;

                    List<ventaEst> LstVenSum = new List<ventaEst>();
                    LstVenSum = fac_B.Get_List_VentasXEstablecimientoParaATS(param.IdEmpresa, Convert.ToInt32(cmb_anio.Text), Convert.ToInt32(cmb_periodo.SelectedValue));

                    foreach (var item in LstVenSum)
                    {
                        
                        
                    }
                    if (LstVenSum.Count > 0)
                    {
                        iva.ventasEstablecimiento = LstVenSum;
                        iva.totalVentas = Math.Round(Math.Abs(LstVenSum.Sum(c => c.ventasEstab)), 2, MidpointRounding.AwayFromZero);
                    }
                    else
                        iva.totalVentas = 0;

                    
                    iva.totalVentasSpecified = true;

                    return iva;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return iva;
            }
        }
       
        private void frmCP_AnexosAtsRoc_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_periodo.DataSource = mes_D.Get_List_Mes();
                cmb_periodo.ValueMember = "idMes";
                cmb_periodo.DisplayMember = "smes";

                cmb_anio.DataSource = AnoF_B.Get_list_AnioFiscal();
                cmb_anio.ValueMember = "IdanioFiscal";
                cmb_anio.DisplayMember = "IdanioFiscal";
                Empresa_I = Empresa_B.Get_Info_Empresa(param.IdEmpresa);

                direcDoc = Cp.FileSystem.SpecialDirectories.MyDocuments;//obtiene el directorio de mis docuemntos
                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);

            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.Message);
            }
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 30;

                DS_Iva_REOC_XML = new iva();

                DS_Iva_REOC_XML=CargaDatos();
                
                string ruta = "";
                saveFileDialog1.FileName = "AT-" + param.InfoEmpresa.codigo+"-"  + ((cmb_periodo.SelectedValue.ToString().Length < 2) ? "0" + cmb_periodo.SelectedValue.ToString() : cmb_periodo.SelectedValue.ToString()) + cmb_anio.Text + ".xml";
                saveFileDialog1.Filter = "All files (*.xlm*)|*.xlm*";
                saveFileDialog1.InitialDirectory = @direcDoc;
                this.saveFileDialog1.ShowDialog();
                ruta = saveFileDialog1.FileName;


                if (SerializeToXML(DS_Iva_REOC_XML, ruta))
                {
                    progressBar1.Value = 100;

                        string msg = "";

                        if (validaXmlConXsd(ruta, Core.Erp.Info.Properties.Resources.ats_xsd_V_1_1_4, ref msg))
                        {
                            MessageBox.Show("Archivo ATS XML generado en la ruta:" + ruta + ", pero tiene los Siguientes errores:\n " + msg, "Errores en Validación con XSD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                        }
                  
                }
                else
                {
                    progressBar1.Value = 0;
                    MessageBox.Show("Ocurrio un inconveniente al guardar el archivo ATS XML", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

                List<Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras> List_Compras = new List<Info.CuentasxPagar.xmlATS_V_1_1_4.detalleCompras>();

                List<Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas> List_Ventas = new List<Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas>();

                List_Compras = DS_Iva_REOC_XML.compras;
                List_Ventas = DS_Iva_REOC_XML.ventas;


                List<cp_retencion_Info> listRetenciones = new List<cp_retencion_Info>();


                foreach (var item in List_Compras)
                {
                    cp_retencion_Info InfoRet= new cp_retencion_Info();


                    try
                    {

                        if (item.air != null)
                        {

                            foreach (var item_ret in item.air)
                            {
                                try
                                {
                                    InfoRet.Factura_Prov = item.establecimiento + "-" + item.puntoEmision + "-" + item.secuencial;
                                    InfoRet.ced_ruc_proveedor = item.idProv;
                                    InfoRet.NumRetencion = item.secRetencion1;
                                    InfoRet.fecha = Convert.ToDateTime(item.fechaEmiRet1);

                                    InfoRet.Info_det_retencion.CodigoSRI = item_ret.codRetAir;
                                    InfoRet.Info_det_retencion.re_baseRetencion = Convert.ToDouble(item_ret.baseImpAir);
                                    InfoRet.Info_det_retencion.re_Porcen_retencion = Convert.ToDouble(item_ret.porcentajeAir);
                                    InfoRet.Info_det_retencion.re_valor_retencion = Convert.ToDouble(item_ret.valRetAir);
                                    listRetenciones.Add(InfoRet);

                                }
                                catch (Exception ex)
                                {


                                }

                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        
                        
                    }

                    
                }

                gridControlCompras.DataSource = List_Compras;
                gridControlRT.DataSource = listRetenciones;
                gridControlVentas.DataSource = List_Ventas;







            }
            catch(Exception ex)
            {       Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.Message);
            }
        }

        static public Boolean SerializeToXML(reoc data, string ruta)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(reoc));
                TextWriter textWriter = new StreamWriter(@ruta);
                serializer.Serialize(textWriter, data);
                textWriter.Close();
                return true;
            }
            catch (Exception )
            {
                
                return false;
            }
        }

        static public Boolean SerializeToXML(iva data, string ruta)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(iva));
                TextWriter textWriter = new StreamWriter(@ruta);
                serializer.Serialize(textWriter, data);
                textWriter.Close();
                return true;
            }
            catch (Exception)
            {
               
                return false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = "";
                this.saveFileDialog1.ShowDialog();
                ruta = saveFileDialog1.FileName;
                //richTextBox1.SaveFile(ruta);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public bool validaXmlConXsd(string rutaXML, string xsd, ref string mgs)
        {
            try
            {
              
                Boolean val;

                string archiTem = direcDoc + @"\ValidadorXml.xsd";
                if (Cp.FileSystem.FileExists(archiTem))
                {
                    Cp.FileSystem.DeleteFile(archiTem);
                }
                FileStream fs = new FileStream(archiTem, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(xsd);
                bw.Close();


                return val = Valido(archiTem, rutaXML, ref  mgs);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }


        public Boolean Valido(String patchxsd, string pathXML, ref string MensajeOut)
        {
            Boolean isValid = true;

            try
            {
                try
                {

                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.Schemas.Add(null, patchxsd);

                    settings.ValidationType = ValidationType.Schema;
                    //--------------
                    XmlDocument document = new XmlDocument();
                    document.Load(pathXML);
                    XmlReader rdr = XmlReader.Create(new StringReader
                        (document.InnerXml), settings);
                    while (rdr.Read()) { }

                    MensajeOut = "Archivo Valido";


                }
                catch (Exception ex)
                {
                    isValid = false;
                    return isValid;
                }




                return isValid;
            }
            catch (XmlSchemaException schemaEx)
            {
                Log_Error_bus.Log_Error(schemaEx.ToString());
                MensajeOut = "Documento no es valido con el xsd :" +
                    Environment.NewLine + schemaEx.Message;
                isValid = false;
                return isValid;
            }
        }

        public   void GeneraFormularios(iva iva, byte[] xls,string descr)
        {
            try
            { 
                refere.ServerComputer Cp = new refere.ServerComputer();
                string archiTem = Cp.FileSystem.SpecialDirectories.MyDocuments + @"\Formulario103_" + descr + ".xls";
                
                if(Cp.FileSystem.FileExists(archiTem))
                {
                    Cp.FileSystem.DeleteFile(archiTem);
                }
                FileStream fs = new FileStream(archiTem, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(xls);
              //  bw.Close();
              
         
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            var misValue = Type.Missing;

            // abrir el documento
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(archiTem, misValue, misValue,
               misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);


            //**********************
            Excel._Worksheet oSheet;
            oSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);// selecciona la hoja del excel

            oSheet.Cells[10, 2] = iva.IdInformante;
            oSheet.Cells[10, 16] = iva.razonSocial;

            if(iva.compras!=null)
            foreach(var item in iva.compras)
	        {
                if(item.air!=null)
		        foreach(var item2 in item.air)
	            {
		         for(int i = 15; i < 46; i++)
                  {
                     String c = Convert.ToString(oSheet.Cells[i, 22].Value);
                     
                      if(Convert.ToString(oSheet.Cells[i, 22].Value) == item2.codRetAir)
                      {
                          oSheet.Cells[i, 24].Value = Convert.ToDecimal(item2.valRetAir)+Convert.ToDecimal( oSheet.Cells[i, 24].Value);
                      }
                      else if(Convert.ToString(oSheet.Cells[i, 31].Value) == item2.codRetAir)
                      {
                          oSheet.Cells[i, 33].Value = Convert.ToDecimal(item2.valRetAir)+Convert.ToDecimal(oSheet.Cells[i, 33].Value);
                      }
                  }
	            }
                
            }
         
            xlApp.Visible = true;
            xlApp.UserControl = true;

            progressBar1.Value = 100;
            MessageBox.Show("Formulario 103 generado correctamente en la ruta:" + archiTem, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                progressBar1.Value = 0;
                MessageBox.Show("Error al generar el Formulario 103 " , "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }

        private void btn_formu_Click(object sender, EventArgs e)
        {
            try
            {                
                if (paramCP_I.pa_Formulario103_104 == null)
                {
                    MessageBox.Show("No puede realizar la generaciòn del Formulario 103, debido a que la plantilla del formulario en Excel no se ha ingresado.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GeneraFormularios(CargaDatos(), paramCP_I.pa_Formulario103_104, ((cmb_periodo.SelectedValue.ToString().Length < 2) ? "0" + cmb_periodo.SelectedValue.ToString() : cmb_periodo.SelectedValue.ToString()) + cmb_anio.Text);
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }



    }
}

