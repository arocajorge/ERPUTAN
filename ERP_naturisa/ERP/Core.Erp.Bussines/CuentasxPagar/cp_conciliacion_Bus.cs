using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;


namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_conciliacion_Bus
    {
        cp_conciliacion_Data Data = new cp_conciliacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        public List<cp_conciliacion_Info> Get_List_conciliacion(int IdEmpresa, ref string mensaje)
        {
            try
            {
                return Data.Get_List_conciliacion(IdEmpresa,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_conciliacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Bus) };
            }
        }

        public Boolean GrabarDB(ref cp_conciliacion_Info Info, ct_Cbtecble_Info CbteCble_I, ref string mensaje)
        {
            try
            {
                Boolean res = false;

                if (Info.lista_Orden_Pago_Cancel.Count != 0)
                {
                    
                                                        
                    foreach (var item2 in Info.lista_Orden_Pago_Cancel)
                    {
                        item2.IdEmpresa_op =  item2.IdEmpresa_op;
                        item2.IdOrdenPago_op =  item2.IdOrdenPago_op;
                        item2.Secuencia_op =  item2.Secuencia_op;

                        item2.IdEmpresa_op_padre = item2.IdEmpresa_op_padre == 0 ? null : item2.IdEmpresa_op_padre;
                        item2.IdOrdenPago_op_padre = item2.IdOrdenPago_op_padre == 0 ? null : item2.IdOrdenPago_op_padre;
                        item2.Secuencia_op_padre = item2.Secuencia_op_padre == 0 ? null : item2.Secuencia_op_padre;

                        item2.IdEmpresa_cxp = item2.IdEmpresa_cxp == 0 ? null : item2.IdEmpresa_cxp;
                        item2.IdTipoCbte_cxp = item2.IdTipoCbte_cxp == 0 ? null : item2.IdTipoCbte_cxp;
                        item2.IdCbteCble_cxp = item2.IdCbteCble_cxp == 0 ? null : item2.IdCbteCble_cxp;

                        item2.IdEmpresa_pago = item2.IdEmpresa_pago == 0 ? null : item2.IdEmpresa_pago;
                        item2.IdTipoCbte_pago = item2.IdTipoCbte_pago == 0 ? null : item2.IdTipoCbte_pago;
                        item2.IdCbteCble_pago = item2.IdCbteCble_pago == 0 ? null : item2.IdCbteCble_pago;

                    }

                    cp_orden_pago_cancelaciones_Data oCance = new cp_orden_pago_cancelaciones_Data();

                    if (oCance.GuardarDB(Info.lista_Orden_Pago_Cancel, Info.IdEmpresa, ref mensaje))
                    {
                        foreach (var item in Info.lista_Orden_Pago_Cancel)
                        {
                            Info.IdCancelacion = item.Idcancelacion;
                        }


                        if (Data.GrabarDB(ref Info, ref mensaje))
                        {
                            res = true;
                        }

                    }
                } 
            

                
                if (Info.tipo == "ANTPROV")
                {
                
                }
                                                     
                return res;       
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Bus) };
            }
        }

        public Boolean ModificarDB(cp_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                return Data.ModificarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Bus) };
            }
        }

        public Boolean AnularDB(cp_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                return Data.AnularDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Bus) };
            }
        }
    }
}
