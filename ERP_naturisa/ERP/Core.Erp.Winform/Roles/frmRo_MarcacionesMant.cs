using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using System.Globalization;
using System.IO;
using System.Data.OleDb;

using System.Threading;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_MarcacionesMant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Empleado_Bus busEmp = new ro_Empleado_Bus();
        List<ro_Empleado_Info> LstInfoEmp = new List<ro_Empleado_Info>();
        BindingList<ro_Empleado_Info> BindListEmp = new BindingList<ro_Empleado_Info>();
        BindingList<ro_marcaciones_x_empleado_Info> BindListMarc = new BindingList<ro_marcaciones_x_empleado_Info>();
        ro_marcaciones_x_empleado_Bus BusMarcac = new ro_marcaciones_x_empleado_Bus();
        List<ro_marcaciones_x_empleado_Info> ListMarc = new List<ro_marcaciones_x_empleado_Info>();
        List<ro_marcaciones_x_empleado_Info> ListaProcesada = new List<ro_marcaciones_x_empleado_Info>();
        string Mensaje = "";
        List<ro_marcaciones_tipo_Info> LstTipMarc = new List<ro_marcaciones_tipo_Info>();
        //Hilo
        Thread oThreadProcesar;
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        DataTable ds = new DataTable();
        string msg;
        public delegate void delegate_frmRo_MarcacionesMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_MarcacionesMant_FormClosing event_frmRo_MarcacionesMant_FormClosing;
        #endregion
       
        public frmRo_MarcacionesMant()
        {
            try
            {
                InitializeComponent();
                inicializar();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_MarcacionesMant_FormClosing += frmRo_MarcacionesMant_event_frmRo_MarcacionesMant_FormClosing;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frmRo_MarcacionesMant_event_frmRo_MarcacionesMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmRo_MarcacionesMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_MarcacionesMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoEquipo.EditValue != null)
                {

                    if (grabar())
                    {
                        MessageBox.Show("Grabado correctamente"); Close();
                    }
                }

                else
                {
                    MessageBox.Show("Seleccione el equipo de marcación");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoEquipo.EditValue != null)
                {
                    var Info = (ro_marcaciones_x_empleado_Info)this.gridViewMarcaciones.GetFocusedRow();

                    if (Info != null)
                    {
                        if (Info.existeerror.Trim() != "N")
                        {
                            MessageBox.Show("Error al grabar. Verificar los datos en ROJO", "Sistemas");
                            return;
                        }
                        else
                        {
                            grabar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese las marcaciones de los empleados");
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione el equipo de marcación");

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        void inicializar()
        {            
            try
            {
                
                ro_marcaciones_Equipo_Bus busEquipos = new ro_marcaciones_Equipo_Bus();
                var listadoequipos = busEquipos.Get_List_marcaciones_Equipo(param.IdEmpresa,param.IdSucursal);
                cmbTipoEquipo.Properties.DataSource = listadoequipos;

                //carga los tipos de marcaciones
                ro_marcaciones_tipo_Bus busTipo = new ro_marcaciones_tipo_Bus();
                LstTipMarc = busTipo.Get_List_marcaciones_tipo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

            this.gridViewMarcaciones.OptionsBehavior.Editable = false;
        }
        
        private string diacalendario(DateTime fecha)
        {
            try
            {
                var s = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
                string Dia_Semana = fecha.ToString("dddd", new CultureInfo("es-Ec"));
                return Dia_Semana;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                return null;

            }
        }

        private int semanadelaño(DateTime fecha)
        {
            try
            {
                
                int x = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(fecha , CalendarWeekRule.FirstFullWeek, fecha.DayOfWeek);

                return x;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                return 0;

            }
        }

        private Boolean  getInfo()
        {
            bool resultado = false;

            try
            {
                DateTime dt = new DateTime(0001, 1, 1);

                ListMarc = new List<ro_marcaciones_x_empleado_Info>();
                foreach (var item in BindListMarc)
                {
                        ro_marcaciones_x_empleado_Info info = new ro_marcaciones_x_empleado_Info();
                                                       
                    // validacion para el ingreso de empleados con codigo biometrico
                    if (item.IdEmpleado != 0 && (item.IdTipoMarcaciones != "" || item.es_fechaRegistro!=dt))
                        {
                        
                            info.IdEmpleado = item.IdEmpleado;
                            info.IdEmpresa = param.IdEmpresa;
                            DateTime fec = Convert.ToDateTime(item.es_fechaRegistro);
                            info.es_fechaRegistro = fec;
                            info.es_anio = fec.Year;
                            info.es_dia = Convert.ToInt32(fec.DayOfWeek);
                            info.es_semana = semanadelaño(fec);
                            info.es_sdia = diacalendario(fec);
                            info.es_idDia = fec.Day;
                            info.es_mes = fec.Month;
                            info.es_EsActualizacion = "N";
                            info.es_Hora = item.es_Hora;
                            info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                            info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                          
                            // Codigo IdRegistro                        
                            string horas = Convert.ToString(info.es_Hora);
                            DateTime ho = DateTime.Now;
                            TimeSpan horaa;
                          
                             ho = Convert.ToDateTime(horas);
                             horaa = ho.TimeOfDay;

                             TimeSpan ts = horaa;
                           
                            int Horas = ts.Hours;
                            string hora = Convert.ToString(Horas);

                            int Minutos = ts.Minutes;
                            string minuto = Convert.ToString(Minutos);

                            int Segundos = ts.Seconds;
                            string segundo = Convert.ToString(Segundos);

                            int d = Convert.ToInt32(info.es_idDia);
                            string dia = Convert.ToString(d);

                            int m = Convert.ToInt32(info.es_mes);
                            string mes = Convert.ToString(m);

                            int a = Convert.ToInt32(info.es_anio);
                            string anio = Convert.ToString(a);

                            if (dia.Length == 1)
                                dia = "0" + dia;
                         
                            if (mes.Length == 1)
                                mes = "0" + mes;

                            if (hora.Length == 1)
                                hora = "0" + hora;

                            if (minuto.Length == 1)
                                minuto = "0" + minuto;

                            if (segundo.Length == 1)
                                segundo = "0" + segundo;

                            info.IdRegistro = Convert.ToString(info.IdEmpleado) + anio + mes + dia + info.IdTipoMarcaciones + hora + minuto + segundo;
                            // Codigo IdRegistro
                            ListMarc.Add(info);

                        
                        
                        }
                                                         
                }
                if (BindListMarc.Count < 1)
                {
                    MessageBox.Show("Por favor seleccione empleados para registrar las marcaciones");

                    return false;
                }
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

            return resultado;
        }       

        private Boolean grabar()
        {
            bool resultado = false;
            try
            {
                txtHoja.Focus();
                if (getInfo())
                {
                    //Hilo
                    PbarEstado.Value = 0;
                    TimerProcesar1.Enabled = true;

                    backgroundWorker_Marca.RunWorkerAsync();

                    //
                    oThreadProcesar = new Thread(new ThreadStart(grabar_db));
                    oThreadProcesar.Start();
                    Thread.Sleep(1);

                    Mensaje = "Proceso Grabación .....";

                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                resultado = false;

            } return resultado;

        }

        public void grabar_db()
        {
            try
            {
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

  
              
        void ObtenerRuta()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();

               // dialogo.Filter = "All files (*.*)|*.*";

                dialogo.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                //solo los archivos excel

                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                                
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);

                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    txtRuta.Text = ruta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
          
        }
        
        void CargarArchivoExcelADataTable()
        {
            try
            {
               
                String strconn = "";
                strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtRuta.Text + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(strconn);
                //
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [" + txtHoja.Text + "$]", mconn);
                
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(ds);
                //cierra una conexion de tipo oledb
                mconn.Close();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); ds = new DataTable();
                
            }
        }

        public void cargaExcel()
        {
            try
            {
                        CargarArchivoExcelADataTable();
                        ListaProcesada = BusMarcac.ProcesarDataTableAInfo_x_TipEquipo(ds, Convert.ToInt32(cmbTipoEquipo.EditValue), param.IdEmpresa, ref msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
           
        public void Cargar_excel_grilla()
       {

           try
           {

               if (cmbTipoEquipo.EditValue != null)
               {
                   List<ro_marcaciones_x_empleado_Info> ListaProcesada = new List<ro_marcaciones_x_empleado_Info>();

                   if (txtRuta.Text != "")
                   {

                       this.gridControlMarcaciones.DataSource = null;
                       //Hilo
                       PbarEstado.Value = 0;
                       TimerProcesar1.Enabled = true;

                       backgroundWorker_Marca.RunWorkerAsync();

                       //
                       oThreadProcesar = new Thread(new ThreadStart(cargaExcel));
                    
                       oThreadProcesar.Start();
                       Thread.Sleep(1);

                       Mensaje = "Proceso Carga Excel terminado ...";


                       //MessageBox.Show("Proceso completado satisfactoriamente");
                   }
                   else { MessageBox.Show("Por favor seleccione un archivo válido."); }
                   if (txtRuta.Text == "")
                   { MessageBox.Show("Por favor ingrese el nombre de la hoja."); }

               }

               else
               {
                   MessageBox.Show("Seleccione el equipo de marcación");
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
               Log_Error_bus.Log_Error(ex.ToString());
           }       
       }

        private void btnObtenerRuta_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbTipoEquipo.EditValue == null || cmbTipoEquipo.EditValue == "")
                {
                    MessageBox.Show("Seleccione el equipo de marcación ","Sistemas");
                    return;
                }

                ObtenerRuta();

                if (fileName == "" || path == "" || tipofile == "")
                {                   
                    return;
                }

                cargaExcel();

                if(this.ListaProcesada.Count()==0)
                {
                    return;             
                }
                                      
                Cargar_excel_grilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }      
        
        private void TimerProcesar1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (oThreadProcesar.IsAlive == false) //esta ejecutandoce
                {
                    backgroundWorker_Marca.CancelAsync();
                    TimerProcesar1.Enabled = false;
                    PbarEstado.Value = 100;


                    BindListMarc = new BindingList<ro_marcaciones_x_empleado_Info>(ListaProcesada);

                    gridControlMarcaciones.DataSource = BindListMarc;

                    MessageBox.Show(Mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void backgroundWorker_Marca_DoWork(object sender, DoWorkEventArgs e)
        {
          
            //no usaremos código try/catch aquí, a no ser que después hagamos un throw de la excepción capturada.
            //es necesario dejar que el backgroundworker sea quien capture cualquier excepción producida.
            //si se produce una excepción, el control la disponibilizará una vez haya finalizado su ejecución,
            //y disparado el evento "backgroundWorker_RunWorkerCompleted"
            //the RunWorkerCompletedEventArgs object, method backgroundWorker_RunWorkerCompleted
            //try
            //{
            DateTime start = DateTime.Now;
            e.Result = "";
            //HMayorizacion.Mayorizar(periodoSelect, ref mensajeError);

            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (i == 100) { i = 0; }


                    System.Threading.Thread.Sleep(50); //simulamos trabajo

                    //hemos completado un porcentaje del trabajo previsto, luego notificamos de ello.
                    backgroundWorker_Marca.ReportProgress(i, DateTime.Now);

                    //descomenta este código para ver como esta excepción es gestionada por el
                    //control backgroundworker
                    //descomenta también el atributo indicado arriba para evitar que el depurador
                    //pare en la excepción, ya que queremos simular
                    //el comportamiento del control en tiempo de ejecución.
                    //if (i == 34)
                    //    throw new Exception("something wrong here!!");

                    //en caso de que soporte cancelación y el control haya recibido la petición de cancelación,
                    //cancelamos el trabajo. Es la manera en la que realizamos una salida "limpia".
                    if (backgroundWorker_Marca.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


            TimeSpan duration = DateTime.Now - start;

            //aquí podríamos devolver información de utilidad, como el resultado de un cálculo,
            //número de elementos afectados, etc.. de manera sencilla y segura
            //al hilo principal
            e.Result = "Duration: " + duration.TotalMilliseconds.ToString() + " ms.";
            //}
            //catch(Exception ex){
            //    MessageBox.Show("Don't use try catch here!");
            //}
        }

        private void backgroundWorker_Marca_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                PbarEstado.Value = e.ProgressPercentage; //actualizamos la barra de progreso
                DateTime time = Convert.ToDateTime(e.UserState); //obtenemos información adicional si procede
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void backgroundWorker_Marca_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {

                }
                else if (e.Error != null)
                {
                    MessageBox.Show("Detalle Error: " + (e.Error as Exception).ToString());
                }
                else
                {
                    //   MessageBox.Show("Proceso completado satisfactoriamente: " + e.Result.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

            PbarEstado.Value = 100;

        }

        private void gridViewMarcaciones_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var Info = (ro_marcaciones_x_empleado_Info)this.gridViewMarcaciones.GetRow(e.RowHandle);

                if (Info != null)
                {
                    if (Info.existeerror.Trim() != "N")
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_MarcacionesMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
       
      
     

    }
}
