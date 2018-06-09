using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SRI;
using Core.Erp.Info.Roles;
using Core.Erp.Data.SRI;
using Core.Erp.Business.General;

namespace Core.Erp.Business.SRI
{
    public class sri_tipo_Gasto_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        sri_tipo_Gasto_Data Data = new sri_tipo_Gasto_Data();

        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> ConsultaSRITipoGasto()
        {
            try
            {
              return Data.ConsultaSRITipoGasto();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaSRITipoGasto", ex.Message), ex) { EntityType = typeof(sri_tipo_Gasto_Bus) };
            }

        }
    }
}
