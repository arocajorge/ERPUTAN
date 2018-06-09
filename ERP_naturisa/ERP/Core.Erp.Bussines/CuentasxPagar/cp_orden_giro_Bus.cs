using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_giro_Bus
    {
        cp_orden_giro_Data data = new cp_orden_giro_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        cp_reembolso_Bus Reem_B = new cp_reembolso_Bus();
        cp_orden_giro_pagos_sri_Bus pagoSRI_B = new cp_orden_giro_pagos_sri_Bus();
        cp_orden_giro_x_com_ordencompra_local_Bus OC_B = new cp_orden_giro_x_com_ordencompra_local_Bus();
        imp_ordencompra_ext_x_imp_gastosxImport_Bus ocXgastosxImp_B = new imp_ordencompra_ext_x_imp_gastosxImport_Bus();
        imp_ordencompra_ext_x_ct_cbtecble_Bus ocXcbt_B = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
        cp_orden_giro_x_imp_ordencompra_ext_Bus Importacion_B = new cp_orden_giro_x_imp_ordencompra_ext_Bus();
        cp_parametros_Bus busParam = new cp_parametros_Bus();
        cp_retencion_Bus Bus_Retencion = new cp_retencion_Bus();
        cp_cuotas_x_doc_Bus bus_cuotas_x_doc = new cp_cuotas_x_doc_Bus();
        string mensaje = "";


        public Boolean Modificar_tipo_flujo(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble, Nullable<decimal> IdTipoFlujo)
        {
            try
            {
                return data.Modificar_tipo_flujo(IdEmpresa, IdTipoCbte_OG, IdCbteCble, IdTipoFlujo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_tipo_flujo", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        private Boolean Validar_y_corregir_objeto(cp_orden_giro_Info orden_giro_Info, ref string msg)
        {
            try
            {
                #region 'Validaciones'
                /*--- validaciones */


                if (orden_giro_Info.IdEmpresa <= 0 && orden_giro_Info.IdSucursal <= 0 )
                {
                    msg = "Error en la cabecera de fact uno de los PK es <=0";
                    return false;
                }


                if (orden_giro_Info.IdProveedor<=0)
                {
                    msg = "Erro en la cabecera  IdProveedor es <=0";
                    return false;
                }




                if (orden_giro_Info.Info_CbteCble_x_OG._cbteCble_det_lista_info == null)
                {
                    msg = "la factura no tiene detalle ";
                    return false;
                }

                if (orden_giro_Info.Info_CbteCble_x_OG._cbteCble_det_lista_info.Count == 0)
                {
                    msg = "la factura no tiene detalle ";
                    return false;
                }


                foreach (var item in orden_giro_Info.Info_CbteCble_x_OG._cbteCble_det_lista_info)
                {

                    if (item.IdCtaCble == "")
                    {
                        msg = "el IdCtaCble id:" + item.IdCtaCble + " no puede ser blanco ";
                    }

                    if (item.dc_Valor == 0)
                    {
                        msg = "el dc_Valor no puede ser cero";
                    }


                  
                }

                /*--- Fin validaciones */


                /*--- corrigiendo data */

                if (orden_giro_Info.IdCtaCble_CXP == "" || orden_giro_Info.IdCtaCble_CXP == null || orden_giro_Info.IdCtaCble_Gasto == "" ||  orden_giro_Info.IdCtaCble_Gasto == null)
                {
                    cp_proveedor_Bus BusProv = new cp_proveedor_Bus();
                    cp_proveedor_Info InfoProve = new cp_proveedor_Info();
                    InfoProve = BusProv.Get_Info_Proveedor(orden_giro_Info.IdEmpresa, orden_giro_Info.IdProveedor);
                    orden_giro_Info.IdCtaCble_CXP = InfoProve.IdCtaCble_CXP;
                    orden_giro_Info.IdCtaCble_Gasto  = InfoProve.IdCtaCble_Gasto;
                }


                if (orden_giro_Info.IdCod_101 == 0)
                {
                    cp_codigo_SRI_Bus busCodSri = new cp_codigo_SRI_Bus();
                    orden_giro_Info.IdCod_101 = busCodSri.Get_List_codigo_SRI("COD_101").FirstOrDefault().IdCodigo_SRI;
                }

                if (orden_giro_Info.IdCod_ICE == 0)
                {
                    cp_codigo_SRI_Bus busCodSri = new cp_codigo_SRI_Bus();
                    orden_giro_Info.IdCod_ICE = busCodSri.Get_List_codigo_SRI("COD_ICE").FirstOrDefault().IdCodigo_SRI;
                }

                if (orden_giro_Info.IdIden_credito == 0)
                {
                    cp_codigo_SRI_Bus busCodSri = new cp_codigo_SRI_Bus();
                    orden_giro_Info.IdIden_credito = busCodSri.Get_List_codigo_SRI("COD_IDCREDITO").FirstOrDefault().IdCodigo_SRI;
                }

                if (orden_giro_Info.PaisPago == "")
                {
                    orden_giro_Info.PaisPago = null;
                }
               

                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }


        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, decimal OrdenGiro)
        {
            try
            {
                return data.Get_List_orden_giro(IdEmpresa, OrdenGiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }

        public Boolean Generar_OrdenPago_x_Faxtura(cp_orden_giro_Info info_og,DateTime Fecha_OP, ref string mensaje)
        {
            try
            {
                return data.Generar_OrdenPago_x_Faxtura(info_og,Fecha_OP, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_OrdenPago_x_Faxtura", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }


        public cp_orden_giro_Info Get_Info_orden_giro(int IdEmpresa ,int IdTipoCbte_Ogiro,decimal IdCbteCble_Ogiro)
        {
            try
            {
                return data.Get_Info_orden_giro(IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }


        public cp_orden_giro_Info Get_Info_orden_giro(cp_orden_giro_Info info)
        {
            try
            {
                return data.Get_Info_orden_giro(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, DateTime F_inicio, DateTime F_fin)
        {
            try
            {
                return data.Get_List_orden_giro(IdEmpresa, F_inicio, F_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }

        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_x_Pagar(int IdEmpresa, bool Mostrar_fact_conci_caja, ref string mensaje)
        {

            try
            {
                return data.Get_List_orden_giro_x_Pagar(IdEmpresa,Mostrar_fact_conci_caja,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_rpt_nota_credito", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        
        
        
        
        }


        public Boolean GrabarDB(cp_orden_giro_Info Info_OrdenGiro, ref decimal idCbteCble, ref string mensaje)
        {
            

            Boolean res = false;

            try
            {
               //validar serie y #Documento Factura


                

                if (Validar_y_corregir_objeto(Info_OrdenGiro, ref mensaje))
                {


                    if (data.ExisteFacturaPorProveedor(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdProveedor, Info_OrdenGiro.co_serie, Info_OrdenGiro.co_factura))
                    {

                        mensaje = "La Factura#: " + Info_OrdenGiro.co_serie + "-" + Info_OrdenGiro.co_factura + ". Ya se encuentra ingresada";
                        res = false;
                        return false;

                    }


                    if (!CbteCble_B.GrabarDB(Info_OrdenGiro.Info_CbteCble_x_OG, ref idCbteCble, ref mensaje))
                    {
                        mensaje = "No se pudo Ingresar el Cbte Cble de la Factura Proveedor \n Comuníquese con sistema por favor" + mensaje; return false;
                    }
                    else
                    {
                        Info_OrdenGiro.IdCbteCble_Ogiro = idCbteCble;
                        if (!data.GrabarDB(Info_OrdenGiro, ref mensaje))
                        {
                            mensaje = "No se pudo Ingresar la Factura Proveedor \n Comuníquese con sistema por favor" + mensaje; return false;
                        }

                        if (Info_OrdenGiro.lst_reembolso != null )
                        {
                            if (Info_OrdenGiro.lst_reembolso.Count != 0)
                            {
                                if (!Reem_B.GuardarDBLst(Info_OrdenGiro.lst_reembolso, Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref mensaje))
                                {

                                    mensaje = "No se pudo Ingresar lo(s) reembolso(s) \n Comuníquese con sistema por favor" + mensaje; return false;
                                }

                            }

                        }


                        if (Info_OrdenGiro.lst_formasPagoSRI != null)
                        {
                            if (Info_OrdenGiro.lst_formasPagoSRI.Count != 0)
                            {
                                if (!pagoSRI_B.GuardarDB(Info_OrdenGiro.lst_formasPagoSRI, Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref mensaje))
                                {
                                    mensaje = "No se pudo Ingresar la(s) Forma(s) de Pago \n Comuníquese con sistema por favor" + mensaje; return false;
                                }
                            }

                        }

                        if (Info_OrdenGiro.Info_cuotas_x_doc.lst_cuotas_det.Count != 0)
                        {
                            Info_OrdenGiro.Info_cuotas_x_doc.IdEmpresa_ct = Info_OrdenGiro.IdEmpresa;
                            Info_OrdenGiro.Info_cuotas_x_doc.IdTipoCbte = Info_OrdenGiro.IdTipoCbte_Ogiro;
                            Info_OrdenGiro.Info_cuotas_x_doc.IdCbteCble = Info_OrdenGiro.IdCbteCble_Ogiro;
                            bus_cuotas_x_doc.GuardarDB(Info_OrdenGiro.Info_cuotas_x_doc);
                        }

                        if (Info_OrdenGiro.Info_Retencion != null &&  Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT != null)
                        {

                            if (Info_OrdenGiro.Info_Retencion.IdEmpresa != 0)
                            {
                                Info_OrdenGiro.Info_Retencion.IdCbteCble_Ogiro = Info_OrdenGiro.IdCbteCble_Ogiro = idCbteCble;


                                //grabando la retencion

                                if (Bus_Retencion.Graba_CbteCble_Ret_FactProveedor(Info_OrdenGiro.Info_Retencion, Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT, ref mensaje))
                                {
                                    //actualizando el suencial de la retencion serie y #retencion
                                    Bus_Retencion.Modificar_Num_Retencion(Info_OrdenGiro.Info_Retencion, ref mensaje);

                                }
                                else
                                {
                                    mensaje = "Hubo un inconveniente al ingresar la retención comuniquese con sistemas.." + mensaje; res = false;
                                }

                            }
                        }

                        decimal IdCbteCble = 0; IdCbteCble = idCbteCble;

                        if (Info_OrdenGiro.LstImportacionGrid != null)
                        {
                            if (Info_OrdenGiro.LstImportacionGrid.Count() > 0)
                            {
                                Info_OrdenGiro.LstImportacionGrid.ForEach(p => p.IdCbteCble = IdCbteCble);

                                if (ocXgastosxImp_B.GuardarDB(Info_OrdenGiro.LstImportacionGrid, ref mensaje))
                                {
                                    Info_OrdenGiro.LstocXcbt_I.ForEach(p => p.ct_IdCbteCble = IdCbteCble);
                                    if (ocXcbt_B.GuardarDB(Info_OrdenGiro.LstocXcbt_I, ref mensaje))
                                    {
                                        Info_OrdenGiro.LisImportacion.ForEach(p => p.og_IdCbteCble = IdCbteCble);
                                        if (Importacion_B.GrabarDB(Info_OrdenGiro.LisImportacion, ref mensaje))
                                        {
                                            Info_OrdenGiro.LstImportacionOC.ForEach(p => p.og_IdCbteCble = IdCbteCble);

                                            if (!OC_B.GrabarDB(Info_OrdenGiro.LstImportacionOC, ref mensaje))
                                            { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                        }
                                        else { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                    }
                                    else { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                }
                                else { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                            }

                        }



                    }

                }
                else
                {
                    res = false;
                    return false;
                }


                res = true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarFactProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;

        }


        public Boolean AnularFacturaProveedor(cp_orden_giro_Info ordenGiro_I, 
            List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC, ref decimal IdCbteCbleRev, ref string msg2)
        {
            Boolean res = true;
            try
            {
                if (CbteCble_B.ReversoCbteCble(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro,
                    Convert.ToInt32(ordenGiro_I.IdTipoCbte_Anulacion), ref IdCbteCbleRev, ref msg2, ordenGiro_I.IdUsuarioUltAnu))
                {
                    ordenGiro_I.IdCbteCble_Anulacion = IdCbteCbleRev;
                    if (data.EliminarDB(ordenGiro_I, ref msg2))
                    {

                        #region Anula Retención
                        decimal idrev = 0;
                        cp_retencion_Info Info_retencion = Bus_Retencion.Get_Info_retencion(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro);

                        //cp_retencion_x_ct_cbtecble_Info ret_x_dia = ret_B.ObtenerObjetoRetXCbteCble(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro,
                        //    ordenGiro_I.IdTipoCbte_Ogiro);

                        if (Info_retencion.IdRetencion != 0)
                        {
                            if (!Bus_Retencion.AnularDB(Info_retencion,ref idrev, ref msg2))
                                return false;
                        }
                        #endregion

                        #region Eliminar Aprobación de ing a bodega x OC

                        cp_Aprobacion_Ing_Bod_x_OC_Bus bus_aprob_ing_bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                        cp_Aprobacion_Ing_Bod_x_OC_Info info_aprob_ing_bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Info();

                        info_aprob_ing_bod_x_OC = bus_aprob_ing_bod_x_OC.Get_Info_Aprobacion_Ing_Bod_x_OC(ordenGiro_I.IdEmpresa, ordenGiro_I.IdTipoCbte_Ogiro, ordenGiro_I.IdCbteCble_Ogiro);
                        if (info_aprob_ing_bod_x_OC.IdAprobacion!=0)
                        {
                            bus_aprob_ing_bod_x_OC.EliminarDB(info_aprob_ing_bod_x_OC.IdEmpresa, info_aprob_ing_bod_x_OC.IdAprobacion, ordenGiro_I.IdUsuarioUltAnu, ordenGiro_I.MotivoAnu, ref mensaje);
                        }

                        #endregion

                        ocXgastosxImp_B.AnularXOG(ordenGiro_I.IdEmpresa, ordenGiro_I.IdTipoCbte_Ogiro, ordenGiro_I.IdCbteCble_Ogiro,
                            Convert.ToInt32(ordenGiro_I.IdTipoCbte_Anulacion), Convert.ToDecimal(ordenGiro_I.IdCbteCble_Anulacion));

                        Importacion_B.EliminarDB(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro);
                        
                        OC_B.EliminarLista(LstImportacionOC);
                    }
                    else return false;

                }
                else return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularFacturaProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            } 
            return  res;

        }


        public Boolean Modificar_ValorRetencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, double valorRetencion, ref string mensaje)
        {
            try
            {

                return data.Modificar_ValorRetencion(IdEmpresa,  IdCbteCble_Ogiro,  IdTipoCbte_Ogiro,  valorRetencion, ref mensaje);
            }

            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_ValorRetencion", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean VericarNumDocumento(int IdEmpresa, decimal IdProveedor ,string tipoDocumento,string Serie, string NumDocumento,  ref string mensaje)
        {
            try
            {
                
                return data.VericarNumDocumento(IdEmpresa,IdProveedor,tipoDocumento,Serie, NumDocumento, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarNumDocumento", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, int anio, int mes)
        {
            try
            {
                return data.Get_List_orden_giro(IdEmpresa, anio, mes);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_SRI(int IdEmpresa, int anio, int mes)
        {
            try
            {
                return data.Get_List_orden_giro_SRI(IdEmpresa, anio, mes);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public decimal GetNDocumentoXTipo(String CodTipoDocumento, int IdEmpresa)
        {
            try
            {
                return data.GetNDocumentoXTipo(CodTipoDocumento, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetNDocumentoXTipo", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, String co_Factura)
        {
            try
            {
                return data.ExisteFacturaPorProveedor(IdEmpresa, IdProveedor, co_Factura);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, String co_serie, String co_Factura)
        {
            try
            {
                return data.ExisteFacturaPorProveedor(IdEmpresa, IdProveedor, co_serie, co_Factura);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }
        public Boolean ModificarDB_proceso_cerrado(cp_orden_giro_Info info, ref string mensaje)
        {
            try
            {
                if (data.ModificarDB_proceso_cerrado(info, ref mensaje))
                {
                    if (info.lst_formasPagoSRI != null)
                    {
                        if (info.lst_formasPagoSRI.Count != 0)
                        {
                            if (!pagoSRI_B.GuardarDB(info.lst_formasPagoSRI, info.IdEmpresa, info.IdTipoCbte_Ogiro, info.IdCbteCble_Ogiro, ref mensaje))
                            {
                                mensaje = "No se pudo Ingresar la(s) Forma(s) de Pago \n Comuníquese con sistema por favor" + mensaje; return false;
                            }
                        }

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }
        public bool ModificarDB(cp_orden_giro_Info InfoOrdenGiro_I,  ref string msg)
        {
            Boolean res = true;
            try
            {
              
                cp_orden_giro_Info info= new cp_orden_giro_Info();
                info.IdEmpresa=InfoOrdenGiro_I.IdEmpresa;
                info.IdTipoCbte_Ogiro=InfoOrdenGiro_I.IdTipoCbte_Ogiro;
                info.IdCbteCble_Ogiro=InfoOrdenGiro_I.IdCbteCble_Ogiro;

                cp_orden_giro_Data odata= new cp_orden_giro_Data();

                info = odata.Get_Info_orden_giro(info);

                if (info.co_serie == InfoOrdenGiro_I.co_serie && info.co_factura == InfoOrdenGiro_I.co_factura)
                {
                    // no valido               
                }
                else
                { 
                  //valido
                    if (data.ExisteFacturaPorProveedor(InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdProveedor, InfoOrdenGiro_I.co_serie, InfoOrdenGiro_I.co_factura))
                    {
                        msg = "La Factura#: " + InfoOrdenGiro_I.co_serie + "-" + InfoOrdenGiro_I.co_factura + ". Ya se encuentra ingresada";
                        res = false;
                        return false;

                    }
                
                }


                //diario contable x OG
                if (CbteCble_B.ModificarDB(InfoOrdenGiro_I.Info_CbteCble_x_OG, ref msg))
                {
                    //OG
                    cp_orden_giro_Data OdataOG = new cp_orden_giro_Data();
                    if (OdataOG.ModificarDB(InfoOrdenGiro_I, ref msg))
                    {
                        #region reembolso formaspago y retenciones
                        InfoOrdenGiro_I.lst_reembolso.ForEach(p => { p.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro; p.IdTipoCbte_Ogiro = InfoOrdenGiro_I.IdTipoCbte_Ogiro; });

                        if (!Reem_B.ModificarLst(InfoOrdenGiro_I.lst_reembolso, InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdCbteCble_Ogiro, InfoOrdenGiro_I.IdTipoCbte_Ogiro))
                        {
                            msg = "No se pudo Modificar lo(s) reembolso(s) \n Comuníquese con sistemas por favor";

                            res = false;
                        }
                        InfoOrdenGiro_I.lst_formasPagoSRI.ForEach(p => { p.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro; p.IdTipoCbte_Ogiro = InfoOrdenGiro_I.IdTipoCbte_Ogiro; });
                        if (!pagoSRI_B.ModificarDB(InfoOrdenGiro_I.lst_formasPagoSRI, InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdCbteCble_Ogiro, InfoOrdenGiro_I.IdTipoCbte_Ogiro, ref msg))
                        {
                            msg = "No se pudo Modificar la(s) forma(s) de pago \n Comuníquese con sistemas por favor";
                            res = false;
                        }

                       

                        if (InfoOrdenGiro_I.Info_Retencion != null  && InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT != null)
                        {

                            if (InfoOrdenGiro_I.Info_Retencion.IdEmpresa != 0)
                            {
                               
                               //  Verificar Retencion
                                cp_retencion_Bus bus_Reten = new cp_retencion_Bus();
                                if (bus_Reten.Existe_Retencion(InfoOrdenGiro_I.Info_Retencion.IdEmpresa, InfoOrdenGiro_I.Info_Retencion.IdRetencion))
                                {
                                    //Modifica
                                    if (!Bus_Retencion.ModificarDB(InfoOrdenGiro_I.Info_Retencion, InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT, ref msg))
                                    {
                                        msg = "No se pudo Actualizar las retenciones"; res = false;
                                    }

                                }
                                else
                                {

                                    InfoOrdenGiro_I.Info_Retencion.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro;

                                    

                                    if (Bus_Retencion.Graba_CbteCble_Ret_FactProveedor(InfoOrdenGiro_I.Info_Retencion, InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT, ref mensaje))
                                    {
                                        //actualizando el suencial de la retencion serie y #retencion
                                        Bus_Retencion.Modificar_Num_Retencion(InfoOrdenGiro_I.Info_Retencion, ref mensaje);

                                    }
                                    else
                                    {
                                        mensaje = "Hubo un inconveniente al ingresar la retención comuniquese con sistemas.." + mensaje; res = false;
                                    }


                                }                               
                            }
                        }

                       
#endregion

                        if (InfoOrdenGiro_I.Info_cuotas_x_doc.lst_cuotas_det.Count != 0)
                        {
                            InfoOrdenGiro_I.Info_cuotas_x_doc.IdEmpresa_ct = InfoOrdenGiro_I.IdEmpresa;
                            InfoOrdenGiro_I.Info_cuotas_x_doc.IdTipoCbte = InfoOrdenGiro_I.IdTipoCbte_Ogiro;
                            InfoOrdenGiro_I.Info_cuotas_x_doc.IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro;
                            bus_cuotas_x_doc.GuardarDB(InfoOrdenGiro_I.Info_cuotas_x_doc);
                        }

                        List<imp_ordencompra_ext_x_ct_cbtecble_Info> Tab_Int = ocXcbt_B.Get_List_ordencompra_ext_x_ct_cbtecble(InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdTipoCbte_Ogiro, 
                            InfoOrdenGiro_I.IdCbteCble_Ogiro, ref msg);
                        if (Tab_Int == null||Tab_Int.Count <1)
                        {
                            #region
                            if (InfoOrdenGiro_I.LstImportacionGrid.Count() > 0)
                            {
                                InfoOrdenGiro_I.LstImportacionGrid.ForEach(p => p.IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);

                                if (ocXgastosxImp_B.GuardarDB(InfoOrdenGiro_I.LstImportacionGrid, ref mensaje))
                                {
                                    InfoOrdenGiro_I.LstocXcbt_I.ForEach(p => p.ct_IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);
                                    if (ocXcbt_B.GuardarDB(InfoOrdenGiro_I.LstocXcbt_I, ref mensaje))
                                    {
                                        InfoOrdenGiro_I.LisImportacion.ForEach(p => p.og_IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);
                                        if (Importacion_B.GrabarDB(InfoOrdenGiro_I.LisImportacion, ref mensaje))
                                        {
                                            InfoOrdenGiro_I.LstImportacionOC.ForEach(p => p.og_IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);

                                            if (!OC_B.GrabarDB(InfoOrdenGiro_I.LstImportacionOC, ref mensaje))
                                            { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                        }
                                        else { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                    }
                                    else { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                }
                                else { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                            }
                            #endregion
                        }
                        else
                        {
                            List<imp_ordencompra_ext_x_imp_gastosxImport_Info> a = ocXgastosxImp_B.Get_List_ordencompra_ext_x_imp_gastosxImport(Tab_Int[0].imp_IdEmpresa,
                                Tab_Int[0].imp_IdSucusal, Tab_Int[0].imp_IdOrdenCompraExt);
                            List<imp_ordencompra_ext_x_imp_gastosxImport_Info> b = new List<imp_ordencompra_ext_x_imp_gastosxImport_Info>();
                            if (a != null)
                            {
                                b = a.FindAll(q => Convert.ToInt32(q.IdTipoCbte) == InfoOrdenGiro_I.IdTipoCbte_Ogiro 
                                    && Convert.ToDecimal( q.IdCbteCble) == InfoOrdenGiro_I.IdCbteCble_Ogiro);
                            
                            }
                            //eliminar tabla intermedia
                            ocXcbt_B.EliminarDB(Tab_Int[0].ct_IdEmpresa, Tab_Int[0].ct_IdCbteCble, Tab_Int[0].ct_IdTipoCbte);
                            imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus detBus = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus();

                            foreach (imp_ordencompra_ext_x_imp_gastosxImport_Info item in b)
                            {
                                if (!detBus.EliminarDB(item, ref msg)) return false;

                                if (!ocXgastosxImp_B.EliminarDB(item.IdEmpresa, item.IdSucusal, item.IdOrdenCompraExt, item.IdRegistroGasto, ref msg)) return false;
                            }
                            if (InfoOrdenGiro_I.LstImportacionGrid.Count() > 0)
                            {
                                InfoOrdenGiro_I.LstImportacionGrid.ForEach(p => p.IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);

                                if (!ocXgastosxImp_B.GuardarDB(InfoOrdenGiro_I.LstImportacionGrid, ref mensaje)) return false;

                                InfoOrdenGiro_I.LstocXcbt_I.ForEach(p => p.ct_IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);

                                if (!ocXcbt_B.GuardarDB(InfoOrdenGiro_I.LstocXcbt_I, ref mensaje)) return false;

                                    var d = Importacion_B.Get_List_orden_giro_x_imp_ordencompra_ext(Tab_Int[0].ct_IdEmpresa, Tab_Int[0].ct_IdCbteCble, Tab_Int[0].ct_IdTipoCbte);
                                    if (d != null)
                                    {
                                        Importacion_B.EliminarDB(d);
                                        InfoOrdenGiro_I.LisImportacion.ForEach(p => p.og_IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);
                                        if (!Importacion_B.GrabarDB(InfoOrdenGiro_I.LisImportacion, ref mensaje)) return false;
                                        var e = OC_B.Get_List_orden_giro_x_com_ordencompra_local(Tab_Int[0].ct_IdEmpresa, Tab_Int[0].ct_IdCbteCble, Tab_Int[0].ct_IdTipoCbte);
                                        if (e != null)
                                        {
                                            OC_B.EliminarLista(e);
                                            InfoOrdenGiro_I.LstImportacionOC.ForEach(p => p.og_IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro);
                                            if (!OC_B.GrabarDB(InfoOrdenGiro_I.LstImportacionOC, ref mensaje))
                                            { mensaje = "Hubo un inconveniente al ingresar la importación comuniquese con sistemas.." + mensaje; res = false; }
                                        }
                                    }
                                //}
                            }
                        }


                        msg = "La Fact. Proveedor # " + InfoOrdenGiro_I.IdCbteCble_Ogiro + " se modificó Exitósamente";
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarFacturaProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;
        }

        
       
    }
}

