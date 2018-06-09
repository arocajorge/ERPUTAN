

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;

namespace Core.Erp.Business.Roles
{
    public class ro_marcaciones_x_empleado_Bus
    {
        ro_turno_x_tb_dia_Bus bus_turnos = new ro_turno_x_tb_dia_Bus();
        List<ro_turno_x_tb_dia_Info> lista_turnos_x_dia = new List<ro_turno_x_tb_dia_Info>();

       public ro_marcaciones_x_empleado_Bus(int IdEmpresa)
        {
            lista_turnos_x_dia = bus_turnos.ConsultaDetallexTurno(IdEmpresa);
        }

       public ro_marcaciones_x_empleado_Bus()
       {
       }
        #region
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_marcaciones_x_empleado_Data data = new ro_marcaciones_x_empleado_Data();

        #endregion


        public Boolean GrabarDB(List<ro_marcaciones_x_empleado_Info> ListaGrabar, int IdEmpresa, int IdPeriodo)
        {
            try
            {
                return data.GrabarDB(ListaGrabar, IdEmpresa, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }

        public Boolean GrabarDB(List<ro_marcaciones_x_empleado_Info> ListaGrabar, int IdEmpresa)
        {
            try
            {
                return data.GrabarDB(ListaGrabar, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }

        public Boolean GrabarDB(List<ro_marcaciones_x_empleado_Info> ListaGrabar)
        {
            try
            {
                return data.GrabarDB(ListaGrabar);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }
      
        public List<ro_marcaciones_x_empleado_Info> ProcesarDataTableAInfo_x_TipEquipo(DataTable ds, int tipo, int idempresa, ref string msg)
        {
            try
            {
                  return data.ProcesarDataTableAInfo_x_TipEquipo(ds, tipo, idempresa, ref msg); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTableAInfo_x_TipEquipo", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            } 

        }

        public Boolean GrabarDB(ro_marcaciones_x_empleado_Info Item, ref string IdRegistro, ref string mensaje)
        {
            try
            {
                return data.GrabarDB(Item, ref IdRegistro, ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }
        }

        public Boolean ModificarDB(ro_marcaciones_x_empleado_Info Info, string msj)
        {
            try
            {
                 return data.ModificarDB(Info, msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                 return data.Get_List_marcaciones_x_empleado(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_x_empleado", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }

        public Boolean EliminarDB(string IdRegistro, int IdEmpresa)
        {
            try
            {
                return data.EliminarDB(IdRegistro, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }



        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(int IdEmpresa, decimal idEmpleado, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_marcaciones_x_empleado(IdEmpresa,idEmpleado, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_x_empleado", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(DateTime Finicio, DateTime Ffin, string Ocon)
        {
            try
            {
                return data.Get_List_marcaciones_x_empleado(Finicio, Ffin, Ocon);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_x_empleado", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }
        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado_Graf(DateTime Finicio, DateTime Ffin, string Ocon)
        {
            try
            {
                return data.Get_List_marcaciones_x_empleado_Graf(Finicio, Ffin, Ocon);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_x_empleado", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }
        }

        // granar marcaciones transgandia ingresadas por el sistema

        public Boolean GrabarDB_Transgandia(List< ro_marcaciones_x_empleado_Info> lista)
        {
            try
            {
                ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus bus_novedad_x_ingreso = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus();
                ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Bus bus_novedades_pendientes = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Bus();
                int sec = 0;
                foreach (var item in lista)
                {
                    sec = sec + 1;
                    item.secuencia = sec;
                    item.es_fechaRegistro = Convert.ToDateTime(Convert.ToDateTime(item.es_fechaRegistro).ToShortDateString());
                    item.IdRegistro = item.IdRegistro.ToString() +"-"+"IdE"+"-"+ item.IdEmpleado.ToString();
                    if (data.GrabarDB(item))
                    {
                        bus_novedad_x_ingreso.Grabar_DB(item.info_novedad_x_ingreso);
                    }


                    // si es sabadop o domingo o feriado para ingresar las horas extras tmp hasta ser aprobadas
                    int dia = Convert.ToInt32(Convert.ToDateTime( item.es_fechaRegistro).DayOfWeek);

                    if ((dia == 6 || dia == 0) || (item.info_novedad_x_ingreso.es_feriado == true) && (item.info_novedad_x_ingreso.Id_catalogo_Cat == "ASIST" || item.info_novedad_x_ingreso.Id_catalogo_Cat == "ATRA"))
                    {


                        if (item.es_jornada_desfasada == false)// si no es jornada desfasada pago horas extras sabado y domingo normal
                        {


                            ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info info_novedades = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info();
                            info_novedades.IdEmpleado = item.IdEmpleado;
                            info_novedades.IdNomina = item.IdNomina_Tipo;
                            info_novedades.IdEmpresa = item.IdEmpresa;
                            info_novedades.Num_horasExtras = "0";
                            info_novedades.IdRubro = "9";
                            info_novedades.es_fecha_registro = Convert.ToDateTime(item.es_fechaRegistro);
                            info_novedades.Observacion = "horas extras por dia" + item.es_fechaRegistro.ToString();
                            info_novedades.Estado_aprobacion = false;
                            info_novedades.IdRegistro = item.IdRegistro;
                            
                            bus_novedades_pendientes.GuardarDB(info_novedades);
                        }

                        else
                        {
                          
                            if (dia== 0)
                            {
                                ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info info_novedades = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info();
                                info_novedades.IdEmpleado = item.IdEmpleado;
                                info_novedades.IdEmpresa = item.IdEmpresa;
                                info_novedades.Num_horasExtras = "0";
                                info_novedades.IdRubro = "9";
                                info_novedades.es_fecha_registro = Convert.ToDateTime(item.es_fechaRegistro);
                                info_novedades.Observacion = "horas extras por dia" + item.es_fechaRegistro.ToString();
                                info_novedades.Estado_aprobacion = false;
                                info_novedades.IdRegistro = item.IdRegistro;
                                bus_novedades_pendientes.GuardarDB(info_novedades);
                            }
                        }

                    }
                    

                    

                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_empleado_Bus) };
            }

        }

    }
}
