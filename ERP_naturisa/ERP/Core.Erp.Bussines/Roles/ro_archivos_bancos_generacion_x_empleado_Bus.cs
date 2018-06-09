
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
    public class ro_archivos_bancos_generacion_x_empleado_Bus
    {
        ro_archivos_bancos_generacion_x_empleado_Data oData = new ro_archivos_bancos_generacion_x_empleado_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ro_archivos_bancos_generacion_x_empleado_Info> GetListConsultaPorIdArchivo(int idEmpresa, decimal idArchivo)
        {
            try
            {
                return oData.GetListConsultaPorIdArchivo(idEmpresa, idArchivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorIdArchivo", ex.Message), ex) { EntityType = typeof(ro_archivos_bancos_generacion_x_empleado_Bus) };

            }
        }

        public Boolean GuardarBD(ro_archivos_bancos_generacion_x_empleado_Info info, ref string msg)
        {
            try
            {
                return oData.GuardarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_archivos_bancos_generacion_x_empleado_Bus) };

            }
        }


        public Boolean EliminarBD(int idEmpresa, decimal idArchivo, ref string msg)
        { 
         try
            {
                return oData.EliminarBD(idEmpresa,idArchivo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_archivos_bancos_generacion_x_empleado_Bus) };

            }
        
        
        }

        public bool SiExiste(int idEmpresa, int IdNomina, int IdNomiaTipoLiq, int IdPeriodo, decimal IdEmpleado)
        {
            try
            {
                return oData.SiExiste(idEmpresa, IdNomina, IdNomiaTipoLiq, IdPeriodo, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_archivos_bancos_generacion_x_empleado_Bus) };

            }
        
        }
        public Boolean ActulizarDB(int idEmpresa, int IdNomina, int IdNomiaTipoLiq, int IdPeriodo, decimal IdEmpleado, double valor)
        {
            try
            {
                return oData.ActulizarDB(idEmpresa, IdNomina, IdNomiaTipoLiq, IdPeriodo, IdEmpleado, valor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_archivos_bancos_generacion_x_empleado_Bus) };

            }
        }

    }
}
