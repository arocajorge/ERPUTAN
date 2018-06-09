using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Roles
{
    public class ro_Asignacion_Implemento_x_Empleado_det_Bus
    {
        ro_Asignacion_Implemento_x_Empleado_det_Data Data = new ro_Asignacion_Implemento_x_Empleado_det_Data();

        public List<ro_Asignacion_Implemento_x_Empleado_det_Info> Get_Lista_Implemento_x_empleador_det(int idEmpresa, decimal IdAsignacion_Impl)
        {
            try
            {
                return Data.Get_Lista_Implemento_x_empleador_det(idEmpresa, IdAsignacion_Impl);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Implemento_x_empleador_det", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_det_Bus) };

            }
        }
    }
}
