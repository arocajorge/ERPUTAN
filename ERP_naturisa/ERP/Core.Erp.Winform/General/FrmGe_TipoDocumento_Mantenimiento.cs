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
    public partial class FrmGe_TipoDocumento_Mantenimiento : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //CJimenez 22.01.14
        public delegate void delegate_FrmGe_TipoDocumento_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_TipoDocumento_Mantenimiento_FormClosing Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing;
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }

        tb_sis_tipoDocumento_Info Info = new tb_sis_tipoDocumento_Info();
        tb_sis_tipoDocumento_Bus tipoDocBus = new tb_sis_tipoDocumento_Bus();


        public void setInfo(tb_sis_tipoDocumento_Info Info)
        {
            try
            {
                this.Info = Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FrmGe_TipoDocumento_Mantenimiento()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void FrmGe_TipoDocumento_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ckEstado.Checked = true;
                        ckEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        txtCodigo.Enabled = false;
                        txtCodigo.ForeColor = Color.Black;
                        txtCodigo.BackColor = Color.White;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FrmGe_TipoDocumento_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void guardar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    if (tipoDocBus.GuardarDB(Info))
                    {
                        //Bloquear_Datos();
                        MessageBox.Show("Se guardo el registro correctamente " + Info.IdTipoDocumento, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Modificar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    if (tipoDocBus.ModificarDB(Info))
                    {
                        //Bloquear_Datos();
                        MessageBox.Show("Se guardo el registro correctamente " + Info.IdTipoDocumento, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                }

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
                Info.IdTipoDocumento = txtCodigo.Text;
                Info.Descripcion = txtDescripcion.Text;
                Info.Posicion = Int32.Parse(txtPosicion.Text);
                if (ckEstado.Checked == true)
                {
                    Info.Estado = "A";
                }
                else
                {
                    Info.Estado = "I";
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
                txtCodigo.Text = Info.IdTipoDocumento;
                txtDescripcion.Text = Info.Descripcion;
                txtPosicion.Text = Info.Posicion.ToString();
                if (Info.Estado == "A")
                {
                    ckEstado.Checked = true;
                }
                else
                {
                    ckEstado.Checked = false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Bloquear_Datos()
        {
            try
            {
                txtCodigo.Enabled = false;
                txtCodigo.ForeColor = Color.Black;
                txtCodigo.BackColor = Color.White;

                txtDescripcion.Enabled = false;
                txtDescripcion.ForeColor = Color.Black;
                txtDescripcion.BackColor = Color.White;

                txtPosicion.Enabled = false;
                txtPosicion.ForeColor = Color.Black;
                txtPosicion.BackColor = Color.White;
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;

                ckEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        bool validar()
        {
            try
            {
                if (txtCodigo.Text == "" || txtCodigo.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese el codigo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese el Descripción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtPosicion.Text == "" || txtPosicion.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese la posición", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txtPosicion.Text).Length > 5)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
             try
            {
                if (e.KeyChar != 8)
                {

                    if (txtDescripcion.Text.Length > 50)
                    {
                        e.Handled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {

                    if (txtCodigo.Text.Length > 5)
                    {
                        e.Handled = true;
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
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
                        break;

                }
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
                ucGe_Menu_event_btnGuardar_Click(sender,e);
                Close();
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
                Info = new tb_sis_tipoDocumento_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtPosicion.Text = "";
                ckEstado.Checked = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
         

    }
}
