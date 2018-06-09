using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_parametros_CusCidersus_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_parametros_CusCidersus_Data data = new prd_parametros_CusCidersus_Data();
        
        public prd_parametros_CusCidersus_Info ObtenerObjeto(int IdEmpresa)
        {
            try
            {
              return data.ObtenerObjeto(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(prd_parametros_CusCidersus_Bus) };
               
            }

        }
        
        public Boolean GuardarDB(prd_parametros_CusCidersus_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_parametros_CusCidersus_Bus) };
               
            }
        }

        public Boolean ModificarDB(prd_parametros_CusCidersus_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_parametros_CusCidersus_Bus) };
               
            }
        }

         public Boolean GuardaroModificar(int idempresa)
         {
            try
            {
                return data.GuardaroModificar(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardaroModificar", ex.Message), ex) { EntityType = typeof(prd_parametros_CusCidersus_Bus) };
               
                }
            }
    }
}
