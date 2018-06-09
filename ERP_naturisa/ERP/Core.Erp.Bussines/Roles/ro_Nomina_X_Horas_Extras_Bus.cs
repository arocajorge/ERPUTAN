
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using System.Collections;
using DevExpress.Data;
using DevExpress.XtraGrid;

namespace Core.Erp.Business.Roles
{
    public class ro_Nomina_X_Horas_Extras_Bus 
    {

        public ro_Nomina_X_Horas_Extras_Bus()
        {
           
            List_dias = Bus_Dia.Get_Dias();
        }

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
 
        string mensaje = "";

        List< ro_dias_Info >List_dias = new List< ro_dias_Info>();
        ro_dias_Info Info_dias = new ro_dias_Info();

        ro_dias_Bus Bus_Dia = new ro_dias_Bus();

        //BUS
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_marcaciones_x_empleado_Bus oRo_marcaciones_x_empleado_Bus = new ro_marcaciones_x_empleado_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_horario_planificacion_Bus oRo_horario_planificacion_Bus = new Roles.ro_horario_planificacion_Bus();
        ro_Horario_Bus oRo_Horario_Bus = new ro_Horario_Bus();
        ro_HistoricoSueldo_Bus oHistoricoSueldoBus = new ro_HistoricoSueldo_Bus();
        ro_Empleado_Novedad_Bus oRo_Empleado_Novedad_Cab_Bus = new Roles.ro_Empleado_Novedad_Bus();
        ro_Empleado_Novedad_Det_Bus oRo_Empleado_Novedad_Det_Bus = new Roles.ro_Empleado_Novedad_Det_Bus();

        //INFO


        //DATA
        ro_Nomina_X_Horas_Extras_Data oData = new ro_Nomina_X_Horas_Extras_Data();





        public List<ro_Nomina_X_Horas_Extras_Info> Get_List_Nomina_X_Horas_Extras(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {

            try
            {
                return oData.Get_List_Nomina_X_Horas_Extras(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Nomina_X_Horas_Extras", ex.Message), ex) { EntityType = typeof(ro_Nomina_X_Horas_Extras_Bus) };
            }
        }




        public Boolean GuardarBD(ro_Nomina_X_Horas_Extras_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA DETALLE
                if (oData.GetExiste(info, ref mensaje))
                {
                    info.UsuarioModifica = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;
                    valorRetornar = oData.ModificarBD(info, ref mensaje);
                }
                else
                {//GRABA DETALLE
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaIngresa= param.Fecha_Transac;

                    valorRetornar = oData.GuardarBD(info, ref mensaje);
                }
                return valorRetornar;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Nomina_X_Horas_Extras_Bus) };
            }
        }




