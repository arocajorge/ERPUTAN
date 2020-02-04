using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_sis_Mensajes_sys_Mantenimiento : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public tb_sis_Mensajes_sys_Info setInfo{ get; set;}

        tb_sis_Mensajes_sys_Info _Info = new tb_sis_Mensajes_sys_Info();
        tb_sis_Mensajes_sys_Bus MensajeBus = new tb_sis_Mensajes_sys_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;

        public delegate void delegate_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing;


        public FrmGe_sis_Mensajes_sys_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                //List<string> lst = MensajeBus.ListaMensajes();
                //foreach (string var in lst)
                //{
                //    cmbMensaje.Properties.Items.Add(var);
                //}

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_sis_Mensajes_sys_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        cbxEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtId.Enabled = false;
                        txtId.Text = setInfo.IdMensaje;
                        ucGe_Menu.Visible_bntAnular = false;
                        if (setInfo.Estado == "I")
                        {
                            lblEstado.Visible = true;
                            cbxEstado.Enabled = true;
                        }
                        else
                        {
                            cbxEstado.Enabled = false;
                        }
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                      ucGe_Menu.Visible_btnGuardar = false;
                        bloquear_Datos();
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        bloquear_Datos();
                        Set();
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


        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Boolean Validar()
        {
            try
            {
                if ((txtId.Text == "")&&(txtMensajeI.Text == "") && (cmbMensaje.Text == "" || cmbMensaje.EditValue == null))
                {
                    MessageBox.Show("Debe ingresar algun dato", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        Boolean Guardar()
        {
            try
            {
                Boolean bolResult = false;
                Get();
                if (txtId.Text == "" || txtId.EditValue == null)
                {
                    _Info.IdMensaje = "";
                }
                if (MensajeBus.ValidarCodigoExiste(_Info.IdMensaje) == false)
                {
                    if (MensajeBus.ValidarDescripcion(_Info.IdMensaje, _Info.Mensaje_Esp) == false)
                    {
                        if (MensajeBus.GuardarDB(_Info))
                        {
                            MessageBox.Show("Se Guardado Correctamente #:" + _Info.IdMensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bolResult = true;
                            LimpiarDatos();                            
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido grabar:" + _Info.IdMensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        MessageBox.Show("La Descripción Asignada Ya Existe", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El Codigo Ingresado Ya se encuentra asignado \n Por favor ingrese uno nuevo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        Boolean Actualizar()
        {            
            try
            {
                Boolean bolResult = false;
                Get();
                if (MensajeBus.ModificarDB(_Info))
                {
                    txtId.Text = _Info.IdMensaje;
                    MessageBox.Show("Se Actualizado Correctamente #:" + _Info.IdMensaje);
                    //bloquear_Datos();
                    lblEstado.Visible = false;
                    LimpiarDatos();
                    bolResult = true;
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

        public void bloquear_Datos()
        {
            try
            {
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;
                ucGe_Menu.Visible_bntAnular = false;
                txtId.Enabled = false;
                cmbMensaje.Enabled = false;
                txtMensajeI.Enabled = false;
                cbxEstado.Enabled = false;
                txtId.ForeColor = Color.Black;
                txtId.BackColor = Color.White;
                cmbMensaje.ForeColor = Color.Black;
                cmbMensaje.BackColor = Color.White;
                txtMensajeI.ForeColor = Color.Black;
                txtMensajeI.BackColor = Color.White;

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
                _Info.Mensaje_Englesh = txtMensajeI.Text;
                _Info.Mensaje_Esp = cmbMensaje.Text;
                _Info.IdMensaje = txtId.Text;

                if (cbxEstado.Checked == true)
                {
                    _Info.Estado = "A";
                }
                else
                {
                    _Info.Estado = "I";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void Set()
        {
            try
            {
                txtId.Text = setInfo.IdMensaje;
                cmbMensaje.Text = setInfo.Mensaje_Esp;
                txtMensajeI.Text = setInfo.Mensaje_Englesh;
                if (setInfo.Estado == "I")
                {
                    lblEstado.Visible = true;
                    ucGe_Menu.Visible_bntAnular = false;
                    cbxEstado.Checked = false; 
                }
                else
                {
                    cbxEstado.Checked = true;   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      
        private void FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbMensaje_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void cmbMensaje_KeyUp(object sender, KeyEventArgs e)
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (MessageBox.Show("Esta Seguro que desea Anular  ?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MensajeBus.AnularDB(setInfo.IdMensaje))
                    {
                        txtId.Text = setInfo.IdMensaje;
                        MessageBox.Show("Se Anulado Correctamente #:" + setInfo.IdMensaje);
                        bloquear_Datos();
                        lblEstado.Visible = true;
                    }
                }
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
                GuardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                 switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            bolResult = Guardar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validar())
                        {
                            bolResult = Actualizar();
                        }
                        break;
                    default: MessageBox.Show("hi");
                        break;
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


        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (GuardarDatos())                   
                        Close();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _Info = new tb_sis_Mensajes_sys_Info();
                txtMensajeI.Text = "";
                cmbMensaje.Text = "";
                txtId.Text = "";

                cbxEstado.Checked = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
