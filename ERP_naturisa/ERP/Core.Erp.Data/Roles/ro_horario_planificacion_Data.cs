
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_horario_planificacion_Data
    {
        string mensaje = "";
        ro_Parametros_Info RolesParam = new ro_Parametros_Info();
        ro_Parametros_Data busParam = new ro_Parametros_Data();


        public List<ro_horario_planificacion_Grid_Info> Get_List_horario_planificacion_Grid(DateTime FechaIni, DateTime FechaFin, List<ro_horario_planificacion_Grid_Info> ListadoEmpleados)
        {
            List<ro_horario_planificacion_Grid_Info> Listtempo = new List<ro_horario_planificacion_Grid_Info>();
           
            List<ro_horario_planificacion_Grid_Info> resultado = new List<ro_horario_planificacion_Grid_Info>();
            try
            {
                int dias = 0;
                var x = FechaFin - FechaIni;
                dias = x.Days;
                EntitiesRoles oEnt = new EntitiesRoles();
               
//                RolesParam = busParam.ConsultaParametrosRoles(ListadoEmpleados[0].IdEmpresa).First(var => var.IdEmpresa == ListadoEmpleados[0].IdEmpresa);
                RolesParam = busParam.Get_List_Parametros(ListadoEmpleados[0].IdEmpresa).FirstOrDefault();
                
                List<VwRo_Planificaion_Horarios_x_Empleado_Info> listHorariosxEmple = new List<VwRo_Planificaion_Horarios_x_Empleado_Info>();
                //List<VwRo_Planificaion_Horarios_x_Empleado_Info> listHorariosxEmple_ItemEmpleado = new List<VwRo_Planificaion_Horarios_x_Empleado_Info>();


                IQueryable<VwRo_Planificaion_Horarios_x_Empleado_Info> Consulta =
                                                        from C in oEnt.vwRo_Planificacion_Horarios_x_Empleado
                                                        where
                                                           C.fecha <= FechaFin
                                                        && C.fecha >= FechaIni
                                                        && C.Estado == "A"
                                                        select new VwRo_Planificaion_Horarios_x_Empleado_Info 
                                                        { 
                                                            Descripcion=C.Descripcion
                                                            ,Estado=C.Estado
                                                            ,fecha=C.fecha
                                                            ,IdEmpleado=C.IdEmpleado
                                                            ,IdEmpresa=C.IdEmpresa
                                                            ,IdRegistro=C.IdRegistro
                                                            ,IdSucursal=C.IdSucursal
                                                            ,IdHorario=C.IdHorario
                                                            ,Inicial_del_Dia=C.Inicial_del_Dia
                                                            ,NombreCortoFecha=C.NombreCortoFecha
                                                            ,pe_nombreCompleto=C.pe_nombreCompleto
                                                            ,Su_Descripcion=C.Su_Descripcion
                                                            ,ca_descripcion = C.ca_descripcion
                                                            ,Departamento = C.Departamento
                                                            ,IdCalendario = C.IdCalendario  
        
                                                        };

                listHorariosxEmple = Consulta.ToList();       
                

                foreach (var empl in ListadoEmpleados)
                {
                    ro_horario_planificacion_Grid_Info Info = new ro_horario_planificacion_Grid_Info();
                    Info.IdEmpleado = empl.IdEmpleado;
                    Info.IdEmpresa = empl.IdEmpresa;
                    Info.NomCompleto = empl.NomCompleto;
                    Info.ca_descripcion = empl.ca_descripcion;
                    Info.Departamento = empl.Departamento;
                    Info.Sucursal = empl.Sucursal;
                    Info.IdCalendario = empl.IdCalendario;


                    List<VwRo_Planificaion_Horarios_x_Empleado_Info> listHorariosxEmple_ItemEmpleado =
                                                      listHorariosxEmple.FindAll(C => C.IdEmpleado == empl.IdEmpleado);

                    var turnosdobles = from C in listHorariosxEmple_ItemEmpleado
                                       group C by new { C.fecha }
                                       into grupo
                                       select new { grupo.Key };
                  
                    foreach (var item in turnosdobles)
                    {
                        ro_horario_planificacion_Grid_Info.turnos turn = new ro_horario_planificacion_Grid_Info.turnos(); int sec = 0;
                        foreach (var item2 in listHorariosxEmple_ItemEmpleado)
                        {
                            if (item2.fecha == item.Key.fecha)
                            {
                                turn.fecha = item2.fecha;
                                turn.turno[sec] = Convert.ToInt32 (item2.IdHorario);
                                turn.count = ++sec;
                                                            
                            }
                        }
                        empl.Listado.Add(turn);                       
                    }
                    try
                    {                    
                        if (listHorariosxEmple_ItemEmpleado.Count > 0)
                        {
                            for (int i = 0; i < dias + 1; i++)
                            {

                                DateTime dia;
                                dia = FechaIni.AddDays(i);                  


                                foreach (var reg in listHorariosxEmple_ItemEmpleado)
                                {
                                    if (reg.fecha == dia)
                                    {
                                        Info = new ro_horario_planificacion_Grid_Info();
                                        Info.IdEmpleado = empl.IdEmpleado;
                                        Info.IdEmpresa = empl.IdEmpresa;
                                        Info.NomCompleto = empl.NomCompleto;
                                        Info.Sucursal = empl.Sucursal;
                                        Info.ca_descripcion = empl.ca_descripcion;
                                        Info.Departamento = empl.Departamento;
                                        Info.IdCalendario = empl.IdCalendario;

                                        Info.IdHorarioDia[i] = Convert.ToInt32(reg.IdHorario);

                                        {
                                            ro_horario_planificacion_Grid_Info tempo = new ro_horario_planificacion_Grid_Info();
                                            try
                                            {
                                                tempo = resultado.First(var => var.IdEmpleado == empl.IdEmpleado && var.IdHorarioDia[i] == 0);
                                                if (tempo != null)
                                                {
                                                    resultado.Remove(tempo);
                                                    Info = tempo;
                                                    Info.IdHorarioDia[i] = Convert.ToInt32(reg.IdHorario);
                                                    Info = Get_Info_horario_planificacion_Grid(Info.IdHorarioDia, Info);
                                                    resultado.Add(Info);

                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                string arreglo = ToString();
                                                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                                mensaje = ex.InnerException + " " + ex.Message;
                                                Info = Get_Info_horario_planificacion_Grid(Info.IdHorarioDia, Info);
                                                resultado.Add(Info);
                                                
                                            }
                                        
                                        }
                                       
                                    }
                                }
                                                              
                            }
                                                       
                        }
                        else
                        {
                            for (int i = 0; i < dias + 1; i++)
                            {
                                Info.IdHorarioDia[i] = 0;
                            }
                            Info = Get_Info_horario_planificacion_Grid(Info.IdHorarioDia, Info);
                            resultado.Add(Info);       
                 
                          
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;                     
                    }                   
                }

                ro_Empleado_X_Horario_Data oRo_Empleado_X_Horario_Data = new Roles.ro_Empleado_X_Horario_Data();
              

                foreach (var item in resultado)
                {

                    var reg = Getarray(item.IdHorarioDia, item);
                   
                    for (int i = 0; i < 32; i++)
                    {
                        if (reg.IdHorarioDia[i] == 0)
                            reg.IdHorarioDia[i] = 1;
                    }

                    reg = Get_Info_horario_planificacion_Grid(reg.IdHorarioDia, reg);

                    ro_Empleado_X_Horario_Info info = new ro_Empleado_X_Horario_Info();
                    info = oRo_Empleado_X_Horario_Data.Get_Info_Empleado_X_Horario_Preterminado(item.IdEmpresa, item.IdEmpleado);
                    reg.IdHorario = info.IdHorario; 

                    Listtempo.Add(reg);
                }
                return Listtempo;
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





        
        public decimal getIDRegistro(int idempresa, decimal idempleado, int idcalendario)
        {
            decimal id = 0;
            try
            {
                EntitiesRoles OeRoles = new EntitiesRoles();
                var select = from q in OeRoles.ro_horario_planificacion
                             where q.IdEmpresa == idempresa && q.IdEmpleado == idempleado && q.IdCalendario == idcalendario
                             select q;

                if (select.ToList().Count < 1)
                {
                    id = 1;
                }
                else
                {
                    var select_pv = (from q in OeRoles.ro_horario_planificacion
                                     where q.IdEmpresa == idempresa && q.IdEmpleado == idempleado && q.IdCalendario == idcalendario
                                     select q.IdRegistro).Max();
                    id = Convert.ToDecimal(select_pv.ToString()) + 1;
                }
                return id;
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

        public Boolean grabaritem(ro_horario_planificacion_Info Info)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var contact = new  ro_horario_planificacion();
                    contact.IdEmpleado  = Info.IdEmpleado;
                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdRegistro = Info.IdRegistro;
                    contact.IdHorario = Info.IdHorario;
                    contact.IdCalendario = Info.IdCalendario;
                    contact.Estado = "A";
                    contact.Observacion = Info.Observacion;
                    Context.ro_horario_planificacion.Add(contact);
                    Context.SaveChanges();
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

        public Boolean activaritem(ro_horario_planificacion Info)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var contact = Context.ro_horario_planificacion.First(
                        Hor => Hor.IdHorario == Info.IdHorario && Hor.IdEmpresa == Info.IdEmpresa
                        && Hor.IdEmpleado == Info.IdEmpleado && Hor.IdCalendario == Info.IdCalendario );
                    
                    contact.Estado  = "A";
                   
                    Context.SaveChanges();
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

        public Boolean eliminaritem(int IdEmpresa, int IdCalendario, decimal IdEmpleado)
        {
            Boolean retornar = false;
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    string query = "delete from ro_horario_planificacion where IdEmpresa = " + IdEmpresa +
                    " and IdEmpleado = " + IdEmpleado + " and IdCalendario = " + IdCalendario;

                    Context.Database.ExecuteSqlCommand(query);

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

        public List<ro_horario_planificacion_Info> ObtenerHorarioxEmplXFEcha(int IdEmpresa, int IdCalendario, decimal IdEmpleado)
        {
            List<ro_horario_planificacion_Info> Lista = new List<ro_horario_planificacion_Info>();
               
            try
            {
               EntitiesRoles oeEnt = new EntitiesRoles();
                var registros = from A in oeEnt.ro_horario_planificacion
                                where A.IdEmpresa == IdEmpresa && A.IdCalendario == IdCalendario 
                                && A.IdEmpleado == IdEmpleado 
                                select A;
                if (registros.ToList().Count > 0)
                {

                    foreach (var item in registros)
                    {
                        ro_horario_planificacion_Info info = new ro_horario_planificacion_Info();
                        info.IdCalendario = item.IdCalendario;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRegistro = item.IdRegistro;
                        Lista.Add(info);
                    }
                    return Lista;
                }
                else
                    return new List<ro_horario_planificacion_Info>();
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

        public Boolean existeitem(int IdEmpresa, int IdCalendario, decimal IdEmpleado, decimal IdHorario)
        {
             Boolean retornar = false;
            try
            {
                EntitiesRoles oeEnt = new EntitiesRoles();
                var registros = from A in oeEnt.ro_horario_planificacion
                                where A.IdEmpresa == IdEmpresa && A.IdCalendario == IdCalendario
                                && A.IdEmpleado == IdEmpleado && A.IdHorario == IdHorario 
                                select A;
                if (registros.ToList().Count > 0)
                {
                    retornar = true;
                   
                }
                return retornar;                 
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


        public Boolean GrabarDB(decimal IdHorarioLibre, DateTime FechaIni, DateTime FechaFin, List<ro_horario_planificacion_Grid_Info> ListadoHorarios)
        {
            Boolean retornar = false;
            try
            {
                int dias = 0;
                var x = FechaFin - FechaIni;
                dias = x.Days;

                foreach (var item in ListadoHorarios)
                {
                        for (int i = 0; i <= dias; i++)
                        {
                        DateTime fecha; int fechadia = 0; string fechaS = "010113";
                        fecha = Convert.ToDateTime(FechaIni.AddDays(i).ToShortDateString());
                        fechaS = Convert.ToString(fecha.Year) + ((fecha.Month>9) ?Convert.ToString(fecha.Month):"0"+Convert.ToString(fecha.Month) )+ ((fecha.Day > 9) ? Convert.ToString(fecha.Day) : "0" + Convert.ToString(fecha.Day));
                        fechadia = Convert.ToInt32(fechaS);
                        item.IdCalendario = fechadia;

                        eliminaritem(item.IdEmpresa, item.IdCalendario, item.IdEmpleado);
                    }
                }


                foreach (var item in ListadoHorarios)
                {
                        for (int i = 0; i <= dias; i++)
                        {
                        ro_horario_planificacion_Info Info = new ro_horario_planificacion_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdEmpleado = item.IdEmpleado;
                        Info.Estado = "A";

                        DateTime fecha; int fechadia = 0; string fechaS = "010113";
                        fecha = Convert.ToDateTime(FechaIni.AddDays(i).ToShortDateString());
                        fechaS = Convert.ToString(fecha.Year) + ((fecha.Month > 9) ? Convert.ToString(fecha.Month) : "0" + Convert.ToString(fecha.Month)) + ((fecha.Day > 9) ? Convert.ToString(fecha.Day) : "0" + Convert.ToString(fecha.Day));
                        fechadia = Convert.ToInt32(fechaS);
                        Info.IdCalendario = fechadia;
                        Info.IdHorario = item.IdHorarioDia[i];
                        Info.IdRegistro = getIDRegistro(item.IdEmpresa, item.IdEmpleado, fechadia);
                        Info.Observacion = item.Observacion;
                        if (grabaritem(Info) == false) return retornar;

                    }
                } retornar = true;
                return retornar;
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


        public ro_horario_planificacion_Grid_Info Get_Info_horario_planificacion_Grid(decimal[] arreglo, ro_horario_planificacion_Grid_Info info)
        { 
            try
            {
                info.IdHorarioDia0 = Convert.ToInt32(arreglo[0]);
                info.IdHorarioDia1 = Convert.ToInt32(arreglo[1]);
                info.IdHorarioDia2 = Convert.ToInt32(arreglo[2]);
                info.IdHorarioDia3 = Convert.ToInt32(arreglo[3]);
                info.IdHorarioDia4 = Convert.ToInt32(arreglo[4]);
                info.IdHorarioDia5 = Convert.ToInt32(arreglo[5]);
                info.IdHorarioDia6 = Convert.ToInt32(arreglo[6]);
                info.IdHorarioDia7 = Convert.ToInt32(arreglo[7]);
                info.IdHorarioDia8 = Convert.ToInt32(arreglo[8]);
                info.IdHorarioDia9 = Convert.ToInt32(arreglo[9]);
                info.IdHorarioDia10 = Convert.ToInt32(arreglo[10]);
                info.IdHorarioDia11 = Convert.ToInt32(arreglo[11]);
                info.IdHorarioDia12 = Convert.ToInt32(arreglo[12]);
                info.IdHorarioDia13 = Convert.ToInt32(arreglo[13]);
                info.IdHorarioDia14 = Convert.ToInt32(arreglo[14]);
                info.IdHorarioDia15 = Convert.ToInt32(arreglo[15]);
                info.IdHorarioDia16 = Convert.ToInt32(arreglo[16]);
                info.IdHorarioDia17 = Convert.ToInt32(arreglo[17]);
                info.IdHorarioDia18 = Convert.ToInt32(arreglo[18]);
                info.IdHorarioDia19 = Convert.ToInt32(arreglo[19]);
                info.IdHorarioDia20 = Convert.ToInt32(arreglo[20]);
                info.IdHorarioDia21 = Convert.ToInt32(arreglo[21]);
                info.IdHorarioDia22 = Convert.ToInt32(arreglo[22]);
                info.IdHorarioDia23 = Convert.ToInt32(arreglo[23]);
                info.IdHorarioDia24 = Convert.ToInt32(arreglo[24]);
                info.IdHorarioDia25 = Convert.ToInt32(arreglo[25]);
                info.IdHorarioDia26 = Convert.ToInt32(arreglo[26]);
                info.IdHorarioDia27 = Convert.ToInt32(arreglo[27]);
                info.IdHorarioDia28 = Convert.ToInt32(arreglo[28]);
                info.IdHorarioDia29 = Convert.ToInt32(arreglo[29]);
                info.IdHorarioDia30 = Convert.ToInt32(arreglo[30]);
                info.IdHorarioDia31 = Convert.ToInt32(arreglo[31]);
                return info;
            }
            catch (Exception ex)
            {
                string Arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", Arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_horario_planificacion_Grid_Info Getarray(decimal[] arreglo, ro_horario_planificacion_Grid_Info info)
        {


            try
            {
                arreglo[0] = info.IdHorarioDia0;
                arreglo[1] = info.IdHorarioDia1;
                arreglo[2] = info.IdHorarioDia2;
                arreglo[3] = info.IdHorarioDia3;
                arreglo[4] = info.IdHorarioDia4;
                arreglo[5] = info.IdHorarioDia5;
                arreglo[6] = info.IdHorarioDia6;
                arreglo[7] = info.IdHorarioDia7;
                arreglo[8] = info.IdHorarioDia8;
                arreglo[9] = info.IdHorarioDia9;
                arreglo[10] = info.IdHorarioDia10;
                arreglo[11] = info.IdHorarioDia11;
                arreglo[12] = info.IdHorarioDia12;
                arreglo[13] = info.IdHorarioDia13;
                arreglo[14] = info.IdHorarioDia14;
                arreglo[15] = info.IdHorarioDia15;
                arreglo[16] = info.IdHorarioDia16;
                arreglo[17] = info.IdHorarioDia17;
                arreglo[18] = info.IdHorarioDia18;
                arreglo[19] = info.IdHorarioDia19;
                arreglo[20] = info.IdHorarioDia20;
                arreglo[21] = info.IdHorarioDia21;
                arreglo[22] = info.IdHorarioDia22;
                arreglo[23] = info.IdHorarioDia23;
                arreglo[24] = info.IdHorarioDia24;
                arreglo[25] = info.IdHorarioDia25;
                arreglo[26] = info.IdHorarioDia26;
                arreglo[27] = info.IdHorarioDia27;
                arreglo[28] = info.IdHorarioDia28;
                arreglo[29] = info.IdHorarioDia29;
                arreglo[30] = info.IdHorarioDia30;
                arreglo[31] = info.IdHorarioDia31;
                return info;
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

        public List<ro_horario_planificacion_Grid_Info> setIdHorario(Decimal IdHorario, DateTime FechaIni, DateTime FechaFin, List<ro_horario_planificacion_Grid_Info> Listado)
        {
            List<ro_horario_planificacion_Grid_Info> result = new List<ro_horario_planificacion_Grid_Info>();
            try
            {
                int dias = 0;
                var x = FechaFin - FechaIni;
                dias = x.Days;
                foreach (var item in Listado)
                {
                    ro_horario_planificacion_Grid_Info info = new ro_horario_planificacion_Grid_Info();

                    for (int i = 0; i <= dias; i++)
                    {
                        item.IdHorarioDia[i] = IdHorario;
                    }
                    info = Get_Info_horario_planificacion_Grid(item.IdHorarioDia, item);
                    result.Add(info);
                }
                return result;
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

        public class MyClass
        {
            public int[] turno { get; set; }
            public int count { get; set; }
            public DateTime fecha { get; set; }

            public MyClass()
            {
                turno = new int[20];
            }

        }
        public Boolean prueba(MyClass clase)
        {
            try
            {
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





        public List<ro_horario_planificacion_Info> Get_List_horario_planificacion(int IdEmpresa, decimal IdEmpleado, DateTime FechaInicial, DateTime FechaFinal)
        {
            List<ro_horario_planificacion_Info> listado = new List<ro_horario_planificacion_Info>();

            //FORMATO YYYYMMDD
            DateTime fecha; int fechadia = 0; string fechaS = "010113";
            fecha = Convert.ToDateTime(FechaInicial.ToShortDateString());
            fechaS = Convert.ToString(fecha.Year) + ((fecha.Month > 9) ? Convert.ToString(fecha.Month) : "0" + Convert.ToString(fecha.Month)) + ((fecha.Day > 9) ? Convert.ToString(fecha.Day) : "0" + Convert.ToString(fecha.Day));
            fechadia = Convert.ToInt32(fechaS);

            int fechaIni = fechadia;

            fecha = Convert.ToDateTime(FechaFinal.ToShortDateString());
            fechaS = Convert.ToString(fecha.Year) + ((fecha.Month > 9) ? Convert.ToString(fecha.Month) : "0" + Convert.ToString(fecha.Month)) + ((fecha.Day > 9) ? Convert.ToString(fecha.Day) : "0" + Convert.ToString(fecha.Day));
            fechadia = Convert.ToInt32(fechaS);

            int fechaFin = fechadia;


            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = from a in db.ro_horario_planificacion
                                where a.IdEmpresa == IdEmpresa && a.IdEmpleado == IdEmpleado
                                && a.IdCalendario>=fechaIni && a.IdCalendario<=fechaFin
                                orderby a.IdCalendario ascending
                                select a;

                    foreach (var item in datos)
                    {
                        ro_horario_planificacion_Info info = new ro_horario_planificacion_Info();
                        info.IdCalendario = item.IdCalendario;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdHorario = item.IdHorario;
                        info.IdRegistro = item.IdRegistro;
                        info.Estado = item.Estado;
                        listado.Add(info);
                    }
                }

                
                return listado;
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




        public Boolean GetVerificarDobleTurno(int idEmpresa,  decimal idEmpleado, int idCalendario, ref string msg) {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_horario_planificacion
                                where a.IdEmpresa == idEmpresa  && a.IdEmpleado==idEmpleado && a.IdCalendario==idCalendario
                                select a).Count();

                    if (cont > 1) { valorRetornar = true; }
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
    }
}
