using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

using Core.Erp.Business.General;



namespace Core.Erp.Business.CuentasxPagar
{
   public class vwcp_orden_pago_con_cancelacion_para_conciliacion_Bus
    {
       vwcp_orden_pago_con_cancelacion_para_conciliacion_Data OPD = new vwcp_orden_pago_con_cancelacion_para_conciliacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";


        public List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Get_List_orden_pago_con_cancelacion_para_conciliacion(int IdEmpresa, ref string mensaje)
       {
           try
           {
               return OPD.Get_List_orden_pago_con_cancelacion_para_conciliacion(IdEmpresa, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_para_conciliacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
           }
       }

       public List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Get_List_orden_pago_con_cancelacion_para_conciliacion(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
       {
           try
           {
               return OPD.Get_List_orden_pago_con_cancelacion_para_conciliacion(IdEmpresa, IdConciliacion, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_para_conciliacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
           }
       }
    }
}
