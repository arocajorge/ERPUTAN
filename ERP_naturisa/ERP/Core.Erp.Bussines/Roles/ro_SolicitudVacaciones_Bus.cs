
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_SolicitudVacaciones_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
      
        ro_SolicitudVacaciones_Data oRo_SolicitudVacaciones_Data = new ro_SolicitudVacaciones_Data();

        public List<ro_SolicitudVacaciones_Info> ConsultaPermisosVacaciones(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.Get_List_SolicitudVacaciones(IdEmpresa, Fecha_Inicio, Fecha_Fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPermisosVacaciones", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }

        }

           

        public int MaxPermisoVacaciones(int IdEmpresa)
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.MaxPermisoVacaciones(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "MaxPermisoVacaciones", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }

        }

        public int CalculoDiasTrabajos(int IdEmpresa, DateTime FI, DateTime FF, Decimal IdEmpleado)
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.CalculoDiasTrabajos(IdEmpresa, FI, FF, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalculoDiasTrabajos", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }

        }

        public List<ro_historico_vacaciones_x_empleado_Info> CalculoDiasTrabajosDetalle(int IdEmpresa, DateTime FI, DateTime FF, Decimal IdEmpleado)
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.CalculoDiasTrabajosDetalle(IdEmpresa, FI, FF, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalculoDiasTrabajosDetalle", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }

        }
        
        public int ExisteSolicitud(int IdEmpresa, decimal IdEmpleado, DateTime FI, DateTime FF, string Estado, string Idestado )
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.ExisteSolicitud(IdEmpresa, IdEmpleado, FI, FF, Estado, Idestado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteSolicitud", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }

        }


        public Boolean getExisteFecha(int idEmpresa, decimal idEmpleado, DateTime fecha)
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.getExisteFecha(idEmpresa, idEmpleado, fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getExisteFecha", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }
        
        }




        public Boolean GrabarBD(ro_SolicitudVacaciones_Info info, ref int id, ref string msg)
        { 
            try{
                Boolean valorRetornar = false;

                //MODIFICAR
                if (oRo_SolicitudVacaciones_Data.GetExiste(info, ref msg))
                {
                    info.Fecha_UltMod = param.Fecha_Transac;
                    info.IdUsuarioUltMod = param.IdUsuario;
                    valorRetornar=oRo_SolicitudVacaciones_Data.ModificarBD(info, ref msg);
                    id = info.IdSolicitudVaca;
                }else{
                    //GRABAR
                    info.Fecha = param.Fecha_Transac;
                    info.IdUsuario = param.IdUsuario;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    info.IdUsuarioUltMod = param.IdUsuario;
                    info.Fecha_Transac = param.Fecha_Transac;
                    info.Estado="A";
                    valorRetornar = oRo_SolicitudVacaciones_Data.GrabarBD(info, ref id, ref msg);
                }

                return valorRetornar;
             }
                catch (Exception ex)
                {
                    Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
                }
        }



        public int Get_Dias_Vacaciones(int idempresa, int IdNomina_Tipo, int idempleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oRo_SolicitudVacaciones_Data.Get_Dias_Vacaciones(idempresa, IdNomina_Tipo, idempleado, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_SolicitudVacaciones_Bus) };
            }
        }



       
    }
}
