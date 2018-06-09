/*CLASE: ro_empleado_x_centro_costo_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 21-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;


namespace Core.Erp.Business.Roles
{
    public class ro_empleado_x_centro_costo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
     
        ro_empleado_x_centro_costo_Data oData = new ro_empleado_x_centro_costo_Data();

        public List<ro_empleado_x_centro_costo_Info> Get_List_CentroCosto_X_emplead(int idEmpresa, decimal Idempleado, ref string msg)
        {
            try
            {
                return oData.Get_List_CentroCosto_X_empleado(idEmpresa, Idempleado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CentroCosto_X_empleado", ex.Message), ex) { EntityType = typeof(ro_empleado_x_centro_costo_Bus) };
            }
        }


        public List<ro_empleado_x_centro_costo_Info> Get_List_empleado_x_centro_costo(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.Get_List_empleado_x_centro_costo(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_centro_costo", ex.Message), ex) { EntityType = typeof(ro_empleado_x_centro_costo_Bus) };
            }
        }


        public Boolean GrabarBD(ro_empleado_x_centro_costo_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                info.UsuarioIngresa = param.IdUsuario;
                info.FechaIngresa = param.Fecha_Transac;

                valorRetornar = oData.GuardarBD(info, ref msg);
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_centro_costo_Bus) };
            }

        }



        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                valorRetornar = oData.EliminarBD(idEmpresa, idEmpleado, ref msg);
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_centro_costo_Bus) };
            }
        }



        public Boolean GrabarBD(ro_empleado_x_centro_costo_Info info)
        {
            try
            {
                Boolean valorRetornar = false;

                info.UsuarioIngresa = param.IdUsuario;
                info.FechaIngresa = param.Fecha_Transac;

                valorRetornar = oData.GuardarBD(info);
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_centro_costo_Bus) };
            }

        }


    }
}
