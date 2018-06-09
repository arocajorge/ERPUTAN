using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Salario_Digno_Empleado_Bus
    {

        ro_Salario_Digno_Empleado_Data oData = new ro_Salario_Digno_Empleado_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ro_Salario_Digno_Empleado_Info> GetListConsultaPorNomina(int idEmpresa, int idNominaTipo, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorNomina(idEmpresa, idNominaTipo, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorNomina", ex.Message), ex) { EntityType = typeof(ro_Salario_Digno_Empleado_Bus) };
            }
        }

        public Boolean GuardarBD(ro_Salario_Digno_Empleado_Info info, ref string msg)
        {
            try
            {
                info.FechaIngresa = param.Fecha_Transac;
                info.UsuarioIngresa = param.IdUsuario;
                return oData.GuardarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Salario_Digno_Empleado_Bus) };
            }

        }


        public Boolean EliminarBD(int idEmpresa, int idNomina, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.EliminarBD(idEmpresa, idNomina,idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Salario_Digno_Empleado_Bus) };
            }
        
        }


    }
}
