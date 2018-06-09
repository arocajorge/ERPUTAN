using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    
    public class vwct_cbtecble_con_saldo_cxp_Bus
    {
        vwct_cbtecble_con_saldo_cxp_Data Data = new vwct_cbtecble_con_saldo_cxp_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwct_cbtecble_con_saldo_cxp_Info> Get_list_cbtecble_con_saldo_cxp(int IdEpresa, string tipo, DateTime cb_fechaDesde,
            DateTime cb_fechaHasta, ref string mensaje)
        {
            try
            {
                return Data.Get_list_cbtecble_con_saldo_cxp(IdEpresa, tipo, cb_fechaDesde, cb_fechaHasta, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_cbtecble_con_saldo_cxp", ex.Message), ex) { EntityType = typeof(vwct_cbtecble_con_saldo_cxp_Bus) };
            }
        }

        public vwct_cbtecble_con_saldo_cxp_Info Get_Info_cbtecble_con_saldo_cxp(int IdEmpresa_op, decimal IdOrdenPago_op, string tipo, ref string mensaje)
        {
            try
            {
                return Data.Get_Info_cbtecble_con_saldo_cxp(IdEmpresa_op, IdOrdenPago_op, tipo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_cbtecble_con_saldo_cxp", ex.Message), ex) { EntityType = typeof(vwct_cbtecble_con_saldo_cxp_Bus) };
            }
        
        
        }
    }
}