        public Boolean pu_CalcularHorasExtras(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, DateTime fechaInicial, DateTime fechaFinal, Boolean acreditaRol)
        {
            try
            {

                //if (idEmpleado == 59)
                //{
                //}

                //JORNADA NOCTURNA
                TimeSpan inicioHora25 = TimeSpan.FromHours(19); //19:00 PM
                TimeSpan finalHora25 = TimeSpan.FromHours(6); //06:00 AM

                //HORAS EXTRAS 50
                TimeSpan inicioHora50 = TimeSpan.FromHours(6); //06:00 AM
                TimeSpan finalHora50 = TimeSpan.FromHours(24); //24:00 PM

                //HORAS EXTRAS 100
                TimeSpan inicioHora100 = TimeSpan.FromHours(0); //00:00 PM
                TimeSpan finalHora100 = TimeSpan.FromHours(6); //06:00 AM

                int contadorIN = 0;
                int contadorOUT = 0;
                Boolean banderaHorario = false;
             
                List<ro_Nomina_X_Horas_Extras_Info> listado = new List<ro_Nomina_X_Horas_Extras_Info>();
                List<ro_marcaciones_x_empleado_Info> oListRo_marcaciones_x_empleado_Info = new List<ro_marcaciones_x_empleado_Info>();

                //OBTENER LA PLANIFICACION DE HORARIOS DEL EMPLEADO
                List<ro_horario_planificacion_Info> oListRo_horario_planificacion_Info =new List<ro_horario_planificacion_Info>();
                oListRo_horario_planificacion_Info = oRo_horario_planificacion_Bus.Get_List_horario_planificacion(idEmpresa, idEmpleado, fechaInicial, fechaFinal);

                //OBTENER LISTADO DE HORARIOS EN GENERAL
                List<ro_Horario_Info> oListRo_Horario_Info = new List<ro_Horario_Info>();
                oListRo_Horario_Info = oRo_Horario_Bus.Get_List_Horario(idEmpresa);

                //RECORRE LA PLANIFICACION DE HORARIOS DEL EMPLEADO - DIA X DIA
                foreach (ro_horario_planificacion_Info horarioEmpleado in oListRo_horario_planificacion_Info)
                {
                      ro_Nomina_X_Horas_Extras_Info info = new ro_Nomina_X_Horas_Extras_Info();
                    
                      double horaExtra25 = 0;
                      double horaExtra50 = 0;
                      double horaExtra100 = 0;
                      double horaAtraso = 0;
                      double horaTemprano = 0;
                      double horaTrabajada = 0;

                      TimeSpan horaEntrada1 = new TimeSpan();
                      TimeSpan horaSalida1 = new TimeSpan();
                      TimeSpan horaEntrada2 = new TimeSpan();
                      TimeSpan horaSalida2 = new TimeSpan();

                      TimeSpan unDia = TimeSpan.FromHours(24); //24:00 PM

                    //OBTIENE LOS DATOS DEL HORARIO DEL EMPLEADO
                      ro_Horario_Info horarioActual = oListRo_Horario_Info.Where(v => v.IdHorario == horarioEmpleado.IdHorario).FirstOrDefault();

                    //COMBINO FECHA + HORA
                      string subcadena = horarioEmpleado.IdCalendario.ToString();

                      int YYYY = Convert.ToInt32(subcadena.Substring(0, 4));
                      int mm = Convert.ToInt32(subcadena.Substring(4, 2));
                      int dd = Convert.ToInt32(subcadena.Substring(6, 2));

                      DateTime f1 = new DateTime(YYYY, mm, dd);
                      DateTime f2 = new DateTime(YYYY, mm, dd);

                      DateTime fechaMarcacionInicial = new DateTime(YYYY, mm, dd);
                      DateTime fechaMarcacionFinal= new DateTime(YYYY, mm, dd);


                    //AGREGA LOS TIEMPOS
                       f1 = f1.Add((TimeSpan)horarioActual.InicioEntrada);
                       f2 = f2.Add((TimeSpan)horarioActual.FinalSalida);


                    //VERIFICAR HORARIO DEL MISMO DIA VS. HORARIO DEL DIA SIGUIENTE
                        if (horarioActual.HoraIni<=horarioActual.HoraFin)//CORRESPONDE AL MISMO DIA
                        {
                            banderaHorario = false;
                    
                        }else{//CORRESPONDE A PARTE DEL MISMO DIA, Y PARTE DEL DIA SIGUIENTE 
                            f2 = f2.AddDays(1);
                            banderaHorario = true;
                        }



                    //AQUI DEBE VERIFICAR SI TIENE VARIOS TURNOS EN EL MISMO DIA - MODALIDAD DE TURNOS DOBLES 


                        if (oRo_horario_planificacion_Bus.GetVerificarDobleTurno(horarioEmpleado.IdEmpresa, horarioEmpleado.IdEmpleado, horarioEmpleado.IdCalendario, ref mensaje))
                        {
                            fechaMarcacionInicial = fechaMarcacionInicial.Add((TimeSpan)horarioActual.InicioEntrada);
                            fechaMarcacionFinal = fechaMarcacionFinal.Add((TimeSpan)horarioActual.InicioEntrada).AddHours(11);
                        }
                        else
                        {
                            fechaMarcacionInicial = fechaMarcacionInicial.Add((TimeSpan)horarioActual.InicioEntrada);
                            fechaMarcacionFinal = fechaMarcacionFinal.Add((TimeSpan)horarioActual.InicioEntrada).AddHours(12);
                        }


                    
                    //OBTENER LAS MARCACIONES DEL EMPLEADO EN LA FECHA CORRESPONDIENTE
                     oListRo_marcaciones_x_empleado_Info = oRo_marcaciones_x_empleado_Bus.Get_List_marcaciones_x_empleado(idEmpresa, idEmpleado, fechaMarcacionInicial, fechaMarcacionFinal);


                     ro_marcaciones_x_empleado_Info info_entrada = new ro_marcaciones_x_empleado_Info();
                     ro_marcaciones_x_empleado_Info info_salida = new ro_marcaciones_x_empleado_Info();
                     // si marco mas de una vez
                     try
                     {
                         info_entrada = oListRo_marcaciones_x_empleado_Info.Where(v => v.IdTipoMarcaciones == "IN").FirstOrDefault();
                     }
                     catch (Exception)
                     {
                     }
                     try
                     {
                         info_salida = oListRo_marcaciones_x_empleado_Info.Where(v => v.IdTipoMarcaciones == "OUT").FirstOrDefault();
                     }
                     catch (Exception)
                     {
                     }

                     oListRo_marcaciones_x_empleado_Info = new List<ro_marcaciones_x_empleado_Info>();
                     if (info_entrada != null)
                     {
                         oListRo_marcaciones_x_empleado_Info.Add(info_entrada);

                     }
                     if (info_salida != null)
                     {
                         oListRo_marcaciones_x_empleado_Info.Add(info_salida);

                     }

                    contadorIN = 0;
                    contadorOUT = 0;


                    //RECORRER EL LISTADO DE MARCACIONES OBTENIDO
                    foreach (var item in oListRo_marcaciones_x_empleado_Info)
                    {
                        // cambio por tolerancia de horas y minutos Carlos cedeño
                        

                            // este cambio es exclusivo para edehsa aqui revisar con el sensei como se puede hacer 


                            // este cambio es exclusivo para edehsa aqui revisar con el sensei como se puede hacer 
                            if (item.IdTipoMarcaciones == "IN")
                            {
                                if (item.es_Hora > horarioActual.InicioEntrada)
                                {
                                    item.es_Hora = (TimeSpan)horarioActual.InicioEntrada;
                                }

                            }

                        
                        

                       // horarioActual


                        if (item.IdTipoMarcaciones == "OUT")
                        {
                            if (horarioActual.Tolerancia_Hora != null && horarioActual.Tolerancia_Minuto != null)
                            {

                                int hora = Convert.ToInt32(item.es_Hora.ToString().Substring(0, 2));
                                int minuto = Convert.ToInt32(item.es_Hora.ToString().Substring(3, 2));
                                if (minuto < horarioActual.Tolerancia_Minuto)
                                {
                                    minuto = 0;
                                }

                                if (minuto < horarioActual.Tolerancia_Hora && minuto > horarioActual.Tolerancia_Minuto)
                                {
                                    minuto = 30;
                                }

                                if (minuto > horarioActual.Tolerancia_Hora)
                                {
                                    hora = hora + 1;
                                    minuto = 0;
                                }

                                item.es_Hora = new TimeSpan(hora, minuto, 0);
                            }

                        }




                        if (item.IdTipoMarcaciones == "IN")
                        {
                            contadorIN++;
                        }
                        else
                        {
                            if (item.IdTipoMarcaciones == "OUT")
                            {
                                contadorOUT++;
                            }
                        }

                      

                        //ENTRADAS
                        if (contadorIN == 1 && contadorOUT==0)
                        {
                            horaEntrada1 = (TimeSpan)item.es_Hora;
                            horaEntrada2 = (TimeSpan)item.es_Hora;
                        }
                        else
                        {
                            if (contadorIN == 2)
                            {
                                horaEntrada2 = (TimeSpan)item.es_Hora;
                                contadorIN++;
                            }
                        }







                        //SALIDAS                        
                        if (contadorOUT == 1 && contadorIN<=2)
                        {        
                            horaSalida1 = (TimeSpan)item.es_Hora;
                            horaSalida2 = (TimeSpan)item.es_Hora;
                        }
                        else
                        {
                            if (contadorOUT == 2)
                            {
                                horaSalida2 = (TimeSpan)item.es_Hora;
                                contadorOUT++;
                            }
                        }


                    }



                    //PROCESAR HORAS EXTRAS        
                    info.IdEmpresa = idEmpresa;
                    info.IdEmpleado = idEmpleado;
                    info.IdCalendario = horarioEmpleado.IdCalendario;
                    info.IdNominaTipo = idNominaTipo;
                    info.IdNominaTipoLiqui = idNominaTipoLiqui;
                    info.IdPeriodo = idPeriodo;
                    info.IdHorario = horarioActual.IdHorario;

                    ///AQUI REVISAR PARA LOS TURNOS DOBLES
                    info.IdTurno= horarioEmpleado.IdRegistro;

                    info.FechaRegistro= Convert.ToDateTime(f1.ToShortDateString());

                    info.time_entrada1 = horaEntrada1;
                    info.time_entrada2 = horaEntrada2;
                    info.time_salida1 = horaSalida1;
                    info.time_salida2 = horaSalida2;

                    //CALCULA HORAS DE ATRASO
                    if (horaEntrada1 > (TimeSpan)horarioActual.FinalEntrada)
                    {
                        horaAtraso = (horaEntrada1 - (TimeSpan)horarioActual.HoraIni).TotalHours; //TOTAL DE HORAS DE ATRASO
                        horaSalida2 = horaSalida2.Subtract(horaEntrada1 - (TimeSpan)horarioActual.HoraIni); // AQUI SE RESTA EL ATRASO A LA HORA DE SALIDA
         
                    }


                    int dia_semana = ((int)f1.DayOfWeek == 0) ? 7 : (int)f1.DayOfWeek;

                    if (dia_semana >= 1 && dia_semana <= 5)    //VERIFICA QUE LOS DIAS DE TRABAJO SON DE LUNES A VIERNES 
                    {
                        //VERIFICA QUE TURNO TIENE EL EMPLEADO (DIURNO - NOCTURNO)
                        if (banderaHorario == false)//TURNO DIURNO
                        {
                            //CALCULA SALIDAS TEMPRANO                 
                            if (horaSalida2 < (TimeSpan)horarioActual.HoraFin && horaSalida2 > (TimeSpan)horarioActual.InicioEntrada)
                            {
                                horaTemprano = ((TimeSpan)horarioActual.HoraFin - horaSalida2).TotalHours;
                            }


                            //CALCULA LAS HORAS TRABAJADAS                    
                            if (horaSalida2 >= horaEntrada1)
                            {

                                if (horaSalida1 > horaEntrada1 && horaSalida1 < horaEntrada2)
                                {
                                    horaTrabajada = (horaSalida1 - horaEntrada1).TotalHours + (horaSalida2 - horaEntrada2).TotalHours;
                                }
                                else
                                {
                                    horaTrabajada = (horaSalida2 - horaEntrada1).TotalHours;
                                }

                            }
                            else
                            {
                                

                                if (horaSalida1 > horaEntrada1 && horaSalida1 < horaEntrada2)
                                {

                                    horaTrabajada = (horaSalida1 - horaEntrada1).TotalHours + (unDia - horaEntrada2).TotalHours + horaSalida2.TotalHours;
                                }
                                else
                                {
                                    horaTrabajada = (unDia - horaEntrada1).TotalHours + horaSalida2.TotalHours;
                                }

                            }

                            if (horaTrabajada > 0)
                            {

                                //VERIFICA QUE LA SALIDA CORRESPONDA A HORAS EXTRAS DEL MISMO DIA
                                if (horaSalida2 > (TimeSpan)horarioActual.FinalSalida && horaSalida2 > horaEntrada1)
                                {
                                    //VERIFICA SI TIENE HORAS EXTRAS 100
                                    if (horaSalida2 > inicioHora100 && horaSalida2 <= finalHora100)
                                    {
                                        horaExtra100 = (horaSalida2 - finalHora100).TotalHours; //TOTAL DE HORAS EXTRAS 100

                                    }
                                    else
                                    {
                                        //VERIFICA SI TIENE HORAS EXTRAS 50%
                                        if (horaSalida2 > inicioHora50 && horaSalida2 < finalHora50)
                                        {
                                            horaExtra50 = (horaSalida2 - (TimeSpan)horarioActual.FinalSalida).TotalHours; //TOTAL DE HORAS EXTRAS 50%                                    
                                        }
                                    }
                                }
                                else
                                {

                                    if (horaSalida2 < (TimeSpan)horarioActual.InicioEntrada)
                                    {
                                        horaExtra50 = (finalHora50 - (TimeSpan)horarioActual.FinalSalida).TotalHours; //TOTAL DE HORAS EXTRAS 50%  
                                        horaExtra100 = (horaSalida2 - inicioHora100).TotalHours; //TOTAL DE HORAS EXTRAS 100

                                    }


                                }


                            }


                        }
                        else
                        { //***********************************TURNO NOCTURNO*****************************************

                           
                            //CALCULA SALIDAS TEMPRANO                 
                            if (horaSalida2 < (TimeSpan)horarioActual.HoraFin && (unDia + horaSalida2) > (TimeSpan)horarioActual.InicioEntrada)
                            {
                                horaTemprano = ((TimeSpan)horarioActual.HoraFin - horaSalida2).TotalHours;

                                if (horaEntrada1.TotalHours == 0 && horaEntrada2.TotalHours == 0)
                                {
                                    horaTemprano = 0;
                                }
                            }


                            //VERIFICA SI ES JORNADA NOCTURNA
                            if (horaEntrada1 >= inicioHora25 && horaEntrada1 <= (unDia + finalHora25) && banderaHorario)
                            {
                                //horaExtra25 = (horaSalida2 - finalHora25).Hours; //TOTAL DE HORAS DE JORNADA NOCTURNA
                                horaExtra25 = ((unDia + horaSalida2) - horaEntrada1).TotalHours; //TOTAL DE HORAS DE JORNADA NOCTURNA

                                if (horaExtra25 > 8)
                                {
                                    horaExtra25 = 8;
                                }

                            }


                            //CALCULO DE HORAS EXTRAS
                            if (horaSalida2 > horaEntrada1 && horaSalida2 < finalHora50)
                            {
                                horaTrabajada = (horaSalida2.TotalHours - horaEntrada1.TotalHours);
                            }
                            else
                            {

                                if (horaSalida2 > inicioHora100)
                                {
                                    horaTrabajada = (unDia + horaSalida2).TotalHours - horaEntrada1.TotalHours;


                                    if (horaSalida2 > (TimeSpan)horarioActual.HoraFin && horaSalida2 <= finalHora100)
                                    {
                                        horaExtra100 = (horaSalida2 - (TimeSpan)horarioActual.HoraFin).TotalHours;
                                    }
                                    else
                                    {
                                        if (horaSalida2 > (TimeSpan)horarioActual.HoraFin && horaSalida2 > inicioHora50 && horaSalida2 <= finalHora50)
                                        {
                                            horaExtra100 = (inicioHora50 - (TimeSpan)horarioActual.HoraFin).TotalHours;
                                            horaExtra50 = (horaSalida2 - inicioHora50).TotalHours;
                                        }
                                    }
                                }
                            }

                        } //CIERRE TURNO NOCTURNO

                    }
                    else {

                        if (dia_semana == 6 | dia_semana==7) //REPRESENTA SABADO Y DOMINGO
                        {
                            if (horaEntrada1 != horaSalida2)
                            {

                                //CALCULO DE HORAS EXTRAS
                                if (dia_semana == 6)//SOLO SABADO
                                {
                                    
                                    if (horaSalida2 > (TimeSpan)horarioActual.HoraIni && horaSalida2 < finalHora50)
                                    {
                                        horaExtra100 = (horaSalida2 - (TimeSpan)horarioActual.HoraIni).TotalHours;

                                        //CALCULA LA SALIDA TEMPRANA
                                        if (horaSalida2.TotalHours < (unDia + (TimeSpan)horarioActual.FinalSalida).TotalHours)
                                        {
                                            horaTemprano = ((unDia + (TimeSpan)horarioActual.FinalSalida) - horaSalida2).TotalHours;
                                        }

                                        //CALCULA HORAS TRABAJADAS
                                        horaTrabajada = (horaSalida2 - horaEntrada1).TotalHours;
                                    }
                                    else
                                    {
                                        if (horaSalida2.Hours > 0)
                                        {
                                            horaExtra100 = ((unDia + horaSalida2) - (TimeSpan)horarioActual.HoraIni).TotalHours;
                                        }

                                        Info_dias = List_dias.Where(v => v.Id_dia == 6).FirstOrDefault();
                                        if (Convert.ToInt32(horaExtra100) > Info_dias.sdia_completo_a_partir_de && horaExtra100 <= 8)
                                        {
                                            horaExtra100= 8;
                                        }

                                        //CALCULA LA SALIDA TEMPRANA
                                        if (horaSalida2 < (TimeSpan)horarioActual.HoraFin)
                                        {
                                            horaTemprano = ((TimeSpan)horarioActual.HoraFin - horaSalida2).TotalHours;
                                        }


                                        //CALCULA HORAS TRABAJADAS
                                        horaTrabajada = ((unDia + horaSalida2) - horaEntrada1).TotalHours;
                                    }
                                }
                                else 
                                {
                                    if (dia_semana == 7)//SOLO DOMINGO
                                    {

                                        if (horaSalida2 > (TimeSpan)horarioActual.HoraIni && horaSalida2 < finalHora50)//SALIDA ANTES DE LAS 24h00
                                        {
                                            horaExtra100 = (horaSalida2 - (TimeSpan)horarioActual.HoraIni).TotalHours;


                                            Info_dias = List_dias.Where(v => v.Id_dia == 7).FirstOrDefault();
                                            if (Convert.ToInt32(horaExtra100)  > Info_dias.sdia_completo_a_partir_de && horaExtra100<=8)
                                            {
                                                horaExtra100 = 8;
                                            }

                                            //CALCULA LA SALIDA TEMPRANA
                                            if (horaSalida2 < (TimeSpan)horarioActual.FinalSalida)
                                            {
                                                horaTemprano = ((TimeSpan)horarioActual.FinalSalida - (horaSalida2)).TotalHours;
                                            }

                                            //CALCULA HORAS TRABAJADAS
                                            horaTrabajada = (horaSalida2 - horaEntrada1).TotalHours;
                                        }
                                        else
                                        { //SALIDA DESPUES DE LAS 24h00
                                        
                                        
                                        }




                                    }
                                }

                                
                                
                            
                            }

                        }

                    }//CIERRE DIA DE LA SEMANA


                    //VERIFICA SI EL EMPLEADO ESTA AUTORIZADO PARA COBRAR HORAS EXTRAS 
                    
                    if (acreditaRol)
                    {
                        info.hora_extra25 = horaExtra25;
                        info.hora_extra50 = horaExtra50;
                        info.hora_extra100 = horaExtra100;
                    
                    }else{
                        info.hora_extra25 = 0;
                        info.hora_extra50 = 0;
                        info.hora_extra100 = 0;                                       
                    }

                    
                    info.hora_atraso = horaAtraso;
                    info.hora_atraso = 0;
                    info.hora_temprano = horaTemprano;
                    info.hora_trabajada = horaTrabajada;


                    GuardarBD(info, ref mensaje);

                }
    
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CalcularHorasExtras", ex.Message), ex) { EntityType = typeof(ro_Nomina_X_Horas_Extras_Bus) };
            }
        }




