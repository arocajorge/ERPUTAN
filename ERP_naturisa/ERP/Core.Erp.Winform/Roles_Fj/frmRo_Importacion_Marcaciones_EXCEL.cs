using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Importacion_Marcaciones_EXCEL : Form
    {   
        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        DataTable dt;
        TimeSpan finalHora50 = TimeSpan.FromHours(24); //24:00 PM
        TimeSpan inicioHora100 = TimeSpan.FromHours(0); //00:00 PM
        DateTime Fecha_minima;
        DateTime Fecha_maxima;
        #endregion

        #region clases
        bool Bandera_ValidarPagina;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ro_marcaciones_x_Jornada_Info> ListadoMarcaciones_x_Jornada = new List<ro_marcaciones_x_Jornada_Info>();
        List<ro_marcaciones_x_Jornada_Info> lista_de_empleado_x_marcaciones = new List<ro_marcaciones_x_Jornada_Info>();

        List<ro_Empleado_Info> Lista_empleado_en_base = new List<ro_Empleado_Info>();
        ro_Empleado_Bus dataEmp = new ro_Empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
        List<ro_rubro_tipo_Info> lista_rubro = new List<ro_rubro_tipo_Info>();
        ro_rubro_tipo_Bus rubro_bus = new ro_rubro_tipo_Bus();
        List<ro_Empleado_Novedad_Det_Info> lista_novedades_Tmp = new List<ro_Empleado_Novedad_Det_Info>();
        BindingList<ro_Empleado_Novedad_Det_Info> lista_novedades = new BindingList<ro_Empleado_Novedad_Det_Info>();
        List<ro_marcaciones_x_empleado_Info> listado_marcaciones_guardar_DB = new List<ro_marcaciones_x_empleado_Info>();
        ro_marcaciones_x_empleado_Bus BusMarcaciones = new ro_marcaciones_x_empleado_Bus();
        ro_Novedad_Subida_Bach_Bus Novedad_subida_batch = new ro_Novedad_Subida_Bach_Bus();
        ro_Empleado_Novedad_Bus novedad_bus = new ro_Empleado_Novedad_Bus();
        Erp.Business.Roles_Fj.ro_marcaciones_x_Jornada_Bus marcaciones_x_jornda_bus = new Business.Roles_Fj.ro_marcaciones_x_Jornada_Bus();



        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_perido = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        // datos si existe empleado en remplazo
        List<ro_Remplazo_x_emplado_Info> lista_remplazo_x_empleado = new List<ro_Remplazo_x_emplado_Info>();
        ro_Remplazo_x_emplado_Bus bus_remplazo_x_empleado = new ro_Remplazo_x_emplado_Bus();
        ro_Parametro_calculo_Horas_Extras_Bus bus_parametro_horas_extras = new ro_Parametro_calculo_Horas_Extras_Bus();
        ro_Parametro_calculo_Horas_Extras_Info info_parametro_horas_extras = new ro_Parametro_calculo_Horas_Extras_Info();


        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        }; 



        #endregion

        public frmRo_Importacion_Marcaciones_EXCEL()
        {
            InitializeComponent();
            //INICIALIZA LOS EVENTOS DELEGADOS DE LA BARRA DE PROGRESO
          
            bw.ProgressChanged += bw_ProgressChanged;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.DoWork += bw_DoWork;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {

                int i = 0;
                int numFila = 0;
                double percent = 0;
                decimal id_nov = 0;

                List<ro_Empleado_Novedad_Det_Info> lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                ro_Empleado_Novedad_Info Novedad_info = new ro_Empleado_Novedad_Info();
                ro_Empleado_Novedad_Det_Info Novedad_detalle_info = new ro_Empleado_Novedad_Det_Info();

                double Tota_Valor = 0;
                double NumHoras = 0;
                numFila = lista_de_empleado_x_marcaciones.Count();
                foreach (var item in lista_de_empleado_x_marcaciones)
                {
                    // novedad al 25%
                    lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                    Novedad_info = new ro_Empleado_Novedad_Info();
                    lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.IdRubro == "7").ToList();
                    if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 25%
                    {
                        // armo la cabecera de la novedad
                        Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                        NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                        Novedad_info.TotalValor = Tota_Valor;
                        Novedad_info.IdEmpresa = param.IdEmpresa;
                        Novedad_info.IdEmpleado = item.IdEmpleado;
                        Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                        Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                        Novedad_info.Fecha = DateTime.Now;
                        Novedad_info.NumCoutas = 1;
                        Novedad_info.IdUsuario = param.IdUsuario;
                        Novedad_info.Fecha_Transac = DateTime.Now;
                        Novedad_info.Estado = "A";
                        // creo el detalle de la novedad
                        Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                        Novedad_detalle_info.NumHoras = NumHoras;
                        Novedad_detalle_info.Valor = Tota_Valor;
                        Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                        Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                        novedad_bus.GrabarDB(Novedad_info, ref id_nov);

                        // grabo la novedad

                    }




                    // novedad al 50%
                    lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                    Novedad_info = new ro_Empleado_Novedad_Info();
                    lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.IdRubro == "8").ToList();
                    if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 50%
                    {
                        // armo la cabecera de la novedad
                        Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                        NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                        Novedad_info.TotalValor = Tota_Valor;
                        Novedad_info.IdEmpresa = param.IdEmpresa;
                        Novedad_info.IdEmpleado = item.IdEmpleado;
                        Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                        Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                        Novedad_info.Fecha = info_perido.pe_FechaFin;
                        Novedad_info.NumCoutas = 1;
                        Novedad_info.IdUsuario = param.IdUsuario;
                        Novedad_info.Fecha_Transac = DateTime.Now;
                        Novedad_info.Estado = "A";
                        // creo el detalle de la novedad
                        Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                        Novedad_detalle_info.NumHoras = NumHoras;
                        Novedad_detalle_info.Valor = Tota_Valor;
                        Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                        Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                        novedad_bus.GrabarDB(Novedad_info, ref id_nov);

                    }



                    // novedad al 100%
                    lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                    Novedad_info = new ro_Empleado_Novedad_Info();
                    lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.IdRubro == "9").ToList();
                    if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 100%
                    {
                        // armo la cabecera de la novedad
                        Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                        NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                        Novedad_info.TotalValor = Tota_Valor;
                        Novedad_info.IdEmpresa = param.IdEmpresa;
                        Novedad_info.IdEmpleado = item.IdEmpleado;
                        Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                        Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                        Novedad_info.Fecha = info_perido.pe_FechaFin;
                        Novedad_info.NumCoutas = 1;
                        Novedad_info.IdUsuario = param.IdUsuario;
                        Novedad_info.Fecha_Transac = DateTime.Now;
                        Novedad_info.Estado = "A";
                        // creo el detalle de la novedad
                        Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                        Novedad_detalle_info.NumHoras = NumHoras;
                        Novedad_detalle_info.Valor = Tota_Valor;
                        Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                        Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                        novedad_bus.GrabarDB(Novedad_info, ref id_nov);
                    }







                    if (info_parametro_horas_extras.Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo)
                    {

                        // novedad de reverso por remplazo
                        lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                        Novedad_info = new ro_Empleado_Novedad_Info();
                        lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.es_Fech_remplazo.Year > 2010).ToList();
                        if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 100%
                        {
                            // armo la cabecera de la novedad
                            Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                            // NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                            Novedad_info.TotalValor = Tota_Valor;
                            Novedad_info.IdEmpresa = param.IdEmpresa;
                            Novedad_info.IdEmpleado = item.IdEmpleado;
                            Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                            Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                            Novedad_info.Fecha = info_perido.pe_FechaFin;
                            Novedad_info.NumCoutas = 1;
                            Novedad_info.IdUsuario = param.IdUsuario;
                            Novedad_info.Fecha_Transac = DateTime.Now;
                            Novedad_info.Estado = "A";
                            // creo el detalle de la novedad
                            Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                            Novedad_detalle_info.NumHoras = 0;
                            Novedad_detalle_info.Valor = Tota_Valor;
                            Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                            Novedad_detalle_info.IdRubro = info_parametro_horas_extras.IdRubro_rev_Horas;
                            Novedad_detalle_info.Observacion = "Descuento por horas extras";
                            Novedad_detalle_info.IdCalendario = Convert.ToString(cmbPeriodos.EditValue);
                            Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                            novedad_bus.GrabarDB(Novedad_info, ref id_nov);
                        }

                    }
                    i++;
                    percent = (Convert.ToDouble(i) / Convert.ToDouble(numFila)) * 100;
                    bw.ReportProgress((int)percent);
                }
            

                              

                                   

                               

                          
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        
       
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("El proceso ha sido detenido por el usuario, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (e.Error != null) { MessageBox.Show(e.Error.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {

                    //cmdCargar.Enabled = true;
                    //cmdProcesar.Enabled = true;
                    //cmdDetener.Enabled = false;

                    ////MUESTRA TODOS LOS REPORTES DE ERRORES 
                    //pu_AgregarMensajeLog(oRo_Rol_Detalle_Bus.GetListConsultaPorRol(_idEmpresa, _idNomina, _idNominaLiqui, _idPeriodo, ref mensaje));

                    ////CAMBIA EL ESTADO DEL ROL A PROCESADO
                    //oRo_PeriodoInfo.Procesado = "S";
                    //oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.GuardarDB(oRo_PeriodoInfo);

                    //MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

       
        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        

        public void Get_Marcaciones_x_Turnos(string RutaFile)
        {
            ListadoMarcaciones_x_Jornada = new List<ro_marcaciones_x_Jornada_Info>();
            int Secuencia = 0;
            DateTime Fecha_m = new DateTime();
            TimeSpan es_hora;
            int hora = 0;
            int minutos = 0;
            double Total_horas = 0;
            try
            {
                // leo el excel
                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = RutaFile;
                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }
                using (OleDbConnection conexion = new OleDbConnection(cb.ConnectionString))
                {


                    string Hoja = LimpiarCadena(cmbHoja.Text);
                    conexion.Open();
                    string Sql = "SELECT * " +
                             "FROM [" + Hoja + "$]  where Cedula is not null";
                     

                    OleDbCommand Cmd = new OleDbCommand(Sql, conexion);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Secuencia = Secuencia + 1;
                        string Cedula = "";
                         hora = 0;
                         minutos = 0;
                         Total_horas = 0;
                        if (Reader.IsDBNull(0) == false && Reader.IsDBNull(3)==false && Reader.IsDBNull(4)==false)
                        {
                            ro_marcaciones_x_Jornada_Info Info_marcaciones = new ro_marcaciones_x_Jornada_Info();

                            Cedula = Reader.GetString(0);
                            if(Cedula=="0925784456")
                            {
                            }
                            if (Cedula.Length == 9)
                            {
                                Cedula = "0" + Cedula;
                            }
                            ro_Empleado_Info emp = new ro_Empleado_Info();

                            try
                            {
                                emp = Lista_empleado_en_base.First(var => var.InfoPersona.pe_cedulaRuc == Cedula);
                            }
                            catch (Exception)
                            {
                                Info_marcaciones.error = "Error";

                            }

                            if (emp.IdEmpleado != 0 || emp.IdEmpleado != null)// si existe en la base
                            {
                                DateTime FechaRegistro = Reader.GetDateTime(2);

                                InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(FechaRegistro));
                                Info_marcaciones.EsFeriado = InfoCalendario.EsFeriado;

                                if (Reader.IsDBNull(3) == false || Reader.IsDBNull(4))// si tiene por lo menos una marcacion en la primera jornada
                                {                                    
                                    Info_marcaciones.pe_cedula = Reader.GetString(0);
                                    Info_marcaciones.pe_NombreCompleto = Reader.GetString(1);
                                    Info_marcaciones.es_fechaRegistro = Reader.GetDateTime(2);
                                    Info_marcaciones.es_anio = FechaRegistro.Year;
                                    Info_marcaciones.es_dia = FechaRegistro.Day;
                                    Info_marcaciones.es_mes = FechaRegistro.Month;
                                    Info_marcaciones.es_idDia = InfoCalendario.dia_x_semana;
                                    Info_marcaciones.es_semana = InfoCalendario.IdSemana;
                                    Info_marcaciones.secuencia = Secuencia;
                                    Info_marcaciones.nomina = emp.Nomina;
                                    Info_marcaciones.dia = InfoCalendario.NombreDia;
                                    Info_marcaciones.IdEmpleado = emp.IdEmpleado;
                                    if (Reader.IsDBNull(3) == false)
                                    {

                                        Fecha_m = Convert.ToDateTime(Reader.GetValue(3));
                                        hora = Fecha_m.Hour;
                                        minutos = Fecha_m.Minute;
                                        Info_marcaciones.es_Hora_ingreso_jornada1 = new TimeSpan(hora, minutos, 0);
                                    }
                                    else
                                    {
                                        Info_marcaciones.es_Hora_ingreso_jornada1 = new TimeSpan(0, 0, 0);
                                    }

                                    if (Reader.IsDBNull(4) == false)
                                    {
                                        Fecha_m = Convert.ToDateTime(Reader.GetValue(4));
                                        hora = Fecha_m.Hour;
                                        minutos = Fecha_m.Minute;

                                        Info_marcaciones.es_Hora_salida_jornada1 = new TimeSpan(hora, minutos, 0);
                                    }
                                    else
                                    {
                                        Info_marcaciones.es_Hora_salida_jornada1 = new TimeSpan(0, 0, 0);

                                    }
                                    if (Reader.IsDBNull(5) == false)
                                    {

                                        Fecha_m = Convert.ToDateTime(Reader.GetValue(5));
                                        hora = Fecha_m.Hour;
                                        minutos = Fecha_m.Minute;

                                        Info_marcaciones.es_Hora_ingreso_jornada2 = new TimeSpan(hora, minutos, 0);
                                    }
                                    else
                                    {
                                        Info_marcaciones.es_Hora_ingreso_jornada2 = new TimeSpan(0, 0, 0);

                                    }

                                    if (Reader.IsDBNull(6) == false)
                                    {
                                        Fecha_m = Convert.ToDateTime(Reader.GetValue(6));
                                        hora = Fecha_m.Hour;
                                        minutos = Fecha_m.Minute;

                                        Info_marcaciones.es_Hora_salida_jornada2 = new TimeSpan(hora, minutos, 0);
                                    }
                                    else
                                    {
                                        Info_marcaciones.es_Hora_salida_jornada2 = new TimeSpan(0, 0, 0);


                                    }
                                   
                                   
                                    double to_hora_J1;
                                    double to_hora_j2;
                                   
                                    if (InfoCalendario.dia_x_semana == 7 || InfoCalendario.dia_x_semana == 6)
                                    {
                                        if ( ((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).TotalHours > 0)
                                        {
                                            if (((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).TotalHours > ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1).TotalHours)
                                            {
                                                if (((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1).TotalHours > inicioHora100.TotalDays)
                                                {
                                                    double horas_tmp = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1).TotalHours - inicioHora100.TotalHours;
                                                    double horas_tm = 24 - ((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).TotalHours;
                                                    Total_horas = horas_tmp + horas_tm;
                                                }
                                                else
                                                {
                                                    to_hora_J1 = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1 - (TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).TotalHours;
                                                    Total_horas = to_hora_J1;
                                                }
                                            }
                                            else
                                            {
                                                to_hora_J1 = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1 - (TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).TotalHours;
                                                Total_horas = to_hora_J1;

                                            }
                                        }




                                        if (((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada2).TotalHours > 0)
                                        {
                                            if (((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada2).TotalHours > ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada2).TotalHours)
                                            {
                                                if (((TimeSpan)Info_marcaciones.es_Hora_salida_jornada2).TotalHours > inicioHora100.TotalDays)
                                                {
                                                    double horas_tmp = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada2).TotalHours - inicioHora100.TotalHours;
                                                    double horas_tm = 24 - ((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada2).TotalHours;
                                                    Total_horas = horas_tmp + horas_tm;
                                                }
                                                else
                                                {
                                                    to_hora_j2 = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada2 - (TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada2).TotalHours;
                                                    Total_horas = Total_horas + to_hora_j2;
                                                }
                                            }
                                            else
                                            {
                                                to_hora_j2 = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada2 - (TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada2).TotalHours;
                                                Total_horas = Total_horas + to_hora_j2;
                                            }
                                        }


                                    }
                                    else
                                    {
                                        if (((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).Hours < 24 && ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1).Hours < 8)
                                        {
                                           

                                           to_hora_J1 = 24 - ((TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).Hours;
                                           to_hora_J1 = to_hora_J1 + (((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1).Hours);
                                           Total_horas = to_hora_J1;
                                        }
                                        else
                                        {
                                        to_hora_J1 = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada1 - (TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada1).TotalHours;
                                        to_hora_j2 = ((TimeSpan)Info_marcaciones.es_Hora_salida_jornada2 - (TimeSpan)Info_marcaciones.es_Hora_ingreso_jornada2).TotalHours;
                                        Total_horas = to_hora_J1 + to_hora_j2;
                                        }
                                    }
                                   
                                    if (Total_horas < 0)
                                    {
                                        Total_horas = Total_horas * -1;
                                    }




                                    Info_marcaciones.es_tot_horasTrabajadas = Total_horas;
                                    Info_marcaciones.grupo.Calculo_Horas_extras_Sobre = emp.grupo.Calculo_Horas_extras_Sobre;
                                    Info_marcaciones.grupo.Max_num_horas_sab_dom = emp.grupo.Max_num_horas_sab_dom;
                                    if (Info_marcaciones.error == "" || Info_marcaciones.error == null)
                                    {
                                        ListadoMarcaciones_x_Jornada.Add(Info_marcaciones);
                                    }

                                }


                               
                            }

                            else// si no existe en la base vzen
                            {

                            }
                        }
                    }

                    gridControl_Marcaciones.DataSource = ListadoMarcaciones_x_Jornada;

                    Reader.Close();
                    conexion.Close();

                    // obtengo la fecha maxima y minima prar ver si exiten remplaso en ese rango de fecha

                    Fecha_maxima =Convert.ToDateTime( ListadoMarcaciones_x_Jornada.Max(v => v.es_fechaRegistro));
                    Fecha_minima = Convert.ToDateTime(ListadoMarcaciones_x_Jornada.Min(v => v.es_fechaRegistro));
                    lista_remplazo_x_empleado = bus_remplazo_x_empleado.Get_lista_remplazo_para_reversar_horas_extras(param.IdEmpresa,Fecha_maxima,Fecha_minima);
                    foreach (var item_remp in lista_remplazo_x_empleado)
                    {
                        DateTime fecha;
                        fecha = item_remp.Fecha_Salida;
                        while (fecha<=item_remp.Fecha_Entrada)
                        {
                             foreach (var item_mar in ListadoMarcaciones_x_Jornada)
                            {
                                if ( item_remp.IdEmpleado == item_mar.IdEmpleado && item_mar.es_fechaRegistro==fecha)
                                   {
                                    item_mar.es_Fech_remplazo = fecha;
                                   }
                            }
                             fecha = fecha.AddDays(1);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Bandera_ValidarPagina = false;
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        public void Get_Empleados_en_excel(string RutaFile)
        {
            lista_de_empleado_x_marcaciones = new List<ro_marcaciones_x_Jornada_Info>();
            int Secuencia = 0;
            DateTime Fecha_m = new DateTime();
            int hora = 0;
            int minutos = 0;
            TimeSpan H = new TimeSpan(hora, minutos, 0);
            try
            {
                // leo el excel
                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = RutaFile;
                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }
                using (OleDbConnection conexion = new OleDbConnection(cb.ConnectionString))
                {


                    string Hoja = LimpiarCadena(cmbHoja.Text);
                    conexion.Open();
                    string Sql = "SELECT Cedula,Nombres " +
                             "FROM [" + Hoja + "$] where Cedula is not null  " +
                             " group by  Cedula,Nombres";


                    OleDbCommand Cmd = new OleDbCommand(Sql, conexion);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Secuencia = Secuencia + 1;
                        string Cedula = "";

                        if (Reader.IsDBNull(0) == false)
                        {

                            ro_marcaciones_x_Jornada_Info info_marcaciones = new ro_marcaciones_x_Jornada_Info();
                            Cedula = Reader.GetString(0);
                            if (Cedula.Length == 9)
                            {
                                Cedula = "0" + Cedula;
                            }
                            ro_Empleado_Info emp = new ro_Empleado_Info();
                            try
                            {
                                emp = Lista_empleado_en_base.First(var => var.InfoPersona.pe_cedulaRuc == Cedula);
                                if(emp.grupo.Calculo_Horas_extras_Sobre==0)
                                {
                                 info_marcaciones.error = "No tiene asigando valor para el calculo de horas extras";
                                }
                                info_marcaciones.grupo.Calculo_Horas_extras_Sobre=emp.grupo.Calculo_Horas_extras_Sobre;
                            }
                         
                            catch (Exception)
                            {
                                info_marcaciones.error = "No esta registrado este colaborador en la Base de datos VZEN";
                            }
                            info_marcaciones.pe_cedula = Cedula;
                            info_marcaciones.IdEmpleado = emp.IdEmpleado;
                            info_marcaciones.Id_nomina_Tipo = emp.IdNomina_Tipo;
                            info_marcaciones.pe_NombreCompleto = Reader.GetValue(1).ToString();
                            info_marcaciones.secuencia = Secuencia;
                            info_marcaciones.nomina = emp.Nomina;
                            info_marcaciones.Sueldo_Actual = emp.SueldoActual;
                            lista_de_empleado_x_marcaciones.Add(info_marcaciones);
                            

                        }
                    }

                    gridControlEmpleados.DataSource = lista_de_empleado_x_marcaciones;

                    Reader.Close();
                    conexion.Close();
                }


            }
            catch (Exception ex)
            {
                Bandera_ValidarPagina = false;
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }




        private void wizardImportacionMarcaciones_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                switch (e.Page.Name)
                {

                    case "WizardPaginainicio":
                        group_box_datos_nomina.Visible = false;

                        break;
                    case "wizardPaginaSeleccionFile":
                        group_box_datos_nomina.Visible = false;

                        if (ValidarSiSeleccionofile())
                        {
                            Get_Empleados_en_excel(TxtRuraFile.Text);
                        }
                        break;
                    case "wizardPaginaempleados":
                        group_box_datos_nomina.Visible = false;

                        Get_Marcaciones_x_Turnos(TxtRuraFile.Text);

                        break;
                    case "wizardPaginaMarcaciones":
                        group_box_datos_nomina.Visible = true;

                        // generar las marcaciones
                        Get_Marcaciones(ListadoMarcaciones_x_Jornada);



                        CargarRubros();// cargar rubros de horas extras
                        // recorro a los emplados que estan en el excel y que notienen errores para el calculo de hora extra
                        lista_novedades_Tmp = new List<ro_Empleado_Novedad_Det_Info>();
                        foreach (var item in lista_de_empleado_x_marcaciones)
                        {
                            List<ro_marcaciones_x_Jornada_Info> lista_tmp = new List<ro_marcaciones_x_Jornada_Info>();
                            lista_tmp = ListadoMarcaciones_x_Jornada.Where(v=>v.pe_cedula==item.pe_cedula).ToList();
                            if (lista_tmp.Count() > 0)
                             {
                                 Get_Horas_extras_x_rubro_x_empleado(lista_tmp, item.Sueldo_Actual);
                             }
                        }
                          lista_novedades =new BindingList<ro_Empleado_Novedad_Det_Info>( lista_novedades_Tmp);
                          lista_novedades_Tmp = null;
                          gridControlNovedades.DataSource = lista_novedades;
                          gridControlNovedades.RefreshDataSource();
                        break;

                    case "wizardPaginaNovedadesCreadas":
                        if (Validar())
                        {
                            if (!Novedad_subida_batch.SiArchivoFueSubido(param.IdEmpresa, info_perido.IdPeriodo.ToString(), "966"))
                            {
                                splashScreenManagereEspera.ShowWaitForm();

                               Guardar_Novedades();// grabo las novedades
                                Guardar_Marcaciones();// grabo las marcaciones 

                                Guardar_Nomina_x_horas_Extras();// guardar nomina x horas extras 
                                Novedad_subida_batch.GrabarDB(param.IdEmpresa, info_perido.IdPeriodo.ToString(), "966");// grabo el registro para controlar que no vuelva subir el mismo registro                                                              
                                Bandera_ValidarPagina = true;
                                group_box_datos_nomina.Visible = false;

                                splashScreenManagereEspera.CloseWaitForm();

                            }
                            else
                            {
                                MessageBox.Show("Ya existe un proceso para el periodo seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Bandera_ValidarPagina = false;
                            }
                        }
                        else
                        {
                            Bandera_ValidarPagina = false;
                        }
                        break;

                    case "WizardPaginaValidar":
                        this.Close();
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        

        }

        public bool ValidarSiSeleccionofile()
        {
            bool Bande = true;
            try
            {
                if (TxtRuraFile.Text == "")
                {
                    MessageBox.Show("Eeleccione un Archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }

                if (cmbHoja.Text == "")
                {
                    MessageBox.Show("Seleccione la hoja de Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }
                Bandera_ValidarPagina = Bande;
                return Bande;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }


        public string LimpiarCadena(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }

            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        private void frmRo_Importacion_Marcaciones_EXCEL_Load(object sender, EventArgs e)
        {
            try
            {


                info_parametro_horas_extras = bus_parametro_horas_extras.Get_info(param.IdEmpresa);
                Lista_empleado_en_base = dataEmp.get_lista_emp_con_sueldo_actual_para_calculo_HE(param.IdEmpresa);
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                cmbnomina.EditValue = 1;


            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {

            try
            {
                ObterRutaExcel();
                if (!CargarHojasCombo())
                    MessageBox.Show("Archivo de excel no valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        bool CargarHojasCombo()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                bool flag = false;
                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;
                if (ruta != "")
                {
                    if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                    {
                        cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                        cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                    }
                    else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                    {
                        cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                        cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                    }

                    OleDbConnection mconn2 = new OleDbConnection(cb.ConnectionString);
                    //abre una conexion de tipo oledb
                    mconn2.Open();
                    dt = mconn2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    //Lo agrega a mi datatable
                    if (dt != null)
                    {
                        String[] excelSheets = new String[dt.Rows.Count];
                        int i = 0;

                        // Add the sheet name to the string array.
                        cmbHoja.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            excelSheets[i] = row["TABLE_NAME"].ToString();
                            cmbHoja.Items.Add(excelSheets[i].Substring(0, excelSheets[i].Length - 1)); //$
                            i++;
                        }
                        cmbHoja.SelectedIndex = 0;
                        //cierra una conexion de tipo oledb                
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                    mconn2.Close();
                    return flag;
                }
                else
                {
                    return flag;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); dt = new DataTable();
                return false;
            }
        }

        void ObterRutaExcel()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
               // dialogo.Filter = "All files (*.XLS*)|*.XLSX*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    TxtRuraFile.Text = ruta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void wizardPaginaempleados_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                e.Valid = Bandera_ValidarPagina;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardPaginaMarcaciones_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                e.Valid = Bandera_ValidarPagina;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewNovxEmp_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewNovxEmp.GetRow(e.RowHandle) as ro_marcaciones_x_Jornada_Info;
                if (data == null)
                    return;

                if (data.error == "No esta registrado este colaborador en la Base de datos VZEN")
                    e.Appearance.ForeColor = Color.Red;
                if(data.grupo.Calculo_Horas_extras_Sobre==0)
                    e.Appearance.ForeColor = Color.Orange;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void CargarRubros()
        {
            try
            {
                lista_rubro = rubro_bus.Get_List_Rubros_Horas_Extras(param.IdEmpresa);
                cmb_rubros.DataSource = lista_rubro;
                cmb_rubros.DisplayMember = "ru_descripcion";
                cmb_rubros.ValueMember = "IdRubro";
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
               
            }
        }

        public void Get_Horas_extras_x_rubro_x_empleado(List<ro_marcaciones_x_Jornada_Info> lista, double Sueldo_Actual )
        {
            try
            {
                lista_novedades_Tmp.AddRange( marcaciones_x_jornda_bus.Get_list_Horas_Extras(lista, Sueldo_Actual));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }


        public void Get_Marcaciones(List<ro_marcaciones_x_Jornada_Info> lista)
        {
            try
            {
                listado_marcaciones_guardar_DB = marcaciones_x_jornda_bus.Get_List_Marcaciones(lista,Convert.ToInt32(cmbPeriodos.EditValue));
                gridControlNovedades.DataSource = lista_novedades_Tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }


        private void wizardImportacionMarcaciones_Click(object sender, EventArgs e)
        {
          
        }

        public void Guardar_Novedades()
        {
            try
            {
                decimal id_nov = 0;
                List<ro_Empleado_Novedad_Det_Info> lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                ro_Empleado_Novedad_Info Novedad_info = new ro_Empleado_Novedad_Info();
                ro_Empleado_Novedad_Det_Info Novedad_detalle_info = new ro_Empleado_Novedad_Det_Info();

                double Tota_Valor = 0;
                double NumHoras = 0;
                foreach (var item in lista_de_empleado_x_marcaciones)
                {
                    // novedad al 25%
                    lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                    Novedad_info = new ro_Empleado_Novedad_Info();
                    lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.IdRubro == "7").ToList();
                    if (lista_nov_tmp.Count()>0)// si tiene novedad por horas al 25%
                    {
                        // armo la cabecera de la novedad
                        Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                        NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                        Novedad_info.TotalValor = Tota_Valor;
                        Novedad_info.IdEmpresa = param.IdEmpresa;
                        Novedad_info.IdEmpleado = item.IdEmpleado;
                        Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                        Novedad_info.IdNomina_TipoLiqui =Convert.ToInt32( cmbnominaTipo.EditValue);
                        Novedad_info.Fecha = DateTime.Now;
                        Novedad_info.NumCoutas = 1;
                        Novedad_info.IdUsuario = param.IdUsuario;
                        Novedad_info.Fecha_Transac = DateTime.Now;
                        Novedad_info.Estado = "A";
                        // creo el detalle de la novedad
                        Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                        Novedad_detalle_info.NumHoras = NumHoras;
                        Novedad_detalle_info.Valor = Tota_Valor;
                        Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                        Novedad_detalle_info.IdCalendario = cmbPeriodos.EditValue.ToString();

                        Novedad_info.InfoNovedadDet=Novedad_detalle_info;
                        Novedad_info.IdCalendario = cmbPeriodos.EditValue.ToString();
                        novedad_bus.GrabarDB(Novedad_info, ref id_nov);

                        // grabo la novedad
                        
                    }




                    // novedad al 50%
                    lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                    Novedad_info = new ro_Empleado_Novedad_Info();
                    lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.IdRubro == "8").ToList();
                    if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 50%
                    {
                        // armo la cabecera de la novedad
                        Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                        NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                        Novedad_info.TotalValor = Tota_Valor;
                        Novedad_info.IdEmpresa = param.IdEmpresa;
                        Novedad_info.IdEmpleado = item.IdEmpleado;
                        Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                        Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue); 
                        Novedad_info.Fecha = info_perido.pe_FechaFin;
                        Novedad_info.NumCoutas = 1;
                        Novedad_info.IdUsuario = param.IdUsuario;
                        Novedad_info.Fecha_Transac = DateTime.Now;
                        Novedad_info.Estado = "A";
                        // creo el detalle de la novedad
                        Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                        Novedad_detalle_info.NumHoras = NumHoras;
                        Novedad_detalle_info.Valor = Tota_Valor;
                        Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                        Novedad_detalle_info.IdCalendario = cmbPeriodos.EditValue.ToString();
                        Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                        Novedad_info.IdCalendario = cmbPeriodos.EditValue.ToString();
                        novedad_bus.GrabarDB(Novedad_info, ref id_nov);

                    }



                    // novedad al 100%
                    lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                    Novedad_info = new ro_Empleado_Novedad_Info();
                    lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.IdRubro == "9").ToList();
                    if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 100%
                    {
                        // armo la cabecera de la novedad
                        Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                        NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                        Novedad_info.TotalValor = Tota_Valor;
                        Novedad_info.IdEmpresa = param.IdEmpresa;
                        Novedad_info.IdEmpleado = item.IdEmpleado;
                        Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                        Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                        Novedad_info.Fecha = info_perido.pe_FechaFin;
                        Novedad_info.NumCoutas = 1;
                        Novedad_info.IdUsuario = param.IdUsuario;
                        Novedad_info.Fecha_Transac = DateTime.Now;
                        Novedad_info.Estado = "A";
                        // creo el detalle de la novedad
                        Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                        Novedad_detalle_info.NumHoras = NumHoras;
                        Novedad_detalle_info.Valor = Tota_Valor;
                        Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                        Novedad_detalle_info.IdCalendario = cmbPeriodos.EditValue.ToString();

                        Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                        Novedad_info.IdCalendario = cmbPeriodos.EditValue.ToString();
                        novedad_bus.GrabarDB(Novedad_info, ref id_nov);
                    }







                    if (info_parametro_horas_extras.Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo)
                    {

                        // novedad de reverso por remplazo
                        lista_nov_tmp = new List<ro_Empleado_Novedad_Det_Info>();
                        Novedad_info = new ro_Empleado_Novedad_Info();
                        lista_nov_tmp = lista_novedades.Where(v => v.em_cedula == item.pe_cedula && v.es_Fech_remplazo.Year>2010).ToList();
                        if (lista_nov_tmp.Count() > 0)// si tiene novedad por horas al 100%
                        {
                            // armo la cabecera de la novedad
                            Tota_Valor = lista_nov_tmp.Sum(v => v.Valor);
                           // NumHoras = lista_nov_tmp.Sum(v => v.NumHoras);
                            Novedad_info.TotalValor = Tota_Valor;
                            Novedad_info.IdEmpresa = param.IdEmpresa;
                            Novedad_info.IdEmpleado = item.IdEmpleado;
                            Novedad_info.IdNomina_Tipo = item.Id_nomina_Tipo;
                            Novedad_info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                            Novedad_info.Fecha = info_perido.pe_FechaFin;
                            Novedad_info.NumCoutas = 1;
                            Novedad_info.IdUsuario = param.IdUsuario;
                            Novedad_info.Fecha_Transac = DateTime.Now;
                            Novedad_info.Estado = "A";
                            // creo el detalle de la novedad
                            Novedad_detalle_info = lista_nov_tmp.FirstOrDefault();
                            Novedad_detalle_info.NumHoras = 0;
                            Novedad_detalle_info.Valor = Tota_Valor;
                            Novedad_detalle_info.FechaPago = info_perido.pe_FechaFin;
                            Novedad_detalle_info.IdRubro = info_parametro_horas_extras.IdRubro_rev_Horas;
                            Novedad_detalle_info.Observacion = "Descuento por horas extras";
                            Novedad_detalle_info.IdCalendario =Convert.ToString( cmbPeriodos.EditValue);
                            Novedad_info.InfoNovedadDet = Novedad_detalle_info;
                            Novedad_info.IdCalendario = cmbPeriodos.EditValue.ToString();

                            novedad_bus.GrabarDB(Novedad_info, ref id_nov);
                        }

                    }
                }
            
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
          
        }
        public void Guardar_Marcaciones()
        {
            try
            {
                BusMarcaciones.GrabarDB(listado_marcaciones_guardar_DB, param.IdEmpresa,Convert.ToInt32(cmbPeriodos.EditValue));
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void Guardar_Nomina_x_horas_Extras()
        {
            try
            {
                string  msg="";
                ro_Nomina_X_Horas_Extras_Bus bus_nomina_Horas_Extras = new ro_Nomina_X_Horas_Extras_Bus();

                var horas_extras = marcaciones_x_jornda_bus.get_nomina_x_Horas_Extras();
                foreach (var item in horas_extras)
                {
                    item.IdPeriodo =Convert.ToInt32( cmbPeriodos.EditValue);
                    item.IdNominaTipo =Convert.ToInt32( cmbnomina.EditValue);
                    item.IdNominaTipoLiqui =Convert.ToInt32( cmbnominaTipo.EditValue);
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdCalendario=Convert.ToInt32( item.FechaRegistro.Year.ToString()+item.FechaRegistro.Month.ToString().PadLeft(2,'0')+item.FechaRegistro.Day.ToString().PadLeft(2,'0'));
                    bus_nomina_Horas_Extras.GuardarBD(item, ref msg);
                }
              
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_perido = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public bool Validar()
        {
            bool ba_si_datos_validos = true;
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " La nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ba_si_datos_validos = false;
                    Bandera_ValidarPagina = false;
                    return ba_si_datos_validos;

                }
                if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ba_si_datos_validos = false;
                    Bandera_ValidarPagina = false;
                    return ba_si_datos_validos;

                }
                if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ba_si_datos_validos = false;
                    Bandera_ValidarPagina = false;
                    return ba_si_datos_validos;

                }


                return ba_si_datos_validos;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return ba_si_datos_validos;
            }
        }
      
        private void wizardImportacionMarcaciones_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                
                
            }
        }
        private void wizardPaginaNovedadesCreadas_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                  e.Valid = Bandera_ValidarPagina;
            }
            catch (Exception ex)
            {
                
               
            }
        }

        private void WizardPaginaValidar_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pu_ProcesarSeleccionados()
        {
            try
            {


               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
