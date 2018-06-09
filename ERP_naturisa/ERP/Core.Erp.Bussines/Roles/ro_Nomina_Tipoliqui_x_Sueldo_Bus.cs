using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Nomina_Tipoliqui_x_Sueldo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Nomina_Tipoliqui_x_Sueldo_Data Data = new ro_Nomina_Tipoliqui_x_Sueldo_Data();

        public List<ro_Nomina_Tipoliqui_x_Sueldo_Info> ConsultaTipoLiquixSueldo(int IDempresa)
        {
            try
            {
                return Data.Get_List_Nomina_Tipoliqui_x_Sueldo(IDempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Nomina_Tipoliqui", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_x_Sueldo_Bus) };
            }

        }

        public Boolean GuardarBD(List<ro_Nomina_Tipoliqui_x_Sueldo_Info> Info)
        {
            try
            {
                return Data.GuardarBD(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_x_Sueldo_Bus) };
            }

        }
    }
}