    public Boolean pu_AgregarNovedadPorEmpleado(int idEmpresa, decimal idEmpleado,int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, DateTime fechaInicial, DateTime fechaFinal,Boolean acreditaRol)
    {
        try {

                string idRubroHoraNocturnaExtra25 = "7";
                string idRubroHoraExtra50 = "8";
                string idRubroHoraExtra100 = "9";

                double valorSueldo = 0;
                double valorHoraMes = 0;

                //OBTENER EL VALOR DEL SUELDO
                valorSueldo = oHistoricoSueldoBus.Get_List_HistoricoSueldo(idEmpresa, idEmpleado).FirstOrDefault().SueldoActual;

                //OBTENER EL VALOR DE LA HORA DE TRABAJO DIURNO
                valorHoraMes = Convert.ToDouble(valorSueldo / 240); //CORRESPONDE A UNA JORNADA DE 8 HORAS X 30 DIAS

                ro_Nomina_X_Horas_Extras_Info info = new ro_Nomina_X_Horas_Extras_Info();
                ro_Empleado_Novedad_Det_Info tmp = new ro_Empleado_Novedad_Det_Info();               

                //OBTIENE LAS HORAS EXTRAS DEL EMPLEADO GENERADAS EN EL PROCESO DE CALCULO
                info = Get_Info_Nomina_X_Horas_Extras(idEmpresa, idEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);

                if (info.hora_extra25 > 0) {
                    ro_Empleado_Novedad_Info oRo_Empleado_Novedad_Cab_Info = new ro_Empleado_Novedad_Info();
                    ro_Empleado_Novedad_Det_Info oRo_Empleado_Novedad_Det_Info = new ro_Empleado_Novedad_Det_Info();
                    
                    decimal idNovedad = 0;  

                    oRo_Empleado_Novedad_Cab_Info.IdEmpresa = info.IdEmpresa;
                    oRo_Empleado_Novedad_Cab_Info.IdEmpleado = info.IdEmpleado;
                    oRo_Empleado_Novedad_Cab_Info.IdNomina_Tipo = idNominaTipo;
                    oRo_Empleado_Novedad_Cab_Info.IdNomina_TipoLiqui = idNominaTipoLiqui;
                    oRo_Empleado_Novedad_Cab_Info.Fecha = fechaFinal;
                    oRo_Empleado_Novedad_Cab_Info.TotalValor = info.hora_extra25 * valorHoraMes*1.25;
                    oRo_Empleado_Novedad_Cab_Info.IdUsuario=param.IdUsuario;
                    oRo_Empleado_Novedad_Cab_Info.Fecha_Transac =param.Fecha_Transac ;
                    oRo_Empleado_Novedad_Cab_Info.Estado ="A";

                    //BORRAR VALORES PREVIOS DE NOVEDADES
                    tmp=oRo_Empleado_Novedad_Det_Bus.Get_Info_Novedad_det(idEmpresa,idEmpleado,idRubroHoraNocturnaExtra25,fechaFinal,ref mensaje);
                    oRo_Empleado_Novedad_Det_Bus.EliminarDB(tmp.IdEmpresa, tmp.IdEmpleado, tmp.IdNovedad, tmp.Secuencia, ref mensaje);//BORRA EL DETALLE
                    oRo_Empleado_Novedad_Cab_Bus.EliminarDB(tmp.IdEmpresa,tmp.IdNovedad,tmp.IdEmpleado,idNominaTipo,idNominaTipoLiqui,ref mensaje); //BORRA LA CABECERA

                    //GUARDA LA CABECERA
                    if (acreditaRol)
                    {
                        if (oRo_Empleado_Novedad_Cab_Bus.GrabarDB(oRo_Empleado_Novedad_Cab_Info, ref idNovedad, ref mensaje))
                        {
                            oRo_Empleado_Novedad_Det_Info.IdEmpresa = info.IdEmpresa;
                            oRo_Empleado_Novedad_Det_Info.IdNovedad = idNovedad;
                            oRo_Empleado_Novedad_Det_Info.IdEmpleado = info.IdEmpleado;
                            oRo_Empleado_Novedad_Det_Info.Secuencia = 1;
                            oRo_Empleado_Novedad_Det_Info.IdRubro = idRubroHoraNocturnaExtra25;
                            oRo_Empleado_Novedad_Det_Info.FechaPago = fechaFinal.Date;
                            oRo_Empleado_Novedad_Det_Info.Valor = info.hora_extra25 * valorHoraMes*1.25;
                            oRo_Empleado_Novedad_Det_Info.EstadoCobro = "PEN";
                            oRo_Empleado_Novedad_Det_Info.Observacion = "Generado Automáticamente por el Cálculo de Horas Extras";
                            oRo_Empleado_Novedad_Det_Info.Estado = "A";
                            oRo_Empleado_Novedad_Det_Info.NumHoras = info.hora_extra25;
                            //GUARDA EL DETALLE
                            oRo_Empleado_Novedad_Det_Bus.GrabarDB(oRo_Empleado_Novedad_Det_Info, ref mensaje);

                        }
                    }
                                
                }

                if (info.hora_extra50 > 0)
                {
                    ro_Empleado_Novedad_Info oRo_Empleado_Novedad_Cab_Info = new ro_Empleado_Novedad_Info();
                    ro_Empleado_Novedad_Det_Info oRo_Empleado_Novedad_Det_Info = new ro_Empleado_Novedad_Det_Info();

                    decimal idNovedad = 0;

                    oRo_Empleado_Novedad_Cab_Info.IdEmpresa = info.IdEmpresa;
                    oRo_Empleado_Novedad_Cab_Info.IdEmpleado = info.IdEmpleado;
                    oRo_Empleado_Novedad_Cab_Info.IdNomina_Tipo = idNominaTipo;
                    oRo_Empleado_Novedad_Cab_Info.IdNomina_TipoLiqui = idNominaTipoLiqui;
                    oRo_Empleado_Novedad_Cab_Info.Fecha = fechaFinal;
                    oRo_Empleado_Novedad_Cab_Info.TotalValor =Math.Round( info.hora_extra50 * valorHoraMes * 1.5,2);
                    oRo_Empleado_Novedad_Cab_Info.IdUsuario = param.IdUsuario;
                    oRo_Empleado_Novedad_Cab_Info.Fecha_Transac = param.Fecha_Transac;
                    oRo_Empleado_Novedad_Cab_Info.Estado = "A";


                    //BORRAR VALORES PREVIOS DE NOVEDADES
                    tmp = oRo_Empleado_Novedad_Det_Bus.Get_Info_Novedad_det(idEmpresa, idEmpleado, idRubroHoraExtra50, fechaFinal, ref mensaje);
                    oRo_Empleado_Novedad_Det_Bus.EliminarDB(tmp.IdEmpresa, tmp.IdEmpleado, tmp.IdNovedad, tmp.Secuencia, ref mensaje);
                    oRo_Empleado_Novedad_Cab_Bus.EliminarDB(tmp.IdEmpresa, tmp.IdNovedad, tmp.IdEmpleado, idNominaTipo, idNominaTipoLiqui, ref mensaje); //BORRA LA CABECERA

                    //GUARDA LA CABECERA
                    if (acreditaRol)
                    {
                        if (oRo_Empleado_Novedad_Cab_Bus.GrabarDB(oRo_Empleado_Novedad_Cab_Info, ref idNovedad, ref mensaje))
                        {
                            oRo_Empleado_Novedad_Det_Info.IdEmpresa = info.IdEmpresa;
                            oRo_Empleado_Novedad_Det_Info.IdNovedad = idNovedad;
                            oRo_Empleado_Novedad_Det_Info.IdEmpleado = info.IdEmpleado;
                            oRo_Empleado_Novedad_Det_Info.Secuencia = 1;
                            oRo_Empleado_Novedad_Det_Info.IdRubro = idRubroHoraExtra50;
                            oRo_Empleado_Novedad_Det_Info.FechaPago = fechaFinal.Date;
                            oRo_Empleado_Novedad_Det_Info.Valor =Math.Round( info.hora_extra50 * valorHoraMes * 1.5,2);
                            oRo_Empleado_Novedad_Det_Info.EstadoCobro = "PEN";
                            oRo_Empleado_Novedad_Det_Info.Observacion = "Generado Automáticamente por el Cálculo de Horas Extras";
                            oRo_Empleado_Novedad_Det_Info.Estado = "A";
                            oRo_Empleado_Novedad_Det_Info.NumHoras = info.hora_extra50;

                            //GUARDA EL DETALLE
                            oRo_Empleado_Novedad_Det_Bus.GrabarDB(oRo_Empleado_Novedad_Det_Info, ref mensaje);

                        }
                    }
                }

                if (info.hora_extra100 > 0)
                {
                    ro_Empleado_Novedad_Info oRo_Empleado_Novedad_Cab_Info = new ro_Empleado_Novedad_Info();
                    ro_Empleado_Novedad_Det_Info oRo_Empleado_Novedad_Det_Info = new ro_Empleado_Novedad_Det_Info();

                    decimal idNovedad = 0;

                    oRo_Empleado_Novedad_Cab_Info.IdEmpresa = info.IdEmpresa;
                    oRo_Empleado_Novedad_Cab_Info.IdEmpleado = info.IdEmpleado;
                    oRo_Empleado_Novedad_Cab_Info.IdNomina_Tipo = idNominaTipo;
                    oRo_Empleado_Novedad_Cab_Info.IdNomina_TipoLiqui = idNominaTipoLiqui;
                    oRo_Empleado_Novedad_Cab_Info.Fecha = fechaFinal;
                    oRo_Empleado_Novedad_Cab_Info.TotalValor = info.hora_extra100 * valorHoraMes*2;
                    oRo_Empleado_Novedad_Cab_Info.IdUsuario = param.IdUsuario;
                    oRo_Empleado_Novedad_Cab_Info.Fecha_Transac = param.Fecha_Transac;
                    oRo_Empleado_Novedad_Cab_Info.Estado = "A";

                    //BORRAR VALORES PREVIOS DE NOVEDADES
                    tmp = oRo_Empleado_Novedad_Det_Bus.Get_Info_Novedad_det(idEmpresa, idEmpleado, idRubroHoraExtra100, fechaFinal, ref mensaje);
                    oRo_Empleado_Novedad_Det_Bus.EliminarDB(tmp.IdEmpresa, tmp.IdEmpleado, tmp.IdNovedad, tmp.Secuencia, ref mensaje);
                    oRo_Empleado_Novedad_Cab_Bus.EliminarDB(tmp.IdEmpresa, tmp.IdNovedad, tmp.IdEmpleado, idNominaTipo, idNominaTipoLiqui, ref mensaje); //BORRA LA CABECERA

                    //GUARDA LA CABECERA
                    if (acreditaRol)
                    {
                        if (oRo_Empleado_Novedad_Cab_Bus.GrabarDB(oRo_Empleado_Novedad_Cab_Info, ref idNovedad, ref mensaje))
                        {
                            oRo_Empleado_Novedad_Det_Info.IdEmpresa = info.IdEmpresa;
                            oRo_Empleado_Novedad_Det_Info.IdNovedad = idNovedad;
                            oRo_Empleado_Novedad_Det_Info.IdEmpleado = info.IdEmpleado;
                            oRo_Empleado_Novedad_Det_Info.Secuencia = 1;
                            oRo_Empleado_Novedad_Det_Info.IdRubro = idRubroHoraExtra100;
                            oRo_Empleado_Novedad_Det_Info.FechaPago = fechaFinal.Date;
                            oRo_Empleado_Novedad_Det_Info.Valor = info.hora_extra100 * valorHoraMes*2;
                            oRo_Empleado_Novedad_Det_Info.EstadoCobro = "PEN";
                            oRo_Empleado_Novedad_Det_Info.Observacion = "Generado Automáticamente por el Cálculo de Horas Extras";
                            oRo_Empleado_Novedad_Det_Info.Estado = "A";
                            oRo_Empleado_Novedad_Det_Info.NumHoras = info.hora_extra100;

                            //GUARDA EL DETALLE
                            oRo_Empleado_Novedad_Det_Bus.GrabarDB(oRo_Empleado_Novedad_Det_Info, ref mensaje);
                        }
                    }
                }


                return true;
            } 
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_AgregarNovedadPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_Nomina_X_Horas_Extras_Bus) };
            }
        
        
        }


    public ro_Nomina_X_Horas_Extras_Info Get_Info_Nomina_X_Horas_Extras(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
    {
        try {
            return oData.Get_Info_Nomina_X_Horas_Extras(idEmpresa, idEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo,ref msg);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Nomina_X_Horas_Extras", ex.Message), ex) { EntityType = typeof(ro_Nomina_X_Horas_Extras_Bus) };
        }    
    }



    public Boolean pu_AgregarNovedadPorNomina(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
    {
        try {

            //OBTENER LISTADO DE EMPLEADOS DE LA NOMINA SELECCIONADA
            List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
            oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_Info_PorNominaSaldoNegativo(idEmpresa, idNominaTipo).Where(v => v.IdEmpleado == 302).ToList(); //AQUI CAMBIAR ES DE PRUEBA
            //oListRo_Empleado_Info = ro_Empleado_Bus.GetListConsultaPorNomina(idEmpresa, idNominaTipo);

            //OBTENER EL PERIODO
            ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
            oRo_PeriodoInfo = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(idEmpresa, idNominaTipo, idNominaTipoLiqui).Where(v => v.IdPeriodo == idPeriodo).FirstOrDefault();

            //RECORRER LA NOMINA
            foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
            {
                pu_AgregarNovedadPorEmpleado(item.IdEmpresa, item.IdEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin, Convert.ToBoolean(item.es_AcreditaHorasExtras));                            
            }
            return true;
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_AgregarNovedadPorNomina", ex.Message), ex) { EntityType = typeof(ro_Nomina_X_Horas_Extras_Bus) };
        }  
    }







    }
}
