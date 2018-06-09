using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_marcaciones_tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_marcaciones_tipo_Data data = new ro_marcaciones_tipo_Data();
        public List<ro_marcaciones_tipo_Info> Get_List_marcaciones_tipo()
        {
            try
            {
                return data.Get_List_marcaciones_tipo(); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_tipo", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_x_TipoMarcacion_Bus) };
            }

        }
        public Boolean GrabarDB(ro_marcaciones_tipo_Info info)
        {
            try
            {
             return data.GrabarDB(info); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_x_TipoMarcacion_Bus) };
            }

        }
    }
}
