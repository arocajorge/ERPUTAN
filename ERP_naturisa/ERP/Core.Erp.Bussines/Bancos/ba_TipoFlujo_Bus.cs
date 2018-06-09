using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
   public class ba_TipoFlujo_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";

       ba_TipoFlujo_Data data = new ba_TipoFlujo_Data();
       
       public Boolean GuardarDB(ba_TipoFlujo_Info Info ,ref decimal  IdTipoFlujo)
       {
           try
           {
             return data.GuardarDB(Info, ref IdTipoFlujo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_TipoFlujo_Bus) };
           }

       }

       public List<ba_TipoFlujo_Info> Get_List_TipoFlujo(int IdEmpresa)
       {
           try
           {
             return data.Get_List_TipoFlujo(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TipoFlujo", ex.Message), ex) { EntityType = typeof(ba_TipoFlujo_Bus) };
           }

       }
       public Boolean ModificarDB(ba_TipoFlujo_Info Infoo)
       {
           try
           {
                return data.ModificarDB(Infoo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_TipoFlujo_Bus) };
           }

       }
       public Boolean AnularDB(ba_TipoFlujo_Info Infoo)
       {
           try
           {
                  return data.AnularDB(Infoo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_TipoFlujo_Bus) };
           }
 
       }
       public ba_TipoFlujo_Bus()
       {
          
       }
    }
}
