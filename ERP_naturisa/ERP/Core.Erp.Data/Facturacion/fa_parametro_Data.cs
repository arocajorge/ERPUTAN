using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_parametro_Data
    {
        string mensaje = "";

        public fa_parametro_info Get_Info_parametro(int idEmpresa)
        {
            try
            { 
                    fa_parametro_info inf = new fa_parametro_info();
                EntitiesFacturacion fac = new EntitiesFacturacion();
                var Info = from q in fac.fa_parametro
                           where q.IdEmpresa == idEmpresa
                           select q;
                foreach (var item in Info)
                {
                    inf.pa_compania = item.IdEmpresa;
                    
                    inf.IdMovi_inven_tipo_Factura=Convert.ToInt32(item.IdMovi_inven_tipo_Factura);
                    inf.pa_porc_max_total_item_x_despa_Guia = Convert.ToDouble( item.pa_porc_max_total_item_x_despa_Guia);
                    inf.IdMovi_inven_tipo_Dev_Vta = Convert.ToInt32(item.IdMovi_inven_tipo_Dev_Vta);
                    inf.IdMovi_inven_tipo_Factura_Anulacion = Convert.ToInt32(item.IdMovi_inven_tipo_Factura_Anulacion);
                    inf.IdMovi_inven_tipo_Dev_Vta_Anulacion = Convert.ToInt32(item.IdMovi_inven_tipo_Dev_Vta_Anulacion);
                    inf.Tipo_NC_x_DevVta=Convert.ToInt32(item.Tipo_NC_x_DevVta);
                    inf.IdDepartamento_x_DevVta =Convert.ToInt32( item.IdDepartamento_x_DevVta);
                    inf.IdTipoCbteCble_Factura =Convert.ToInt32( item.IdTipoCbteCble_Factura);
                    inf.IdTipoCbteCble_Factura_Reverso =Convert.ToInt32( item.IdTipoCbteCble_Factura_Reverso);
                    inf.IdTipoCbteCble_Factura_Costo_VTA =Convert.ToInt32( item.IdTipoCbteCble_Factura_Costo_VTA);
                    inf.IdTipoCbteCble_Factura_Costo_VTA_Reverso =Convert.ToInt32( item.IdTipoCbteCble_Factura_Costo_VTA_Reverso);
                    inf.SeImprimiGuiaRemiAuto = item.SeImprimiGuiaRemiAuto;
                    inf.IdTipoCbteCble_NC = Convert.ToInt32(item.IdTipoCbteCble_NC);
                    inf.IdTipoCbteCble_NC_Reverso = Convert.ToInt32(item.IdTipoCbteCble_NC_Reverso);
                    inf.IdTipoCbteCble_ND = Convert.ToInt32(item.IdTipoCbteCble_ND);
                    inf.IdTipoCbteCble_ND_Reverso = Convert.ToInt32(item.IdTipoCbteCble_ND_Reverso);
                    inf.NumeroDeItemFact = item.NumeroDeItemFact;
                    inf.TipoCobroDafaultFactu = item.TipoCobroDafaultFactu;
                    inf.File_Reporte_FacturaDiseño = item.File_Reporte_FacturaDiseño;
                    inf.File_Reporte_Nota_CRED_DEB = item.File_Reporte_Nota_CRED_DEB;
                    inf.IdCaja_Default_Factura = item.IdCaja_Default_Factura;

                    inf.IdCtaCble_x_anticipo_cliente = item.IdCtaCble_x_anticipo_cliente;
                    inf.pa_ruta_descarga_xml_fac_elct = item.pa_ruta_descarga_xml_fac_elct;
                    inf.pa_IdTipoNota_NC_x_Anulacion = Convert.ToInt32(item.pa_IdTipoNota_NC_x_Anulacion);
                    inf.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    
                    inf.IdCtaCble_CXC_Vtas_x_Default = item.IdCtaCble_CXC_Vtas_x_Default;
                    inf.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    inf.IdCtaCble_SubTotal_Vtas_x_Default = item.IdCtaCble_SubTotal_Vtas_x_Default;


                    inf.pa_X_Defecto_la_factura_es_cbte_elect =item.pa_X_Defecto_la_factura_es_cbte_elect;
                    inf.pa_X_Defecto_la_guia_es_cbte_elect = item.pa_X_Defecto_la_guia_es_cbte_elect;
                    inf.pa_X_Defecto_la_ND_es_cbte_elect = item.pa_X_Defecto_la_ND_es_cbte_elect;
                    inf.pa_X_Defecto_la_NC_es_cbte_elect = item.pa_X_Defecto_la_NC_es_cbte_elect;

                }
                return inf;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_parametro_info Info, ref string mensaje) 
        {
            try
            {
                using (EntitiesFacturacion Oent = new EntitiesFacturacion())
                {
                    fa_parametro Contac = Oent.fa_parametro.FirstOrDefault(var => var.IdEmpresa == Info.pa_compania);
                    if (Contac != null)
                    {
                        Contac.IdEmpresa = Info.pa_compania;
                        Contac.IdMovi_inven_tipo_Factura = Info.IdMovi_inven_tipo_Factura;
                        Contac.pa_porc_max_total_item_x_despa_Guia = Info.pa_porc_max_total_item_x_despa_Guia;
                        Contac.IdMovi_inven_tipo_Dev_Vta = Info.IdMovi_inven_tipo_Dev_Vta;
                        Contac.IdMovi_inven_tipo_Factura_Anulacion = Info.IdMovi_inven_tipo_Factura_Anulacion;
                        Contac.IdMovi_inven_tipo_Dev_Vta_Anulacion = Info.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                        Contac.Tipo_NC_x_DevVta = Info.Tipo_NC_x_DevVta;
                        Contac.IdDepartamento_x_DevVta = Info.IdDepartamento_x_DevVta;
                        Contac.IdTipoCbteCble_Factura = Info.IdTipoCbteCble_Factura;
                        Contac.IdTipoCbteCble_Factura_Reverso = Info.IdTipoCbteCble_Factura_Reverso;
                        Contac.IdTipoCbteCble_Factura_Costo_VTA = Info.IdTipoCbteCble_Factura_Costo_VTA;

                        Contac.IdTipoCbteCble_Factura_Costo_VTA_Reverso = Info.IdTipoCbteCble_Factura_Costo_VTA_Reverso;

                        Contac.IdTipoCbteCble_NC = Info.IdTipoCbteCble_NC;
                        Contac.IdTipoCbteCble_NC_Reverso = Info.IdTipoCbteCble_NC_Reverso;
                        Contac.IdTipoCbteCble_ND = Info.IdTipoCbteCble_ND;
                        Contac.IdTipoCbteCble_ND_Reverso = Info.IdTipoCbteCble_ND_Reverso;
                        Contac.SeImprimiGuiaRemiAuto = Info.SeImprimiGuiaRemiAuto;
                        Contac.NumeroDeItemFact = Info.NumeroDeItemFact;
                        Contac.TipoCobroDafaultFactu = Info.TipoCobroDafaultFactu;

                        Contac.IdCaja_Default_Factura = (int)Info.IdCaja_Default_Factura;
                        Contac.IdCtaCble_x_anticipo_cliente = Info.IdCtaCble_x_anticipo_cliente;
                        Contac.pa_IdTipoNota_NC_x_Anulacion = Info.pa_IdTipoNota_NC_x_Anulacion;
                        Contac.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                        Contac.pa_ruta_descarga_xml_fac_elct = Info.pa_ruta_descarga_xml_fac_elct;
                        Contac.IdCaja_Default_Factura = (int)Info.IdCaja_Default_Factura;
                        Contac.File_Reporte_FacturaDiseño = Info.File_Reporte_FacturaDiseño;
                        Contac.File_Reporte_Nota_CRED_DEB = Info.File_Reporte_Nota_CRED_DEB;

                        Contac.IdCtaCble_IVA = Info.IdCtaCble_IVA;
                        Contac.IdCtaCble_CXC_Vtas_x_Default = Info.IdCtaCble_CXC_Vtas_x_Default;
                        Contac.IdCtaCble_SubTotal_Vtas_x_Default = Info.IdCtaCble_SubTotal_Vtas_x_Default;

                        Contac.pa_X_Defecto_la_factura_es_cbte_elect = Info.pa_X_Defecto_la_factura_es_cbte_elect;
                        Contac.pa_X_Defecto_la_guia_es_cbte_elect = Info.pa_X_Defecto_la_guia_es_cbte_elect;
                        Contac.pa_X_Defecto_la_ND_es_cbte_elect = Info.pa_X_Defecto_la_ND_es_cbte_elect;
                        Contac.pa_X_Defecto_la_NC_es_cbte_elect = Info.pa_X_Defecto_la_NC_es_cbte_elect;

                        Oent.SaveChanges();
                    }
                    else
                    {
                        if (GuardarDB(Info, ref mensaje))
                        { return true; }
                        else
                        { return false; }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_parametro_info Info, ref string mensaje)
        {
            try
            {
                List<fa_parametro_info> Lst = new List<fa_parametro_info>();           


                using (EntitiesFacturacion Oent = new EntitiesFacturacion())
                {
                    fa_parametro parametro = new fa_parametro();

                    parametro.IdEmpresa = Info.pa_compania;
                    parametro.IdMovi_inven_tipo_Factura = Info.IdMovi_inven_tipo_Factura;
                    parametro.pa_porc_max_total_item_x_despa_Guia = Info.pa_porc_max_total_item_x_despa_Guia;
                    parametro.IdMovi_inven_tipo_Dev_Vta = Info.IdMovi_inven_tipo_Dev_Vta;
                    parametro.IdMovi_inven_tipo_Factura_Anulacion = Info.IdMovi_inven_tipo_Factura_Anulacion;
                    parametro.IdMovi_inven_tipo_Dev_Vta_Anulacion = Info.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                    parametro.Tipo_NC_x_DevVta = Info.Tipo_NC_x_DevVta;
                    parametro.IdDepartamento_x_DevVta = Info.IdDepartamento_x_DevVta;
                    parametro.IdTipoCbteCble_Factura = Info.IdTipoCbteCble_Factura;
                    parametro.IdTipoCbteCble_Factura_Reverso = Info.IdTipoCbteCble_Factura_Reverso;
                    parametro.IdTipoCbteCble_Factura_Costo_VTA = Info.IdTipoCbteCble_Factura_Costo_VTA;
                    parametro.IdTipoCbteCble_Factura_Costo_VTA_Reverso = Info.IdTipoCbteCble_Factura_Costo_VTA_Reverso;
                    parametro.IdTipoCbteCble_NC = Info.IdTipoCbteCble_NC;
                    parametro.IdTipoCbteCble_NC_Reverso = Info.IdTipoCbteCble_NC_Reverso;
                    parametro.IdTipoCbteCble_ND = Info.IdTipoCbteCble_ND;
                    parametro.IdTipoCbteCble_ND_Reverso = Info.IdTipoCbteCble_ND_Reverso;
                    parametro.SeImprimiGuiaRemiAuto = Info.SeImprimiGuiaRemiAuto;
                    parametro.NumeroDeItemFact = Info.NumeroDeItemFact;
                    parametro.TipoCobroDafaultFactu = Info.TipoCobroDafaultFactu;

                    parametro.IdCaja_Default_Factura = (int)Info.IdCaja_Default_Factura;
                    parametro.IdCtaCble_x_anticipo_cliente = Info.IdCtaCble_x_anticipo_cliente;

                    parametro.pa_IdTipoNota_NC_x_Anulacion = Info.pa_IdTipoNota_NC_x_Anulacion;
                    parametro.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                    parametro.pa_ruta_descarga_xml_fac_elct = Info.pa_ruta_descarga_xml_fac_elct;
                    parametro.File_Reporte_FacturaDiseño = Info.File_Reporte_FacturaDiseño;
                    parametro.File_Reporte_Nota_CRED_DEB = Info.File_Reporte_Nota_CRED_DEB;

                    parametro.IdCtaCble_IVA = Info.IdCtaCble_IVA;
                    parametro.IdCtaCble_CXC_Vtas_x_Default = Info.IdCtaCble_CXC_Vtas_x_Default;
                    parametro.IdCtaCble_SubTotal_Vtas_x_Default = Info.IdCtaCble_SubTotal_Vtas_x_Default;

                    parametro.pa_X_Defecto_la_factura_es_cbte_elect = Info.pa_X_Defecto_la_factura_es_cbte_elect;
                    parametro.pa_X_Defecto_la_guia_es_cbte_elect = Info.pa_X_Defecto_la_guia_es_cbte_elect;
                    parametro.pa_X_Defecto_la_ND_es_cbte_elect = Info.pa_X_Defecto_la_ND_es_cbte_elect;
                    parametro.pa_X_Defecto_la_NC_es_cbte_elect = Info.pa_X_Defecto_la_NC_es_cbte_elect;

                    Oent.fa_parametro.Add(parametro);
                    Oent.SaveChanges();
                }
               
                return true;
            }
            catch (Exception ex)             
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",  "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
