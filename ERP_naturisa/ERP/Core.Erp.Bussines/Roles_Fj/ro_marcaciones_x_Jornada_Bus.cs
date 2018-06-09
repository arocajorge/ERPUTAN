using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Roles_Fj
{
   public class ro_marcaciones_x_Jornada_Bus
   {
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       ro_Parametro_calculo_Horas_Extras_Bus bus_parametros_calculo_horas_extras = new ro_Parametro_calculo_Horas_Extras_Bus();
       ro_Parametro_calculo_Horas_Extras_Info info_parametro = new ro_Parametro_calculo_Horas_Extras_Info();
     
       TimeSpan inicioHora25 = TimeSpan.FromHours(19); //19:00 PM
       TimeSpan finalHora25 = TimeSpan.FromHours(6); //06:00 AM
       //HORAS EXTRAS 50
       TimeSpan inicioHora50 = TimeSpan.FromHours(6); //06:00 AM
       TimeSpan finalHora50 = TimeSpan.FromHours(24); //24:00 PM
       //HORAS EXTRAS 100
       TimeSpan inicioHora100 = TimeSpan.FromHours(0); //00:00 PM
       TimeSpan finalHora100 = TimeSpan.FromHours(6); //06:00 AM


       double Horas_25 = 0;
       double Horas_50 = 0;
       double Horas_100 = 0;
       decimal IdEmpleado = 0;
       DateTime fecha_pago = new DateTime();
       String Nombre = "";
       String Cedula = "";
       int horas = 0;
       int minutos = 0;
       TimeSpan es_hora;
       double Horas_tmp = 0;

       public List<ro_Nomina_X_Horas_Extras_Info> lista_nomina_x_horas_Hextras = new List<Info.Roles.ro_Nomina_X_Horas_Extras_Info>();
       public List<ro_Empleado_Novedad_Det_Info> Get_list_Horas_Extras(List<ro_marcaciones_x_Jornada_Info> lista, double Suel_Actual)
       {
           try
           {
               
               info_parametro = bus_parametros_calculo_horas_extras.Get_info(param.IdEmpresa);                         
               List<ro_Empleado_Novedad_Det_Info> lista_novedad_detalle = new List<ro_Empleado_Novedad_Det_Info>();
             
               // recorro las marcaciones y sumo las horas extras del 25%, 50%, 100%
               foreach (var item in lista)
               {

                   if (item.pe_cedula == "1310545478")
                   {
                   }

                   Horas_25 = 0; Horas_50 = 0; Horas_100 = 0; horas = 0; minutos = 0; Horas_tmp = 0;
                   es_hora = new TimeSpan();
                   IdEmpleado = item.IdEmpleado;
                   fecha_pago = Convert.ToDateTime(item.es_fechaRegistro);
                   Nombre = item.pe_NombreCompleto;
                   Cedula = item.pe_cedula;
                   int dia_Semana = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                   if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)// si tiene una sola jornada le resto la hora de almuerzo
                   {
                       if (dia_Semana == 6 || dia_Semana == 7 ||item.EsFeriado=="S")
                       {
                           if (item.es_tot_horasTrabajadas >= 9)
                           {
                               item.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas - 1;

                           }
                       }
                       else
                       {
                           item.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas - 1;
                           horas = ((TimeSpan)item.es_Hora_ingreso_jornada1).Hours;
                           minutos = ((TimeSpan)item.es_Hora_ingreso_jornada1).Minutes;
                           item.es_Hora_ingreso_jornada1 = new TimeSpan(horas, minutos, 0);
                       }
                   }
                   if (dia_Semana == 6 || dia_Semana == 7 || item.EsFeriado == "S")// sumo las horas trabajadas al 100% correspondiente al sabado y domingo
                   {
                      
                       Horas_100 =  item.es_tot_horasTrabajadas;                      
                   }
                   else
                   {
                       if (item.es_tot_horasTrabajadas > 0)// si trabajo mas de ocho horas
                       {
                           #region Horas al 100% de 00:00 a 06:00
                           if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)//si trabajo una sola jornada y tiene horas al 100% de 00:00 a 06:00
                           {
                               if (
                                   (item.es_Hora_ingreso_jornada1 > inicioHora100 && item.es_Hora_ingreso_jornada1 < finalHora100) ||
                                   (item.es_Hora_salida_jornada1 > inicioHora100 && item.es_Hora_salida_jornada1 < finalHora100) ||
                                   (item.es_Hora_ingreso_jornada1 > inicioHora100 && item.es_Hora_ingreso_jornada1 > finalHora100 && ((TimeSpan)item.es_Hora_ingreso_jornada1).Hours > 12)



                                   )
                               {
                                    Horas_100 = Get_Horas_100_x_dia(item);// calculo de horas al 100%

                               }
                           }
                           else// si tiene doble jornada 
                           {
                           }



                           #endregion
                           #region Horas al 50% de 18:00 a 24:00

                           if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)// tiene horas al 50% de 06:00h a 24:00h en una sola jornada 
                           {
                               if ((item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 < finalHora50) ||
                                  (item.es_Hora_salida_jornada1 > inicioHora50 && item.es_Hora_salida_jornada1 < finalHora50) ||
                                  (item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 > finalHora50)
                                  )
                               {
                                   Horas_50 = Get_Horas_50_x_dia(item);// calculo de horas al 50%

                               }
                           }
                           else// si tiene horas al 50% y trabajo dos jornadas
                           {
                               if (((item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 < finalHora50) ||
                                         (item.es_Hora_salida_jornada1 > inicioHora50 && item.es_Hora_salida_jornada1 < finalHora50) ||
                                         (item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 > finalHora50))
                                   ||
                                         ((item.es_Hora_ingreso_jornada2 > inicioHora50 && item.es_Hora_ingreso_jornada2 < finalHora50) ||
                                         (item.es_Hora_salida_jornada2 > inicioHora50 && item.es_Hora_salida_jornada2 < finalHora50) ||
                                         (item.es_Hora_ingreso_jornada2 > inicioHora50 && item.es_Hora_ingreso_jornada2 > finalHora50))
                                   )
                               {

                                   Horas_50 = Get_Horas_50_x_dia_con_dos_jornadas(item);// calculo de horas al 50% con doble jornada
                               }
                           }
                           #endregion
                           #region Horas al 25% de 19:00 a 06:00
                           if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)// tiene horas al 25% de 19:00h a 06:00h en una sola jornada
                           { // tiene horas al 25% de 19:00h a 06:00h en la jornada 1

                               if ((item.es_Hora_ingreso_jornada1 >= inicioHora25 && item.es_Hora_ingreso_jornada1 <= finalHora25) ||
                                  (item.es_Hora_salida_jornada1 >= inicioHora25 && item.es_Hora_salida_jornada1 <= finalHora25) ||
                                  (item.es_Hora_ingreso_jornada1 >= inicioHora25 && item.es_Hora_ingreso_jornada1 >= finalHora25) ||
                                   (item.es_Hora_ingreso_jornada1 <= inicioHora25 && item.es_Hora_ingreso_jornada1 >= finalHora25 && ((TimeSpan)item.es_Hora_ingreso_jornada1).Hours > 12)

                                  )
                               {
                                   if (((TimeSpan)item.es_Hora_ingreso_jornada1).Hours > 0)
                                   {
                                       
                                       if(dia_Semana!=6 && dia_Semana!=7)
                                       Horas_25 = Get_Horas_25_x_dia(item); // calculo de horas al 25%
                                   }
                               }
                           }
                           else
                           {
                           }
                           #endregion


                       }
                   }




                   // creo las novedades
                   if (info_parametro.Se_calcula_horas_Extras_al100)
                   {
                       if (Horas_100 > 0)// si es que tiene horas al 100%
                       {
                           ro_Empleado_Novedad_Det_Info info_novedad_100 = new ro_Empleado_Novedad_Det_Info();
                           info_novedad_100.IdEmpresa = param.IdEmpresa;
                           info_novedad_100.IdEmpleado = IdEmpleado;
                           info_novedad_100.Nombre = Nombre;
                           info_novedad_100.em_cedula = Cedula;
                           info_novedad_100.IdNovedad = 0;
                           info_novedad_100.Secuencia = 1;
                           info_novedad_100.IdRubro = "9";
                           info_novedad_100.FechaPago = fecha_pago;
                           if (item.grupo.Calculo_Horas_extras_Sobre > 0)
                           {
                               info_novedad_100.Valor = Math.Round(Horas_100 * ((Suel_Actual / item.grupo.Calculo_Horas_extras_Sobre) * 2), 2);// aqui cambiar segun el parametro del empleado se calcula sobre 160 o 240
                           }
                           else
                           {
                               info_novedad_100.Valor = Math.Round(Horas_100 * ((Suel_Actual / 160) * 2), 2);// aqui cambiar segun el parametro del empleado se calcula sobre 160 o 240

                           }
                           info_novedad_100.NumHoras = Horas_100;
                           info_novedad_100.Observacion = "Horas extras al 100% correspondiente al " + fecha_pago.Month.ToString().PadLeft(2, '0') + "/" + fecha_pago.Year;
                           info_novedad_100.es_Hora_ingreso_jornada1 = item.es_Hora_ingreso_jornada1;
                           info_novedad_100.es_Hora_ingreso_jornada2 = item.es_Hora_ingreso_jornada2;
                           info_novedad_100.es_Hora_salida_jornada1 = item.es_Hora_salida_jornada1;
                           info_novedad_100.es_Hora_salida_jornada2 = item.es_Hora_salida_jornada2;
                           if (item.es_Fech_remplazo != null)
                           {
                               info_novedad_100.es_Fech_remplazo =Convert.ToDateTime( item.es_Fech_remplazo);
                           }
                           info_novedad_100.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas;
                           lista_novedad_detalle.Add(info_novedad_100);

                       }
                   }
                   if (info_parametro.Se_calcula_horas_Extras_al50)
                   {
                       if (Horas_50 > 0)// si es que tiene horas al 50%
                       {
                           ro_Empleado_Novedad_Det_Info info_novedad_50 = new ro_Empleado_Novedad_Det_Info();

                           info_novedad_50.IdEmpresa = param.IdEmpresa;
                           info_novedad_50.IdEmpleado = IdEmpleado;
                           info_novedad_50.Nombre = Nombre;
                           info_novedad_50.em_cedula = Cedula;
                           info_novedad_50.IdNovedad = 0;
                           info_novedad_50.Secuencia = 1;
                           info_novedad_50.IdRubro = "8";
                           info_novedad_50.FechaPago = fecha_pago;
                           if (item.grupo.Calculo_Horas_extras_Sobre > 0)
                           {
                               info_novedad_50.Valor = Math.Round(Horas_50 * ((Suel_Actual / item.grupo.Calculo_Horas_extras_Sobre) * 1.5), 2);// aqui cambiar segun el parametro del empleado se calcula sobre 160 o 240
                           }
                           else
                           {
                               info_novedad_50.Valor = Math.Round(Horas_50 * ((Suel_Actual / 160) * 1.5), 2);// aqui cambiar segun el parametro del empleado se calcula sobre 160 o 240
                           }
                           info_novedad_50.NumHoras = Horas_50;
                           info_novedad_50.Observacion = "Horas extras al 50% correspondiente al " + fecha_pago.Month.ToString().PadLeft(2, '0') + "/" + fecha_pago.Year;
                           info_novedad_50.es_Hora_ingreso_jornada1 = item.es_Hora_ingreso_jornada1;
                           info_novedad_50.es_Hora_ingreso_jornada2 = item.es_Hora_ingreso_jornada2;
                           info_novedad_50.es_Hora_salida_jornada1 = item.es_Hora_salida_jornada1;
                           info_novedad_50.es_Hora_salida_jornada2 = item.es_Hora_salida_jornada2;
                           if (item.es_Fech_remplazo != null)
                           {
                               info_novedad_50.es_Fech_remplazo = Convert.ToDateTime(item.es_Fech_remplazo);
                           }
                           info_novedad_50.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas;

                           lista_novedad_detalle.Add(info_novedad_50);
                       }

                   }

                   if (info_parametro.Se_calcula_horas_Extras_al25)
                   {
                       if (Horas_25 > 0)// si es que tiene horas al 25%
                       {
                           ro_Empleado_Novedad_Det_Info info_novedad_25 = new ro_Empleado_Novedad_Det_Info();
                           info_novedad_25.IdEmpresa = param.IdEmpresa;
                           info_novedad_25.IdEmpleado = IdEmpleado;
                           info_novedad_25.Nombre = Nombre;
                           info_novedad_25.em_cedula = Cedula;
                           info_novedad_25.IdNovedad = 0;
                           info_novedad_25.Secuencia = 1;
                           info_novedad_25.IdRubro = "7";
                           info_novedad_25.FechaPago = fecha_pago;
                           if (item.grupo.Calculo_Horas_extras_Sobre > 0)
                           {
                               info_novedad_25.Valor = Math.Round(Horas_25 * ((Suel_Actual / item.grupo.Calculo_Horas_extras_Sobre) * 0.25), 2);// aqui cambiar segun el parametro del empleado se calcula sobre 160 o 240
                           }
                           else
                           {
                               info_novedad_25.Valor = Math.Round(Horas_25 * ((Suel_Actual / 160) * 0.25), 2);// aqui cambiar segun el parametro del empleado se calcula sobre 160 o 240
                           }
                           info_novedad_25.NumHoras = Horas_25;
                           info_novedad_25.Observacion = "Horas extras al 25% correspondiente al " + fecha_pago.Month.ToString().PadLeft(2, '0') + "/" + fecha_pago.Year;
                           info_novedad_25.es_Hora_ingreso_jornada1 = item.es_Hora_ingreso_jornada1;
                           info_novedad_25.es_Hora_ingreso_jornada2 = item.es_Hora_ingreso_jornada2;
                           info_novedad_25.es_Hora_salida_jornada1 = item.es_Hora_salida_jornada1;
                           info_novedad_25.es_Hora_salida_jornada2 = item.es_Hora_salida_jornada2;

                           if (item.es_Fech_remplazo != null)
                           {
                               info_novedad_25.es_Fech_remplazo = Convert.ToDateTime(item.es_Fech_remplazo);
                           }
                           info_novedad_25.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas;

                           lista_novedad_detalle.Add(info_novedad_25);
                           


                       }
                   }



                   // ro nomina por horas extras para la liquidacion 
                   ro_Nomina_X_Horas_Extras_Info Info_ro_Nomina_X_Horas_Extras = new Info.Roles.ro_Nomina_X_Horas_Extras_Info();
                   Info_ro_Nomina_X_Horas_Extras.IdEmpresa = item.IdEmpresa;
                   Info_ro_Nomina_X_Horas_Extras.IdEmpleado = item.IdEmpleado;
                   Info_ro_Nomina_X_Horas_Extras.IdNominaTipo = item.Id_nomina_Tipo;
                   Info_ro_Nomina_X_Horas_Extras.IdNominaTipoLiqui = 1;
                   Info_ro_Nomina_X_Horas_Extras.IdPeriodo = 2016;
                   Info_ro_Nomina_X_Horas_Extras.IdCalendario = 20145;
                   Info_ro_Nomina_X_Horas_Extras.IdTurno = 1;
                   Info_ro_Nomina_X_Horas_Extras.IdHorario = 1;
                   Info_ro_Nomina_X_Horas_Extras.FechaRegistro = Convert.ToDateTime(item.es_fechaRegistro);

                   Info_ro_Nomina_X_Horas_Extras.time_entrada1 = item.es_Hora_ingreso_jornada1;
                   Info_ro_Nomina_X_Horas_Extras.time_entrada2 = item.es_Hora_ingreso_jornada2;
                   Info_ro_Nomina_X_Horas_Extras.time_salida1 = item.es_Hora_salida_jornada1;
                   Info_ro_Nomina_X_Horas_Extras.time_salida2 = item.es_Hora_salida_jornada2;
                   if (Horas_25 < 0)
                   {
                       Horas_25 = 0;
                   }

                   if (Horas_50 < 0)
                   {
                       Horas_50 = 0;
                   }

                   if (Horas_100 < 0)
                   {
                       Horas_100 = 0;
                   }
                  
                   Info_ro_Nomina_X_Horas_Extras.hora_extra25 = Horas_25;
                   Info_ro_Nomina_X_Horas_Extras.hora_extra50 = Horas_50;
                   Info_ro_Nomina_X_Horas_Extras.hora_extra100 = Horas_100;

                   Info_ro_Nomina_X_Horas_Extras.hora_atraso = 0;
                   Info_ro_Nomina_X_Horas_Extras.hora_temprano = 0;
                   Info_ro_Nomina_X_Horas_Extras.hora_trabajada = item.es_tot_horasTrabajadas;
                   Info_ro_Nomina_X_Horas_Extras.UsuarioIngresa = param.IdUsuario;
                   lista_nomina_x_horas_Hextras.Add(Info_ro_Nomina_X_Horas_Extras);               
               }

             


               return lista_novedad_detalle;

               
           }
           catch (Exception )
           {

               return new List<ro_Empleado_Novedad_Det_Info>();
           }
       }
       public double Get_Horas_25_x_dia(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {

               Horas_tmp = 0;
               horas = 0;
               minutos = 0;
               horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours);
               minutos = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Minutes);
               horas = horas + 8;     
               es_hora = new TimeSpan(horas, minutos, 0);
               if (((TimeSpan)info.es_Hora_ingreso_jornada1).Hours >= 19)// si ingreso des pues de las siete
               {
                   es_hora = new TimeSpan(horas, minutos, 0);
                   Horas_tmp = (es_hora -(TimeSpan) info.es_Hora_ingreso_jornada1).TotalHours;
               }
               else
               {                   
                   Horas_tmp = (es_hora - inicioHora25).TotalHours;
               }
               if (Horas_tmp < 0)
               {
                   Horas_tmp = Horas_tmp * -1;
               }

               return Horas_tmp;

              

           }
           catch (Exception ex)
           {

               return 0;
           }
       }
       public double Get_Horas_50_x_dia(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {

               Horas_tmp = 0;
               horas = 0;
               minutos = 0;

               if (((TimeSpan)info.es_Hora_ingreso_jornada1).Hours <= 24 && ((TimeSpan)info.es_Hora_salida_jornada1).Hours <= 8)
               {
                   Horas_tmp = ((TimeSpan)info.es_Hora_salida_jornada1 - inicioHora50).TotalHours;
                   Horas_tmp = Horas_tmp + 1;
               }
               else
               {
                 
                   horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours);
                   minutos = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Minutes);
                   horas = horas + 8;
                   if (horas > 24)
                   {
                       horas = horas - 24;
                   }
                   es_hora = new TimeSpan(horas, minutos, 0);
                   Horas_tmp = ((TimeSpan)info.es_Hora_salida_jornada1 - es_hora).TotalHours;
               }
               return Horas_tmp = Horas_tmp-1;
           }
           catch (Exception ex)
           {

               return 0;
           }
       }
       public double Get_Horas_50_x_dia_con_dos_jornadas(ro_marcaciones_x_Jornada_Info info)
      {

           try
           {
               double Hora_j1=0;
               double Hora_j2 = 0;
               Horas_tmp = 0;
               horas = 0;
               minutos = 0;

               Hora_j1 = ((TimeSpan)(info.es_Hora_salida_jornada1 - (TimeSpan)info.es_Hora_ingreso_jornada1) ).TotalHours;
               Hora_j2 = ((TimeSpan)(info.es_Hora_salida_jornada2 - (TimeSpan)info.es_Hora_ingreso_jornada2)).TotalHours;
               Horas_tmp = (Hora_j1 + Hora_j2) - 8;
               return Horas_tmp = Horas_tmp-1;
           }
           catch (Exception ex)
           {

               return 0;
           }
       }  
       public double Get_Horas_100_x_dia(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {
               Horas_tmp = 0;
               horas = 0;
               minutos = 0;
               horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours);
               horas = horas + 8;
               if (horas > 24)
               {
                   horas = horas - 24;
               }
               minutos = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Minutes);
               es_hora = new TimeSpan(horas, minutos, 0);
               Horas_tmp = (es_hora - finalHora100).TotalHours;
               if (((TimeSpan)info.es_Hora_salida_jornada1).TotalHours < finalHora100.TotalHours)
               {
                   Horas_tmp = horas - ((TimeSpan)info.es_Hora_salida_jornada1).TotalHours;
               }
               else
               {
                   if (((TimeSpan)info.es_Hora_salida_jornada1).TotalHours >= finalHora100.TotalHours)
                   {
                       if (info.es_tot_horasTrabajadas <= 8)
                           Horas_tmp = 0;
                       else
                           Horas_tmp = Horas_tmp + 1;
                   }
                   else

                   Horas_tmp = horas - finalHora100.TotalHours;
               }
               if (Horas_tmp < 0)
               {
                Horas_tmp = Horas_tmp * -1;
               }
               return Horas_tmp;

           }
           catch (Exception ex)
           {

              return 0;
           }
       }
       public List<ro_marcaciones_x_empleado_Info> Get_List_Marcaciones(List<ro_marcaciones_x_Jornada_Info> lista, int IdPeriodo)
       {
           try
           {
               int secuencia = 0;
               tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
               tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
               List<ro_marcaciones_x_empleado_Info> lista_marcaciones = new List<ro_marcaciones_x_empleado_Info>();
               foreach (var item in lista)
               {
                   InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(item.es_fechaRegistro));                            

                   ro_marcaciones_x_empleado_Info info;
                   if ( ((TimeSpan) item.es_Hora_ingreso_jornada1).Hours>0)// ingreso primera jornada
                   {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdRegistro = "IN1-"+Convert.ToDateTime(item.es_fechaRegistro).Day.ToString()+"/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString()+"/"+ Convert.ToDateTime(item.es_fechaRegistro).Year.ToString()  ;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "IN1";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_ingreso_jornada1;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int) Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "IN1";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }



                   if ( ((TimeSpan) item.es_Hora_salida_jornada1).Hours>0)// ingreso primera jornada
                   {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdRegistro = "OUT1-" + Convert.ToDateTime(item.es_fechaRegistro).Day.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Year.ToString();
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "OUT1";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_ingreso_jornada1;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "OUT1";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }









                   if ( ((TimeSpan) item.es_Hora_ingreso_jornada2).Hours>0)// ingreso primera jornada
                   {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdRegistro = "IN2-" + Convert.ToDateTime(item.es_fechaRegistro).Day.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Year.ToString();
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "IN2";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_ingreso_jornada1;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "IN2";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }



                      if ( ((TimeSpan) item.es_Hora_salida_jornada2).Hours>0)// ingreso primera jornada
                       {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdRegistro = "OUT2-" + Convert.ToDateTime(item.es_fechaRegistro).Day.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Year.ToString();
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "OUT2";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_ingreso_jornada1;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "OUT2";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }

               }

               return lista_marcaciones;
           }
           catch (Exception ex)
           {
               
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Marcaciones", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_Jornada_Bus) };

           }
       }
       public List<ro_Nomina_X_Horas_Extras_Info> get_nomina_x_Horas_Extras()
       {
           try
           {
               return lista_nomina_x_horas_Hextras;
           }
           catch (Exception ex)
           {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_nomina_x_Horas_Extras", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_Jornada_Bus) };

           }
       }
   
   }
}
