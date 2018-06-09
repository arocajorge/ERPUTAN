/*CLASE: ro_Participacion_Utilidad_Empleado_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 28-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_Participacion_Utilidad_Empleado_Bus
    {
        //INFO
        ro_Participacion_Utilidad_Empleado_Data oData = new ro_Participacion_Utilidad_Empleado_Data();

        //BUS
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      
        string mensaje = "";

        public List<ro_Participacion_Utilidad_Empleado_Info> GetListPorIdPeriodo(int idEmpresa, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListPorIdPeriodo(idEmpresa, idPeriodo,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorIdPeriodo", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Empleado_Bus) };
            }
        }


       public List<ro_Participacion_Utilidad_Empleado_Info> GetListPorIdEmpleado(int idEmpresa, int idEmpleado, ref string msg)
        {
            try
            {
                return oData.GetListPorIdEmpleado(idEmpresa, idEmpleado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorIdEmpleado", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Empleado_Bus) };
            }
        }

        public Boolean GuardarBD(ro_Participacion_Utilidad_Empleado_Info info, ref string msg)
        {
            try {
                Boolean valorRetornar=false;

                valorRetornar = oData.GuardarBD(info, ref msg);  

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Empleado_Bus) };
            }
        }

     public Boolean EliminarBD(int idEmpresa, int idPeriodo,  ref string msg)
        {
            try
            {
                return oData.EliminarBD(idEmpresa, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Empleado_Bus) };
            }
        }





    }
}
