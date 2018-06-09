using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
   public  class ro_Config_rubros_x_Prestamo_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       ro_Config_rubros_x_Prestamo_Data odata = new ro_Config_rubros_x_Prestamo_Data();


       public Boolean GuardarDB(ro_Config_rubros_x_Prestamo_Info Info)
        {
            try
            {
                return odata.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Config_rubros_x_Prestamo_Bus) };

            }

        }

       public Boolean ModificarDB(ro_Config_rubros_x_Prestamo_Info info)
       {
           try
           {
               return odata.ModificarDB(info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Config_rubros_x_Prestamo_Bus) };

           }

       }

       public Boolean Borrar(ro_Config_rubros_x_Prestamo_Info Info)
       {
           try
           {
             return odata.Borrar(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Borrar", ex.Message), ex) { EntityType = typeof(ro_Config_rubros_x_Prestamo_Bus) };

           }

       }

       public int getId(int IdEmpresa)
       {
           try
           {
               ro_Config_rubros_x_Prestamo_Data data = new ro_Config_rubros_x_Prestamo_Data();
               return data.getId(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_Config_rubros_x_Prestamo_Bus) };


           }
       }

       public List<ro_Config_rubros_x_Prestamo_Info> ConsultaGeneral(int IdEmpresa)
       {
           try
           {
               return odata.ConsultaGeneral(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Config_rubros_x_Prestamo_Bus) };

           }

       }
    }
}
