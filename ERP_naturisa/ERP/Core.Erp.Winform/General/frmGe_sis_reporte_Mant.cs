using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_sis_reporte : Form
    {

        public delegate void delegate_FrmGe_sis_reporte_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_sis_reporte_FormClosing event_FrmGe_sis_reporte_FormClosing;

        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_modulo_Bus Modulo_B = new tb_modulo_Bus();
        tb_sis_reporte_Info rpt_I = new tb_sis_reporte_Info();
        tb_sis_reporte_Bus rpt_B = new tb_sis_reporte_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        List<String> lstTipo = new List<String>();
        private Assembly Ensamblado;
        string Nom_SP = "";
        #endregion
        
        public FrmGe_sis_reporte()
        {
            
            try
            {
                InitializeComponent();
                event_FrmGe_sis_reporte_FormClosing += FrmGe_sis_reporte_event_FrmGe_sis_reporte_FormClosing;

                gridLookUpEdit_modulo.Properties.DataSource = Modulo_B.Get_list_Modulo();
                //cmbTabla.Properties.DataSource=rpt_B.Get_List_Tablas();
                lstTipo.Add("RESULTADO");
                lstTipo.Add("BALANCE");
                cmbTipo.Properties.DataSource = lstTipo;
                cmbTipo.Enabled = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmGe_sis_reporte_event_FrmGe_sis_reporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {               
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private bool valida()
        {
            try
            {
                if (txt_nombre.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre del Reporte ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txt_nomCorto.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre corto del Reporte ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txt_tabla.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre de la Tabla", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
                if (gridLookUpEdit_modulo.EditValue == null|| gridLookUpEdit_modulo.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Modulo al que pertenece el Reporte", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public byte[]ImageToByte(Image my_image)
        {
            try
            {
                if (my_image != null)
                {
                    MemoryStream Mstream = new MemoryStream();
                    my_image.Save(Mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return Mstream.ToArray();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                if (byteArrayIn != null)
                {
                    MemoryStream ms = new MemoryStream(byteArrayIn);
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void get_Info()
        {
            try
            {
                rpt_I.Class_NomReporte = txt_class_rpt.Text.Trim();
                rpt_I.Class_Info = txt_class_info.Text.Trim();
                rpt_I.Class_Bus = txt_class_bus.Text.Trim();
                rpt_I.Class_Data = txt_class_data.Text.Trim();

                rpt_I.CodReporte = txt_Id.Text.Trim();
                rpt_I.Formulario = txt_frm.Text.Trim();
                rpt_I.Modulo = gridLookUpEdit_modulo.EditValue.ToString();
                rpt_I.Nombre = txt_nombre.Text.Trim();
                rpt_I.NombreCorto = txt_nomCorto.Text.Trim();
                rpt_I.Observacion = txt_obser.Text.Trim();
                rpt_I.Orden = Convert.ToInt32(num_Orden.Value);
                
                rpt_I.VistaRpt = txt_tabla.Text.Trim();
                rpt_I.Estado = (chkEstado.Checked == true) ? "A" : "I";
                rpt_I.se_Muestra_Admin_Reporte = chkAdmRpts.Checked;
                rpt_I.Store_proce_rpt = txt_Store_Procedure.Text;

                rpt_I.imgByt= ImageToByte(pbox_logo.Image);
                rpt_I.VersionActual = Convert.ToInt32(num_version.Value);
                
                rpt_I.nom_Asembly = txt_asembly.Text.Trim();
                rpt_I.Tipo_Balance = cmbTipo.Text;
                rpt_I.SQuery = txtQuery.Text;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Info(tb_sis_reporte_Info info)
        {
            try
            {
                txt_class_info.Text=info.Class_NomReporte;
                txt_Id.Text=info.CodReporte;
                txt_frm.Text=info.Formulario;
                gridLookUpEdit_modulo.EditValue = info.Modulo;
                txt_nombre.Text=info.Nombre;
                txt_nomCorto.Text=info.NombreCorto;
                txt_obser.Text=info.Observacion;
                num_Orden.Value=info.Orden;
                txt_tabla.Text = info.VistaRpt;
                this.pbox_logo.Image = byteArrayToImage(info.imgByt);
                num_version.Value = info.VersionActual;
                txt_Store_Procedure.Text = info.Store_proce_rpt;

                txt_class_rpt.Text = info.Class_NomReporte;
                txt_class_bus.Text = info.Class_Bus;
                txt_class_data.Text = info.Class_Data;
                txt_class_info.Text = info.Class_Info;
                chkEstado.Checked = (info.Estado == "A") ? true : false;
                chkAdmRpts.Checked = (info.se_Muestra_Admin_Reporte == true) ? true : false;
                chkUsa_SP.Checked = (info.Store_proce_rpt != null) ? true : false;

                txt_asembly.Text = info.nom_Asembly;
                cmbTipo.Text = info.Tipo_Balance.Trim();
                txtQuery.Text = info.SQuery;
                rpt_I = info;
                if (info.Modulo == "CONTA")
                {
                    cmbTipo.Enabled = true;
                }
                else
                {
                    cmbTipo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private bool Grabar()
        {
            try
            {
                bool resultado = false;
                if (valida())
                {
                    get_Info();
                    if (txtQuery.Text == "" || txtQuery.EditValue == null)
                    {
                        rpt_I.SQuery = "select 1 as IdEmpresa";
                        resultado = true;
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (rpt_B.GuardarDB(rpt_I))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " el Reporte " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            resultado = true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos) + " del Reporte " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultado = false;
                        }
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (rpt_B.ModificarDB(rpt_I))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Reporte " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resultado = true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) + " del Reporte " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultado = false;
                        }
                    }
                    return resultado;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void gridLookUpEdit_modulo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var items = gridLookUpEdit_modulo.GetSelectedDataRow() as tb_modulo_Info;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (items != null)
                    {
                        string carpeta = items.Nom_Carpeta;
                        string codModulo = gridLookUpEdit_modulo.EditValue.ToString();
                        string num = rpt_B.Get_Numero(codModulo);
                        txt_Id.Text = gridLookUpEdit_modulo.EditValue.ToString() + "_" + num;
                        txt_tabla.Text = "vw" + codModulo + "_Rpt" + num;
                        txt_class_info.Text = carpeta + ".X" + codModulo + "_Rpt" + num + "_Info";
                        txt_class_bus.Text = carpeta + ".X" + codModulo + "_Rpt" + num + "_Bus";
                        txt_class_data.Text = carpeta + ".X" + codModulo + "_Rpt" + num + "_Data";
                        txt_class_rpt.Text = carpeta + ".X" + codModulo + "_Rpt" + num + "_Rpt";
                        txt_asembly.Text = "Core.Erp.Reportes";
                        txt_frm.Text = carpeta + ".X" + codModulo + "_Rpt" + num + "_frm";
                        Nom_SP = "sp" + codModulo + "_Rpt" + num;

                        if (codModulo == "CONTA")
                        {
                            cmbTipo.Enabled = true;
                        }
                        else
                        {
                            cmbTipo.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valida())
                 {
                       Grabar();
                        this.Close();
                   }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (valida())
                  {
                        Grabar();
                       this.Close();
                  }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_busLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialog.ShowDialog() != DialogResult.Cancel)
                {

                    Image image = Image.FromFile(openDialog.FileName);
                    pbox_logo.Image = image;
                    pbox_logo.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGe_sis_reporte_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        gridLookUpEdit_modulo.Enabled = false;
                        txt_Id.ReadOnly = true;
                        txt_Id.ReadOnly = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        gridLookUpEdit_modulo.Enabled = false;
                        txt_Id.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        gridLookUpEdit_modulo.Enabled = false;
                        ucGe_Menu.Visible_bntDiseñoReporte = false;
                        txt_Id.ReadOnly = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        BloquearDatos();
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTabla_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                System.Data.DataTable DS = rpt_B.Get_DataTable_Tabla(cmbTabla.Text);
                gridView1.Columns.Clear();
                gridControl1.DataSource = new object();
                gridControl1.DataSource = DS;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F5)
                {
                    try
                    {
                        System.Data.DataTable DS = new System.Data.DataTable();
                        DS = rpt_B.Get_DataSet_SQL(txtQuery.Text.Trim());

                        gridView1.Columns.Clear();
                        gridControl1.DataSource = new object();
                        gridControl1.DataSource = DS;

                    }
                    catch (Exception ex)
                    {
                        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                        NameMetodo = NameMetodo + " - " + ex.ToString();
                        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                        MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                            , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        void BloquearDatos()
        {
            try
            {
                txt_class_info.ReadOnly = true;
                txt_Id.ReadOnly = true;
                txt_frm.ReadOnly = true;
                gridLookUpEdit_modulo.Enabled = false;
                txt_nombre.ReadOnly = true;
                txt_nomCorto.ReadOnly = true;
                txt_obser.ReadOnly = true;
                num_Orden.Enabled = false;
                                txt_tabla.ReadOnly = true;
                this.pbox_logo.Enabled= false;
                num_version.Enabled = false;
                
                
                txt_asembly.ReadOnly = true;
                cmbTipo.Enabled = false;

                //BackColor
                txt_class_info.BackColor = Color.White;
                txt_Id.BackColor = Color.White;
                txt_frm.BackColor = Color.White;
                gridLookUpEdit_modulo.BackColor = Color.White;
                txt_nombre.BackColor = Color.White;
                txt_nomCorto.BackColor = Color.White;
                txt_obser.BackColor = Color.White;
                num_Orden.BackColor = Color.White;
                                txt_tabla.BackColor = Color.White;
                this.pbox_logo.BackColor = Color.White;
                num_version.BackColor = Color.White;
                
                txt_asembly.BackColor = Color.White;
                cmbTipo.BackColor = Color.White;

                btn_busLogo.Enabled = false;
                txtQuery.Enabled = false;
                txtQuery.BackColor = Color.White;
                btnQuery.Enabled = false;
                cmbTabla.Enabled = false;
                cmbTabla.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable DS = new System.Data.DataTable();
                DS = rpt_B.Get_DataSet_SQL(txtQuery.Text.Trim());

                gridView1.Columns.Clear();
                gridControl1.DataSource = new object();
                gridControl1.DataSource = DS;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                gridLookUpEdit_modulo.EditValue = "";
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                txt_class_info.ReadOnly = false;
                txt_Id.ReadOnly = false;
                txt_frm.ReadOnly = false;
                gridLookUpEdit_modulo.Enabled = true;
                txt_nombre.ReadOnly = false;
                txt_nomCorto.ReadOnly = false;
                txt_obser.ReadOnly = false;
                num_Orden.Enabled = true;
                txt_tabla.ReadOnly = false;
                this.pbox_logo.Enabled = true;
                num_version.Enabled = true;
                chkUsa_SP.Checked = false;
                
                txt_asembly.ReadOnly = false;
                cmbTipo.Enabled = true;

                txt_class_info.Text = "";
                txt_class_bus.Text = "";
                txt_class_data.Text = "";
                txt_class_rpt.Text = "";
                txt_Id.Text = "";
                txt_frm.Text = "";
                txt_nombre.Text = "";
                txt_nomCorto.Text = "";
                txt_obser.Text = "";
                num_Orden.Value = 0;
                txt_Store_Procedure.Text = "";

                txt_tabla.Text = "";
                this.pbox_logo.Image = null;
                num_version.Value = 0;
                
                txt_asembly.Text = "";
                cmbTipo.Text = "";
                txtQuery.Text = "";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }              

        private void ucGe_Menu_event_btnImpFrm_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre_dll = "";
                string Nom_asambly = "";
                string NombreFormulario = "";
                string RutaPantalla = "";

                Nom_asambly = txt_asembly.Text.Trim();
                NombreFormulario = txt_frm.Text.Trim();

                nombre_dll = Nom_asambly + ".dll";

                //cargando la dll
                Ensamblado = Assembly.LoadFrom(nombre_dll);

                // Load the object
                string nAsambly2 = txt_asembly.Text;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Nom_asambly + "." + NombreFormulario);

                AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;
                //

                RutaPantalla = Nom_asambly + "." + NombreFormulario;


                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario Emsamblado:" + Nom_asambly + "  Formulario:" + NombreFormulario, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjFrm = Activator.CreateInstance(tipo);
                    Form Formulario = (Form)ObjFrm;
                    Formulario.WindowState = FormWindowState.Maximized;
                    Formulario.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ucGe_Menu_event_btnImpRep_Click(object sender, EventArgs e)
        {

            try
            {

                string nombre_dll = "";
                string Nom_asambly = "";
                string NombreReporte = "";
                string RutaPantalla = "";

                Nom_asambly = txt_asembly.Text.Trim();
                NombreReporte = txt_class_rpt.Text.Trim();

                nombre_dll = Nom_asambly + ".dll";

                //cargando la dll
                Ensamblado = Assembly.LoadFrom(nombre_dll);

                // Load the object
                string nAsambly2 = txt_asembly.Text;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Nom_asambly + "." + NombreReporte);

                AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;
                //
                RutaPantalla = Nom_asambly + "." + NombreReporte;

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el Reporte Emsamblado:" + Nom_asambly + "  Reporte:" + NombreReporte, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjFrm = Activator.CreateInstance(tipo);
                    DevExpress.XtraReports.UI.XtraReport reporte1 = (DevExpress.XtraReports.UI.XtraReport)ObjFrm;
                    reporte1.ShowPreviewDialog();
                    
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkUsa_SP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int star_length = txt_Id.Text.Length-3;
                int finish_length = txt_Id.Text.Length;
                int length= finish_length-star_length;
                string codModulo = gridLookUpEdit_modulo.EditValue.ToString();
                string num = txt_Id.Text.Substring(star_length, length);
                txt_Store_Procedure.Enabled = chkUsa_SP.Checked;
                Nom_SP = "sp" + codModulo + "_Rpt" + num;
                

                if (txt_Store_Procedure.Enabled == true)
                {

                    txt_Store_Procedure.Text = Nom_SP;
                }

                if (txt_Store_Procedure.Enabled == false)
                {
                    txt_Store_Procedure.Text = "";
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void ucGe_Menu_event_btn_DiseñoReporte_Click(object sender, EventArgs e)
        {
            try
            {
                frmGe_sis_reporte_Disenador Report_dis = new frmGe_sis_reporte_Disenador();
                Report_dis.set_reporte(rpt_I);
                Report_dis.ShowDialog();
                Report_dis.Close();
  
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_sis_reporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_sis_reporte_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
