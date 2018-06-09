
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_historico_vacaciones_x_empleado_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        string mensaje = "";

        //DATA
        ro_historico_vacaciones_x_empleado_Data oRo_historico_vacaciones_x_empleado_Data = new ro_historico_vacaciones_x_empleado_Data();
        //INFO
        ro_Empleado_Info oRo_Empleado_Info = new ro_Empleado_Info();
        //BUS
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();



        public List<ro_historico_vacaciones_x_empleado_Info> ConsultarHistoricoVaca(Decimal IdEmpleado, int IdEmpresa) {
            try
            {
                return oRo_historico_vacaciones_x_empleado_Data.ConsultarHistoricoVaca(IdEmpleado, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        
        }

        public Boolean ExisteHistoricoVaca(Decimal IdEmpleado, int IdEmpresa) {
            try
            {
                return oRo_historico_vacaciones_x_empleado_Data.ExisteHistoricoVaca(IdEmpleado, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }

        public Boolean GrabaHistoricoVaca(List<ro_historico_vacaciones_x_empleado_Info> info) {
            try
            {
                return oRo_historico_vacaciones_x_empleado_Data.GrabaHistoricoVaca(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }




        public int CalcularMesesDeDiferencia(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return Math.Abs((fechaDesde.Month - fechaHasta.Month) + 12 * (fechaDesde.Year - fechaHasta.Year));
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalcularMesesDeDiferencia", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
                
            }
            
        }

        public double CalcularDiasDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
        {
            try
            {
                TimeSpan diferencia;
                diferencia = primerFecha - segundaFecha;

                return Math.Abs(diferencia.Days);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalcularDiasDeDiferencia", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }

        }

        public int CalcularAniosDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
        {
            try
            {
                return Math.Abs(primerFecha.Year - segundaFecha.Year);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
           
        }


        public List<ro_historico_vacaciones_x_empleado_Info> pu_CalcularVacaciones(ro_Empleado_Info oRo_Empleado_Info, int diasDisfrutar)
        {
            try
            {

                List<ro_historico_vacaciones_x_empleado_Info> listInfo = new List<ro_historico_vacaciones_x_empleado_Info>();

                listInfo = oRo_historico_vacaciones_x_empleado_Data.ConsultarHistoricoVaca(oRo_Empleado_Info.IdEmpleado, oRo_Empleado_Info.IdEmpresa);


                foreach (ro_historico_vacaciones_x_empleado_Info item in listInfo)
                {
                    //EXISTE SALDO
                    if (diasDisfrutar > 0 )
                    {
                        if (diasDisfrutar <= item.DiasPendientes)
                        {
                            item.DiasTomados = item.DiasTomados + diasDisfrutar;
                            diasDisfrutar = 0;
                        }
                        else
                        {
                                item.DiasTomados =item.DiasTomados + item.DiasPendientes;
                                diasDisfrutar = diasDisfrutar - item.DiasPendientes;
                        }

                        item.DiasPendientes = item.DiasGanados - item.DiasTomados;
                        item.check = true;
                    }
                    else {
                        break;
                    }
                }

                return listInfo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CalcularVacaciones", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }


        public List<ro_historico_vacaciones_x_empleado_Info> pu_RevertirVacaciones(int idEmpresa, decimal idEmpleado, int diasRevertir)
        {
            try
            {

                List<ro_historico_vacaciones_x_empleado_Info> listInfo = new List<ro_historico_vacaciones_x_empleado_Info>();

                listInfo = oRo_historico_vacaciones_x_empleado_Data.ConsultarHistoricoVaca(idEmpleado, idEmpresa);
               
                //ORDENA LA LISTA DE MANERA DESCENDENTE
                listInfo=(from a in listInfo
                          orderby a.FechaInicio descending
                          select a).ToList();


                foreach (ro_historico_vacaciones_x_empleado_Info item in listInfo)
                {
                    //EXISTE SALDO
                    if (diasRevertir > 0)
                    {
                         if(diasRevertir <=item.DiasTomados){
                             item.DiasTomados = item.DiasTomados - diasRevertir;
                             //item.DiasPendientes = item.DiasPendientes + diasRevertir;
                             diasRevertir = 0;
                         }else{
                             diasRevertir = diasRevertir - item.DiasTomados;
                             item.DiasTomados = 0;
                         }

                         item.DiasPendientes = item.DiasGanados - item.DiasTomados;

                    }
                    else
                    {
                        break;
                    }
                }

                return listInfo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_RevertirVacaciones", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }

        public Boolean GenerarVacacionesPorEmpleado(ro_Empleado_Info oRo_Empleado_Info, ref string msg)
        { 
            try
            {
                List<ro_historico_vacaciones_x_empleado_Info> listadoOriginal = new List<ro_historico_vacaciones_x_empleado_Info>();
                List<ro_historico_vacaciones_x_empleado_Info> listadoTmp = new List<ro_historico_vacaciones_x_empleado_Info>();
                
                Boolean valorRetornar = false;
                DateTime fechaActual = param.Fecha_Transac;
                DateTime fechaIngreso = Convert.ToDateTime(oRo_Empleado_Info.em_fechaIngaRol);
                DateTime fechaNueva = new DateTime();


                double dias =0;
                int meses = 0;
                int anio = 0;
                if (oRo_Empleado_Info.em_status == "EST_PLQ")
                {
                     dias = CalcularDiasDeDiferencia(fechaIngreso,Convert.ToDateTime( oRo_Empleado_Info.em_fechaSalida) );
                     meses = CalcularMesesDeDiferencia(fechaIngreso, Convert.ToDateTime(oRo_Empleado_Info.em_fechaSalida));
                     anio = CalcularAniosDeDiferencia(fechaIngreso, Convert.ToDateTime(oRo_Empleado_Info.em_fechaSalida));
                }
                else
                {
                     dias = CalcularDiasDeDiferencia(fechaIngreso, fechaActual);
                     meses = CalcularMesesDeDiferencia(fechaIngreso, fechaActual);
                     anio = CalcularAniosDeDiferencia(fechaIngreso, fechaActual);
                }
                int minAnio = 5;
                int maxDiasGanados = 15;
                int minDiasGanados = 15;

                int diasGanados = 0;
                int contDiasGanados = 0;


                
                int idSecuencia=0;

                //MODIFICA
                if (ExisteHistoricoVaca(oRo_Empleado_Info.IdEmpleado, oRo_Empleado_Info.IdEmpresa))
                {
                
                    listadoOriginal = ConsultarHistoricoVaca(oRo_Empleado_Info.IdEmpleado, oRo_Empleado_Info.IdEmpresa);

                   //CREAR ARREGLO PREVIO DE FECHAS DE VACACIONES
                    
                      fechaNueva = fechaIngreso;
                     //RECORRE LA CANTIDAD DE AÑOS QUE TIENE DE SERVICIO
                    for (int i = 0; i < anio; i++)
                    {
                        ro_historico_vacaciones_x_empleado_Info tmp = new ro_historico_vacaciones_x_empleado_Info();

                        diasGanados = minDiasGanados;
                        tmp.IdEmpresa = oRo_Empleado_Info.IdEmpresa;
                        tmp.IdEmpleado = oRo_Empleado_Info.IdEmpleado;
                        tmp.FechaInicio = fechaNueva.AddYears(i);
                        tmp.FechaFin = tmp.FechaInicio.AddYears(1).AddDays(-1);
                        tmp.DiasGanados = diasGanados;
                        tmp.DiasPendientes = diasGanados;
                        tmp.DiasTomados = 0;

                        //listadoTmp.Add(tmp);
                        int indice = -1;
                        indice = listadoOriginal.FindIndex(v => v.FechaInicio.ToShortDateString() == tmp.FechaInicio.ToShortDateString());                           
 
                        if(indice<0){//OBJETO ENCONTRADO
                            valorRetornar = oRo_historico_vacaciones_x_empleado_Data.GrabarBD(tmp, ref idSecuencia, ref msg);
                        }

                    }



                }
                else
                {//GRABAR NUEVO

                    //VALIDA SI TIENE MAS DE 1 AÑO
                    if(dias >360)
                    {

                        fechaNueva = fechaIngreso;

                        //RECORRE LA CANTIDAD DE AÑOS QUE TIENE DE SERVICIO
                        for (int i = 0; i < anio;i++ )
                        {

                            if (i < minAnio)//VALIDA LOS 5 AÑOS BASE
                            {
                                diasGanados = minDiasGanados;
                                contDiasGanados = 0;
                            }
                            else 
                            {
                                if (i >= minAnio && contDiasGanados < maxDiasGanados)//VALIDA QUE SOLO ACUMULE 30 DIAS DE VACACIONES A PARTIR DEL 5 AÑO
                                {
                                    contDiasGanados++;
                                    diasGanados = minDiasGanados + contDiasGanados;
                                }
                                else 
                                {
                                    diasGanados = 30;//DE AQUI EN ADELANTE TENDREA SOLO 30 DIAS 
                                }
                            }
                            
                            ro_historico_vacaciones_x_empleado_Info info = new ro_historico_vacaciones_x_empleado_Info();
                            info.IdEmpresa = oRo_Empleado_Info.IdEmpresa;
                            info.IdEmpleado = oRo_Empleado_Info.IdEmpleado;
                            info.FechaInicio = fechaNueva.AddYears(i);
                            info.FechaFin = info.FechaInicio.AddYears(1).AddDays(-1);
                            info.DiasGanados = diasGanados;
                            info.DiasPendientes = diasGanados;
                            info.DiasTomados = 0;

                            valorRetornar = oRo_historico_vacaciones_x_empleado_Data.GrabarBD(info, ref idSecuencia, ref msg);

                        }
                    
                    }

                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarVacacionesPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        
        }









        public Boolean GrabarBD(ro_historico_vacaciones_x_empleado_Info info,ref int id ,ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICAR
                if (oRo_historico_vacaciones_x_empleado_Data.GetExiste(info, ref msg))
                {
                    valorRetornar=oRo_historico_vacaciones_x_empleado_Data.ModificarBD(info, ref msg);
                    id = info.IdHis_Vacaciones;
                }else{//GRABAR
                   valorRetornar= oRo_historico_vacaciones_x_empleado_Data.GrabarBD(info, ref id, ref msg);                
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }


        public List<ro_Empleado_Info> GenerarVacacionesTodos(DateTime Finicio,DateTime Ffin)
        { 
            try{

                List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
                oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado(param.IdEmpresa,Finicio,Ffin);

                foreach (var item in oListRo_Empleado_Info)
                {
                    GenerarVacacionesPorEmpleado(item, ref mensaje);
                }


                foreach (var item in oListRo_Empleado_Info)
                {

                        //OBTENER FECHA DE INGRESO A LABORAR
                        DateTime fechaIngresa = new DateTime();
                        fechaIngresa = Convert.ToDateTime(item.em_fecha_ingreso);

                        //CALCULO DE DIAS TRABAJADOS
                        TimeSpan diasTrabaja = Ffin.Subtract(fechaIngresa);
                        int diasTrabajados = diasTrabaja.Days;
                        item.diasTrabajo = diasTrabajados;

                        List<ro_historico_vacaciones_x_empleado_Info> listado = new List<ro_historico_vacaciones_x_empleado_Info>();

                        listado = ConsultarHistoricoVaca(item.IdEmpleado, item.IdEmpresa);

                        //OBTENER DIAS VACACION
                        item.diasVacacion = (from a in listado
                                             select a.DiasGanados).Sum();

                        //OBTENER DIAS TOMADOS
                        item.diasTomados = (from a in listado
                                            select a.DiasTomados).Sum();

                        //OBTENER DIAS PENDIENTES
                        item.diasPendientes = (from a in listado
                                               select a.DiasPendientes).Sum();
                        item.em_fecha_Actual = DateTime.Now;
                }




                return oListRo_Empleado_Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarVacacionesTodos", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }

        public Boolean ModificarBD(int IdEmpresa, decimal idEmpleado, int dias_Tomados)
        {
            try
            {
                return oRo_historico_vacaciones_x_empleado_Data.ModificarBD(IdEmpresa, idEmpleado, dias_Tomados);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
            }
        }




    }
}
