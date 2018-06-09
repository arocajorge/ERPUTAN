using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_empresa_x_TipoLiqui_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_empresa_x_TipoLiqui_data oData = new ro_empresa_x_TipoLiqui_data();

        public Boolean ModificarDB(ro_empresa_x_TipoLiqui_Info prI, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_empresa_x_TipoLiqui_bus) };
            }
        }

        public Boolean GrabarDB(ro_empresa_x_TipoLiqui_Info prI, ref string mensaje)
        {
            try
            {
                return oData.GrabarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_empresa_x_TipoLiqui_bus) };
            }
        }

        public List<ro_empresa_x_TipoLiqui_Info> Get_List_empresa_x_TipoLiqui(int IdEmpresa)
        {
            try
            {
                List<ro_empresa_x_TipoLiqui_Info> lM = new List<ro_empresa_x_TipoLiqui_Info>();
                ro_empresa_x_TipoLiqui_data data = new ro_empresa_x_TipoLiqui_data();
                lM = data.Get_List_empresa_x_TipoLiqui(IdEmpresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empresa_x_TipoLiqui", ex.Message), ex) { EntityType = typeof(ro_empresa_x_TipoLiqui_bus) };
            }

        }

        public ro_empresa_x_TipoLiqui_bus(){}
    }
}
