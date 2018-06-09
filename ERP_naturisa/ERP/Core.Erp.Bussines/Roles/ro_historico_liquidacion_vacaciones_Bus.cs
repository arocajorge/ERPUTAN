using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
namespace Core.Erp.Business.Roles
{
   public class ro_historico_liquidacion_vacaciones_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       ro_historico_liquidacion_vacaciones_Data data = new Data.Roles.ro_historico_liquidacion_vacaciones_Data(); 
        public Boolean GrabarBD(ro_historico_liquidacion_vacaciones_Info Info)
        {
            try
            {

                return data.GrabarBD(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
     
            }

        }
        public Boolean EliminarDB(ro_historico_liquidacion_vacaciones_Info info)
        {
            try
            {
                return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
     
            }
        }

        public double Get_Valor_vacaciones(int IdEmpresa, int IdNomina_tipo, int IdEmpleado, DateTime Fecha_Inicio, DateTime Fecha_Fin, string IdRubro)
        {
            try
            {
                return data.Get_Valor_vacaciones(IdEmpresa, IdNomina_tipo, IdEmpleado, Fecha_Inicio, Fecha_Fin, IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
     
            }
        }

    }
}
