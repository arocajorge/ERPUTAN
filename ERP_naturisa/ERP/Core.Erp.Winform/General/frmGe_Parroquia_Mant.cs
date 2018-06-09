using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.General
{
    public partial class frmGe_Parroquia_Mant : Form
    {

        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_pais_Bus busPais= new tb_pais_Bus();
        List<tb_pais_Info> LstInfoPais = new List<tb_pais_Info>();

        tb_Provincia_Bus busProvincia = new tb_Provincia_Bus();
        List<tb_provincia_Info> LstInfoPro = new List<tb_provincia_Info>();

        tb_Ciudad_Bus busCiudad = new tb_Ciudad_Bus();
        List<tb_ciudad_Info> lstCiudad = new List<tb_ciudad_Info>();

        tb_parroquia_Bus busParroquia = new tb_parroquia_Bus();
        tb_parroquia_Info InfoParroquia = new tb_parroquia_Info();

        Cl_Enumeradores.eTipo_action _Accion;

        public delegate void delegate_frmGe_Parroquia_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_Parroquia_Mant_FormClosing event_frmGe_Parroquia_Mant_FormClosing;

        public string IdParroquia { get; set; }

        public frmGe_Parroquia_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_frmGe_Parroquia_Mant_FormClosing += frmGe_Parroquia_Mant_event_frmGe_Parroquia_Mant_FormClosing;
        }

        void frmGe_Parroquia_Mant_event_frmGe_Parroquia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmGe_Parroquia_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar ; }
                CargarCombo();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (IdParroquia != null)
                            cmbCiudad.EditValue = IdParroquia;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarData())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Enabled_bntAnular = false;
                }
                else                
                    AnularDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

           

        void CargarCombo()
        {
            try
            {
                LstInfoPais = busPais.Get_List_pais();
                cmbPais.Properties.DataSource = LstInfoPais;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean GuardarData()
        {
            try
            {
                Boolean bolResult = false;
                string IdParroquia = "";
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busParroquia.Guardar_DB(InfoParroquia, ref IdParroquia, ref msjError))
                            {
                                txtIdParroquia.EditValue = IdParroquia;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente la Parroquia # " + IdParroquia, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                           
                            InfoParroquia.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            InfoParroquia.IdUsuarioUltMod = param.IdUsuario;

                            if (busParroquia.Modificar_DB(InfoParroquia, ref msjError))
                            {
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente la Parroquia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                InfoParroquia = new tb_parroquia_Info();
                cmbCiudad.EditValue = null;
                txtIdParroquia.EditValue = "";
                txtCodParroquia.EditValue = "";
                txtDescripcion.EditValue = "";

                
            }
            catch (Exception ex)
            { 
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean ValidarDatos()
        {
            try
            {
                if (cmbCiudad.EditValue == null || cmbCiudad.EditValue == "")
                {
                    MessageBox.Show("Seleccione el País", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCiudad.Focus();
                    return false;
                }

                if (txtDescripcion.EditValue == null || txtDescripcion.EditValue == "")
                {
                    MessageBox.Show("Ingrese el Nombre de la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
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

        Boolean AnularDatos()
        {
            try
            {
                Boolean bolResult = false;
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    InfoParroquia.MotivoAnula = frm.motivoAnulacion;
                    InfoParroquia.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoParroquia.IdUsuarioUltAnu = param.IdUsuario;

                    if (busParroquia.Anular_DB(InfoParroquia,  ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return bolResult;
            }
            catch (Exception ex)
            {
                                Log_Error_bus.Log_Error(ex.ToString());
                                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void GetInfo()
        {
            try
            {
                InfoParroquia.IdCiudad_Canton = Convert.ToString(cmbCiudad.EditValue);
                InfoParroquia.IdParroquia = (txtIdParroquia.EditValue == "") ? null : Convert.ToString(txtIdParroquia.EditValue);
                InfoParroquia.cod_parroquia = (txtCodParroquia.EditValue == "") ? null : Convert.ToString(txtCodParroquia.EditValue);
                InfoParroquia.nom_parroquia = Convert.ToString(txtDescripcion.EditValue);

                InfoParroquia.IdUsuario = param.IdUsuario;
                InfoParroquia.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                InfoParroquia.nom_pc = param.nom_pc;
                InfoParroquia.ip = param.ip;
                InfoParroquia.IdUsuarioUltMod = param.IdUsuario;
                InfoParroquia.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SeInfo(tb_parroquia_Info Info_Parroquia)
        {
            try
            {
                cmbCiudad.EditValue = Info_Parroquia.IdCiudad_Canton;
                txtIdParroquia.EditValue = Info_Parroquia.IdParroquia;
                txtCodParroquia.EditValue = Info_Parroquia.cod_parroquia;
                txtDescripcion.EditValue = Info_Parroquia.nom_parroquia;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmGe_Parroquia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmGe_Parroquia_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void cargarComboProvi(string IdPais)
        {
            try
            {
                LstInfoPro = busProvincia.Get_List_Provincia(IdPais);
                cmbProvincia.Properties.DataSource = LstInfoPro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void cargarComboCiudad(string IdProvincia)
        {
            try
            {
                lstCiudad = busCiudad.Get_List_Ciudad(IdProvincia);
                cmbCiudad.Properties.DataSource = lstCiudad;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPais_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarComboProvi(Convert.ToString(cmbPais.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProvincia_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarComboCiudad(Convert.ToString(cmbProvincia.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
