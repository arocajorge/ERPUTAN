using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
   public class vwba_ordenGiroPendientes_Bus
    {

       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       vwba_ordenGiroPendientes_Data data = new vwba_ordenGiroPendientes_Data();

       public List<vwba_ordenGiroPendientes_Info> Get_List_ordenGiroPendientes(int IdEmpresa)
       {
           try
           {
             return data.Get_List_ordenGiroPendientes(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordenGiroPendientes", ex.Message), ex) { EntityType = typeof(vwba_ordenGiroPendientes_Bus) };
           }

       }
       public List<vwba_ordenGiroPendientes_Info> Get_List_ordenGiroPendientes(int IdEmpresa, decimal IdProveedor)
       {
           try
           {
             return data.Get_List_ordenGiroPendientes(IdEmpresa, IdProveedor);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordenGiroPendientes", ex.Message), ex) { EntityType = typeof(vwba_ordenGiroPendientes_Bus) };
           }

       }
        public vwba_ordenGiroPendientes_Bus() {
           
        }
    }
}
