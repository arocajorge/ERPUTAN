using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
   public  class cp_codigo_SRI_tipo_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       public List<cp_codigo_SRI_tipo_Info> Get_List_codigo_SRI_tipo()
       {
           try
           {
                cp_codigo_SRI_tipo_Data tp_data_ = new cp_codigo_SRI_tipo_Data();
                return tp_data_.Get_List_codigo_SRI_tipo();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_codigo_SRI_tipo", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_tipo_Bus) };
           }


        }

       public Boolean GrabarDB(cp_codigo_SRI_tipo_Info info)
        {
            try
            {
                cp_codigo_SRI_tipo_Data data = new cp_codigo_SRI_tipo_Data();
                return data.GrabarDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_tipo_Bus) };
            }
        }



       public Boolean ModificarDB(cp_codigo_SRI_tipo_Info info)
        {

            try
            {
                cp_codigo_SRI_tipo_Data data = new cp_codigo_SRI_tipo_Data();
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_tipo_Bus) };
            }
        }



       public cp_codigo_SRI_tipo_Bus()
       {
           
       }
   }
}
