/*CLASE: ro_historico_vacaciones_x_empleado_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 07-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_historico_vacaciones_x_empleado_Data
    {
        string mensaje = "";
        public List<ro_historico_vacaciones_x_empleado_Info> ConsultarHistoricoVaca(Decimal IdEmpleado, int IdEmpresa)
        {
                List<ro_historico_vacaciones_x_empleado_Info> lst = new List<ro_historico_vacaciones_x_empleado_Info>();
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var consultar = from q in rol.ro_historico_vacaciones_x_empleado
                                    where q.IdEmpleado == IdEmpleado &&
                                    q.IdEmpresa ==  IdEmpresa
                                    orderby q.FechaIni ascending
                                    select q;
                    foreach (var item in consultar)
                    {
                        ro_historico_vacaciones_x_empleado_Info info = new ro_historico_vacaciones_x_empleado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdHis_Vacaciones = item.IdHis_Vacaciones;
                        info.Secuencia = item.Secuencia;
                        info.FechaInicio = Convert.ToDateTime(item.FechaIni);
                        info.FechaFin = Convert.ToDateTime(item.FechaFin);
                        info.DiasGanados = Convert.ToInt32(item.DiasGanado);
                        info.DiasTomados = Convert.ToInt32(item.DiasTomados);
                        info.DiasPendientes = Convert.ToInt32(item.DiasGanado - item.DiasTomados);
                        info.check = (info.DiasTomados > 0) ? true : false;

                        lst.Add(info);
                    }
                }


                //lst = (from a in lst
                //            orderby a.FechaInicio ascending
                //            select a).ToList();

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ExisteHistoricoVaca(Decimal IdEmpleado, int IdEmpresa)
        {
            Boolean retorna = false;
            try
            {                 
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var existe = from q in rol.ro_historico_vacaciones_x_empleado
                                 where q.IdEmpleado == IdEmpleado &&
                                 q.IdEmpresa == IdEmpresa
                                 select q;
                    foreach (var item in existe)
                    {
                        if (item.IdEmpleado > 0)
                        {
                            retorna = true;
                            break;
                        } 
                    }
                    return retorna;                                       
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabaHistoricoVaca(List<ro_historico_vacaciones_x_empleado_Info> info) {
            try
            {
                EliminarHistoricoVaca(info);
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    foreach (var item in info)
                    {
                        ro_historico_vacaciones_x_empleado data = new ro_historico_vacaciones_x_empleado();
                        data.IdEmpresa = item.IdEmpresa;
                        data.IdEmpleado = item.IdEmpleado;
                        data.IdHis_Vacaciones = item.IdHis_Vacaciones;
                        data.Secuencia = item.Secuencia;
                        data.FechaIni = item.FechaInicio;
                        data.FechaFin = item.FechaFin;
                        data.DiasGanado = item.DiasGanados;
                        data.DiasTomados = item.DiasTomados;
                        rol.ro_historico_vacaciones_x_empleado.Add(data);
                        rol.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarHistoricoVaca(List<ro_historico_vacaciones_x_empleado_Info> info)
        {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    foreach (var item in info)
                    {
                        ro_historico_vacaciones_x_empleado elim = rol.ro_historico_vacaciones_x_empleado.First(v => v.IdEmpleado == item.IdEmpleado && v.IdEmpresa == item.IdEmpresa);
                        rol.ro_historico_vacaciones_x_empleado.Remove(elim);
                        rol.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public int getId(int idEmpresa, decimal idEmpleado)
        {
            int Id = 0;
            try
            {

                EntitiesRoles db = new EntitiesRoles();
                var selecte = db.ro_historico_vacaciones_x_empleado.Count(a => a.IdEmpresa == idEmpresa && a.IdEmpleado==idEmpleado);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_historico_vacaciones_x_empleado
                                     where q.IdEmpresa == idEmpresa && q.IdEmpleado==idEmpleado
                                     select q.IdHis_Vacaciones).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }






        public Boolean GetExiste(ro_historico_vacaciones_x_empleado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_historico_vacaciones_x_empleado
                                where a.IdEmpresa == info.IdEmpresa && a.IdEmpleado==info.IdEmpleado
                                && a.IdHis_Vacaciones== info.IdHis_Vacaciones
                                && a.Secuencia==info.Secuencia
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public Boolean GrabarBD(ro_historico_vacaciones_x_empleado_Info info,ref int id, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {                
                        ro_historico_vacaciones_x_empleado data = new ro_historico_vacaciones_x_empleado();
                        data.IdEmpresa = info.IdEmpresa;
                        data.IdEmpleado = info.IdEmpleado;
                        data.IdHis_Vacaciones = id = getId(info.IdEmpresa, info.IdEmpleado);
                        data.Secuencia = id;
                        data.FechaIni = info.FechaInicio;
                        data.FechaFin = info.FechaFin;
                        data.DiasGanado = info.DiasGanados;
                        data.DiasTomados = info.DiasTomados;
                        db.ro_historico_vacaciones_x_empleado.Add(data);
                        db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarBD(ro_historico_vacaciones_x_empleado_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var data = db.ro_historico_vacaciones_x_empleado.First(a => a.IdEmpresa == info.IdEmpresa && a.IdEmpleado == info.IdEmpleado
                               && a.IdHis_Vacaciones==info.IdHis_Vacaciones && a.Secuencia==info.Secuencia);
                    data.FechaIni = info.FechaInicio;
                    data.FechaFin = info.FechaFin;
                    data.DiasGanado = info.DiasGanados;
                    data.DiasTomados = info.DiasTomados;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        // modificar los dias tomados por permiso

        public Boolean ModificarBD(int IdEmpresa, decimal idEmpleado, int dias_Tomados)
        {
            try
            {
                int Dias_Diferencia = 0;
                int Dias_ganado = 0;

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var consultar = from q in db.ro_historico_vacaciones_x_empleado
                                    where q.IdEmpleado == idEmpleado &&
                                    q.IdEmpresa ==  IdEmpresa
                                    && q.DiasTomados<15

                                    orderby q.FechaIni ascending
                                    select q;

                    if (consultar.Count() > 0)
                    {
                        if(dias_Tomados>0)
                        {
                            using (EntitiesRoles db_ = new EntitiesRoles())
                            {
                                foreach (var item in consultar)
                               {

                                   if (dias_Tomados > 0)
                                   {

                                       var data = db_.ro_historico_vacaciones_x_empleado.First(a => a.IdEmpresa == item.IdEmpresa && a.IdEmpleado == item.IdEmpleado
                                              && a.IdHis_Vacaciones == item.IdHis_Vacaciones && a.Secuencia == item.Secuencia);
                                       Dias_Diferencia = Convert.ToInt32(item.DiasGanado - item.DiasTomados);
                                       if (Dias_Diferencia >= dias_Tomados)
                                       {
                                           data.DiasGanado = item.DiasGanado;
                                           data.DiasTomados = item.DiasTomados + dias_Tomados;
                                           dias_Tomados = dias_Tomados - Dias_Diferencia;
                                           db_.SaveChanges();
                                           break;
                                       }
                                       else
                                       {

                                           data.DiasTomados = item.DiasTomados + Dias_Diferencia;
                                           dias_Tomados = dias_Tomados - Dias_Diferencia;
                                           db_.SaveChanges();

                                           // break;
                                       }

                                   }
                            }
                                
                            }
                        }
                        
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
  
    }
}
