/*CLASE: ro_Empleado_X_Horario_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 12-06-2015
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
    public  class ro_Empleado_X_Horario_Bus
    {
        ro_Empleado_X_Horario_Data oData = new ro_Empleado_X_Horario_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

      public List<ro_Empleado_X_Horario_Info> Get_List_Empleado_X_Horario(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_List_Empleado_X_Horario(IdEmpresa,IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_X_Horario", ex.Message), ex) { EntityType = typeof(ro_Empleado_X_Horario_Bus) };
            }
        }

      public ro_Empleado_X_Horario_Info Get_Info_Empleado_X_Horario_Preterminado(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_Info_Empleado_X_Horario_Preterminado(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_X_Horario_Preterminado", ex.Message), ex) { EntityType = typeof(ro_Empleado_X_Horario_Bus) };
            }
        
        }

      public Boolean GrabarBD(ro_Empleado_X_Horario_Info info, ref string msg)
      {
              try
              {
                  if (oData.GetExiste(info, ref msg))
                  {//MODIFICA
                      return oData.ModificarBD(info, ref msg);
                  }
                  else
                  {
                      //NUEVO
                      info.UsuarioIngresa = param.IdUsuario;
                      info.FechaIngresa = param.Fecha_Transac;
                      return oData.GrabarBD(info, ref msg);
                  }

              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_X_Horario_Bus) };
              }
      }

      public Boolean EliminarBD(int IdEmpresa, decimal IdEmpleado, ref string msg)
      {
          try
          {
              return oData.EliminarBD(IdEmpresa, IdEmpleado, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_X_Horario_Bus) };
          }
      }

    }
}
