using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Importacion
{
    public class imp_Parametros_Bus
    {
        
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_Parametros_Data odata = new imp_Parametros_Data();

        public imp_Parametros_Info Get_Info_Parametros(int IdEmpresa)
        {
            try
            {
             return odata.Get_Info_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtener_parametros", ex.Message), ex) { EntityType = typeof(imp_Parametros_Bus) };
            
            }

        }

        public Boolean ModificarDB(imp_Parametros_Info Info)
        {
            try
            {
                return odata.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(imp_Parametros_Bus) };
            
            }

        
        }
    }
}
