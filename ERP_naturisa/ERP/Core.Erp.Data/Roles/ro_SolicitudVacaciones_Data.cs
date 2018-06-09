
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
    public class ro_SolicitudVacaciones_Data
    {
        string mensaje = "";

        public List<ro_SolicitudVacaciones_Info> Get_List_SolicitudVacaciones(int IdEmpresa, DateTime Fecha_Inicio,DateTime Fecha_Fin)
        {
             List<ro_SolicitudVacaciones_Info> Lst = new List<ro_SolicitudVacaciones_Info>();
            try
            {
                DateTime fi = Convert.ToDateTime(Fecha_Inicio.ToShortDateString());
                DateTime ff = Convert.ToDateTime(Fecha_Fin.ToShortDateString());

                using (EntitiesRoles Rol = new EntitiesRoles())
                {
                    var Consulta = from q in Rol.vwRo_Solicitud_Vacaciones
                                   where q.IdEmpresa == IdEmpresa
                                   && q.Fecha>=fi
                                   && q.Fecha<=ff
                                   select q;

                    foreach (var item in Consulta)
                    {
                        ro_SolicitudVacaciones_Info Info = new ro_SolicitudVacaciones_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdNomina_Tipo = item.IdNomina_Tipo;
                        Info.IdSolicitudVaca = item.IdSolicitudVaca;
                        Info.Fecha = Convert.ToDateTime(item.Fecha);
                        Info.IdEmpleado = Convert.ToInt32(item.IdEmpleado);
                        Info.AnioServicio = item.AnioServicio;
                        Info.Dias_q_Corresponde = item.Dias_q_Corresponde;
                        Info.Dias_a_disfrutar = item.Dias_a_disfrutar;
                        Info.Dias_pendiente = item.Dias_pendiente;
                        Info.Anio_Desde = item.Anio_Desde;
                        Info.Anio_Hasta = item.Anio_Hasta;
                        Info.Fecha_Desde = Convert.ToDateTime(item.Fecha_Desde);
                        Info.Fecha_Hasta = Convert.ToDateTime(item.Fecha_Hasta);
                        Info.Fecha_Retorno = Convert.ToDateTime(item.Fecha_Retorno);
                        Info.Observacion = item.Observacion;
                        Info.IdUsuario = item.IdUsuario;
                        Info.IdUsuario_Anu = item.IdUsuario_Anu;
                        Info.FechaAnulacion = Convert.ToDateTime(item.FechaAnulacion);
                        Info.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                        Info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod);
                        Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        Info.Estado = item.Estado;
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.ip = item.ip;
                        Info.nom_pc = item.nom_pc;
                        Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        Info.IdEmpleado_aprue = item.IdEmpleado_aprue;
                        Info.IdEmpleado_remp = item.IdEmpleado_remp;
                        Info.Gozadas_Pgadas = item.Gozadas_Pgadas;
                        Lst.Add(Info);
                    }
                    return Lst;
                }
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


        public Boolean  GetExiste(ro_SolicitudVacaciones_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_Solicitud_Vacaciones_x_empleado
                                where a.IdEmpresa == info.IdEmpresa && a.IdSolicitudVaca == info.IdSolicitudVaca
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

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {

                EntitiesRoles db = new EntitiesRoles();
                var selecte = db.ro_Solicitud_Vacaciones_x_empleado.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_Solicitud_Vacaciones_x_empleado
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdSolicitudVaca).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
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


        public Boolean GrabarBD(ro_SolicitudVacaciones_Info info,ref int id ,ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_Solicitud_Vacaciones_x_empleado data = new ro_Solicitud_Vacaciones_x_empleado();
                    data.IdEmpresa = info.IdEmpresa;
                    data.IdNomina_Tipo = info.IdNomina_Tipo;
                    data.IdSolicitudVaca = id = getId(info.IdEmpresa);
                    data.Fecha = info.Fecha;
                    data.IdEmpleado = Convert.ToInt32(info.IdEmpleado);
                    data.AnioServicio = info.AnioServicio;
                    data.Dias_q_Corresponde = info.Dias_q_Corresponde;
                    data.Dias_a_disfrutar = info.Dias_a_disfrutar;
                    data.Dias_pendiente = info.Dias_pendiente;
                    data.Anio_Desde = info.Anio_Desde;
                    data.Anio_Hasta = info.Anio_Hasta;
                    data.Fecha_Desde = Convert.ToDateTime(info.Fecha_Desde);
                    data.Fecha_Hasta = Convert.ToDateTime(info.Fecha_Hasta);
                    data.Fecha_Retorno = Convert.ToDateTime(info.Fecha_Retorno);
                    data.Observacion = info.Observacion;
                    data.IdUsuario = info.IdUsuario;
                    data.IdUsuario_Anu = info.IdUsuario_Anu;
                    data.FechaAnulacion = info.FechaAnulacion;
                    data.Fecha_Transac = info.Fecha_Transac;
                    data.Fecha_UltMod = info.Fecha_UltMod;
                    data.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    data.Estado = info.Estado;
                    data.MotivoAnulacion = info.MotivoAnulacion;
                    data.ip = info.ip;
                    data.nom_pc = info.nom_pc;
                    data.IdEstadoAprobacion = info.IdEstadoAprobacion;
                    data.IdEmpleado_aprue = info.IdEmpleado_aprue;
                    data.IdEmpleado_remp = info.IdEmpleado_remp;
                    data.Gozadas_Pgadas = info.Gozadas_Pgadas;
                    db.ro_Solicitud_Vacaciones_x_empleado.Add(data);
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


        public Boolean ModificarBD(ro_SolicitudVacaciones_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var data = db.ro_Solicitud_Vacaciones_x_empleado.First(v=>v.IdEmpresa==info.IdEmpresa && v.IdSolicitudVaca==info.IdSolicitudVaca);

                    data.Fecha = info.Fecha;
                    data.AnioServicio = info.AnioServicio;
                    data.Dias_q_Corresponde = info.Dias_q_Corresponde;
                    data.Dias_a_disfrutar = info.Dias_a_disfrutar;
                    data.Dias_pendiente = info.Dias_pendiente;
                    data.Anio_Desde = info.Anio_Desde;
                    data.Anio_Hasta = info.Anio_Hasta;
                    data.Fecha_Desde = Convert.ToDateTime(info.Fecha_Desde);
                    data.Fecha_Hasta = Convert.ToDateTime(info.Fecha_Hasta);
                    data.Fecha_Retorno = Convert.ToDateTime(info.Fecha_Retorno);
                    data.Observacion = info.Observacion;
                    data.IdUsuarioUltMod = info.IdUsuario;
                    data.FechaAnulacion = info.FechaAnulacion;
                    data.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    data.Estado = info.Estado;
                    data.IdEstadoAprobacion = info.IdEstadoAprobacion;
                    data.IdEmpleado_remp = info.IdEmpleado_remp;
                    data.Gozadas_Pgadas = info.Gozadas_Pgadas;

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

        public Boolean EliminarPermisoVacaciones(ro_SolicitudVacaciones_Info info)
        {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    ro_Solicitud_Vacaciones_x_empleado data = rol.ro_Solicitud_Vacaciones_x_empleado.First(v => v.IdSolicitudVaca == info.IdSolicitudVaca);
                    rol.ro_Solicitud_Vacaciones_x_empleado.Remove(data);
                    rol.SaveChanges();
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

        public int MaxPermisoVacaciones(int IdEmpresa)
        {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var numero = Convert.ToInt32((from q in rol.ro_Solicitud_Vacaciones_x_empleado
                                                  where q.IdEmpresa == IdEmpresa
                                                  select q.IdSolicitudVaca).Max());
                    return numero;
                }
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

        public int CalculoDiasTrabajos(int IdEmpresa,DateTime FI,DateTime FF,Decimal IdEmpleado) {
            try
            {
                using (EntitiesRoles base_ = new EntitiesRoles())
                {
                    var Calculo = from q in base_.spRo_Calculo_Dias_Trabajados(IdEmpresa, FI, FF, IdEmpleado, IdEmpleado)
                                   select new ro_historico_vacaciones_x_empleado_Info
                                   {
                                       DiasTomados = Convert.ToInt32(q.Dias_Vaciones)
                                   };
                    int Valor=0;
                    foreach (var item in Calculo)
                    {
                         Valor = item.DiasTomados;
                    }

                    return Valor;
                }
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

        public List<ro_historico_vacaciones_x_empleado_Info> CalculoDiasTrabajosDetalle(int IdEmpresa, DateTime FI, DateTime FF, Decimal IdEmpleado)
        {
            List<ro_historico_vacaciones_x_empleado_Info> lst = new List<ro_historico_vacaciones_x_empleado_Info>();
            try
            {
               
                using (EntitiesRoles base_ = new EntitiesRoles())
                {
                    var Calculo = from q in base_.spRo_Calculo_Dias_Trabajados_detalle(IdEmpresa, FI, FF, IdEmpleado, IdEmpleado)
                                  select q;                   
                    foreach (var item in Calculo)
                    {
                        ro_historico_vacaciones_x_empleado_Info info = new ro_historico_vacaciones_x_empleado_Info();
                        info.DiasTomados = Convert.ToInt32(item.Dias_a_disfrutar);
                        info.FechaInicio = Convert.ToDateTime(item.fecha_desde);
                        info.FechaFin = Convert.ToDateTime(item.fecha_Hasta);
                        info.Observacion = item.observacion;
                        info.FechaRetorno = Convert.ToDateTime(item.fecha_retorno);
                        lst.Add(info);
                    }

                    return lst;
                }
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
        
        public int ExisteSolicitud(int IdEmpresa, decimal IdEmpleado, DateTime FI, DateTime FF, string Estado, string Idestado)
        {
            try
            {
                using (EntitiesRoles Rol = new EntitiesRoles())
                {
                    var Consulta = from q in Rol.ro_Solicitud_Vacaciones_x_empleado
                                   where q.IdEmpresa == IdEmpresa &&
                                         q.IdEmpleado == IdEmpleado &&
                                         FI >= q.Fecha_Desde &&
                                         FI <= q.Fecha_Hasta &&
                                         //q.Fecha_Hasta >= FI &&
                                         //q.Fecha_Hasta <= FF &&
                                         q.Estado == Estado &&
                                         q.IdEstadoAprobacion == Idestado
                                   select q;
                    int termina = 0;
                    foreach (var item in Consulta)
                    {
                        if (item.IdSolicitudVaca != 0)
                        {
                            termina = 1;
                            break;
                        }
                    }
                    return termina;
                }
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

        public Boolean getExisteFecha(int idEmpresa, decimal idEmpleado, DateTime fecha)
        {
            try
            {
                Boolean valorRetornar = false;

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var cont = (from q in db.ro_Solicitud_Vacaciones_x_empleado
                                where q.IdEmpresa == idEmpresa && q.IdEmpleado == idEmpleado && q.Estado=="A"
                                //&& (new[] { "Pendiente, Aprobado" }.Contains(q.IdEstadoAprobacion.Trim()))
                                && ((fecha >= q.Fecha_Desde) && (fecha <= q.Fecha_Hasta))
                                select q).Count();
                  
                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }

                    return valorRetornar;
                }
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


        public int Get_Dias_Vacaciones(int idempresa, int IdNomina_Tipo, int idempleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                ro_SolicitudVacaciones_Info Info = new ro_SolicitudVacaciones_Info();
                using (EntitiesRoles Rol = new EntitiesRoles())
                {
                    var Consulta = from q in Rol.vwro_Solicitud_Vacaciones_x_empleado
                                   where q.IdEmpresa == idempresa
                                   && q.IdNomina_Tipo==IdNomina_Tipo
                                   && q.IdEmpleado==idempleado
                                  
                                   &&(
                                       (q.Fecha_Desde >= fechaIni && q.Fecha_Hasta <= fechaFin) 
                                       || (q.Fecha_Hasta >= fechaIni && q.Fecha_Hasta <= fechaFin)
                                       || (q.Fecha_Desde <= fechaFin && q.Fecha_Hasta >= fechaFin
                                       )
                                     )

                                   select q;

                    if (Consulta.Count()==0)
                        return 0;
                    else
                        return Consulta.Sum(v=>v.Dias_a_disfrutar);
                }
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
