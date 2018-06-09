using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
   public class vwcp_Anticipos_para_Conciliar_Bus
    {
       vwcp_Anticipos_para_Conciliar_Data Data = new vwcp_Anticipos_para_Conciliar_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwcp_Anticipos_para_Conciliar_Info> Get_list_Anticipos_para_Conciliar(int IdEmpresa, string tipo, DateTime cb_fechaDesde,
   DateTime cb_fechaHasta, ref string mensaje)
        {
            try
            {
                return Data.Get_list_Anticipos_para_Conciliar(IdEmpresa,tipo, cb_fechaDesde, cb_fechaHasta ,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Anticipos_para_Conciliar", ex.Message), ex) { EntityType = typeof(vwcp_Anticipos_para_Conciliar_Bus) };
            }
        }
    }
}
