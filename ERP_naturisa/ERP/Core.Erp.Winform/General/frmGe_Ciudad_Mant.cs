using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.General
{
    public partial class frmGe_Ciudad_Mant : DevExpress.XtraEditors.XtraForm
    {
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_Ciudad_Bus busCiudad = new tb_Ciudad_Bus();
        tb_ciudad_Info InfoCiudad = new tb_ciudad_Info();

        tb_Provincia_Bus busProvincia = new tb_Provincia_Bus();
        List<tb_provincia_Info> LstInfoPro = new List<tb_provincia_Info>();
        
        List<tb_pais_Info> LstInfoPais = new List<tb_pais_Info>();
        tb_pais_Bus busPais = new tb_pais_Bus();
        
        
        Cl_Enumeradores.eTipo_action _Accion;
        public delegate void delegate_frmGe_Ciudad_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_Ciudad_Mant_FormClosing event_frmGe_Ciudad_Mant_FormClosing;
        public string IdProvincia { get; set; }
        public string IdPais { get; set; }

        public frmGe_Ciudad_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_frmGe_Ciudad_Mant_FormClosing += frmGe_Ciudad_Mant_event_frmGe_Ciudad_Mant_FormClosing;
             
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

        void frmGe_Ciudad_Mant_event_frmGe_Ciudad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

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

        private void frmGe_Ciudad_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (IdPais != null)
                            cmbPais.EditValue = IdPais;
                        if (IdProvincia != null)
                            cmbProvincia.EditValue = IdProvincia;
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


        Boolean GuardarData()
        {
            try
            {
                Boolean bolResult = false;
                string IdCiudad = "";
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busCiudad.GuardarDB(InfoCiudad, ref IdCiudad, ref msjError))
                            {
                                txtIdCiudad.EditValue = IdCiudad;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente la Ciudad # " + IdCiudad, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:

                            InfoCiudad.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            InfoCiudad.IdUsuarioUltMod = param.IdUsuario;

                            if (busCiudad.ModificarDB(InfoCiudad, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                InfoCiudad = new tb_ciudad_Info();
                cmbProvincia.EditValue =  null;
                txtIdCiudad.EditValue = "";
                txtCodCiudad.EditValue = "";
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
                if (cmbProvincia.EditValue == null || cmbProvincia.EditValue == "")
                {
                    MessageBox.Show("Seleccione el País", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbProvincia.Focus();
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
                    InfoCiudad.MotivoAnula = frm.motivoAnulacion;
                    InfoCiudad.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoCiudad.IdUsuarioUltAnu = param.IdUsuario;

                    if (busCiudad.AnularDB(InfoCiudad, ref msjError))
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
                InfoCiudad.IdProvincia = Convert.ToString(cmbProvincia.EditValue);
                InfoCiudad.IdCiudad = (txtIdCiudad.EditValue == "") ? null : Convert.ToString(txtIdCiudad.EditValue);
                InfoCiudad.CodCiudad = (txtCodCiudad.EditValue == "") ? null : Convert.ToString(txtCodCiudad.EditValue);
                InfoCiudad.Descripcion = Convert.ToString(txtDescripcion.EditValue);

                InfoCiudad.IdUsuario = param.IdUsuario;
                InfoCiudad.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                InfoCiudad.nom_pc = param.nom_pc;
                InfoCiudad.ip = param.ip;
                InfoCiudad.IdUsuarioUltMod = param.IdUsuario;
                InfoCiudad.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SeInfo(tb_ciudad_Info Info_Ciu)
        {
            try
            {
                cmbPais.EditValue = Info_Ciu.IdPais;
                cmbProvincia.EditValue = Info_Ciu.IdProvincia;
                txtIdCiudad.EditValue = Info_Ciu.IdCiudad;
                txtCodCiudad.EditValue = Info_Ciu.CodCiudad;
                txtDescripcion.EditValue = Info_Ciu.Descripcion;
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

        private void frmGe_Ciudad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmGe_Ciudad_Mant_event_frmGe_Ciudad_Mant_FormClosing(sender, e);
                event_frmGe_Ciudad_Mant_FormClosing(sender, e);
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

    }
}