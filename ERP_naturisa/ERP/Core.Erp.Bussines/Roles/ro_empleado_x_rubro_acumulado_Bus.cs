
/*CLASE: ro_empleado_x_rubro_acumulado_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 14-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;

using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_empleado_x_rubro_acumulado_Bus
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_empleado_x_rubro_acumulado_Data oData = new ro_empleado_x_rubro_acumulado_Data();

        public List<ro_empleado_x_rubro_acumulado_Info> Get_List_empleado_x_rubro_acumulado(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_List_empleado_x_rubro_acumulado(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_rubro_acumulado", ex.Message), ex) { EntityType = typeof(ro_empleado_x_rubro_acumulado_Bus) };
            }
        }




        public Boolean GrabarBD(ro_empleado_x_rubro_acumulado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                info.UsuarioIngresa = param.IdUsuario;
                info.FechaIngresa = param.Fecha_Transac;

                valorRetornar = oData.GrabarBD(info, ref mensaje);
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_rubro_acumulado_Bus) };
            }
        
        }
   


public Boolean EliminarBD(ro_empleado_x_rubro_acumulado_Info info, ref string msg)
   {
       try
       {
           Boolean valorRetornar = false;
           valorRetornar = oData.EliminarBD(info, ref mensaje);
           return valorRetornar;
       }
       catch (Exception ex)
       {
           Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
           throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_rubro_acumulado_Bus) };
       }
   }


public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
{
    try
    {
        Boolean valorRetornar = false;
        valorRetornar = oData.EliminarBD(idEmpresa, idEmpleado, ref mensaje);
        return valorRetornar;
    }
    catch (Exception ex)
    {
        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_rubro_acumulado_Bus) };
    }
}



    }
}
