using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using System.Globalization;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_control_asistencia_eventual
 : Form
    {

        #region clases
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();

        BindingList<ro_Empleado_Info> lista_emplados = new BindingList<ro_Empleado_Info>();
        ro_Empleado_Bus bus_emplaeado = new ro_Empleado_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Catalogo_Bus bus_catalogo = new ro_Catalogo_Bus();
        List<ro_Catalogo_Info> lista_catalogo = new List<ro_Catalogo_Info>();
        List<ro_marcaciones_x_empleado_Info> listado_marcaciones = new List<ro_marcaciones_x_empleado_Info>();
        ro_marcaciones_x_empleado_Bus bus_marcaciones = new ro_marcaciones_x_empleado_Bus();

        List<ro_DiasFaltados_x_Empleado_Info> lista_dias_falta = new List<ro_DiasFaltados_x_Empleado_Info>();
        ro_DiasFaltados_x_Empleado_Bus dias_faltado_bus = new ro_DiasFaltados_x_Empleado_Bus();
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();

        ro_disco_Bus bus_disco = new ro_disco_Bus();
        List<ro_disco_Info> lista_disco = new List<ro_disco_Info>();
        ro_ruta_Bus bus_ruta = new ro_ruta_Bus();
        List<ro_ruta_Info> lista_ruta = new List<ro_ruta_Info>();

        ro_sala_Bus bus_sala = new ro_sala_Bus();
        List<ro_sala_Info> lista_salas = new List<ro_sala_Info>();
        List<ro_Cargo_Info> lista_cargo = new List<ro_Cargo_Info>();
        ro_Cargo_Bus bus_cargo = new ro_Cargo_Bus();


        #endregion
        public frmRo_control_asistencia_eventual()
        {
            InitializeComponent();
            Cargar_Datos();
        }

        private void gridControlAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void dTPFechaIni_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int dia =Convert.ToInt32( Convert.ToDateTime( dtp_es_fecha_registro.Value).DayOfWeek);
                pu_AgregarNombreCabeceraColumnas();
                InfoCalendario = Bus_Calendario.Get_Info_Calendario(dtp_es_fecha_registro.Value);
                Cargar_empleado();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); 
            }
        }

        private void frmRo_control_asistencia_Load(object sender, EventArgs e)
        {
            try
            {
                bus_marcaciones = new ro_marcaciones_x_empleado_Bus(param.IdEmpresa);
                dtp_es_fecha_registro.Value = DateTime.Now;
                Cargar_Catalogo();
                Cargar_empleado();
               
                pu_AgregarNombreCabeceraColumnas();
               
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void Cargar_empleado()
        {
            try
            {
                DateTime fecha=Convert.ToDateTime( dtp_es_fecha_registro.Value.ToShortDateString());
                lista_emplados = new BindingList<ro_Empleado_Info>(bus_emplaeado.Get_list_empleado_sin_registro_asistencia_eventuiales(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), fecha));
                gridControlAsistencia.DataSource = lista_emplados;

                lista_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(37);
                cmb_asistencia.DataSource = lista_catalogo;
                cmb_asistencia.DisplayMember = "ca_descripcion";
                cmb_asistencia.ValueMember = "CodCatalogo";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
        public void Cargar_Catalogo()
        {
            try
            {
               
                lista_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(37);
                cmb_asistencia.DataSource = lista_catalogo;
                cmb_asistencia.DisplayMember = "ca_descripcion";
                cmb_asistencia.ValueMember = "CodCatalogo";

                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                cmbnomina.EditValue = 2;


                lista_cargo = bus_cargo.ObtenerLstCargo(param.IdEmpresa);
                cmb_departamento_.DataSource = lista_cargo;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void pu_AgregarNombreCabeceraColumnas()
        {

            try
            {
              

               

                string[] fechas;
                Boolean[] visibles;

                visibles = new Boolean[32];
                for (int i = 0; i < 32; i++)
                {
                    visibles[i] = false;
                }

                fechas = new string[32];
                gridControlAsistencia.RefreshDataSource();
                gridControlAsistencia.Refresh();

                funcioncaptionvisiblecolumnas(fechas, visibles);

                for (int i = 0; i <= 2; i++)
                {
                    fechas[i] = diacalendario(dtp_es_fecha_registro.Value.AddDays(i));
                    visibles[i] = true;
                }

                funcioncaptionvisiblecolumnas(fechas, visibles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void funcioncaptionvisiblecolumnas(string[] fechas, Boolean[] visibles)
        {
            try
            {
                colIdTurnoDia0.Caption = fechas[0];
                colIdTurnoDia0.Visible = visibles[0]; colIdTurnoDia0.VisibleIndex = (visibles[0] == true) ? 10 : -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }




        }

        private string diacalendario(DateTime fecha)
        {
            try
            {
                var s = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
                string Dia_Semana = fecha.ToString("dddd", new CultureInfo("es-Ec"));
                return Dia_Semana.ToUpper().Substring(0, 3) + " " + fecha.ToShortDateString();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        private void dTPFechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                pu_AgregarNombreCabeceraColumnas();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public bool Grabar()
        {
            try
            {
              
                dtp_es_fecha_registro.Focus();
                Get_Marcaciones();
                bus_marcaciones.GrabarDB_Transgandia(listado_marcaciones);

                     foreach (var item in lista_dias_falta)
	                {
                        dias_faltado_bus.GuardarDB(item);

	                }
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_empleado();
                return true;
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }


        public void Get_Marcaciones()
        {
            try
            {
                lista_dias_falta = new List<ro_DiasFaltados_x_Empleado_Info>();
                listado_marcaciones = new List<ro_marcaciones_x_empleado_Info>();
                foreach (var item in lista_emplados)
                {
                    if (item.CodCatalogo != null)
                    {
                        if (item.check == true)
                        {
                       
                        ro_marcaciones_x_empleado_Info info = new ro_marcaciones_x_empleado_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                        info.IdRegistro = InfoCalendario.IdCalendario.ToString();
                        info.IdTipoMarcaciones = "IN1";
                        info.secuencia = 1;
                        info.es_Hora = item.Info_marcaciones_x_empleado.es_Hora;
                        info.es_fechaRegistro = Convert.ToDateTime(Convert.ToDateTime(dtp_es_fecha_registro.Value).ToShortDateString());
                        info.es_anio = Convert.ToDateTime(dtp_es_fecha_registro.Value).Year;
                        info.es_mes = Convert.ToDateTime(dtp_es_fecha_registro.Value).Month;
                        info.es_semana = InfoCalendario.Semana_x_anio;
                        info.es_dia = (int)Convert.ToDateTime(dtp_es_fecha_registro.Value).DayOfWeek;
                        info.es_idDia = (int)Convert.ToDateTime(dtp_es_fecha_registro.Value).DayOfWeek;
                        info.es_sdia = InfoCalendario.NombreDia;
                        info.es_EsActualizacion = "N";
                        info.IdTipoMarcaciones_Biometrico = "IN1";
                        if (item.Observacion == null)
                        {
                            info.Observacion = "Importadas por proceso del sistema";
                        }
                        
                        info.IdUsuario = param.IdUsuario;
                        info.Estado = "A";
                        info.Fecha_Transac = DateTime.Now;
                        info.IdPeriodo = (dtp_es_fecha_registro.Value.Year * 100) + dtp_es_fecha_registro.Value.Month;

                        info.info_novedad_x_ingreso.IdEmpresa = item.IdEmpresa;
                        info.info_novedad_x_ingreso.IdNomina_Tipo =Convert.ToInt32(cmbnomina.EditValue);
                        info.info_novedad_x_ingreso.IdEmpleado = item.IdEmpleado;
                        info.info_novedad_x_ingreso.IdTurno =1;
                        info.info_novedad_x_ingreso.es_jornada_desfasada =Convert.ToBoolean( item.Info_turno.es_jornada_desfasada);
                        info.info_novedad_x_ingreso.IdRegistro = info.IdRegistro + "-" + "IdE" + "-" + item.IdEmpleado.ToString();
                        info.info_novedad_x_ingreso.es_fecha_registro = Convert.ToDateTime(Convert.ToDateTime(dtp_es_fecha_registro.Value).ToShortDateString());
                        info.info_novedad_x_ingreso.Id_catalogo_Cat = item.CodCatalogo;
                        info.info_novedad_x_ingreso.es_jornada_desfasada = Convert.ToBoolean(item.Info_turno.es_jornada_desfasada);
                        info.info_novedad_x_ingreso.IdTurno = Convert.ToInt32(item.Info_turno.IdTurno);
                        info.info_novedad_x_ingreso.IdDisco = item.Iddisco;
                        info.info_novedad_x_ingreso.IdRuta = item.IdRuta;
                        info.info_novedad_x_ingreso.IdSala = item.IdSala;
                        info.IdPeriodo = (dtp_es_fecha_registro.Value.Year * 100) + dtp_es_fecha_registro.Value.Month;
                        if (InfoCalendario.EsFeriado == "S")
                        {
                            info.info_novedad_x_ingreso.es_feriado = true;
                        }
                        else
                        {
                            info.info_novedad_x_ingreso.es_feriado = false;
                        }
                        info.info_novedad_x_ingreso.Observacion = item.Observacion;
                        listado_marcaciones.Add(info);


                        if (item.CodCatalogo == "FAL")
                        {
                            ro_DiasFaltados_x_Empleado_Info info_faltas = new ro_DiasFaltados_x_Empleado_Info();
                            double sueldoActual = 0;
                            sueldoActual = bus_emplaeado.GetSueldoActual(item.IdEmpresa, item.IdEmpleado);

                            info_faltas.IdEmpresa = item.IdEmpresa;
                            info_faltas.IdNominaTipo = 1;
                            info_faltas.IdNominaTipoLiq=2;
                            info_faltas.IdEmpleado =Convert.ToInt32( item.IdEmpleado);
                            info_faltas.CodCatalogo = "218";
                            info_faltas.FechaFaltaDesde = dtp_es_fecha_registro.Value;
                            info_faltas.FechaFaltaHasta = dtp_es_fecha_registro.Value;
                            info_faltas.DiasFaltados = "1 Dia";
                            info_faltas.DiasDescuento = 2;
                            info_faltas.FechaDescuentaRol = dtp_es_fecha_registro.Value;
                            info_faltas.ValorDescuentaRol = Convert.ToDecimal((sueldoActual / 30) * 2);
                            info_faltas.Observacion = "Falta no justificada el " + dtp_es_fecha_registro.Value.ToString().Substring(0,10);
                            info_faltas.estado = "A";
                            info_faltas.IdUsuario = param.IdUsuario;
                            info_faltas.Fecha_Transac = DateTime.Now;
                            lista_dias_falta.Add(info_faltas);
                        }
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewAsistencia_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "colIdTurnoDia0")
                {
                    TimeSpan es_hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    if (Convert.ToString( gridViewAsistencia.GetFocusedRowCellValue(col_esHoras))=="")
                    {
                        gridViewAsistencia.SetFocusedRowCellValue(col_esHoras, es_hora);

                    }
                   
                }

            }
            catch (Exception ex)
            {
                
              MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                foreach (var item in lista_emplados)
                {
                    item.Info_marcaciones_x_empleado.es_Hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    gridControlAsistencia.RefreshDataSource();
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

                Cargar_empleado();

                if (lista_emplados.Count() == 0)
                    MessageBox.Show("No existe planificación para la semana actual!!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Cargar_Datos()
        {
            try
            {
                cmb_disco.ValueMember = "IdDisco";
                cmb_disco.DisplayMember = "Disco";

                cmb_ruta.ValueMember = "IdRuta";
                cmb_ruta.DisplayMember = "ru_descripcion";


                cmb_sala.ValueMember = "IdSala";
                cmb_sala.DisplayMember = "Sala";


                lista_disco = bus_disco.Get_List_Disco(param.IdEmpresa);
                cmb_disco.DataSource = lista_disco;
                lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);
                cmb_ruta.DataSource = lista_ruta;


                lista_salas = bus_sala.Get_List_sala(param.IdEmpresa);
                cmb_sala.DataSource = lista_salas;


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_disco_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_disco_mant frm = new frmRo_disco_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_disco = bus_disco.Get_List_Disco(param.IdEmpresa);
                cmb_disco.DataSource = lista_disco;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_ruta_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_ruta_mant frm = new frmRo_ruta_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);
                cmb_ruta.DataSource = lista_ruta;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_sala_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_sala_mant frm = new frmRo_sala_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_salas = bus_sala.Get_List_sala(param.IdEmpresa);
                cmb_sala.DataSource = lista_salas;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridViewAsistencia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {


                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewAsistencia.DeleteSelectedRows();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
