using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_marcaciones_Equipo_x_TipoMarcacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_marcaciones_Equipo_x_TipoMarcacion_Data data = new ro_marcaciones_Equipo_x_TipoMarcacion_Data();

        public List<ro_marcaciones_Equipo_x_TipoMarcacion_Info> Get_List_marcaciones_Equipo_x_TipoMarcacion(int id)
        {
            try
            {
                return data.Get_List_marcaciones_Equipo_x_TipoMarcacion(id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_Equipo_x_TipoMarcacion", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_x_TipoMarcacion_Bus) };
            }

        }

        public Boolean ValidarExiste(int cod, string pIdTipoMarcaciones_sys)
        {
            try
            {
                return data.ValidarExiste(cod, pIdTipoMarcaciones_sys);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarExiste", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_x_TipoMarcacion_Bus) };
            }

        }

        public Boolean ModificarDB(ro_marcaciones_Equipo_x_TipoMarcacion_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_x_TipoMarcacion_Bus) };
            }

        }

        public Boolean GuardarDB(ro_marcaciones_Equipo_x_TipoMarcacion_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_x_TipoMarcacion_Bus) };
            }


        }
    }
}



