using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Config_Rubros_ParametrosGenerales_Bus
    {   
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_Config_Rubros_ParametrosGenerales_Data data = new ro_Config_Rubros_ParametrosGenerales_Data();
        public List<ro_Config_Rubros_ParametrosGenerales_Info> ObtenerParamGenerales() 
        {
            try
            {
                return data.Get_List_Config_Rubros_ParametrosGenerales();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParamGenerales", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_ParametrosGenerales_Bus) };

            }
            
           
        }


        public List<ro_Config_Rubros_ParametrosGenerales_Info> ObtenerParamGenerales_Decimos()
        {
            try
            {
                return data.Get_List_Config_Rubros_ParametrosGenerales();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParamGenerales_Decimos", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_ParametrosGenerales_Bus) };

            }
            
        }

        public Boolean Guardar(List<ro_Config_Rubros_ParametrosGenerales_Info> Info, int IncrementaColumnas)
        {


            try
            {
                return data.GrabarDB(Info, IncrementaColumnas);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_ParametrosGenerales_Bus) };

            }
                
        }
    }
}
