/*CLASE: ro_horario_planificacion_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 15-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_horario_planificacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_horario_planificacion_Data data = new ro_horario_planificacion_Data();

        public List<ro_horario_planificacion_Grid_Info> Get_List_horario_planificacion_Grid(DateTime FechaIni, DateTime FechaFin, List<ro_horario_planificacion_Grid_Info> ListadoHorario)
        {
            try
            {
                    return data.Get_List_horario_planificacion_Grid(FechaIni, FechaFin, ListadoHorario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_horario_planificacion_Grid", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }

        }

        public ro_horario_planificacion_Grid_Info Get_Info_horario_planificacion_Gri(decimal[] arreglo, ro_horario_planificacion_Grid_Info info)
        {
            try
            {
                 return data.Get_Info_horario_planificacion_Grid(arreglo, info); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_horario_planificacion_Grid", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }

        }
        public ro_horario_planificacion_Grid_Info Getarray(decimal[] arreglo, ro_horario_planificacion_Grid_Info info)
        {
            try
            {
                return data.Getarray(arreglo, info); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Getarray", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }

        }

        public Boolean GrabarDB(Decimal IdTurnoLibre, DateTime FechaIni, DateTime FechaFin, List<ro_horario_planificacion_Grid_Info> ListadoHorarios)
        {
            try
            {
                return data.GrabarDB(IdTurnoLibre, FechaIni, FechaFin, ListadoHorarios); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }
 
        }
        public List<ro_horario_planificacion_Grid_Info> setIdHorario(Decimal IdTurno, DateTime FechaIni, DateTime FechaFin, List<ro_horario_planificacion_Grid_Info> Listado)
        {
            try
            {
               return data.setIdHorario(IdTurno, FechaIni, FechaFin, Listado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "setIdHorario", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }

        }



        public List<ro_horario_planificacion_Info> Get_List_horario_planificacion(int idEmpresa, decimal idEmpleado, DateTime fechaInicial, DateTime fechaFinal)
        {
            try
            {
                return data.Get_List_horario_planificacion(idEmpresa, idEmpleado, fechaInicial, fechaFinal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_horario_planificacion", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }

        }
  

         public Boolean GetVerificarDobleTurno(int idEmpresa,  decimal idEmpleado, int idCalendario, ref string msg) 
        {
            try
            {
                return data.GetVerificarDobleTurno(idEmpresa, idEmpleado, idCalendario, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetVerificarDobleTurno", ex.Message), ex) { EntityType = typeof(ro_horario_planificacion_Bus) };
            }

        }

    }
}
