/*CLASE: ro_Nomina_X_Horas_Extras_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 10-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;


namespace Core.Erp.Data.Roles
{
    public class ro_Nomina_X_Horas_Extras_Data
    {

        private string mensaje = "";

        public List<ro_Nomina_X_Horas_Extras_Info> Get_List_Nomina_X_Horas_Extras(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                List<ro_Nomina_X_Horas_Extras_Info> oListado = new List<ro_Nomina_X_Horas_Extras_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_HorasExtrasXEmpleado
                                    where a.IdEmpresa == idEmpresa
                                    && a.IdNominaTipo == idNominaTipo
                                    && a.IdNominaTipoLiqui == idNominaTipoLiqui
                                    && a.IdPeriodo == idPeriodo
                                    orderby a.Apellido ascending
                                 select a ) ;

                    foreach (var info in datos)
                    {
                        ro_Nomina_X_Horas_Extras_Info item = new ro_Nomina_X_Horas_Extras_Info();
                 
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdCalendario = info.IdCalendario;
                        item.IdTurno = info.IdTurno;
                        item.IdHorario = info.IdHorario;
                        
                        item.FechaRegistro = info.FechaRegistro;
                        item.time_entrada1 = info.time_entrada1;
                        item.time_entrada2 = info.time_entrada2;
                        item.time_salida1 = info.time_salida1;
                        item.time_salida2= info.time_salida2;
                        item.hora_extra25 = info.hora_extra25;
                        item.hora_extra50 = info.hora_extra50;
                        item.hora_extra100 = info.hora_extra100;
                        item.hora_atraso = info.hora_atraso;
                        item.hora_temprano = info.hora_temprano;
                        item.hora_trabajada = info.hora_trabajada;
                        //VISTA
                        item.NombreCompleto = info.Apellido +" "+info.Nombre;
                        item.CedulaRuc = info.CedulaRuc;
                        item.Cargo = info.cargo;
                        item.Departamento = info.departamento;
                        item.DescripcionHorario = info.DescripcionHorario;
                       
                        item.es_HorasExtrasAutorizadas = info.es_HorasExtrasAutorizadas;


//                        item.DiaSemana = info.FechaRegistro.DayOfWeek.ToString();
                        var culture = new System.Globalization.CultureInfo("es-ES");
                        item.DiaSemana = culture.DateTimeFormat.GetDayName(info.FechaRegistro.DayOfWeek);



                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_Nomina_X_Horas_Extras_Info Get_Info_Nomina_X_Horas_Extras(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                ro_Nomina_X_Horas_Extras_Info item = new ro_Nomina_X_Horas_Extras_Info();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Nomina_X_Horas_Extras_Totales
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado==idEmpleado
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdNominaTipoLiqui == idNominaTipoLiqui
                                 && a.IdPeriodo == idPeriodo
                                 
                                 select a);

                    foreach (var info in datos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;

                        item.hora_extra25 = Convert.ToDouble(info.hora_extra25);
                        item.hora_extra50 = Convert.ToDouble(info.hora_extra50);
                        item.hora_extra100 = Convert.ToDouble(info.hora_extra100);

                        //item.es_HorasExtrasAutorizadas = info.es_HorasExtrasAutorizadas;

                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GetExiste(ro_Nomina_X_Horas_Extras_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_nomina_x_horas_extras
                                where a.IdEmpresa == info.IdEmpresa
                                && a.IdEmpleado == info.IdEmpleado
                                && a.IdNominaTipo == info.IdNominaTipo
                                && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui
                                && a.IdPeriodo == info.IdPeriodo
                                && a.IdCalendario == info.IdCalendario
                                && a.IdTurno == info.IdTurno
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean GuardarBD(ro_Nomina_X_Horas_Extras_Info info , ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                        ro_nomina_x_horas_extras item = new ro_nomina_x_horas_extras();

                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdCalendario = info.IdCalendario;
                        item.IdTurno = Convert.ToInt32(info.IdTurno);
                        item.IdHorario = info.IdHorario;

                        item.FechaRegistro = info.FechaRegistro;
                        item.time_entrada1 = info.time_entrada1;
                        item.time_entrada2 = info.time_entrada2;
                        item.time_salida1 = info.time_salida1;
                        item.time_salida2 = info.time_salida2;
                       
                        item.hora_extra25 = info.hora_extra25;
                        item.hora_extra50 = info.hora_extra50;
                        item.hora_extra100 = info.hora_extra100;
                        item.hora_atraso = info.hora_atraso;
                        item.hora_temprano = info.hora_temprano;
                        item.hora_trabajada = info.hora_trabajada;

                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;
                        item.es_HorasExtrasAutorizadas = info.es_HorasExtrasAutorizadas;
                        db.ro_nomina_x_horas_extras.Add(item);
                        db.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean ModificarBD(ro_Nomina_X_Horas_Extras_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_nomina_x_horas_extras item = (from a in db.ro_nomina_x_horas_extras
                                                     where a.IdEmpresa == info.IdEmpresa
                                                     && a.IdEmpleado==info.IdEmpleado
                                                     && a.IdNominaTipo == info.IdNominaTipo
                                                     && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui
                                                     && a.IdPeriodo == info.IdPeriodo
                                                     && a.IdCalendario == info.IdCalendario 
                                                     && a.IdTurno==info.IdTurno
                                                     select a).FirstOrDefault();

                    item.IdHorario = info.IdHorario;
                    item.FechaRegistro = info.FechaRegistro;
                    item.time_entrada1 = info.time_entrada1;
                    item.time_entrada2 = info.time_entrada2;
                    item.time_salida1 = info.time_salida1;
                    item.time_salida2 = info.time_salida2;         
                    item.hora_extra25 = info.hora_extra25;
                    item.hora_extra50 = info.hora_extra50;
                    item.hora_extra100 = info.hora_extra100;
                    item.hora_atraso = info.hora_atraso;
                    item.hora_temprano = info.hora_temprano;
                    item.hora_trabajada = info.hora_trabajada;

                    item.FechaModifica = info.FechaModifica;
                    item.UsuarioModifica = info.UsuarioModifica;

                    item.es_HorasExtrasAutorizadas = info.es_HorasExtrasAutorizadas;

                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_nomina_x_horas_extras where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNomina_Tipo=" + idNomina.ToString()
                       + " AND IdNomina_TipoLiqui=" + idNominaLiqui.ToString()
                       + " AND IdPeriodo=" + idPeriodo.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       );
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
