using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Roles
{
    public class ro_Asignacion_Implemento_x_Empleado_Bus
    {
        ro_Asignacion_Implemento_x_Empleado_Data Data = new ro_Asignacion_Implemento_x_Empleado_Data();
        Boolean res = true;

       

       
        public List<ro_Asignacion_Implemento_x_Empleado_Info> Get_Lista_Vista_x_Fecha(int idEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Data.Get_ListAsignacion_Implemento_x_Empleado(idEmpresa,FechaIni,FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Vista_x_Fecha", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_Bus) };

            }
        }

        public Boolean GuardarDB(ro_Asignacion_Implemento_x_Empleado_Info Info, ref string mensajeE, ref decimal IdAsignacion)
        {
            try
            {
                if (Validar_Objeto(Info,ref mensajeE))
                {
                    res = Data.GuardarDB(Info,ref IdAsignacion);
                }
                else
                    res = false;
                return res;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_Bus) };

            }
        }

        public Boolean ActualizarDB(ro_Asignacion_Implemento_x_Empleado_Info Info, ref string mensajeE)
        {
            try
            {
                if (Validar_Objeto(Info, ref mensajeE))
                {
                    res = Data.ModificarDB(Info);
                }
                else
                    res = false;
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_Bus) };

            }
        }

        public Boolean AnularDB(ro_Asignacion_Implemento_x_Empleado_Info Info, ref string mensajeE)
        {
            try
            {
                return Data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_Bus) };

            }
        }

        private Boolean Validar_Objeto(ro_Asignacion_Implemento_x_Empleado_Info Info, ref string mensajeE)
        {
            try
            {
                res = true;
                if (Info.IdEmpleado==null || Info.IdEmpleado==0)
                {
                    mensajeE = "Seleccione un empleado ";
                    res = false;
                }

                if (Info.Observacion == null || Info.Observacion == "")
                {
                    mensajeE = "Ingrese una observación ";
                    res = false;
                }

                if (Info.Fecha_Entrega == null)
                {
                    mensajeE = "Seleccione la fecha ";
                    res = false;
                }



                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_Objeto", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_Bus) };
                return false;
            }
        }

        public bool Get_si_existe_Implemento_pendiente_devolver(Int32 idEmpresa, int IdNominaTipo, int IdEmpleado)
        {
            try
            {
                return Data.Get_si_existe_Implemento_pendiente_devolver(idEmpresa, IdNominaTipo, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Asignacion_Implemento_x_Empleado_Bus) };

            }
        }
    }
}
