using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using IExcel = Microsoft.Office.Interop.Excel;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.Data;

using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Roles
{

    public class ro_Rol_Bus
    {
        #region variables
        //VARIABLES 
        private int _idEmpresa = 0;
        private int _idNomina = 0;
        private int _idNominaLiqui = 0;
        string mensaje = "";
        private GridControl grid = new GridControl();
        private GridView view = new GridView();
        private DataTable table = new DataTable();
        private Form formulario = new Form();
        double efe = 0;

        //INFO
        ro_periodo_Info InfoPeriodo = new ro_periodo_Info();
        ro_Rol_Info oRo_Rol_Info = new ro_Rol_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_rol_detalle_x_rubro_acumulado_Info oRo_rol_detalle_x_rubro_acumulado_Info = new ro_rol_detalle_x_rubro_acumulado_Info();
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        ro_Parametros_Bus bus_parametros = new ro_Parametros_Bus();
        ro_Parametros_Info info_parametro = new ro_Parametros_Info();
        List<ro_nomina_tipo_liqui_orden_Info> oListRo_nomina_tipo_liqui_orden_Info = new List<ro_nomina_tipo_liqui_orden_Info>();
        List<ro_Catalogo_Info> oListRo_Catalogo_Info = new List<ro_Catalogo_Info>();
        List<ro_empleado_x_ro_rubro_Info> oListRo_empleado_x_ro_rubro_Info = new List<ro_empleado_x_ro_rubro_Info>();
        List<ro_prestamo_detalle_Info> oListRo_prestamo_detalle_Info = new List<ro_prestamo_detalle_Info>();
        List<ro_Rol_Detalle_Info> oListRo_Rol_Detalle_Info = new List<ro_Rol_Detalle_Info>();
        List<ro_periodo_Info> oLst_InfoPeriodo = new List<ro_periodo_Info>();
        List<ro_rubro_tipo_Info> oListRo_rubro_tipo_Info = new List<ro_rubro_tipo_Info>();
        List<ro_empleado_x_rubro_acumulado_Info> oListRo_empleado_x_rubro_acumulado_Info = new List<ro_empleado_x_rubro_acumulado_Info>();
        List<ro_tabla_Impu_Renta_Info> oListRo_tabla_Impu_Renta_Info = new List<ro_tabla_Impu_Renta_Info>();

        List<ro_Empleado_Novedad_Det_Info> listados_novedades = new List<ro_Empleado_Novedad_Det_Info>();
        //DATA
        ro_Rol_Data oRo_Rol_Data = new ro_Rol_Data();
        //ro_Rol_Detalle_Data oRo_Rol_Detalle_Data = new ro_Rol_Detalle_Data();

        //BUS
        ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();
        ro_rol_detalle_x_rubro_acumulado_Bus oRo_rol_detalle_x_rubro_acumulado_Bus = new ro_rol_detalle_x_rubro_acumulado_Bus();
        ro_empleado_x_rubro_acumulado_Bus oRo_empleado_x_rubro_acumulado_Bus = new ro_empleado_x_rubro_acumulado_Bus();
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_ConfRubrosAcumulados_Bus oRo_ConfRubrosAcumulados_Bus = new ro_ConfRubrosAcumulados_Bus();
        ro_Empleado_Novedad_Det_Bus oEmpleadoNovedadDetBus = new ro_Empleado_Novedad_Det_Bus();
        ro_HistoricoSueldo_Bus oHistoricoSueldoBus = new ro_HistoricoSueldo_Bus();
        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_empleado_x_ro_rubro_Bus oRo_empleado_x_ro_rubro_Bus = new ro_empleado_x_ro_rubro_Bus();
        ro_prestamo_detalle_Bus oRo_prestamo_detalle_Bus = new ro_prestamo_detalle_Bus();
        ro_nomina_tipo_liqui_orden_Bus oRo_nomina_tipo_liqui_orden_Bus = new ro_nomina_tipo_liqui_orden_Bus();
        ro_Catalogo_Bus oCatalogoBus = new ro_Catalogo_Bus();
        ro_Tabla_Impu_Renta_Bus oRo_Tabla_Impu_Renta_Bus = new ro_Tabla_Impu_Renta_Bus();
        ro_rol_individual_Bus oRo_rol_individual_Bus = new ro_rol_individual_Bus();
        ro_contrato_bus oRo_contrato_bus = new ro_contrato_bus();
        ro_Area_X_Departamento_Bus oRo_Area_X_Departamento_Bus = new Roles.ro_Area_X_Departamento_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ct_Cbtecble_Bus oCt_Cbtecble_Bus = new ct_Cbtecble_Bus();
        ro_Parametros_Bus oRo_Parametros_Bus = new ro_Parametros_Bus();
        ro_periodo_Bus BusPeriodo = new ro_periodo_Bus();
        ro_DiasFaltados_x_Empleado_Bus Bus_Dias_Faltados = new ro_DiasFaltados_x_Empleado_Bus();
        ro_permiso_x_empleado_Bus BusPermisoEmpleado = new ro_permiso_x_empleado_Bus();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
        ro_empleado_x_Proyeccion_Gastos_Personales_Bus Gastos_Personales_Bus = new ro_empleado_x_Proyeccion_Gastos_Personales_Bus();
        List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_calculo_variable = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();
        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus bus_efectividad_calculo_variable = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus();

        ro_Grupo_empleado_Bus bus_grupo_empleado = new ro_Grupo_empleado_Bus();
        ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus bus_cuenta_contable_sueldo_x_pagar = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus();


        ro_Config_Param_contable_Bus oRo_Config_Param_contable_Bus = new Roles.ro_Config_Param_contable_Bus();
        List<ro_Config_Param_contable_Info> oListRo_Config_Param_contable_Info = new List<Info.Roles.ro_Config_Param_contable_Info>();



        ro_SolicitudVacaciones_Bus bus_vacaciones = new ro_SolicitudVacaciones_Bus();
        ro_SolicitudVacaciones_Info info_vacaciones = new ro_SolicitudVacaciones_Info();
         
#endregion


        public ro_Rol_Bus()
        {
        }

        public ro_Rol_Bus(ro_Rol_Info info, ro_periodo_x_ro_Nomina_TipoLiqui_Info roPeriodo_Info)
        { 
        try{
            oRo_Rol_Info = info;
            oRo_PeriodoInfo = roPeriodo_Info;
            _idEmpresa = oRo_Rol_Info.IdEmpresa;
            _idNomina = oRo_Rol_Info.IdNominaTipo;
            _idNominaLiqui = oRo_Rol_Info.IdNominaTipoLiqui;

            
            pu_CrearGrillaFormula();
            lista_efectividad_calculo_variable = bus_efectividad_calculo_variable.lista_efectividad_x_periodo_x_empleado(_idEmpresa, _idNomina, roPeriodo_Info.IdPeriodo);
               
        //   listados_novedades= oEmpleadoNovedadDetBus.Get_List_Novedad_x_Periodo(param.IdEmpresa, _idNomina, _idNominaLiqui, roPeriodo_Info.pe_FechaIni, roPeriodo_Info.pe_FechaFin);

            info_parametro = bus_parametros.Get_Parametros(param.IdEmpresa);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ro_Rol_Bus", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
        }
        
        }

        public ro_Rol_Bus(int idEmpresa, int idNomina, int idNominaLiqui, ro_periodo_x_ro_Nomina_TipoLiqui_Info roPeriodo_Info)
        {
         try{
                _idEmpresa = idEmpresa;
                _idNomina = idNomina;
                _idNominaLiqui = idNominaLiqui;
                oRo_PeriodoInfo = roPeriodo_Info;
                pu_CrearGrillaFormula();
            
         }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ro_Rol_Bus", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public List<ro_Rol_Info> GetListConsultaGeneral(int idEmpresa, ref string msg) {
            try
            {
                return oRo_Rol_Data.GetListConsultaGeneral(idEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public ro_Rol_Info GetInfoConsultaPorRol(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg) {
            try
            {
                return oRo_Rol_Data.GetInfoConsultaPorRol(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoConsultaPorRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        
        }

        
        public Boolean GetExiste(ro_Rol_Info info, ref string msg) {
            try
            {
                return oRo_Rol_Data.GetExiste(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetExiste", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }
  

        public Boolean GuardarBD(ro_Rol_Info infoCabecera, List<ro_Rol_Detalle_Info> infoDetalle, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICAR CABECERA
                if (GetExiste(infoCabecera, ref mensaje))
                {
                    infoCabecera.FechaModifica = param.Fecha_Transac;
                    infoCabecera.UsuarioModifica = param.IdUsuario;

                    valorRetornar = oRo_Rol_Data.ModificarBD(infoCabecera, ref mensaje);
                }
                else
                { //GRABAR CABECERA
                    infoCabecera.Cerrado = "N";
                    infoCabecera.FechaIngresa = param.Fecha_Transac;
                    infoCabecera.UsuarioIngresa = param.IdUsuario;

                    valorRetornar = oRo_Rol_Data.GuardarBD(infoCabecera, ref mensaje);
                }

                //VALIDA ANTES DE GUARDAR EL DETALLE
                if (valorRetornar)
                {
                    //RECORRE EL DETALLE DE ITEMS
                    foreach (ro_Rol_Detalle_Info item in infoDetalle)
                    {
                        //MODIFICA DETALLE
                        if (oRo_Rol_Detalle_Bus.GetExiste(item, ref mensaje))
                        {
                            valorRetornar = oRo_Rol_Detalle_Bus.ModificarBD(item, ref mensaje);
                        }
                        else
                        {//ACTUALIZA DETALLE
                            valorRetornar = oRo_Rol_Detalle_Bus.GuardarBD(item, ref mensaje);
                        }
                    }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }

        }


        public Boolean GuardarBD(ro_Rol_Info infoCabecera,ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICAR CABECERA
                if (GetExiste(infoCabecera, ref mensaje)){
                    infoCabecera.FechaModifica = param.Fecha_Transac;
                    infoCabecera.UsuarioModifica = param.IdUsuario;

                    valorRetornar = oRo_Rol_Data.ModificarBD(infoCabecera, ref mensaje);
                }else { //GRABAR CABECERA
                    infoCabecera.Cerrado = "N";
                    infoCabecera.FechaIngresa = param.Fecha_Transac;
                    infoCabecera.UsuarioIngresa = param.IdUsuario;

                    valorRetornar = oRo_Rol_Data.GuardarBD(infoCabecera, ref mensaje);                  
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }

        }

        public Boolean GuardarBD( ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                if (oRo_Rol_Info!=null) { 
                //MODIFICAR CABECERA
                if (GetExiste(oRo_Rol_Info, ref msg))
                {
                    oRo_Rol_Info.FechaModifica = param.Fecha_Transac;
                    oRo_Rol_Info.UsuarioModifica = param.IdUsuario;

                    valorRetornar = oRo_Rol_Data.ModificarBD(oRo_Rol_Info, ref msg);
                }
                else
                { //GRABAR CABECERA
                    oRo_Rol_Info.Cerrado = "N";
                    oRo_Rol_Info.FechaIngresa = param.Fecha_Transac;
                    oRo_Rol_Info.UsuarioIngresa = param.IdUsuario;

                    valorRetornar = oRo_Rol_Data.GuardarBD(oRo_Rol_Info, ref msg);
                }

            }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }

        }


        public double GetDias360(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                fechaFin = Convert.ToDateTime(fechaFin.ToShortDateString()).AddDays(1);
                fechaIni = Convert.ToDateTime(fechaIni.ToShortDateString());

                double valorRetornar = 0;
                TimeSpan dias;
                dias = fechaFin - fechaIni;
                valorRetornar = dias.TotalDays;
                int dia = fechaIni.Day;
                if (valorRetornar > 30 || dia>30)
                    valorRetornar = valorRetornar - 1;
               
                /*
                int dias_fecha_fin = DateTime.DaysInMonth(fechaFin.Year, fechaFin.Month);             
                IExcel.Application myxl = new Microsoft.Office.Interop.Excel.Application();
                IExcel.WorksheetFunction wsf = myxl.WorksheetFunction;
                TimeSpan tie = fechaFin.Subtract(fechaFin);
                if (fechaIni.Month == 2 && fechaFin.Month == 3)
                {
                    int daysInFeb = System.DateTime.DaysInMonth(fechaIni.Year, fechaIni.Month);
                    DateTime Fecha_Fin_mes = Convert.ToDateTime(daysInFeb + "/" + fechaIni.Month + "/" + fechaIni.Year);
                    DateTime Fecha_Inicio_mes = Convert.ToDateTime("01" + "/" + fechaFin.Month + "/" + fechaFin.Year);
                    valorRetornar = +wsf.Days360(fechaIni, Fecha_Fin_mes.AddDays(1), false);// obtengo los dias del mes de febreo
                    valorRetornar = valorRetornar + wsf.Days360(Fecha_Inicio_mes, fechaFin.AddDays(1), false);// obtengo los dias del mes siguiente
                  
                    valorRetornar = valorRetornar - 2;
                }
                else
                 {

                  valorRetornar = wsf.Days360(fechaIni, fechaFin.AddDays(1),false);
                }
                if (fechaIni.Month != fechaFin.Month && valorRetornar == 6 && _idNomina==2)
                {
                    valorRetornar = valorRetornar + 1;
                }

                if (dias_fecha_fin == fechaFin.Day && valorRetornar == 6 && _idNomina==2)
                {
                    valorRetornar = valorRetornar + 1;
                }
               */
                return valorRetornar;

                

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDias360", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }

        public double GetDiasFaltados(int idEmpresa, decimal idEmpleado, DateTime fechaInicial, DateTime fechaFinal)
        {
            try {
                double valorRetornar = 0;




                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDiasFaltados", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }        
        }


        public double GetDiasTrabajados360(int idEmpresa, DateTime fechaInicioLaboral,DateTime fechaInicial, DateTime fechaFinal)
        {
            try
            {
                double valorRetornar = 0;
               
                //OBTIENE LOS DIAS TRABAJADOS DIAS360
                if (fechaInicioLaboral >= fechaInicial)
                {
                    valorRetornar = GetDias360(fechaInicioLaboral, fechaFinal);
                }
                else
                {
                    valorRetornar = GetDias360(fechaInicial, fechaFinal);
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDiasTrabajados360", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public double GetDiasTrabajadosPorRubro(ro_Empleado_Info info, string idRubro)
        {
            try
            {
                double valorRetornar = 0;
               // DateTime fechaInicioLaboral = new DateTime();


                //OBTIENE LA FECHA INICIAL Y FINAL DE RUBROS ACUMULADOS
                ro_ConfRubrosAcumulado_Info oRo_ConfRubrosAcumulado_Info = new ro_ConfRubrosAcumulado_Info();
                oRo_ConfRubrosAcumulado_Info = oRo_ConfRubrosAcumulados_Bus.GetConsultaPorId(info.IdEmpresa, idRubro);

                //VALIDA QUE LA FECHA DE ACUMULACION FINAL DE RUBRO SEA MAYOR AL DE LA FECHA FINAL DE LA LIQUDIACION
                if (oRo_PeriodoInfo.pe_FechaFin <= oRo_ConfRubrosAcumulado_Info.FechaFin)
                {

                    //OBTIENE LOS DIAS TRABAJADOS DIAS360
                    if (info.em_fechaIngaRol >= oRo_ConfRubrosAcumulado_Info.FechaInicio && info.em_fechaIngaRol <= oRo_ConfRubrosAcumulado_Info.FechaFin)
                    {
                        valorRetornar = GetDias360(Convert.ToDateTime(info.em_fechaIngaRol),Convert.ToDateTime( oRo_ConfRubrosAcumulado_Info.FechaFin));//CALCULA EL PROPORCIONAL
                    }
                    else
                    {
                        if (info.em_fechaIngaRol < oRo_ConfRubrosAcumulado_Info.FechaInicio)
                        {
                            valorRetornar = GetDias360(Convert.ToDateTime( oRo_ConfRubrosAcumulado_Info.FechaInicio),Convert.ToDateTime( oRo_ConfRubrosAcumulado_Info.FechaFin));
                        }
                    }

                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDiasTrabajadosPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public double GetDiasTrabajadosMensualPorRubro(ro_Empleado_Info info, string idRubro)
        {
            try
            {
                double valorRetornar = 0;

                //OBTIENE LA FECHA INICIAL Y FINAL DE RUBROS ACUMULADOS
                ro_ConfRubrosAcumulado_Info oRo_ConfRubrosAcumulado_Info = new ro_ConfRubrosAcumulado_Info();
                oRo_ConfRubrosAcumulado_Info = oRo_ConfRubrosAcumulados_Bus.GetConsultaPorId(info.IdEmpresa, idRubro);

                //VALIDA QUE LA FECHA DE ACUMULACION FINAL DE RUBRO SEA MAYOR AL DE LA FECHA FINAL DE LA LIQUDIACION

                if (info.em_status == "EST_ACT")
                {
                    if (oRo_PeriodoInfo.pe_FechaFin <= oRo_ConfRubrosAcumulado_Info.FechaFin)
                    {
                        //OBTIENE LOS DIAS TRABAJADOS DIAS360
                        if (info.em_fecha_inicio_contrato_Actual >= oRo_ConfRubrosAcumulado_Info.FechaInicio && info.em_fechaIngaRol <= oRo_ConfRubrosAcumulado_Info.FechaFin)
                        {
                            if (info.em_fecha_inicio_contrato_Actual >= oRo_PeriodoInfo.pe_FechaIni && info.em_fecha_inicio_contrato_Actual <= oRo_PeriodoInfo.pe_FechaFin) //CALCULA EL PROPORCIONAL                        
                            {
                                valorRetornar = GetDias360(Convert.ToDateTime(info.em_fecha_inicio_contrato_Actual), oRo_PeriodoInfo.pe_FechaFin);
                            }
                            else
                            {
                                if (info.em_fecha_inicio_contrato_Actual < oRo_PeriodoInfo.pe_FechaIni)
                                {
                                    valorRetornar = GetDias360(oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin);
                                }

                            }
                        }

                        else
                        {
                            if (info.em_fecha_ingreso > oRo_PeriodoInfo.pe_FechaIni)
                            {
                                valorRetornar = GetDias360(Convert.ToDateTime(info.em_fecha_ingreso), oRo_PeriodoInfo.pe_FechaFin);

                            }
                            else

                                valorRetornar = GetDias360(oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin);
                        }



                    }

                }


                if (info.em_status == "EST_VAC")
                {
                    if (oRo_PeriodoInfo.pe_FechaFin <= oRo_ConfRubrosAcumulado_Info.FechaFin)
                    {
                        //OBTIENE LOS DIAS TRABAJADOS DIAS360
                        if (info.em_fechaIngaRol >= oRo_ConfRubrosAcumulado_Info.FechaInicio && info.em_fechaIngaRol <= oRo_ConfRubrosAcumulado_Info.FechaFin)
                        {
                            if (info.em_fechaIngaRol >= oRo_PeriodoInfo.pe_FechaIni && info.em_fechaIngaRol <= oRo_PeriodoInfo.pe_FechaFin) //CALCULA EL PROPORCIONAL                        
                            {
                                valorRetornar = GetDias360(Convert.ToDateTime(info.em_fechaIngaRol), oRo_PeriodoInfo.pe_FechaFin);
                            }
                            else
                            {
                                if (info.em_fechaIngaRol < oRo_PeriodoInfo.pe_FechaIni)
                                {
                                    valorRetornar = GetDias360(oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin);
                                }

                            }
                        }

                        else
                        {
                            if (info.em_fecha_ingreso > oRo_PeriodoInfo.pe_FechaIni)
                            {
                                valorRetornar = GetDias360(Convert.ToDateTime(info.em_fecha_ingreso), oRo_PeriodoInfo.pe_FechaFin);

                            }
                            else

                                valorRetornar = GetDias360(oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin);
                        }



                    }

                }


                if (info.em_status == "EST_PLQ" || info.em_status == "EST_VB")
                {
                    if (info.em_status == "EST_VB")
                    {
                        if (oRo_PeriodoInfo.pe_FechaFin > info.em_fechaSalida)
                        {
                           return valorRetornar = 0;
                        }

                        if (info.em_fechaSalida < oRo_PeriodoInfo.pe_FechaFin)
                        {
                            return valorRetornar = 0;
                        }

                    }
                    else
                    {
                        if (info.em_fechaIngaRol > oRo_PeriodoInfo.pe_FechaIni)
                        {
                            return valorRetornar = GetDias360(Convert.ToDateTime( info.em_fechaIngaRol), Convert.ToDateTime(info.em_fechaSalida));
                        }
                        else

                       return valorRetornar = GetDias360(oRo_PeriodoInfo.pe_FechaIni, Convert.ToDateTime(info.em_fechaSalida));
                    }

                   

                }

              

                if (valorRetornar < 0)
                    valorRetornar = 0;


              

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDiasTrabajadosMensualPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }

        public double GetValorAcumuladoPorRubro(int idEmpresa, decimal idEmpleado, int idNominaTipo, string idRubro)
        {
            try
            {
                double valorRetornar = 0;

                //OBTIENE LA FECHA INICIAL Y FINAL DE RUBROS ACUMULADOS
                ro_ConfRubrosAcumulado_Info oRo_ConfRubrosAcumulado_Info = new ro_ConfRubrosAcumulado_Info();
                oRo_ConfRubrosAcumulado_Info = oRo_ConfRubrosAcumulados_Bus.GetConsultaPorId(idEmpresa, idRubro);

                
                //OBTIENE LA SUMATORIA DEL RUBRO ESPECIFICO EN EL PERIODO DE FECHAS SELECCIONADO
                if (_idNomina == 1 && _idNominaLiqui == 3 || _idNomina == 2 && _idNominaLiqui == 2)
                {
                    idRubro = "4";
                }
                valorRetornar = oRo_Rol_Detalle_Bus.GetValorAcumuladoPorRubro(idEmpresa, idEmpleado, idNominaTipo, idRubro,  Convert.ToDateTime( oRo_ConfRubrosAcumulado_Info.FechaInicio),Convert.ToDateTime( oRo_ConfRubrosAcumulado_Info.FechaFin), ref mensaje);
                return valorRetornar;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetValorAcumuladoPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }
     

        public double GetPermiteRubroAcumulado(int idEmpresa, decimal idEmpleado, string idRubro)
        {
            try
            {
            
            double valorRetornar = 0;
  
            //OBTIENE LOS RUBROS QUE PUEDE PROVISIONAR
            int cont = oRo_empleado_x_rubro_acumulado_Bus.Get_List_empleado_x_rubro_acumulado(_idEmpresa, idEmpleado).Where(a => a.IdRubro == idRubro).Count();

                if (cont > 0)
                {
                    valorRetornar = 1;
                }
                else
                {
                    valorRetornar = 0;
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetPermiteRubroAcumulado", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public double GetDiasFaltados()
        {
            try
            {
                double valorRetornar = 0;
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDiasFaltados", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public double GetSueldoBasico(int idEmpresa, decimal idEmpleado)
        {
            try
            {
                
                return oHistoricoSueldoBus.Get_sueldo_actual(idEmpresa, idEmpleado);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetSueldoBasico", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public double GetAnticipoSueldo(ro_Empleado_Info info )
        {
            try
            {
                double valorRetornar = 0;
                double sueldo = oHistoricoSueldoBus.Get_List_HistoricoSueldo(info.IdEmpresa,info.IdEmpleado).FirstOrDefault().SueldoActual;

                switch (info.IdTipoAnticipo) { 
                    case "ANT01"://POR DEFAULT
                        ro_Nomina_Tipoliqui_x_Sueldo_Bus oRro_Nomina_Tipoliqui_x_Sueldo_Bus = new ro_Nomina_Tipoliqui_x_Sueldo_Bus();
                        ro_Nomina_Tipoliqui_x_Sueldo_Info oRo_Nomina_Tipoliqui_x_Sueldo_Info=new Info.Roles.ro_Nomina_Tipoliqui_x_Sueldo_Info();

                        oRo_Nomina_Tipoliqui_x_Sueldo_Info = oRro_Nomina_Tipoliqui_x_Sueldo_Bus.ConsultaTipoLiquixSueldo(param.IdEmpresa).Where(v => v.IdNomina_Tipo == _idNomina && v.IdNomina_TipoLiqui == _idNominaLiqui).FirstOrDefault();

                        valorRetornar = Convert.ToDouble(sueldo * oRo_Nomina_Tipoliqui_x_Sueldo_Info.PorSueldo * 0.01);

                        break;

                    case "ANT02"://POR VALOR
                        valorRetornar = Convert.ToDouble(info.em_AnticipoSueldo);
                        break;

                    case "ANT03"://POR PORCENTAJE
                        valorRetornar = sueldo * Convert.ToDouble(info.em_AnticipoSueldo) * 0.01;
                        break;   

                   
                      
                }

                if (Convert.ToBoolean(info.es_TruncarDecimalAnticipo))
                {
                    valorRetornar = Math.Truncate(valorRetornar); //TRUNCA LOS DECIMALES Y DEVUELVE SOLO LA PARTE ENTERA
                }


                return valorRetornar;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetAnticipoSueldo", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public string GetSubString (string cadena, char carInicio, char carFinal)
    {
       string result = "";
       int posInicio=0;

       posInicio = cadena.IndexOf(carInicio)+1;

       for (int i = posInicio; i < cadena.Length;i++ )
       {
           if (cadena[i] != carFinal)
           {
               result += cadena[i];
           }
           else {
               break;
           }

       }
       return result;
    }


        public int CalcularMesesDeDiferencia(DateTime fechaDesde, DateTime fechaHasta)
    {
        return Math.Abs((fechaDesde.Month - fechaHasta.Month) + 12 * (fechaDesde.Year - fechaHasta.Year));
    }

        public double CalcularDiasDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
    {
        TimeSpan diferencia;
        diferencia = primerFecha - segundaFecha;

        return Math.Abs(diferencia.Days);
    }


        public double pu_DiasAntiguedad(ro_Empleado_Info info)
    {
        try
        {
            double valorDevolver = 0;

            List<ro_contrato_Info> oListRo_contrato_Info = new List<ro_contrato_Info>();

            //OBTENGO TODOS LOS CONTRATOS ACTIVOS DEL EMPLEADO
            oListRo_contrato_Info = oRo_contrato_bus.GetListPorEmpleado(info.IdEmpresa,info.IdEmpleado).Where(v=>v.Estado=="A").ToList();

            foreach (ro_contrato_Info item in oListRo_contrato_Info)
            {
                //CONTRATOS LIQUIDADOS - HISTORICOS
                if (item.EstadoContrato == "ECT_LIQ")
                {
                    valorDevolver += CalcularDiasDeDiferencia(Convert.ToDateTime(item.FechaInicio), Convert.ToDateTime(oRo_PeriodoInfo.pe_FechaFin));            
                }
                else if (item.EstadoContrato == "ECT_ACT")//CONTRATO VIGENTE O ACTUAL DEL EMPLEADO
                {
                  //  valorDevolver += CalcularDiasDeDiferencia(Convert.ToDateTime(item.FechaInicio), oRo_PeriodoInfo.pe_FechaFin);
                    valorDevolver += CalcularDiasDeDiferencia(oRo_PeriodoInfo.pe_FechaFin,Convert.ToDateTime(item.FechaInicio));
                }
            }


            //CalcularDiasDeDiferencia(Convert.ToDateTime(info.em_fechaIngaRol), Convert.ToDateTime(oRo_PeriodoInfo.pe_FechaFin));

            return valorDevolver;
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_DiasAntiguedad", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
        }

    }


        public double pu_DiasDecimoCuarto(ro_Empleado_Info info, string idRubro)
    {
        try
        {
       


            
            return CalcularDiasDeDiferencia(Convert.ToDateTime(info.em_fechaIngaRol), Convert.ToDateTime(oRo_PeriodoInfo.pe_FechaFin));
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_DiasDecimoCuarto", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
        }

    }


        public double GetProcesarFuncion(string nombreFuncion,ro_Empleado_Info info, int idNomina, int idNominaLiqui, string idRubro, DateTime fechaIni, DateTime fechaFin, ref string msg)
        {
            try
            {

                double valorRetornar = 0;
                ro_rubro_tipo_Info item=new ro_rubro_tipo_Info();

                //VERIFICA FUNCIONES CON 1 PARAMETRO
                string subCadena = "";

                if(nombreFuncion.Contains("ESTADO_EMPLEADO"))
                {
                    subCadena= GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                   nombreFuncion = "ESTADO_EMPLEADO()"; 
                }

                if (nombreFuncion.Contains("DIAS_VACACIONES"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_VACACIONES()";
                }

                if (nombreFuncion.Contains("ACUMULADO"))
                {
                   subCadena= GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                   nombreFuncion = "ACUMULADO()"; 
                }

                if (nombreFuncion.Contains("DIAS_TRA_RUBRO"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_TRA_RUBRO()";
                }

                if (nombreFuncion.Contains("DIAS_TRA_MENSUAL_RUBRO"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_TRA_MENSUAL_RUBRO()";
                }

                if (nombreFuncion.Contains("DIAS_TRABAJADOS"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_TRABAJADOS()";
                }

                if (nombreFuncion.Contains("PERMITE_ACUMULAR"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "PERMITE_ACUMULAR()";
                }


                if (nombreFuncion.Contains("DIAS_FALTADOS()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_FALTADOS()";
                }

                if (nombreFuncion.Contains("OBTENER_DIAS_PAGADO_SUBSIDIO()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "OBTENER_DIAS_PAGADO_SUBSIDIO()";
                }


                if (nombreFuncion.Contains("IMPUESTO_RENTA()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "IMPUESTO_RENTA()";
                }

                if (nombreFuncion.Contains("ANTICIPO_SUELDO()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "ANTICIPO_SUELDO()";
                }

                if (nombreFuncion.Contains("DIAS_EFECTIVOS()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_EFECTIVOS()";
                }
                if (nombreFuncion.Contains("DIAS_SABADO_Y_DOMINGOS()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_SABADO_Y_DOMINGOS()";
                }
                if (nombreFuncion.Contains("DIAS_INTEGRALES_MES()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "DIAS_INTEGRALES_MES()";
                }

                if (nombreFuncion.Contains("VALOR_BONO_CALCULO_VARIABLE()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "VALOR_BONO_CALCULO_VARIABLE()";
                }

                if (nombreFuncion.Contains("PAGO_FONDO_RESERVA()"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "PAGO_FONDO_RESERVA()";
                }


                if (nombreFuncion.Contains("ANTICIPO_QUINCENA"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "ANTICIPO_QUINCENA()";
                }




                if (nombreFuncion.Contains("OBTENER_DECIMA_TERCERA"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "OBTENER_DECIMA_TERCERA()";
                }





                if (nombreFuncion.Contains("OBTENER_DECIMA_CUARTA"))
                {
                    subCadena = GetSubString(nombreFuncion, Convert.ToChar("["), Convert.ToChar("]"));
                    nombreFuncion = "OBTENER_DECIMA_CUARTA()";
                }


                //

                switch (nombreFuncion)
                {
                    #region ESTADO_EMPLEADO
                    case "ESTADO_EMPLEADO()":
                        if (info.em_status == "EST_VAC")
                        {
                            valorRetornar = 1;
                        }
                        else
                        {
                            if (info.em_status == "EST_SUB")
                            {
                                valorRetornar = 2;
                               
                            }
                            else
                            {

                                valorRetornar = 0;
                            }
                        }
                     break;
                    #endregion
                    case "SUELDO_BASICO()":
                        valorRetornar = GetSueldoBasico(info.IdEmpresa, info.IdEmpleado);
                        break;
                    #region OBTENER_NOVEDAD
                    case "OBTENER_NOVEDAD()":
                        
                        if (info.Marca_Biometrico == true)
                        {
                            if(idRubro=="1008")
                            {
                            }

                            if (idRubro != "74" && idRubro != "68")
                            {

                                valorRetornar = oEmpleadoNovedadDetBus.GetValorAcumuladoNovedadPorNomina(info.IdEmpresa, info.IdEmpleado, idNomina, idNominaLiqui, idRubro, fechaIni, fechaFin, ref msg);
                            }
                            else
                            {
                                if (idRubro == "74")
                                {
                                    valorRetornar = Convert.ToDouble(info.Alimentacion * info.Dias_Efectivos);
                                }
                                if (idRubro == "68")
                                {
                                    valorRetornar = Convert.ToDouble(info.Transporte * info.Dias_Efectivos);
                                }
                            }
                        }
                            else
                            {
                           valorRetornar = oEmpleadoNovedadDetBus.GetValorAcumuladoNovedadPorNomina(info.IdEmpresa, info.IdEmpleado, idNomina, idNominaLiqui, idRubro, fechaIni, fechaFin, ref msg);
                            }
                                break;

                    #endregion
                    case "DIAS_TRA_RUBRO()":
                        item = oRo_rubro_tipo_Bus.GetInfoConsultaPorCodigoRol(param.IdEmpresa, subCadena);
                        valorRetornar = GetDiasTrabajadosPorRubro(info,item.IdRubro);   
                        break;

                    case "DIAS_TRA_MENSUAL_RUBRO()":
                        item = oRo_rubro_tipo_Bus.GetInfoConsultaPorCodigoRol(param.IdEmpresa, subCadena);
                        valorRetornar = GetDiasTrabajadosMensualPorRubro(info,item.IdRubro);
                        if (valorRetornar < 0)
                            valorRetornar = 0;

                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.FJ)
                        {
                            if (info.em_status == "EST_VB")
                            {
                                valorRetornar = 0;
                            }


                            if (info.em_status == "EST_PLQ")
                            {
                                if (valorRetornar < info_parametro.Dias_considerado_ultimo_pago_quincela_Liq && _idNominaLiqui == 1)
                                {
                                    valorRetornar = 0;
                                }
                            }

                        }
                        break;


                    case "DIAS_TRABAJADOS()": 

                                           
                        valorRetornar = GetDiasTrabajados360(info.IdEmpresa, Convert.ToDateTime(info.em_fechaIngaRol), Convert.ToDateTime("01/01/"+ oRo_PeriodoInfo.pe_FechaIni.Year), Convert.ToDateTime(oRo_PeriodoInfo.pe_FechaFin));

                        break;

                    case "DIAS_ANTIGUEDAD()":
                        valorRetornar = pu_DiasAntiguedad(info);
                        break;                    

                    case "DIAS_FALTADOS()":
                        valorRetornar = Bus_Dias_Faltados.Get_Dias_Faltados_x_Periodo(_idEmpresa,Convert.ToInt32( info.IdEmpleado), fechaIni, fechaFin);
                        break;


                    case "OBTENER_DIAS_PAGADO_SUBSIDIO()":
                        if (info.em_status == "EST_SUB")
                        {
                            valorRetornar = pu_DiasSubsidio(param.IdEmpresa, Convert.ToInt32(info.IdEmpleado), fechaIni, fechaFin);
                        }
                        break;


                    case "ACUMULADO()":
                        item = oRo_rubro_tipo_Bus.GetInfoConsultaPorCodigoRol(param.IdEmpresa, subCadena);
                        if (_idNomina == 1 && _idNominaLiqui == 3 || _idNomina == 2 && _idNominaLiqui == 2)
                        {
                            item.IdRubro = "290";
                        }
                        valorRetornar = GetValorAcumuladoPorRubro(info.IdEmpresa, info.IdEmpleado, idNomina, item.IdRubro);
                        break;

                    case "PERMITE_ACUMULAR()":
                        item = oRo_rubro_tipo_Bus.GetInfoConsultaPorCodigoRol(param.IdEmpresa, subCadena);
                        valorRetornar = GetPermiteRubroAcumulado(info.IdEmpresa, info.IdEmpleado, item.IdRubro);
                        break;


                    case "ANTICIPO_SUELDO()":                       
                        valorRetornar = GetAnticipoSueldo(info);
                        break;

                    case "IMPUESTO_RENTA()":
                        valorRetornar=Convert.ToDouble( Provision_Impuesto_Renta_Mensual(info.IdEmpresa, oRo_PeriodoInfo.IdNomina_Tipo, oRo_PeriodoInfo.IdNomina_TipoLiqui,Convert.ToInt32( info.IdEmpleado), oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin,Convert.ToDecimal( info.SueldoActual)));
                        break;
                    //DIAS_EFECTIVOS FJ
                    case "DIAS_EFECTIVOS()":
                        valorRetornar = Convert.ToDouble(info.Dias_Efectivos);
                         break;
                    //
                    case "DIAS_SABADO_Y_DOMINGOS()":
                        valorRetornar =Convert.ToDouble( info.Dias_SyD);
                        break;

                    //DIAS_INTEGRALES_MES

                    case "DIAS_INTEGRALES_MES()":
                        valorRetornar =Get_Dias_Integrales(oRo_PeriodoInfo.pe_FechaIni,oRo_PeriodoInfo.pe_FechaFin);
                        break;

                    //VALOR_BONO_CALCULO_VARIABLE
                    case "VALOR_BONO_CALCULO_VARIABLE()":
                        valorRetornar = bus_grupo_empleado.Get_valor_bono(info.IdEmpresa,Convert.ToInt32( info.IdGrupo));
                        break;

                    case "PAGO_FONDO_RESERVA()":
                        valorRetornar = oRo_Rol_Detalle_Bus.Get_Valor_Fondo_Reserva_x_periodo_x_nomina(info.IdEmpresa, info.IdNomina_Tipo, oRo_PeriodoInfo.IdNomina_TipoLiqui, Convert.ToInt32( info.IdEmpleado), oRo_PeriodoInfo.IdPeriodo);
                        break;

                    case "ANTICIPO_QUINCENA()":
                        string _perio = oRo_PeriodoInfo.IdPeriodo.ToString() + "01";
                        int idnomiTipoLiq = oRo_PeriodoInfo.IdNomina_TipoLiqui - 1;
                        valorRetornar = oRo_Rol_Detalle_Bus.Get_Valor_Anticipo(info.IdEmpresa, info.IdNomina_Tipo, idnomiTipoLiq, Convert.ToInt32(info.IdEmpleado),Convert.ToInt32( _perio));
                        break;

                    case "DIAS_VACACIONES()":
                        if (info.em_status == "EST_VAC")
                        valorRetornar= bus_vacaciones.Get_Dias_Vacaciones(info.IdEmpresa,info.IdNomina_Tipo,Convert.ToInt32( info.IdEmpleado),oRo_PeriodoInfo.pe_FechaIni,oRo_PeriodoInfo.pe_FechaFin);
                        break;



                        // decimos   



                    case "OBTENER_DECIMA_CUARTA()":
                        valorRetornar = oRo_Rol_Detalle_Bus.Get_Decimotcuarta(info.IdEmpresa,oRo_PeriodoInfo.pe_FechaIni,oRo_PeriodoInfo.pe_FechaFin, info.IdEmpleado);
                        break;

                    case "OBTENER_DECIMA_TERCERA()":
                        valorRetornar = oRo_Rol_Detalle_Bus.Get_Decimoterceo(info.IdEmpresa, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin, info.IdEmpleado);
                        break;

                }


                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetProcesarFuncion", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }

        }


        private void pu_GetRubroFijo(decimal idEmpleado)
        {
            try
            {

                double valor = 0;

                int numFilas = view.RowCount;
                int numCol = view.Columns.Count;
                string nombreCol = "";
                ro_rubro_tipo_Info oRo_rubro_tipo_Info = new ro_rubro_tipo_Info();

                //CONSULTA LOS RUBROS FIJOS

               

                oListRo_empleado_x_ro_rubro_Info = oRo_empleado_x_ro_rubro_Bus.Get_List_empleado_x_ro_rubro(_idEmpresa, idEmpleado, _idNomina, _idNominaLiqui);

                //VERIFICA QUE EL EMPLEADO TENGA REGISTRADO RUBROS FIJOS
               
                    foreach (var rubroFijo in oListRo_empleado_x_ro_rubro_Info)
                    {
                        valor = 0;

                        //RECORRO LA GRILLA DE RUBROS 
                        if (numCol > 0 && numFilas > 0)
                        {
                            //RECORRE LAS FILAS
                            for (int i = 0; i < numFilas; i++)
                            {
                                //RECORRE LAS COLUMNAS
                                for (int j = 0; j < numCol; j++)
                                {
                                    nombreCol = view.Columns[j].Name.Trim();

                                    oRo_rubro_tipo_Info = (from a in oListRo_rubro_tipo_Info
                                                           where a.ru_codRolGen.Trim() == nombreCol.Trim()
                                                           select a).FirstOrDefault();

                                    // ro_rubro_tipo_Info oRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.GetInfoConsultaPorCodigoRol(nombreCol);

                                    //VALIDA QUE EL RUBRO SEA FIJO
                                    if (oRo_rubro_tipo_Info != null && oRo_rubro_tipo_Info.IdRubro == rubroFijo.IdRubro)
                                    {
                                        //OBTIENE EL VALOR DE LA CELDA EN LA COLUMNA ESPECIFICA
                                        string val = view.GetRowCellValue(i, view.Columns[j]).ToString();
                                        valor = (val == "" ? 0 : Convert.ToDouble(val)) + Convert.ToDouble(rubroFijo.Valor);

                                        //SETEA EL NUEVO VALOR ACUMULADO
                                        view.SetRowCellValue(i, view.Columns[j], valor);
                                    }


                                }
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GetRubroFijo", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        private void pu_GetRubroPrestamo(decimal idEmpleado)
        {
            try
            {

                double valor = 0;

                int numFilas = view.RowCount;
                int numCol = view.Columns.Count;
                string nombreCol = "";
                ro_rubro_tipo_Info oRo_rubro_tipo_Info = new ro_rubro_tipo_Info();


                //CONSULTA EL DETALLE DE LOS PRESTAMOS DEL EMPLEADO
                oListRo_prestamo_detalle_Info =  oRo_prestamo_detalle_Bus.GetListConsultaPorEmpleado(_idEmpresa,oRo_PeriodoInfo, idEmpleado);
                                                 



                //VALIDA QUE TENGA CUOTAS PENDIENTES DE PAGO
                if (oListRo_prestamo_detalle_Info.Count > 0)
                {
                    foreach (var cuotaPrestamo in oListRo_prestamo_detalle_Info)
                    {
                        valor = 0;

                        //RECORRO LA GRILLA DE RUBROS 
                        if (numCol > 0 && numFilas > 0)
                        {
                            //RECORRE LAS FILAS
                            for (int i = 0; i < numFilas; i++)
                            {
                                //RECORRE LAS COLUMNAS
                                for (int j = 0; j < numCol; j++)
                                {
                                    nombreCol = view.Columns[j].Name.Trim();

                                    oRo_rubro_tipo_Info = (from a in oListRo_rubro_tipo_Info
                                                           where a.ru_codRolGen.Trim() == nombreCol.Trim()
                                                           select a).FirstOrDefault();

                                    //VALIDA QUE EL RUBRO ESTE CONSIDERADO EN LA CUOTA DEL CONVENIO
                                    if (oRo_rubro_tipo_Info != null && oRo_rubro_tipo_Info.IdRubro == cuotaPrestamo.IdRubro)
                                    {
                                        //OBTIENE EL VALOR DE LA CELDA EN LA COLUMNA ESPECIFICA
                                        string val = view.GetRowCellValue(i, view.Columns[j]).ToString();
                                        valor = (val == "" ? 0 : Convert.ToDouble(val)) + Convert.ToDouble(cuotaPrestamo.TotalCuota);

                                        //SETEA EL NUEVO VALOR ACUMULADO
                                        view.SetRowCellValue(i, view.Columns[j], valor);

                                    }




                                }
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GetRubroPrestamo", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        private bool pu_GuardarRubroProvisional(ro_Rol_Detalle_Info item,decimal idEmpleado)
        { 
        try{
            Boolean valorRetornar = false;
            ro_rubro_tipo_Info oRo_rubro_tipo_Info = new ro_rubro_tipo_Info();


            oRo_rubro_tipo_Info = (from a in oListRo_rubro_tipo_Info
                                               where a.IdRubro == item.IdRubro
                                               select a).FirstOrDefault();

           
            if (Convert.ToBoolean(oRo_rubro_tipo_Info.rub_provision) && item.Valor>0)
            {
                oRo_rol_detalle_x_rubro_acumulado_Info.IdEmpresa = item.IdEmpresa;
                oRo_rol_detalle_x_rubro_acumulado_Info.IdNominaTipo = item.IdNominaTipo;
                oRo_rol_detalle_x_rubro_acumulado_Info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                oRo_rol_detalle_x_rubro_acumulado_Info.IdPeriodo = item.IdPeriodo;
                oRo_rol_detalle_x_rubro_acumulado_Info.IdEmpleado = item.IdEmpleado;
                oRo_rol_detalle_x_rubro_acumulado_Info.IdRubro = item.IdRubro;
                oRo_rol_detalle_x_rubro_acumulado_Info.Valor = item.Valor;
                oRo_rol_detalle_x_rubro_acumulado_Info.Estado = "PEN";
             
                valorRetornar= oRo_rol_detalle_x_rubro_acumulado_Bus.GuardarBD(oRo_rol_detalle_x_rubro_acumulado_Info, ref mensaje);
            }
            return valorRetornar;
        }catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GuardarRubroProvisional", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        
        }


        public Boolean pu_GuardarDetalle(decimal idEmpleado)
        {
            try
            {
                Boolean valorRetornar = false;
                //OBTENGO EL DETALLE DEL ROL
                pu_GetInfoDetalle(idEmpleado);

                //BORRA REGISTROS PREVIOS DEL DETALLE DEL EMPLEADO EN LA NOMINA SELECCIONADA
                oRo_rol_detalle_x_rubro_acumulado_Bus.EliminarBD(_idEmpresa, _idNomina, _idNominaLiqui, oRo_PeriodoInfo.IdPeriodo, idEmpleado, ref mensaje);
                oRo_Rol_Detalle_Bus.EliminarBD(_idEmpresa, _idNomina, _idNominaLiqui, oRo_PeriodoInfo.IdPeriodo, idEmpleado, ref mensaje);
         
                //RECORRE LOS REGISTROS DEL DETALLE
                foreach (ro_Rol_Detalle_Info item in oListRo_Rol_Detalle_Info)
                {

                    //GUARDAR EN LA B/D EL DETALLE DEL ROL
                    valorRetornar = oRo_Rol_Detalle_Bus.GrabarBD(item, ref mensaje);
                    if (valorRetornar)
                    {
                        //GUARDAR EN LA B/D EL PROVISIONAL
                       valorRetornar = pu_GuardarRubroProvisional(item, idEmpleado);
                    }else{
                        return false;
                    }

                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GuardarDetalle", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public Boolean pu_GetInfoDetalle(decimal idEmpleado)
        {
            try
            {
                Boolean valorRetornar = false;
                int numFilas = view.RowCount;
                int numCol = view.Columns.Count;
                //    int orden = 0;
                string nombreCol = "";
                double valor = 0;

                ro_rubro_tipo_Info oRo_rubro_tipo_Info = new ro_rubro_tipo_Info();
                ro_nomina_tipo_liqui_orden_Info oRo_nomina_tipo_liqui_orden_Info = new ro_nomina_tipo_liqui_orden_Info();

                //VERIFICA QUE EXISTAN FILAS Y COLUMNAS EN LA GRILLA
                if (numCol > 0 && numFilas > 0)
                {
                    oListRo_Rol_Detalle_Info.Clear();

                    //RECORRE LAS FILAS
                    for (int i = 0; i < numFilas; i++)
                    {
                        //RECORRE LAS COLUMNAS
                        for (int j = 0; j < numCol; j++)
                        {
                            nombreCol = view.Columns[j].Name.Trim();
                            //****************OJO********
                            //AQUI VERIFICAR Y CAMBIAR ESTA CONSULTA POR DATA EN MEMORIA PARA DISMINUIR TIEMPO DE RESPUESTA
                            //oRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.GetInfoConsultaPorCodigoRol(nombreCol);

                            oRo_rubro_tipo_Info = (from a in oListRo_rubro_tipo_Info
                                                   where a.ru_codRolGen.Trim() == nombreCol.Trim()
                                                   select a).FirstOrDefault();



                            //OBTENER EL ORDEN DE LA SECUENCIA 
                            oRo_nomina_tipo_liqui_orden_Info = (from a in oListRo_nomina_tipo_liqui_orden_Info
                                                                where a.IdRubro == oRo_rubro_tipo_Info.IdRubro
                                                                select a).FirstOrDefault();

                            //VALIDA SI EL RUBRO SE GUARDA EN EL ROL
                            //if (oRo_nomina_tipo_liqui_orden_Info != null && oRo_nomina_tipo_liqui_orden_Info.EsVisible == true && oRo_nomina_tipo_liqui_orden_Info.Orden >= 0)
                            if (oRo_nomina_tipo_liqui_orden_Info != null && oRo_rubro_tipo_Info.rub_guarda_rol == true && oRo_nomina_tipo_liqui_orden_Info.Orden >= 0 )
                                {
                                //OBTIENE EL VALOR DE LA CELDA EN LA COLUMNA ESPECIFICA
                                string val = view.GetRowCellValue(i, view.Columns[j]).ToString();
                                valor = (val == "" ? 0 : Convert.ToDouble(val));

                                ro_Rol_Detalle_Info oRo_Rol_Detalle_Info = new ro_Rol_Detalle_Info();

                                oRo_Rol_Detalle_Info.IdEmpresa = _idEmpresa;
                                oRo_Rol_Detalle_Info.IdNominaTipo = _idNomina;
                                oRo_Rol_Detalle_Info.IdNominaTipoLiqui = _idNominaLiqui;
                                oRo_Rol_Detalle_Info.IdPeriodo = oRo_PeriodoInfo.IdPeriodo;
                                oRo_Rol_Detalle_Info.IdEmpleado = idEmpleado;
                                oRo_Rol_Detalle_Info.IdRubro = oRo_rubro_tipo_Info.IdRubro;
                                oRo_Rol_Detalle_Info.Orden = oRo_nomina_tipo_liqui_orden_Info.Orden;
                                oRo_Rol_Detalle_Info.Valor = valor;
                                oRo_Rol_Detalle_Info.rub_visible_reporte = oRo_nomina_tipo_liqui_orden_Info.EsVisible;

                                if (valor < 0)
                                {
                                oRo_Rol_Detalle_Info.Observacion = "{Valor Negativo}";
                                }
                                else
                                {
                                    oRo_Rol_Detalle_Info.Observacion = "";
                                }

                                oListRo_Rol_Detalle_Info.Add(oRo_Rol_Detalle_Info);
                            }
                        }
                    }

                    valorRetornar = true;
                }
                else {
                    valorRetornar = false;
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GetInfoDetalle", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }


        public void pu_CrearGrillaFormula()
        {
            try
            {
                string idCatalogo = "";

                //grid = new GridControl();
                //view = new GridView();

                //grid.Dock = DockStyle.Fill;
                grid.ViewCollection.Add(view);
                grid.MainView = view;
                view.GridControl = grid;

                formulario.Controls.Add(grid);

                //LIMPIA LOS CONTROLES
                view.Columns.Clear();
                table.Columns.Clear();
                table.Rows.Clear();

                //OBTIENE LOS RUBROS DE LA EMPRESA
                oListRo_rubro_tipo_Info.Clear();
                oListRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.Get_lista_rubros_x_nomina_tipo_liq(param.IdEmpresa, _idNomina, _idNominaLiqui);

                //OBTIENE LISTA DE PROCESOS A EJECUTAR DE LA NOMINA SELECCIONADA
                oListRo_nomina_tipo_liqui_orden_Info.Clear();
                oListRo_nomina_tipo_liqui_orden_Info = oRo_nomina_tipo_liqui_orden_Bus.Get_List_nomina_tipo_liqui_orden(param.IdEmpresa, _idNomina, _idNominaLiqui);

                //OBTIENE LISTA DE CATALOGOS DEL TIPO DE RUBRO
                oListRo_Catalogo_Info.Clear();
                oListRo_Catalogo_Info = oCatalogoBus.Get_List_Catalogo_x_Tipo(13);

                //OBTIENE LA TABLA DEL IMPUESTO A LA RENTA DEL AÑO SEGUN EL PERIODO SELECCIONADO
                oListRo_tabla_Impu_Renta_Info.Clear();
                oListRo_tabla_Impu_Renta_Info = oRo_Tabla_Impu_Renta_Bus.ConsultaTablaImpuAnio(oRo_PeriodoInfo.pe_FechaIni.Year);

                //CREAR COLUMNAS EN LA GRILLA PARA EL PROCESO DE FORMULAS               
                int cont = 0;
                foreach (ro_rubro_tipo_Info item in oListRo_rubro_tipo_Info)
                {
                    //  GridColumn column = view.Columns.Add();
                    GridColumn column = new GridColumn();
                    column.Name = item.ru_codRolGen.Trim();
                    column.FieldName = item.ru_codRolGen.Trim();
                    column.Caption = item.ru_codRolGen.Trim();
                    column.Visible = true;
                    column.VisibleIndex = cont;


                    //PERMITE BUSCAR EN MEMORIA EL TIPO DE CALCULO
                    idCatalogo = (from a in oListRo_Catalogo_Info
                                  where a.IdCatalogo == Convert.ToInt32(item.rub_tipcal)
                                  select a.CodCatalogo).FirstOrDefault();

                    switch (idCatalogo)
                    {
                        //VARIABLE
                        case "TPC1":

                            break;
                        //CONSTANTE
                        case "TPC2":

                            break;
                        //FUNCION
                        case "TPC3":

                            break;

                        //FORMULA LOGICA
                        case "TPC4":

                            column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            column.OptionsColumn.AllowEdit = false;
                            column.ShowUnboundExpressionMenu = true;

                            //OBTIENE LA FORMULA DIRECTAMENTE DE LA LISTA ORDEN
                            column.UnboundExpression = (from a in oListRo_nomina_tipo_liqui_orden_Info
                                                        where a.IdRubro == item.IdRubro
                                                        select a.Formula).FirstOrDefault();



                            break;
                        default:
                            break;
                    }


                    view.Columns.Add(column);

                    //AGREGA A LA TABLA QUE NO SEA UN TIPO DE CACULO DE FORMULA
                    if (idCatalogo != "TPC4")
                    {
                        table.Columns.Add(item.ru_codRolGen.Trim(), typeof(Decimal));
                    }
                    cont += 1;
                }

              table.Rows.Add("0");
              grid.DataSource = table;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CrearGrillaFormula", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }

        }


        public double pu_GetCalcularImpuestoRenta(int idEmpleado, float valor) { 
        try{
            double valorRetornar = 0;
            double exedente = 0;
            
            ro_tabla_Impu_Renta_Info oRo_tabla_Impu_Renta_Info = new ro_tabla_Impu_Renta_Info();
            
            //VALIDA QUE LA TABLA DE IMPUESTO TENGA VALORES
            if (oListRo_tabla_Impu_Renta_Info.Count > 0) {
                //OBTIENE LA FRACCION BASICA SEGUN EL RANGO EN LA TABLA
                oRo_tabla_Impu_Renta_Info = (from a in oListRo_tabla_Impu_Renta_Info
                                             where a.FraccionBasica>=valor && a.ExcesoHasta<valor 
                                             select a).FirstOrDefault();
                //OBTENGO EL EXEDENTE
                exedente=valor - Convert.ToDouble(oRo_tabla_Impu_Renta_Info.FraccionBasica);

                //FRACCION BASICA MAS EL %PORCENTAJE DEL EXEDENTE
                valorRetornar = Convert.ToDouble(oRo_tabla_Impu_Renta_Info.ImpFraccionBasica) + ((exedente * Convert.ToDouble(oRo_tabla_Impu_Renta_Info.Por_ImpFraccion_Exce) * 0.01));         
            }
            return valorRetornar;
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GetCalcularImpuestoRenta", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
        }
 }


        public void pu_ProcesarRol(ro_Empleado_Info info)
        { //
            try
            {
               
                
                if (view.RowCount>0)
                {

                string idCatalogo = "";
                double valor = 0;
                string formula = "";

                //RECORRER LISTADO DE FORMULAS
                foreach (var ordenRubro in oListRo_nomina_tipo_liqui_orden_Info)
                {
                    valor = 0;
                    formula = "";

                    //BUSCAR RUBRO EN EL LISTADO
                    ro_rubro_tipo_Info item = oListRo_rubro_tipo_Info.SingleOrDefault(a => a.IdRubro == ordenRubro.IdRubro);

                    formula = ordenRubro.Formula == null ? "" : ordenRubro.Formula;

                    //PERMITE BUSCAR EN MEMORIA EL TIPO DE CALCULO
                    idCatalogo = (from a in oListRo_Catalogo_Info
                                  where a.IdCatalogo == Convert.ToInt32(item.rub_tipcal)
                                  select a.CodCatalogo).FirstOrDefault();

                    switch (idCatalogo)
                    {
                        //VARIABLE
                        case "TPC1":
                            valor = 0;
                            break;

                        //CONSTANTE
                        case "TPC2":
                     
                            valor = (formula == "") ? 0 : Convert.ToDouble(ordenRubro.Formula);

                            break;

                        //FUNCION
                        case "TPC3":
                            valor = GetProcesarFuncion(formula, info, _idNomina, _idNominaLiqui, item.IdRubro, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin, ref mensaje);

                            /*
                            if (info.em_status == "EST_VAC" && formula.ToString().Trim() == "OBTENER_NOVEDAD()" && item.rub_AplicaEmpleado_Vac==false)
                            {
                                valor = 0;

                            }



                            if (info.em_status == "EST_SUB" && formula.ToString().Trim() == "OBTENER_NOVEDAD()" && item.ru_aplica_empleado_Subsidio == false)
                            {
                                valor = 0;

                            }
                            */
                            break;

                        //FORMULA LOGICA
                        case "TPC4":
                            
                            valor = GetProcesarFuncion(formula, info, _idNomina, _idNominaLiqui, item.IdRubro, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin, ref mensaje);
                            break;
                        default:
                            break;
                    }

                    //SETEA LE VALOR DE LA CELDA ACTUAL
                    if (view.RowCount>0)
                    {
                        
                        view.SetRowCellValue(0, view.Columns[item.ru_codRolGen], valor);
                      

                    }
                }
                    switch (param.IdCliente_Ven_x_Default)
	                {

                case Cl_Enumeradores.eCliente_Vzen.EDEHSA:

                            if (info.em_status == "EST_ACT")
                            {

                                if (info.si_tiene_rubros_fijo == true)
                                {
                                    pu_GetRubroFijo(info.IdEmpleado);
                                }
                                pu_GetRubroPrestamo(info.IdEmpleado);

                            }
                 break;
                default:

                 
                     if (info.si_tiene_rubros_fijo == true)
                     {
                         pu_GetRubroFijo(info.IdEmpleado);
                     }
                     pu_GetRubroPrestamo(info.IdEmpleado);

                 break;
	                }

               
                   
                    
                    //PERMITE GUARDAR EL ROL EN LA B/D
                    pu_GuardarDetalle(info.IdEmpleado);

                }

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ProcesarRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
            }
        }

        private Boolean pu_ValidarRubroFijoRol(decimal idEmpleado,ro_rubro_tipo_Info oRo_rubro_tipo_Info)
          {
              try {
                  Boolean valorRetornar = false;

                  ro_empleado_x_ro_rubro_Bus oRo_empleado_x_ro_rubro_Bus = new ro_empleado_x_ro_rubro_Bus();
                  List<ro_empleado_x_ro_rubro_Info> oListRo_empleado_x_ro_rubro_Info =new List<ro_empleado_x_ro_rubro_Info>();

                  //OBTENGO LOS RUBROS FIJOS DEL EMPLEADO X NOMINA X PROCESO
                  oListRo_empleado_x_ro_rubro_Info=oRo_empleado_x_ro_rubro_Bus.Get_List_empleado_x_ro_rubro(_idEmpresa, idEmpleado, _idNomina, _idNominaLiqui);

                  foreach (var item in oListRo_empleado_x_ro_rubro_Info)
                  {
                      if (item.IdRubro == oRo_rubro_tipo_Info.IdRubro)
                      {
                          valorRetornar = true;
                          break;
                       }
                  }
                  return valorRetornar;
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarRubroFijoRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
              }
          }
     

        private double pu_DiasSubsidio(int idempresa, int idempleado, DateTime fechaIni, DateTime fechaFin)
          {
  
              try 
              {
                  double diasSubsidios_Considerado_Pago = 0;
                
                  ro_permiso_x_empleado_Bus oRo_permiso_x_empleado_Bus = new ro_permiso_x_empleado_Bus();
                  List<ro_permiso_x_empleado_Info> oListRo_permiso_x_empleado_Info = new List<ro_permiso_x_empleado_Info>();
                  oListRo_permiso_x_empleado_Info = oRo_permiso_x_empleado_Bus.GetListLicenciaPorEmpleado(idempresa, idempleado, fechaIni, fechaFin);

                  foreach (var item in oListRo_permiso_x_empleado_Info)
                  {

                      if ((item.FechaSalida.Value.Date >= fechaIni.Date && item.FechaSalida.Value.Date <= fechaFin.Date)
                          && (item.FechaEntrada.Value.Date >= fechaIni.Date && item.FechaEntrada.Value.Date <= fechaFin.Date))
                      {
                          diasSubsidios_Considerado_Pago = CalcularDiasDeDiferencia(Convert.ToDateTime(item.FechaEntrada), Convert.ToDateTime(item.FechaSalida));
                          if (_idNomina == 2)
                          {
                              if (diasSubsidios_Considerado_Pago <= 3)
                              {
                                  diasSubsidios_Considerado_Pago = 7;
                              }
                              else
                              {
                                  diasSubsidios_Considerado_Pago = 3;
                              }
                          }
                      }
                      else
                      {
                          if ((item.FechaSalida.Value.Date >= fechaIni.Date && item.FechaSalida.Value.Date <= fechaFin.Date)
                            && (fechaFin.Date >= item.FechaSalida.Value.Date && fechaFin.Date <= item.FechaEntrada.Value.Date))
                            {
                                diasSubsidios_Considerado_Pago = CalcularDiasDeDiferencia(Convert.ToDateTime(fechaFin.Date), Convert.ToDateTime(item.FechaSalida));

                                if (diasSubsidios_Considerado_Pago == 4)
                                {

                                    diasSubsidios_Considerado_Pago = 6;

                                }
                                else
                                {

                                }
                          }
                          else {
                              if ((fechaIni.Date >= item.FechaSalida.Value.Date && fechaIni.Date <= item.FechaEntrada.Value.Date)
                                  && (fechaFin.Date >= item.FechaSalida.Value.Date && fechaFin.Date <= item.FechaEntrada.Value.Date))
                              {
                                  diasSubsidios_Considerado_Pago = CalcularDiasDeDiferencia(fechaFin.Date, fechaIni.Date);
                                  diasSubsidios_Considerado_Pago = 0;
                              }
                              else {
                                  if (item.FechaEntrada.Value.Date >= fechaIni.Date && item.FechaEntrada.Value.Date <= fechaFin.Date
                                      && item.FechaSalida <= fechaIni.Date)
                                  {
                                      diasSubsidios_Considerado_Pago = CalcularDiasDeDiferencia(item.FechaEntrada.Value.Date, fechaIni.Date);
                                      if (_idNomina == 2)
                                      {
                                          diasSubsidios_Considerado_Pago = 7 - diasSubsidios_Considerado_Pago;
                                      }
                                  }
                              }
                          }                     
                      }
                  }



                  return diasSubsidios_Considerado_Pago;
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_DiasSubsidio", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
              }          
          }


        private Boolean pu_EsRubroPrestamo(int idEmpresa,string idRubro) {
              try {
                  Boolean valorDevolver = false;

                   ro_Config_rubros_x_Prestamo_Bus oRo_Config_rubros_x_Prestamo_Bus=new ro_Config_rubros_x_Prestamo_Bus();

                   int contador = oRo_Config_rubros_x_Prestamo_Bus.ConsultaGeneral(idEmpresa).Where(v=>v.IdRubro==idRubro).Count();

                   if (contador > 0)
                   {
                       valorDevolver = true;
                   }
                   else { valorDevolver = false; }

                   return valorDevolver;
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_EsRubroPrestamo", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
              }          
          }

        private Boolean pu_EsRubroProvision( string idRubro)
          {
              try
              {
                  Boolean valorDevolver = false;

                  ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new Roles.ro_rubro_tipo_Bus();
                  ro_rubro_tipo_Info oRo_rubro_tipo_Info = new Info.Roles.ro_rubro_tipo_Info();
                  oRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.GetInfoConsultaPorId(param.IdEmpresa, idRubro);

                  valorDevolver = Convert.ToBoolean(oRo_rubro_tipo_Info.rub_provision) == null ? false : Convert.ToBoolean(oRo_rubro_tipo_Info.rub_provision);

                  return valorDevolver;
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_EsRubroProvision", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
              }
          }

       
        //carlos cedeños
        public Boolean CrearAsientoSueldoXPagar(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, DateTime fechaContabiliza, ref string msg)
        {
         try
         {
             ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info info_cuenta_contable_sueldo_x_pagar = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info();
             ro_periodo_x_ro_Nomina_TipoLiqui_Info perioso_info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
             oListRo_Config_Param_contable_Info = oRo_Config_Param_contable_Bus.Get_List_Config_Param_contable_Contabilizar_Sueldo_x_pagar(idEmpresa, ref msg);
             Boolean bandera_Si_grabo_diario = false;
             double sumaTotalDebito = 0;
             double sumaTotalCredito = 0;
             double ingreso = 0;
             double egreso = 0;


           
             info_cuenta_contable_sueldo_x_pagar = bus_cuenta_contable_sueldo_x_pagar.Get_Info(idEmpresa, idNominaTipo, idNominaTipoLiqui);
             //OBTENER DETALLE DEL PERIODO
             perioso_info = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(idEmpresa, idNominaTipo, idNominaTipoLiqui).Where(v => v.IdPeriodo == idPeriodo).FirstOrDefault();


             //OBTENER EL DETALLE DEL ROL 
             List<ro_Rol_Detalle_Info> oListRolDetalleTmp = new List<ro_Rol_Detalle_Info>();
             oListRo_Rol_Detalle_Info = oRo_Rol_Detalle_Bus.GetListConsultaPorRol(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref msg);
             ro_Parametros_Info oRo_Parametros_Info = new ro_Parametros_Info();
             oRo_Parametros_Info = oRo_Parametros_Bus.Get_List_Parametros(param.IdEmpresa).FirstOrDefault();


             //CREAR CABECERA DEL DIARIO
             ct_Cbtecble_Info oCt_Cbtecble_Info = new ct_Cbtecble_Info();

             // obtiene las cuentas contables por empleado
             ro_Cuentas_contables_x_empleado_Bus Empleado_cuentas_bus = new ro_Cuentas_contables_x_empleado_Bus();
             List<ro_Cuentas_contables_x_empleado_Info> listas_ceuntas_x_empleado = new List<ro_Cuentas_contables_x_empleado_Info>();
             listas_ceuntas_x_empleado = Empleado_cuentas_bus.Get_List_Cuentas_contables_x_empleados(idEmpresa);



             oCt_Cbtecble_Info.IdEmpresa = idEmpresa;
             oCt_Cbtecble_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar); //DIARIO CONTABLE    
             oCt_Cbtecble_Info.IdPeriodo = idPeriodo;
             oCt_Cbtecble_Info.cb_Fecha = fechaContabiliza;
             oCt_Cbtecble_Info.cb_Valor = 0;
             oCt_Cbtecble_Info.cb_Observacion = "Conta. Rol General al:" + perioso_info.pe_FechaFin.ToShortDateString();
             oCt_Cbtecble_Info.Secuencia = 0;               //AQUI REVISAR CON RICARDO
             oCt_Cbtecble_Info.Estado = "A";
             oCt_Cbtecble_Info.Anio = perioso_info.pe_FechaFin.Year;
             oCt_Cbtecble_Info.Mes = perioso_info.pe_FechaFin.Month;
             oCt_Cbtecble_Info.IdUsuario = param.IdUsuario;
             oCt_Cbtecble_Info.cb_FechaTransac = param.Fecha_Transac;
             oCt_Cbtecble_Info.Mayorizado = "N";
             
             oCt_Cbtecble_Info.IdSucursal = param.IdSucursal;

             //RECORRO LOS PARAMETROS CONTABLES
             foreach (ro_Config_Param_contable_Info oParametroContable in oListRo_Config_Param_contable_Info)
             {
                 if (oParametroContable.IdRubro == "277")
                 {
                 }
                 try
                 {
                      double valorTotal = 0;
                      
                 string pruebaErro = oParametroContable.de_descripcion;
                
                 //FILTRO POR PARAMETRO CONTABLE EL DETALLE DEL ROL
                 oListRolDetalleTmp.Clear();
                 oListRolDetalleTmp = oListRo_Rol_Detalle_Info.Where(v => v.IdDivision == Convert.ToInt32(oParametroContable.IdDivision) && v.IdArea == oParametroContable.IdArea
                                                                      && v.IdDepartamento == oParametroContable.IdDepartamento && v.IdRubro == oParametroContable.IdRubro && v.Valor > 0).ToList();
                 if (oParametroContable.rub_nocontab == true && oParametroContable.rub_Contabiliza_x_empleado == false)
                 {
                     if (!oParametroContable.rub_provision == true)
                     {

                         valorTotal = Convert.ToDouble(oListRolDetalleTmp.Sum(v => v.Valor));
                         if (valorTotal > 0)
                         {
                             ct_Cbtecble_det_Info oCt_Cbtecble_det_Info = new ct_Cbtecble_det_Info();
                             oCt_Cbtecble_det_Info.IdEmpresa = idEmpresa;
                             oCt_Cbtecble_det_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar);
                             oCt_Cbtecble_det_Info.IdCtaCble = oParametroContable.IdCtaCble.Trim();
                             oCt_Cbtecble_det_Info.IdCentroCosto = oParametroContable.IdCentroCosto;


                             if (oParametroContable.DebCre == "C")
                             {
                                 egreso=egreso+ valorTotal;
                                 valorTotal = valorTotal * -1;
                             }
                             else if (oParametroContable.DebCre == "D")
                             {

                                 ingreso = ingreso + valorTotal;
                             }
                             oCt_Cbtecble_det_Info.dc_Valor = valorTotal;
                             oCt_Cbtecble_det_Info.dc_Observacion = oParametroContable.ru_descripcion.Trim() + " " + oParametroContable.DescripcionDiv.Trim() + " " + oParametroContable.DescripcionArea.Trim() + " " + oParametroContable.de_descripcion.Trim() + " al " + perioso_info.pe_FechaFin.ToShortDateString();
                             oCt_Cbtecble_Info._cbteCble_det_lista_info.Add(oCt_Cbtecble_det_Info);

                         }
                     }

                 }

                 else
                 {
                     if (oParametroContable.IdRubro == "277")
                     {
                         foreach (ro_Rol_Detalle_Info item in oListRolDetalleTmp)
                         {
                             ct_Cbtecble_det_Info oCt_Cbtecble_det_Info = new ct_Cbtecble_det_Info();

                             oCt_Cbtecble_det_Info.IdEmpresa = idEmpresa;
                             oCt_Cbtecble_det_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar);
                             ro_Empleado_Info oRo_Empleado_Info = new Info.Roles.ro_Empleado_Info();
                             oRo_Empleado_Info = oRo_Empleado_Bus.Get_Info_Empleado(idEmpresa, item.IdEmpleado);
                             oCt_Cbtecble_det_Info.IdCtaCble = oRo_Empleado_Info.IdCtaCble_Emplea;
                             oCt_Cbtecble_det_Info.IdCentroCosto = oParametroContable.IdCentroCosto;
                             oCt_Cbtecble_det_Info.dc_Observacion = oParametroContable.ru_descripcion.Trim() + " " + oParametroContable.DescripcionDiv.Trim() + " " + oParametroContable.DescripcionArea.Trim() + " " + oParametroContable.de_descripcion.Trim() + " " + item.NombreCompleto.Trim() + " al " + perioso_info.pe_FechaFin.ToShortDateString();
                             oCt_Cbtecble_det_Info.dc_Valor = item.Valor * -1;
                             oCt_Cbtecble_Info._cbteCble_det_lista_info.Add(oCt_Cbtecble_det_Info);
                             sumaTotalCredito = sumaTotalCredito + item.Valor * -1;
                         }
                     }

                   else
                     {
                         foreach (ro_Rol_Detalle_Info item in oListRolDetalleTmp)
                         {
                             ct_Cbtecble_det_Info oCt_Cbtecble_det_Info = new ct_Cbtecble_det_Info();

                             oCt_Cbtecble_det_Info.IdEmpresa = idEmpresa;
                             oCt_Cbtecble_det_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar);
                             ro_Empleado_Info oRo_Empleado_Info = new Info.Roles.ro_Empleado_Info();
                             oRo_Empleado_Info = oRo_Empleado_Bus.Get_Info_Empleado(idEmpresa, item.IdEmpleado);
                             oCt_Cbtecble_det_Info.IdCtaCble = listas_ceuntas_x_empleado.Where(v=>v.IdEmpleado==item.IdEmpleado && v.IdRubro==item.IdRubro).FirstOrDefault().IdCtaCble;
                             oCt_Cbtecble_det_Info.IdCentroCosto = oParametroContable.IdCentroCosto;
                             oCt_Cbtecble_det_Info.dc_Observacion = oParametroContable.ru_descripcion.Trim() + " " + oParametroContable.DescripcionDiv.Trim() + " " + oParametroContable.DescripcionArea.Trim() + " " + oParametroContable.de_descripcion.Trim() + " " + item.NombreCompleto.Trim() + " al " + perioso_info.pe_FechaFin.ToShortDateString();
                             valorTotal = item.Valor;
                             if (oParametroContable.DebCre == "C")//DEBITO
                             {
                                 valorTotal = valorTotal * -1;
                                 sumaTotalCredito = sumaTotalCredito + valorTotal;
                             }
                             else if (oParametroContable.DebCre == "D")//CREDITO
                             {

                                 sumaTotalDebito = sumaTotalDebito + valorTotal;
                             }
                             oCt_Cbtecble_det_Info.dc_Valor = valorTotal;

                             oCt_Cbtecble_Info._cbteCble_det_lista_info.Add(oCt_Cbtecble_det_Info);
                         }
                     }
                 }
                 }
                 catch (Exception ex)
                 {
                     
                    
                 }
 
             }


             double valorSueldoXPagar = 0;
             valorSueldoXPagar = ingreso-egreso;


           
                 ct_Cbtecble_det_Info oCt_Cbtecble_det_Info2 = new ct_Cbtecble_det_Info();
                 oCt_Cbtecble_det_Info2.IdEmpresa = idEmpresa;
                 oCt_Cbtecble_det_Info2.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar); //DIARIO CONTABLE                                
                 oCt_Cbtecble_det_Info2.IdCtaCble = info_cuenta_contable_sueldo_x_pagar.IdCtaCble;
                 oCt_Cbtecble_det_Info2.secuencia = 1;
                 oCt_Cbtecble_det_Info2.dc_Valor = valorSueldoXPagar * -1;
                 oCt_Cbtecble_det_Info2.dc_Observacion = "Sueldo por Pagar Neto a Recibir al " + perioso_info.pe_FechaFin.ToShortDateString();
                 oCt_Cbtecble_Info._cbteCble_det_lista_info.Add(oCt_Cbtecble_det_Info2);

             



                decimal id = 0;

                bandera_Si_grabo_diario = oCt_Cbtecble_Bus.GrabarDB(oCt_Cbtecble_Info, ref id, ref msg);
               // guardar los idcomprobantes contables
                if (bandera_Si_grabo_diario)
                {
                    ro_Comprobantes_Contables_Bus Comprobantes_roles_Bus = new ro_Comprobantes_Contables_Bus();
                    ro_Comprobantes_Contables_Info Comprobantes_Info = new ro_Comprobantes_Contables_Info();
                    Comprobantes_Info.IdEmpresa = param.IdEmpresa;
                    Comprobantes_Info.IdCbteCble = id;
                    Comprobantes_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar);
                    Comprobantes_Info.IdPeriodo =perioso_info.IdPeriodo;
                    Comprobantes_Info.cb_Observacion = oCt_Cbtecble_Info.cb_Observacion;
                    Comprobantes_Info.CodCtbteCble = "SUELDO";
                    bandera_Si_grabo_diario = Comprobantes_roles_Bus.GuardarDB(Comprobantes_Info);

                }


             return bandera_Si_grabo_diario;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CrearAsientoSueldoXPagar", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
         }
     }

        public Boolean pu_CrearAsientoProvision(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, DateTime fechaContabiliza, ref string msg)
     {
         try
         {

             oListRo_Config_Param_contable_Info = oRo_Config_Param_contable_Bus.Get_List_Config_Param_contable_Contabilizar_provisiones(idEmpresa, ref msg);



             Boolean bandera_Si_grabo_diario = false;
           
             string idCtaCtbleDebe = "";
             string idCtaCtbleHaber = "";


             //OBTENER DETALLE DEL PERIODO
             ro_periodo_x_ro_Nomina_TipoLiqui_Info perioso_info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
             perioso_info = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(idEmpresa, idNominaTipo, idNominaTipoLiqui).Where(v => v.IdPeriodo == idPeriodo).FirstOrDefault();

             //OBTENER EL DETALLE DEL ROL 
             List<ro_Rol_Detalle_Info> oListRolDetalleTmp = new List<ro_Rol_Detalle_Info>();

             oListRo_Rol_Detalle_Info = oRo_Rol_Detalle_Bus.Get_lista_rol_Provisiones(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref msg);

             //OBTENER EL LISTADO DE RUBROS DE PROVISION
             List<ro_rubro_tipo_Info> oListo_rubro_tipo_Info = new List<ro_rubro_tipo_Info>();
             oListo_rubro_tipo_Info=oRo_rubro_tipo_Bus.Get_listarubro_provisiones(param.IdEmpresa);

             //OBTENER PARAMETROS CONTABLES PARA PROVISION
             ro_Parametros_Info oRo_Parametros_Info = new ro_Parametros_Info();
             oRo_Parametros_Info = oRo_Parametros_Bus.Get_List_Parametros(param.IdEmpresa).FirstOrDefault();


             //CREAR CABECERA DEL DIARIO
             ct_Cbtecble_Info oCt_Cbtecble_Info = new ct_Cbtecble_Info();

             oCt_Cbtecble_Info.IdEmpresa = idEmpresa;
             oCt_Cbtecble_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar);                            
             oCt_Cbtecble_Info.IdPeriodo = idPeriodo;     
             oCt_Cbtecble_Info.cb_Fecha = fechaContabiliza;
             oCt_Cbtecble_Info.cb_Valor = 0;
             oCt_Cbtecble_Info.cb_Observacion = "Provisión Rol General al:" + perioso_info.pe_FechaFin.ToShortDateString();
             oCt_Cbtecble_Info.Secuencia = 0;           
             oCt_Cbtecble_Info.Estado = "A";
             oCt_Cbtecble_Info.Anio = perioso_info.pe_FechaFin.Year;
             oCt_Cbtecble_Info.Mes = perioso_info.pe_FechaFin.Month;
             oCt_Cbtecble_Info.IdUsuario = param.IdUsuario;
             oCt_Cbtecble_Info.cb_FechaTransac = param.Fecha_Transac;
             oCt_Cbtecble_Info.Mayorizado = "N";
             

             //RECORRO LOS RUBROS DE PROVISION
             foreach (ro_Config_Param_contable_Info item in oListRo_Config_Param_contable_Info) 
             {
                 //FILTRO POR PARAMETRO CONTABLE EL DETALLE DEL ROL
                
                 oListRolDetalleTmp.Clear();
                 oListRolDetalleTmp = oListRo_Rol_Detalle_Info.Where(v => v.IdDivision == Convert.ToInt32(item.IdDivision) && v.IdArea == item.IdArea
                                                                      && v.IdDepartamento == item.IdDepartamento && v.IdRubro == item.IdRubro ).ToList();
               

                

                     double valorTotal = 0;

                     //OBTENGO LA SUMATORIA DEL RUBRO
                     valorTotal = Convert.ToDouble(oListRolDetalleTmp.Sum(v => v.Valor));

                     //VERIFICA MAYOR QUE CERO
                     if (valorTotal > 0)
                     {

                         switch(item.IdRubro.Trim())
                         {
                             case "198"://PROVISION FONDO RESERVA
                                        idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;

                             case "199"://PROVISION DECIMO TERCER
                                         idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;

                             case "200"://PROVISION DECIMO CUARTO
                                        idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;

                             case "295"://PROVISION DE VACACIONES                           
                                        idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;

                             case "493"://APORTE PATRONAL                                                              
                                        idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;


                             case "982"://SECAP                                                              
                                        idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;


                             case "983"://IECE                                                              
                                        idCtaCtbleDebe=item.IdCtaCble;
                                        idCtaCtbleHaber = item.IdCtaCble_Haber;
                                 break;

                             default:
                                 idCtaCtbleDebe = "";
                                 idCtaCtbleHaber = "";
                                 break;
                         
                         }




                         ct_Cbtecble_det_Info oCt_Cbtecble_det_Info = new ct_Cbtecble_det_Info();

                         oCt_Cbtecble_det_Info.IdEmpresa = idEmpresa;
                         oCt_Cbtecble_det_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar); //DIARIO CONTABLE     --  //AQUI REVISAR CON RICARDO                              
                         oCt_Cbtecble_det_Info.IdCtaCble = idCtaCtbleDebe.Trim();
                         oCt_Cbtecble_det_Info.IdCentroCosto = "";
                         oCt_Cbtecble_det_Info.secuencia = 1;                       
                         oCt_Cbtecble_det_Info.dc_Valor = valorTotal;
                         oCt_Cbtecble_det_Info.dc_Observacion = item.ru_descripcion.Trim()+" al " + perioso_info.pe_FechaFin.ToShortDateString();
                         oCt_Cbtecble_Info._cbteCble_det_lista_info.Add(oCt_Cbtecble_det_Info);




                         ct_Cbtecble_det_Info oCt_Cbtecble_det_Info2 = new ct_Cbtecble_det_Info();
                         oCt_Cbtecble_det_Info2.IdEmpresa = idEmpresa;
                         oCt_Cbtecble_det_Info2.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar); //DIARIO CONTABLE    
                         oCt_Cbtecble_det_Info2.IdCtaCble = idCtaCtbleHaber.Trim(); ;
                         oCt_Cbtecble_det_Info.IdCentroCosto = "";                        
                         valorTotal = valorTotal * (-1);
                         oCt_Cbtecble_det_Info2.secuencia = 2;
                         oCt_Cbtecble_det_Info2.dc_Valor = valorTotal;
                         oCt_Cbtecble_det_Info2.dc_Observacion = "Reservas para " + item.ru_descripcion.Trim() + " al " + perioso_info.pe_FechaFin.ToShortDateString();
                         oCt_Cbtecble_Info._cbteCble_det_lista_info.Add(oCt_Cbtecble_det_Info2);

                     }




                 

             }



             decimal id = 0;

             bandera_Si_grabo_diario = oCt_Cbtecble_Bus.GrabarDB(oCt_Cbtecble_Info, ref id, ref msg);

             if (bandera_Si_grabo_diario)
             {
                 ro_Comprobantes_Contables_Bus Comprobantes_roles_Bus = new ro_Comprobantes_Contables_Bus();
                 ro_Comprobantes_Contables_Info Comprobantes_Info = new ro_Comprobantes_Contables_Info();
                 Comprobantes_Info.IdEmpresa = param.IdEmpresa;
                 Comprobantes_Info.IdCbteCble = id;
                 Comprobantes_Info.IdTipoCbte =Convert.ToInt32( oRo_Parametros_Info.IdTipoCbte_AsientoSueldoXPagar);
                 Comprobantes_Info.IdPeriodo = perioso_info.IdPeriodo;
                 Comprobantes_Info.cb_Observacion = oCt_Cbtecble_Info.cb_Observacion;
                 Comprobantes_Info.CodCtbteCble = "PROVISIONES";
                 bandera_Si_grabo_diario=  Comprobantes_roles_Bus.GuardarDB(Comprobantes_Info);

             }


             return bandera_Si_grabo_diario;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CrearAsientoProvision", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
         }
     }


       public Boolean pu_ContabilizarRol(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, ro_periodo_x_ro_Nomina_TipoLiqui_Info roPeriodo_Info, DateTime fechaContabiliza, ref string msg)
      {
         try
         {

               

             if (CrearAsientoSueldoXPagar(idEmpresa, idNominaTipo, idNominaTipoLiqui, roPeriodo_Info.IdPeriodo, fechaContabiliza, ref mensaje))
             {
                 if (pu_CrearAsientoProvision(idEmpresa, idNominaTipo, idNominaTipoLiqui, roPeriodo_Info.IdPeriodo, fechaContabiliza, ref mensaje))
                 {

                     ro_Empleado_Novedad_Det_Bus novedades_bus = new ro_Empleado_Novedad_Det_Bus();


                     //MODIFICAR EL ESTADO DE COBRO DE LAS NOVEDADES PENDIENTES

                     novedades_bus.ModificarEstadoCobroDB(idEmpresa, idNominaTipo, idNominaTipoLiqui, roPeriodo_Info.pe_FechaIni, roPeriodo_Info.pe_FechaFin);
                     //MODIFICAR EL ESTADO DE COBRO DE Los prestamos PENDIENTES

                     oRo_prestamo_detalle_Bus.Cambiar_estado_cancelada(idEmpresa, idNominaTipo, roPeriodo_Info.pe_FechaIni, roPeriodo_Info.pe_FechaFin);

                     //MODIFICAR ESTADO CONTABILIZADO
                     roPeriodo_Info.Contabilizado = "S";
                     ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new Business.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
                     oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ModificarDB(roPeriodo_Info);

                     msg = "El Rol ha sido Contabilizado con éxito";
                 }
                 else
                 {
                     msg = "Ocurrio un error en el Asiento de Provisión: " + mensaje;
                     return false;
                 }
             }
             else
             {
                 msg="Ocurrio un error en el Asiento de Sueldos: " + mensaje;
                 return false;
             }
            return true;
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ContabilizarRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
        }
     }


       public decimal Provision_Impuesto_Renta_Mensual(int IdEmpresa, int IdNomina_Tipo, int Id_Nomina_Tipo_Liqui, int IdEmpleado, DateTime Fecha_Inicio, DateTime Fecha_Fin, decimal Sueldo_Actual)
       {
           try
           {
               decimal Impuesto_Renta = 0;
               decimal Ingresos_Anio_Curso = 0;
               decimal Horas_Extras_Perido_Actual = 0;
               decimal Sueldo_Anual = 0;
               decimal ingreso = 0;
               decimal egreso = 0;
               decimal Base_Imponible = 0;
               Sueldo_Anual = ((Sueldo_Actual * 12) - ((Sueldo_Actual * 12) *Convert.ToDecimal( 0.0945)));
               // obtengo todos los ingreso del empleado del año en curso
             Ingresos_Anio_Curso=  oRo_Rol_Detalle_Bus.Get_Valor_Impuesto_Renta(IdEmpresa, IdEmpleado, Fecha_Inicio.Year);
             // obtengo las horas extras del perido seleccionado

             Horas_Extras_Perido_Actual=   oEmpleadoNovedadDetBus.get_Valor_Novedad_Periodo(IdEmpresa, IdNomina_Tipo, Id_Nomina_Tipo_Liqui, IdEmpleado, Fecha_Inicio, Fecha_Fin);

               // obtengo los gatos del empleado del año en curso
              egreso=  Gastos_Personales_Bus.Get_Proyeccion_Anual(IdEmpresa, IdEmpleado, Fecha_Inicio.Year);
              ingreso = Ingresos_Anio_Curso + Horas_Extras_Perido_Actual + Sueldo_Anual;

              Base_Imponible = ingreso - egreso;
               ro_tabla_Impu_Renta_Info REgistro_calculo_info= new ro_tabla_Impu_Renta_Info();

               REgistro_calculo_info = oListRo_tabla_Impu_Renta_Info.Where(v=>v.FraccionBasica<=Convert.ToDouble( Base_Imponible) && Convert.ToDouble( Base_Imponible)<=v.ExcesoHasta).FirstOrDefault();
               if (REgistro_calculo_info != null)
               {
                   Impuesto_Renta = (decimal)(((Convert.ToDouble(Base_Imponible) - REgistro_calculo_info.FraccionBasica) * REgistro_calculo_info.Por_ImpFraccion_Exce) + REgistro_calculo_info.ImpFraccionBasica);
                   Impuesto_Renta = Impuesto_Renta / 12;
               }
               return Impuesto_Renta;

           }
           catch (Exception ex)
           {
               
           Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
           throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Provision_Impuesto_Renta_Mensual", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
     
           }
       }

       public double Get_Dias_Integrales(DateTime Fecha_Inicio, DateTime Fecha_Fin)
       {
           try
           {
               double Dias = 0;
               while (Fecha_Inicio<=Fecha_Fin)
               {
                   if (Fecha_Inicio.DayOfWeek != DayOfWeek.Saturday && Fecha_Inicio.DayOfWeek != DayOfWeek.Sunday)
                   {
                       Dias = Dias + 1;
                   }
                   Fecha_Inicio = Fecha_Inicio.AddDays(1);
               }
               return Dias;
           }
           catch (Exception ex)
           {
               
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
           throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Provision_Impuesto_Renta_Mensual", ex.Message), ex) { EntityType = typeof(ro_Rol_Bus) };
     
           }
       }
    }
}
