using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt015_Bus
    {
        XROL_Rpt015_Data Data = new XROL_Rpt015_Data();
        public List<XROL_Rpt015_Info> Get_Asignacion_x_empleado(int idEmpresa, int  IdNomina_tipo, decimal IdEmpleado, decimal idAsignacion_Impl)
        {
            try
            {
                return Data.Get_Asignacion_x_empleado(idEmpresa, IdNomina_tipo,IdEmpleado,idAsignacion_Impl);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Asignacion_x_empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt015_Bus) };

            }
        }
    }
}
