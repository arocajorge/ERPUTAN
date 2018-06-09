using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using System.IO;
using System.Data.OleDb;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Efectividad_entrega_x_periodo_xempleado_mant : Form
    { 
        #region variable

        DataTable dt;
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";


        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }

        
        List<ro_ruta_Info> lista_ruta = new List<ro_ruta_Info>();
        ro_ruta_Bus bus_ruta = new ro_ruta_Bus();




        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();



        ro_fectividad_Entrega_x_Periodo_Empleado_Info info_efectividad= new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
        ro_fectividad_Entrega_x_Periodo_Empleado_Bus bus_efectividad = new ro_fectividad_Entrega_x_Periodo_Empleado_Bus();
        BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad = new BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();
        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus bus_efectividad_detalle = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus();



        List<ro_Calculo_Pago_Variable_Porcentaje_Info> Lista_Calculo = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();

        ro_Calculo_Pago_Variable_Porcentaje_Bus Bus_Calculo = new ro_Calculo_Pago_Variable_Porcentaje_Bus();
        
        #endregion
        public frmRo_Efectividad_entrega_x_periodo_xempleado_mant()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                    Guardar_Datos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                if (Guardar_Datos())
                    this.Close();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cargar_dato()
        {
            try
            {

                cmb_ruta.ValueMember = "IdRuta";
                cmb_ruta.DisplayMember = "ru_descripcion";

                // lista de rutas 
                lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);
                cmb_ruta.DataSource = lista_ruta;




                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmRo_Efectividad_entrega_x_periodo_xempleado_mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_dato();
            

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    cmbnomina.Enabled = false;
                    cmbnominaTipo.Enabled = false;
                    cmbPeriodos.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    break;
                case Cl_Enumeradores.eTipo_action.duplicar:
                    break;
                
                default:
                    break;
            }

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_periodo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                if (info_periodo == null)
                    info_periodo = listadoPeriodo.Where(v => v.IdPeriodo == info_efectividad.IdPeriodo).FirstOrDefault();
                lista_efectividad = new BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>(bus_efectividad_detalle.lista_planificada(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue),Convert.ToInt32(cmbPeriodos.EditValue)));
                gridControl_Efectividad.DataSource = lista_efectividad;



                Lista_Calculo = Bus_Calculo.Get_List_Calculo_Pago_Porcentaje(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                gc_ro_Calculo_Pago_Variable_Porcentaje.DataSource = Lista_Calculo;
         

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Get()
        {
            try
            {
                info_efectividad = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
                info_efectividad.lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();
                info_efectividad.IdEmpresa = param.IdEmpresa;
                info_efectividad.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                info_efectividad.IdNomina_tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                info_efectividad.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                info_efectividad.Observacion = txtobservacion.Text;
                info_efectividad.IdUsuario = param.IdUsuario;
                info_efectividad.FechaTransac = DateTime.Now;
                info_efectividad.IdUsuarioUltModi = param.IdUsuario;
                info_efectividad.FechaUltModi = DateTime.Now;

                foreach (var item in lista_efectividad)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    item.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdNomina_tipo_Liq = info_efectividad.IdNomina_tipo_Liq;
                    item.IdPeriodo = info_efectividad.IdPeriodo;
                    item.fecha_Pago = info_periodo.pe_FechaIni.AddDays(1);
                }

                info_efectividad.lista = lista_efectividad.ToList();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void set(ro_fectividad_Entrega_x_Periodo_Empleado_Info info)
        {
            try
            {
                info_efectividad = info;
                cmbnomina.EditValue = info.IdNomina_Tipo;
                cmbnominaTipo.EditValue = info.IdNomina_tipo_Liq;
                cmbPeriodos.EditValue = info.IdPeriodo;
                txtobservacion.Text = info.Observacion;
                lista_efectividad =new BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>( bus_efectividad_detalle.lista_efectividad_x_periodo_x_empleado(info.IdEmpresa, info.IdNomina_Tipo, info.IdPeriodo,info.IdEfectividad));
                gridControl_Efectividad.DataSource = lista_efectividad;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Validar()
        {
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Seleccione el periodo para la planificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Ingrese una observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        bool Grabar()
        {
            try
            {
                Get();
                return bus_efectividad.Guardar_DB(info_efectividad);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool Modificar()
        {
            try
            {
                Get();
                return bus_efectividad.Modificar_DB(info_efectividad);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool Anular()
        {
            try
            {
                Get();
                return bus_efectividad.Anular_DB(info_efectividad);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        bool Guardar_Datos()
        {
            try
            {
                bool bandera_si_grabo = false;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                      bandera_si_grabo = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                     bandera_si_grabo  = Modificar();
                     break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                     bandera_si_grabo = Anular();
                     break;                  
                    default:
                     bandera_si_grabo= false;
                     break;
                }

                if (bandera_si_grabo)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);


                return bandera_si_grabo;


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridView_planificacion_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           if (e.Column.Name == "Col_imagen")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_Efectividad.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void nuevaRutaToolStripMenuItem_Click(object sender, EventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString()); 
                dt = new DataTable();
                return false;
            }
        }

        private void btb_ruta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!Validar_Carga_Archivo())
                    return;

                ObterRutaExcel();
                if (!CargarHojasCombo())
                {
                    MessageBox.Show("Archivo de excel no valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Get_Marcaciones_x_Turnos(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        bool Validar_Carga_Archivo()
        {
            try
            {
                return Validar_datos_periodo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        bool Validar_datos_periodo()
        {
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Seleccione el periodo para la planificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtobservacion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Ingrese una observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (lista_efectividad.Count() == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " No existe datos de planificación para la nomina y periodo seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }



        public void Get_Marcaciones_x_Turnos(string RutaFile)
        {
           
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


                    string Hoja = cmbHoja.Text;
                    conexion.Open();
                    string Sql = "SELECT Ruta,Efectividad_Entrega,Efectividad_Volumen,Recuperacion_cartera " +
                             "FROM [" + Hoja + "$]  where Ruta is not null";


                    OleDbCommand Cmd = new OleDbCommand(Sql, conexion);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        if (Reader.IsDBNull(0) == false)
                        {
                            bool bandera_ = false;

                            ro_Calculo_Pago_Variable_Porcentaje_Info info_rango_pago = new ro_Calculo_Pago_Variable_Porcentaje_Info();
                            string Ruta = Reader.GetString(0);
                           // if (ceduala.Length == 9)
                             //   ceduala = "0" + ceduala;
                            foreach (var item in lista_efectividad)
                            {
                                if (item.ru_descripcion.Trim() == Ruta.Trim())
                                {
                                    bandera_ = true;
                                    List<ro_Calculo_Pago_Variable_Porcentaje_Info> Lista_tmp = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();
                                    item.ruta_excel = Reader.GetString(0).ToString();
                                    // busco el porcentaje correspondiente de efectividad
                                    item.Efectividad_Entrega = Reader.GetDouble(1);

                                    Lista_tmp = Lista_Calculo.Where(v => v.Efec_Entrega_Rango == item.Efectividad_Entrega).ToList();
                                    if (Lista_tmp.Count() > 0)
                                        item.Efectividad_Entrega_aplica = Convert.ToDouble(Lista_tmp.FirstOrDefault().Efec_Entrega_Aplica);
                                    else
                                        item.Efectividad_Entrega_aplica = 0;

                                    // busco el porcentaje correspondiente de volumen de entrega

                                    item.Efectividad_Volumen = Reader.GetDouble(2);

                                    Lista_tmp = Lista_Calculo.Where(v => v.Efec_Volumen_Rango == item.Efectividad_Volumen).ToList();
                                    if (Lista_tmp.Count() > 0)
                                        item.Efectividad_Volumen_aplica = Convert.ToDouble(Lista_tmp.FirstOrDefault().Efec_Volumen_Aplica);
                                    else
                                        item.Efectividad_Entrega_aplica = 0;
                                    // busco el porcentaje correspondiente de volumen de entrega

                                    item.Recuperacion_cartera = Reader.GetDouble(3);

                                    Lista_tmp = Lista_Calculo.Where(v => v.Recup_Cartera_Rango == item.Recuperacion_cartera).ToList();
                                    if (Lista_tmp.Count() > 0)
                                        item.Recuperacion_cartera_aplica = Convert.ToDouble(Lista_tmp.FirstOrDefault().Recup_Cartera_Aplica);
                                    else
                                        item.Efectividad_Entrega_aplica = 0;
                                    item.Error = null;
                                    break;
                                }
                                else
                                {
                                    item.Error = "Error las rutas no coinciden";
                                }
                                
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

        private void gvw_ro_Calculo_Pago_Variable_Porcentaje_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           
        }

        private void gridView_Efectividad_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Efectividad.GetRow(e.RowHandle) as ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info;
                if (data == null)
                    return;
                if (data.Error ==null || data.Error=="")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
