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
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.General;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_responsable_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_bus BusPersona = new tb_persona_bus();
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        in_responsable_Bus Bus_comprador = new in_responsable_Bus();
        tb_persona_Info InfoPersona = new tb_persona_Info();
        in_responsable_Info Info = new in_responsable_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<seg_usuario_info> list_usuario = new List<seg_usuario_info>();
        seg_usuario_bus bus_usuario = new seg_usuario_bus();

        public in_responsable_Info _SetInfo { get; set; }

        public delegate void delegate_FrmIn_responsable_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_responsable_Mant_FormClosing event_delegate_FrmIn_responsable_Mant_FormClosing;
        int C = 0;
        string MensajeError = "";
        #endregion

        public FrmIn_responsable_Mant()
        {
            InitializeComponent();

            event_delegate_FrmIn_responsable_Mant_FormClosing += FrmIn_responsable_Mant_event_delegate_FrmIn_responsable_Mant_FormClosing;
        }

        void FrmIn_responsable_Mant_event_delegate_FrmIn_responsable_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                Info = new in_responsable_Info();

                txtIdResponsable.EditValue = "";
                txtIdPersona.EditValue = "";
                txtCedula.Text = "";
                txtCedula.Enabled = true;
                txtNombre.Text = "";
                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                txtCedula.Focus();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {
            try
            {
                txtIdResponsable.Focus();
                Get_Responsable();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        string ver = "";
                        string variable = (this.txtCedula.Text).TrimEnd();

                        if (variable != "")
                        {
                            if (!BusPersona.Verifica_Ruc(this.txtCedula.Text, ref ver))
                            {
                                MessageBox.Show(ver);
                                return;
                            }

                            //if (Bus_comprador.VericarCedulaExiste(param.IdEmpresa, variable, ref  ver))
                            //{
                            //    MessageBox.Show("La Cédula #: " + txtCedula.Text + " , ya se encuentra ingresada ", "Sistemas");
                            //    return;
                            //}

                        }
                        if (txtNombre.Text != string.Empty)
                        {
                            if (Bus_comprador.VerificarNombre(param.IdEmpresa, txtNombre.Text, ref  ver))
                            {
                                MessageBox.Show("El comprador : " + ver + " ya existe");
                                return;
                            }
                        }

                        Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        Anular();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guardar()
        {
            try
            {
                if (txtNombre.EditValue == null)
                {
                    MessageBox.Show("Ingrese el nombre del comprador", "Sistemas");
                    txtNombre.Focus();
                    return;
                }

                if (Bus_comprador.GuardarDB(Info, ref MensajeError))
                {
                    txtIdResponsable.EditValue = Info.IdResponsable;
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El comprador ", Info.IdResponsable);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Actualizar()
        {
            try
            {
                if (Bus_comprador.ModificarDB(Info, ref MensajeError))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El comprador", Info.IdResponsable);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;    
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Anular()
        {
            try
            {
                if (Info.IdResponsable != 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular eL Comprador #: " + Info.IdResponsable + " ?", "Anulación de Comprador ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        Info.IdUsuarioUltAnu = param.IdUsuario;
                        Info.Fecha_UltAnu = DateTime.Now;
                        Info.MotiAnula = ofrm.motivoAnulacion;

                        if (Info.Estado == true)
                        {
                            if (Bus_comprador.AnularDB(Info, ref MensajeError))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El comprador", Info.IdResponsable);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                                lblAnulado.Visible = true;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, MensajeError);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Comprador:  " + Info.IdResponsable + " debido a que ya se encuentra anulado", "Anulación de Comprador ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Get_Responsable()
        {
            try
            {
                Info.IdResponsable = Convert.ToDecimal((txtIdResponsable.EditValue == "") ? "0" : txtIdResponsable.EditValue);
                Info.IdEmpresa = param.IdEmpresa;
                Info.Nom_responsable = Convert.ToString(txtNombre.EditValue);
                Info.IdPersona = txtIdPersona.EditValue == "" ? 0 : Convert.ToDecimal(txtIdPersona.EditValue);
                Info.IdUsuario = param.IdUsuario;
                Info.Fecha_Transac = DateTime.Now;
                Info.Estado = ckbActivo.Checked;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Info_Responsable()
        {
            try
            {
                if (Info != null)
                {
                    if (_SetInfo != null)
                    {
                        txtIdResponsable.EditValue = _SetInfo.IdResponsable;
                        txtIdPersona.EditValue = _SetInfo.IdPersona;
                        txtNombre.EditValue = _SetInfo.Nom_responsable;
                        this.ckbActivo.Checked = _SetInfo.Estado;
                        if (_SetInfo.Estado == false)
                        {
                            lblAnulado.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un comprador para poder modificarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un comprador para poder modificarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                txtNombre.Focus();

                if (txtNombre.EditValue == null || txtNombre.Text == "")
                {
                    MessageBox.Show("Por Favor Ingresar Nombre");
                    txtNombre.Focus();
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Inhabilita_Campos(int C)
        {
            try
            {
                if (C == 1)
                {
                    txtIdResponsable.Enabled = false;
                    txtIdResponsable.BackColor = System.Drawing.Color.White;
                    txtIdResponsable.ForeColor = System.Drawing.Color.Black;
                }
                if (C == 4)
                {

                    txtIdResponsable.Enabled = false;
                    txtIdResponsable.BackColor = System.Drawing.Color.White;
                    txtIdResponsable.ForeColor = System.Drawing.Color.Black;

                    txtIdPersona.Enabled = false;
                    txtIdPersona.BackColor = System.Drawing.Color.White;
                    txtIdPersona.ForeColor = System.Drawing.Color.Black;

                    txtCedula.Enabled = false;
                    txtCedula.BackColor = System.Drawing.Color.White;
                    txtCedula.ForeColor = System.Drawing.Color.Black;

                    txtNombre.Enabled = false;
                    txtNombre.BackColor = System.Drawing.Color.White;
                    txtNombre.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {

                    txtIdResponsable.Enabled = false;
                    txtIdResponsable.BackColor = System.Drawing.Color.White;
                    txtIdResponsable.ForeColor = System.Drawing.Color.Black;

                    txtIdPersona.Enabled = false;
                    txtIdPersona.BackColor = System.Drawing.Color.White;
                    txtIdPersona.ForeColor = System.Drawing.Color.Black;

                    txtCedula.Enabled = false;
                    txtCedula.BackColor = System.Drawing.Color.White;
                    txtCedula.ForeColor = System.Drawing.Color.Black;

                    ckbActivo.Enabled = true;
                    txtIdPersona.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmIn_responsable_Mant(Cl_Enumeradores.eTipo_action Numerador): this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                if (txtCedula.Text != string.Empty)
                {
                    if (BusPersona.VericarCedulaExiste(txtCedula.Text, ref  msg))
                    {
                        InfoPersona = BusPersona.Get_Info_Persona(txtCedula.Text);

                        txtNombre.EditValue = InfoPersona.pe_nombreCompleto;
                        txtIdPersona.EditValue = Convert.ToDecimal(InfoPersona.IdPersona);
                    }
                }
                else
                {
                    txtNombre.EditValue = "";
                    txtIdPersona.EditValue = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_responsable_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_delegate_FrmIn_responsable_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_responsable_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);

                        txtCedula.Focus();
                        ckbActivo.Checked = true;
                        ckbActivo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;

                        C = 3;
                        Inhabilita_Campos(C);

                        Set_Info_Responsable();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;

                        C = 4;
                        Inhabilita_Campos(C);

                        Set_Info_Responsable();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        Set_Info_Responsable();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
