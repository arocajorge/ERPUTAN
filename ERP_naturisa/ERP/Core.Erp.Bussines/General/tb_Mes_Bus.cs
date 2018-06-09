using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
   public class tb_Mes_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_Mes_Data data = new tb_Mes_Data();


        public List<tb_Mes_info> Get_List_Mes()
        {

            try
            {
                return data.Get_List_Mes();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Allmes", ex.Message), ex) { EntityType = typeof(tb_Mes_Bus) };
                 
                
            }
        }
          
      
      
    }
}
