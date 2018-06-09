using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Acta_Finiquito_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        ro_rol_detalle_x_rubro_acumulado_Bus oRo_rol_detalle_x_rubro_acumulado_Bus = new ro_rol_detalle_x_rubro_acumulado_Bus();

        DateTime _fechaInicial = new DateTime();
        DateTime _fechaFinal = new DateTime();
        double _sueldoProporcional = 0;
        double _diasPendientes = 0;
        double _otrosIngresos = 0;

        //DATA
        ro_Acta_Finiquito_Data oData = new ro_Acta_Finiquito_Data();

        //INFO
        ro_rubro_tipo_Info oRo_rubro_tipo_Info = new ro_rubro_tipo_Info();
        ro_Acta_Finiquito_Info _Info = new ro_Acta_Finiquito_Info();

        //BUS
        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
        ro_Acta_Finiquito_Detalle_Bus oRo_Acta_Finiquito_Detalle_Bus = new ro_Acta_Finiquito_Detalle_Bus();
        ro_Empleado_Novedad_Det_Bus bus_novedad = new ro_Empleado_Novedad_Det_Bus();

        // info
        ro_Parametro_calculo_Horas_Extras_Info info_parametro = new ro_Parametro_calculo_Horas_Extras_Info();
        ro_Parametro_calculo_Horas_Extras_Bus bus_parametros = new ro_Parametro_calculo_Horas_Extras_Bus();



        public ro_Acta_Finiquito_Bus() { }

        public ro_Acta_Finiquito_Bus(ro_Acta_Finiquito_Info info)
        {
            try
            {
                _Info = info;
                _fechaInicial = _Info.FechaIngreso;
                _fechaFinal = _Info.FechaSalida;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ro_Acta_Finiquito_Bus", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }

        }


        public List<ro_Acta_Finiquito_Info> GetListConsultaGeneral(int idEmpresa)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }

        }


        private Boolean GrabarDetalleBD(ro_Acta_Finiquito_Info info)
        {
            try
            {
                decimal id = 0;

                if (info.oListRo_Acta_Finiquito_Detalle_Info.Count > 0)
                {

                    oRo_Acta_Finiquito_Detalle_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, info.IdActaFiniquito, ref mensaje);

                    foreach (ro_Acta_Finiquito_Detalle_Info item in info.oListRo_Acta_Finiquito_Detalle_Info)
                    {
                        int sec = 0;
                        sec = sec + 1;
                        item.IdSecuencia = sec;
                        if (!oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje)) 
                        { 
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDetalleBD", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }



        public Boolean GrabarBD(ro_Acta_Finiquito_Info info, ref decimal id, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA
                if (oData.GetExiste(info, ref msg))
                {
                    info.IdUsuarioUltMod = param.IdUsuario;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    id = info.IdActaFiniquito;

                    if (oData.ModificarDB(info, ref msg))
                    {
                        valorRetornar = GrabarDetalleBD(info);
                    }
                }
                else
                {//GRABAR
                    info.IdUsuario = param.IdUsuario;
                    info.Fecha_Transac = param.Fecha_Transac;
                    info.IdUsuarioUltMod = param.IdUsuario;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    info.ip = param.ip;
                    info.nom_pc = param.nom_pc;
                    info.Estado = "A";

                    if (oData.GrabarBD(info, ref id, ref msg))
                    {
                        valorRetornar = GrabarDetalleBD(info);
                    }
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }

        public double CalcularDiasDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
        {
            TimeSpan diferencia;
            diferencia = primerFecha - segundaFecha;

            return Math.Abs(diferencia.Days);
        }



        private Boolean Get_sueldo_no_Pagados( )
        {
            try
            {


                if (_Info != null)
                {

                    ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();

                    List<ro_Rol_Detalle_Info> oListTo_Rol_Detalle_Info = new List<ro_Rol_Detalle_Info>();


                    oListTo_Rol_Detalle_Info = oRo_Rol_Detalle_Bus.GetListConsultaPorRubroPendiente(_Info.IdEmpresa, _Info.IdEmpleado, "950", _Info.FechaIngreso, _Info.FechaSalida, ref mensaje);
                                               

                    //TOTAL A PAGAR DEL DETALLE DE LOS ROLES NO PAGADOS(PERIODO CERRADO)
                    if (oListTo_Rol_Detalle_Info.Count > 0)
                    {
                        foreach (ro_Rol_Detalle_Info oRo_Rol_Detalle_Info in oListTo_Rol_Detalle_Info)
                        {
                            ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                            item.IdEmpresa = _Info.IdEmpresa;
                            item.IdEmpleado = _Info.IdEmpleado;
                            item.IdActaFiniquito = _Info.IdActaFiniquito;
                            item.Signo = "+";
                            item.Observacion = "Remuneración no cobrada desde el " + oRo_Rol_Detalle_Info.FechaIni.ToShortDateString() + " hasta " + oRo_Rol_Detalle_Info.FechaFin.ToShortDateString() ;
                            item.Valor =Convert.ToDouble( oRo_Rol_Detalle_Info.PendientePago);

                            //GRABA EL REGISTRO
                            oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);

                            //OBTIENE LA ULTIMA FECHA DEL PERIODO DEL ROL PROCESADO
                            _fechaInicial = oRo_Rol_Detalle_Info.FechaFin.AddDays(1);

                        }
                    }


                    
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerSueldoPendiente", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }



       
        private Boolean Get_novedades_Pendientes()
        {
            try
            {

                //OBTENER TODAS LAS NOVEDADES PENDIENTES 
                ro_Empleado_Novedad_Det_Bus oRo_Empleado_Novedad_Det_Bus = new ro_Empleado_Novedad_Det_Bus();
                List<ro_Empleado_Novedad_Det_Info> List_Empleado_Novedad_Det = new List<ro_Empleado_Novedad_Det_Info>();


                List_Empleado_Novedad_Det = oRo_Empleado_Novedad_Det_Bus.Get_List_Empleado_Novedad_Det_x_RubroPendiente(_Info.IdEmpresa, _Info.IdEmpleado, _fechaInicial, ref mensaje);

                foreach (ro_Empleado_Novedad_Det_Info item in List_Empleado_Novedad_Det)
                {
                    ro_Acta_Finiquito_Detalle_Info ifo_det = new ro_Acta_Finiquito_Detalle_Info();

                    ifo_det.IdEmpresa = _Info.IdEmpresa;
                    ifo_det.IdEmpleado = _Info.IdEmpleado;
                    ifo_det.IdActaFiniquito = _Info.IdActaFiniquito;
                    if (item.ru_tipo == "I")
                    {
                        ifo_det.Signo = "+";
                        ifo_det.Observacion= item.ru_descripcion;;
                        ifo_det.Valor = item.Valor;
                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(ifo_det, ref mensaje);
                    }
                    else
                    {
                            ifo_det.Signo = "-";
                            ifo_det.Observacion = item.ru_descripcion;
                            ifo_det.Valor = item.Valor;
                            oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(ifo_det, ref mensaje);
                        
                    }




                }


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerNovedadesPendientes", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        private Boolean Get_prestamos_Pendientes()
        {
            try
            {
                double totalPrestamo = 0;
                ro_prestamo_detalle_Bus oRo_prestamo_detalle_Bus = new ro_prestamo_detalle_Bus();

                totalPrestamo = (from a in oRo_prestamo_detalle_Bus.GetListConsultaPorEmpleado(_Info.IdEmpresa, _Info.IdEmpleado)                               
                                 select a.TotalCuota).Sum();

                if (totalPrestamo > 0)
                {
                    ro_Acta_Finiquito_Detalle_Info item3 = new ro_Acta_Finiquito_Detalle_Info();

                    item3.IdEmpresa = _Info.IdEmpresa;
                    item3.IdEmpleado = _Info.IdEmpleado;
                    item3.IdActaFiniquito = _Info.IdActaFiniquito;
                    item3.Signo = "-";
                    item3.Observacion = "Otros Descuentos por Préstamos ";
                    item3.Valor = totalPrestamo;

                    //GRABA EL REGISTRO
                    oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item3, ref mensaje);
                }


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerPrestamosPendientes", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }



        private Boolean Get_Decimos_Pendientes()
        {
            try
            {

                double totalRubroAcumulado = 0;

                if (_Info != null)
                { //PROVISION DECIMO TERCER
                    totalRubroAcumulado = (from a in oRo_rol_detalle_x_rubro_acumulado_Bus.GetListConsultaPorEmpleado(_Info.IdEmpresa, _Info.IdEmpleado, "199")                                         
                                           select a.Valor).Sum();

                    if (totalRubroAcumulado > 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Décima Tercera Remuneración ";
                        item.Valor = totalRubroAcumulado;

                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);

                    }



                    //PROVISION DECIMO CUARTO
                    totalRubroAcumulado = (from a in oRo_rol_detalle_x_rubro_acumulado_Bus.GetListConsultaPorEmpleado(_Info.IdEmpresa, _Info.IdEmpleado, "200")
                                           select a.Valor).Sum();

                    if (totalRubroAcumulado > 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Décima cuarta Remuneración ";
                        item.Valor = totalRubroAcumulado;

                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);

                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerDecimoTercerSueldoPendiente", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


       
        private Boolean Get_vacaciones()
        {
            try
            {

                
                double Rebaja_vacaciones = bus_novedad.Get_valor_rebaja_Desahucio(_Info.IdEmpresa, _Info.IdEmpleado, info_parametro.IdRubro_Rebaja_Desahucio);
                double totalRubroAcumulado = 0;

                if (_Info != null)
                {
                    totalRubroAcumulado = (from a in oRo_rol_detalle_x_rubro_acumulado_Bus.GetListConsultaPorEmpleado(_Info.IdEmpresa, _Info.IdEmpleado, "295")
                                           select a.Valor).Sum();

                    if (totalRubroAcumulado > 0)
                    {
                       
                       
                            ro_Acta_Finiquito_Detalle_Info info_va = new ro_Acta_Finiquito_Detalle_Info();
                            info_va.IdEmpresa = _Info.IdEmpresa;
                            info_va.IdEmpleado = _Info.IdEmpleado;
                            info_va.IdActaFiniquito = _Info.IdActaFiniquito;
                            info_va.Signo = "+";
                            info_va.Observacion = "Vacaciones no gozadas del último período " ;                           
                            info_va.Valor = totalRubroAcumulado;
                            oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(info_va, ref mensaje);


                        }
                    }

                
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerVacacionesPendiente", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }
        private Boolean pu_ObtenerVacacionesPendiente()
        {
            try
            {

                int Total_anio = 0;
                double valor_x_anio = 0;
                double valor_vac_min_x_anio = 0;
                double Rebaja_vacaciones = bus_novedad.Get_valor_rebaja_Desahucio(_Info.IdEmpresa, _Info.IdEmpleado, info_parametro.IdRubro_Rebaja_Desahucio);


                if (_Info != null)
                {
                    ro_rol_detalle_x_rubro_acumulado_Bus oRo_rol_detalle_x_rubro_acumulado_Bus = new ro_rol_detalle_x_rubro_acumulado_Bus();
                    //ACUMULAR LAS VACACIONES PROVISIONADAS
                    List<ro_rol_detalle_x_rubro_acumulado_Info> lista = new List<ro_rol_detalle_x_rubro_acumulado_Info>();
                    lista = oRo_rol_detalle_x_rubro_acumulado_Bus.GetListConsultaPorEmpleado(_Info.IdEmpresa, _Info.IdNomina_Tipo, _Info.IdEmpleado);


                    if (lista.Count() > 0)
                    {
                        Total_anio = lista.Count();
                        valor_vac_min_x_anio = lista.Min(v => v.Valor);
                        valor_x_anio = Rebaja_vacaciones / Total_anio;

                        if (valor_x_anio > valor_vac_min_x_anio)
                            valor_x_anio = Rebaja_vacaciones / (Total_anio - 1);
                        else
                            valor_x_anio = Rebaja_vacaciones / Total_anio;

                        //ACUMULAR LAS VACACIONES PROPORCIONAL
                        foreach (var item in lista)
                        {

                            ro_Acta_Finiquito_Detalle_Info info_va = new ro_Acta_Finiquito_Detalle_Info();
                            info_va.IdEmpresa = item.IdEmpresa;
                            info_va.IdEmpleado = item.IdEmpleado;
                            info_va.IdActaFiniquito = _Info.IdActaFiniquito;
                            info_va.Signo = "+";
                            info_va.Observacion = "Vacaciones no gozadas del último período " + item.pe_anio;
                            if (item.Valor >= valor_x_anio)
                                info_va.Valor = item.Valor - valor_x_anio;
                            else
                                info_va.Valor = item.Valor;
                            oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(info_va, ref mensaje);


                        }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerVacacionesPendiente", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        private Boolean pu_ObtenerFondoReserva()
        {
            try
            {
                //198
                double totalRubroAcumulado = 0;
                double diasTrabajados = 0;
                int cont = 0;

                if (_Info != null)
                {
                    ro_rol_detalle_x_rubro_acumulado_Bus oRo_rol_detalle_x_rubro_acumulado_Bus = new ro_rol_detalle_x_rubro_acumulado_Bus();

                    //OBTENER DIAS TRABAJADOS DEL EMPLEADO
                    diasTrabajados = CalcularDiasDeDiferencia(_Info.FechaIngreso, _Info.FechaSalida);

                    //AQUI VERIFICAR SI EL EMPLEADO ACUMULA EL FONDO DE RESERVA
                    ro_empleado_x_rubro_acumulado_Bus oRo_empleado_x_rubro_acumulado_Bus = new ro_empleado_x_rubro_acumulado_Bus();

                    cont = (from a in oRo_empleado_x_rubro_acumulado_Bus.Get_List_empleado_x_rubro_acumulado(_Info.IdEmpresa, _Info.IdEmpleado)
                            where a.IdRubro == "296"
                            select a.IdRubro).Count();

                    //Calcular Fondo de Reserva 
                    if (diasTrabajados >= 360)
                    {
                        totalRubroAcumulado = totalRubroAcumulado + (_sueldoProporcional * 0.0833);
                    }

                    //EN CASO QUE EL EMPLEADO MENSUALICE EL FONDO DE RESERVA
                    if (totalRubroAcumulado > 0 && cont == 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Fondo de Reserva";
                        item.Valor = totalRubroAcumulado;

                        //GRABA EL REGISTRO
                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerFondoReserva", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        public int CalcularAniosDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
        {
            return Math.Abs(primerFecha.Year - segundaFecha.Year);
        }


        //ART.185 DESAHUCIO
        private Boolean pu_ObtenerIndemnizacionXDesahucio()
        {
            try
            {
                int anioTrabajados = 0;
                double totalRubroAcumulado = 0;


                TimeSpan dias;
                dias = _Info.FechaSalida - _Info.FechaIngreso;

                if (dias.TotalDays < 360)
                    return false;

                anioTrabajados =Convert.ToInt32( Math.Floor(dias.TotalDays / 360));

                if (anioTrabajados < 1)

                    return false;


                //CORRESPONDE EL 25% X CADA AÑO/FRACCION DE AÑO DE TRABAJO
                totalRubroAcumulado = _Info.UltimaRemuneracion * 0.25 * anioTrabajados;


                if (totalRubroAcumulado > 0)
                {
                    ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();
                    item.IdEmpresa = _Info.IdEmpresa;
                    item.IdEmpleado = _Info.IdEmpleado;
                    item.IdActaFiniquito = _Info.IdActaFiniquito;
                    item.Signo = "+";
                    item.Observacion = "Bonificación por Desahucio según Art.185";
                    item.Valor = totalRubroAcumulado;

                    //GRABA EL REGISTRO
                    oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalcularAniosDeDiferencia", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        //ART.188 INDEMNIZACION POR DESPIDO INTEMPESTIVO
        private Boolean pu_ObtenerIndemnizacionXDespidoIntempestivo()
        {
            try
            {


                int anioTrabajados = 0;
                double totalRubroAcumulado = 0;


                anioTrabajados = CalcularAniosDeDiferencia(_Info.FechaSalida, _Info.FechaIngreso);

                if (anioTrabajados <= 3)
                {
                    totalRubroAcumulado = _Info.UltimaRemuneracion * 3; //HASTA 3 AÑOS DE TRABAJO RECIBE 3 MESES DE REMUNERACION

                }
                else
                {
                    if (anioTrabajados <= 25)
                    {//PUEDE ACUMULAR UNICAMENTE HASTA 25 MESES DE REMUNERACION X CADA AÑO DE TRABAJO
                        totalRubroAcumulado = _Info.UltimaRemuneracion * anioTrabajados;
                    }
                }

                if (totalRubroAcumulado > 0)
                {
                    ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                    item.IdEmpresa = _Info.IdEmpresa;
                    item.IdEmpleado = _Info.IdEmpleado;
                    item.IdActaFiniquito = _Info.IdActaFiniquito;
                    item.Signo = "+";
                    item.Observacion = "Indemnización por Despido Intempestivo según Art.188";
                    item.Valor = totalRubroAcumulado;

                    //GRABA EL REGISTRO
                    oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);
                }



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerIndemnizacionXDespidoIntempestivo", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        //ART.187 INDEMNIZACION POR GARANTIA PARA DIRIGENTES SINDICALES
        private Boolean pu_ObtenerIndemnizacionXDespidoDirigenteSindical()
        {
            try
            {

                double totalRubroAcumulado = 0;

                //VERIFICA SI ES DIRIGENTE SINDICAL
                if (Convert.ToBoolean(_Info.EsDirigenteSindical))
                {
                    totalRubroAcumulado = _Info.UltimaRemuneracion * 12;//EQUIVALE A 1 AÑO DE REMUNERACION

                    if (totalRubroAcumulado > 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Indemnización por Garantía Dirigentes Sindicales según Art.187";
                        item.Valor = totalRubroAcumulado;

                        //GRABA EL REGISTRO
                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerIndemnizacionXDespidoDirigenteSindical", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        //ART.187 INDEMNIZACION POR GARANTIA PARA MUJER EMBARAZADA
        private Boolean pu_ObtenerIndemnizacionXDespidoMujerEmbarazada()
        {
            try
            {

                double totalRubroAcumulado = 0;

                //VERIFICA SI ES MUJER EMBARAZADA
                if (Convert.ToBoolean(_Info.EsMujerEmbarazada))
                {
                    totalRubroAcumulado = _Info.UltimaRemuneracion * 12;//EQUIVALE A 1 AÑO DE REMUNERACION

                    if (totalRubroAcumulado > 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Indemnización por despido y declaratoria de ineficaz de la trabajadora embarazada";
                        item.Valor = totalRubroAcumulado;

                        //GRABA EL REGISTRO
                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerIndemnizacionXDespidoMujerEmbarazada", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }

        //ART.51 INDEMNIZACION POR ESTABILIDAD LABORAL - LEY DE DISCAPACIDAD
        private Boolean pu_ObtenerIndemnizacionXDespidoDiscapacitado()
        {
            try
            {

                double totalRubroAcumulado = 0;

                //VERIFICA SI ES DISCAPACITADO
                if (Convert.ToBoolean(_Info.EsPorDiscapacidad))
                {
                    totalRubroAcumulado = _Info.UltimaRemuneracion * 18;//EQUIVALE A 18 MESES DE REMUNERACION DEL MEJOR SUELDO

                    if (totalRubroAcumulado > 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Indemnización por Estabilidad Laboral Art.51 - Ley de Discapacidad";
                        item.Valor = totalRubroAcumulado;

                        //GRABA EL REGISTRO
                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerIndemnizacionXDespidoDiscapacitado", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }


        //ART.179 INDEMNIZACION POR NO RECIBIR AL TRABAJADOR EN CASO DE ENFERMEDAD NO PROFESIONAL
        private Boolean pu_ObtenerIndemnizacionXDespidoEnfermedadNoProfesional()
        {
            try
            {

                double totalRubroAcumulado = 0;

                //VERIFICA SI ES CASO DE ENFERMEDAD NO PROFESIONAL
                if (Convert.ToBoolean(_Info.EsPorEnfermedadNoProfesional))
                {
                    totalRubroAcumulado = _Info.UltimaRemuneracion * 6;//EQUIVALE A 6 MESES DE REMUNERACION

                    if (totalRubroAcumulado > 0)
                    {
                        ro_Acta_Finiquito_Detalle_Info item = new ro_Acta_Finiquito_Detalle_Info();

                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.IdActaFiniquito = _Info.IdActaFiniquito;
                        item.Signo = "+";
                        item.Observacion = "Indemnización por NO recibir al trabajador en caso de enfermedad no Profesional según Art.175 y 179";
                        item.Valor = totalRubroAcumulado;

                        //GRABA EL REGISTRO
                        oRo_Acta_Finiquito_Detalle_Bus.GrabarBD(item, ref mensaje);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerIndemnizacionXDespidoEnfermedadNoProfesional", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }





        private Boolean pu_ObtenerIndemnizacion()
        {
            try
            {

                switch (_Info.IdCausaTerminacion)
                {
                    case "144": //Por las causas legalmente previstas en el contrato
                        pu_ObtenerIndemnizacionXDesahucio();
                        break;

                    case "145": //Por acuerdo de las partes (Renuncia)
                        pu_ObtenerIndemnizacionXDesahucio();
                        break;

                    case "147": //Por muerte o incapacidad del empleador o extinción de la persona jurídica contratante
                        pu_ObtenerIndemnizacionXDespidoIntempestivo();
                        pu_ObtenerIndemnizacionXDesahucio();
                        break;

                    case "151": //Por voluntad del trabajador previo visto bueno
                        pu_ObtenerIndemnizacionXDespidoIntempestivo();
                        pu_ObtenerIndemnizacionXDesahucio();
                        break;

                    case "152": //Por desahucio
                        pu_ObtenerIndemnizacionXDesahucio();
                        break;
                }


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ObtenerIndemnizacion", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }

        }

        public Boolean pu_CalcularValoresPendientes()
        {
            try
            {
                if (_Info != null)
                {
                    oRo_Acta_Finiquito_Detalle_Bus.EliminarBD(_Info.IdEmpresa, _Info.IdEmpleado, _Info.IdActaFiniquito, ref mensaje);

                    Get_sueldo_no_Pagados();

                    Get_novedades_Pendientes();

                    Get_prestamos_Pendientes();

                    Get_Decimos_Pendientes();

                    switch (param.IdCliente_Ven_x_Default)
                    {

                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                            Get_vacaciones();
                            break;

                        default:
                            Get_vacaciones();
                            break;
                    }


                    pu_ObtenerFondoReserva();

                    pu_ObtenerIndemnizacion();

                    pu_ObtenerIndemnizacionXDespidoDirigenteSindical();

                    pu_ObtenerIndemnizacionXDespidoMujerEmbarazada();

                    pu_ObtenerIndemnizacionXDespidoDiscapacitado();

                    pu_ObtenerIndemnizacionXDespidoEnfermedadNoProfesional();

                  


                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CalcularValoresPendientes", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Bus) };

            }
        }






    }
}
