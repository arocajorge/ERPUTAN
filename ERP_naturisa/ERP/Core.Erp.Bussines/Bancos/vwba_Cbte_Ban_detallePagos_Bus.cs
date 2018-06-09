using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class vwba_Cbte_Ban_detallePagos_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

         vwba_Cbte_Ban_detallePagos_Data data = new vwba_Cbte_Ban_detallePagos_Data();

         public List<vwba_Cbte_Ban_detallePagos_Info> Get_List_Cbte_Ban_detallePagos(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
         {
             try
             {
                     return data.Get_List_Cbte_Ban_detallePagos(IdEmpresa, IdTipocbte, IdCbteCble);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_detallePagos", ex.Message), ex) { EntityType = typeof(vwba_Cbte_Ban_detallePagos_Bus) };
             }

         }



         public List<vwba_ordenGiroPendientes_Info> Get_List_PgCheque(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
        {
            try
            {
               return data.Get_List_PgCheque(IdEmpresa, IdTipocbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PgCheque", ex.Message), ex) { EntityType = typeof(vwba_Cbte_Ban_detallePagos_Bus) };
            }

        }
        public vwba_Cbte_Ban_detallePagos_Bus()
        {
            
        }
    }
}
