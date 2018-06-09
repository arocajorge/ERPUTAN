using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_EstadoCobro_Mantenimiento : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public frmCxc_EstadoCobro_Mantenimiento()
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
        cxc_EstadoCobro_Info Info = new cxc_EstadoCobro_Info();
        cxc_EstadoCobro_Bus cxcEstBus = new cxc_EstadoCobro_Bus();

        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        public void setInfo(cxc_EstadoCobro_Info Info)
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

        public delegate void delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing Event_FrmGe_Tarjeta_Mantenimiento_FormClosing;

        private void frmCxc_EstadoCobro_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmGe_Tarjeta_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void frmCxc_EstadoCobro_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                { 
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        txtCodigo.Enabled = false;
                        txtCodigo.ForeColor = Color.Black;
                        txtCodigo.BackColor = Color.White;
                        btnGuardar.Text = "Actualizar";
                        BtnGuardarySalir.Text = "Actualizar y Salir";
                        btnLimpiar.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        btnLimpiar.Visible = false;
                        Bloquear_Datos();
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Bloquear_Datos()
        {
            try
            {
                btnGuardar.Visible = false;
                BtnGuardarySalir.Visible = false;
                txtCodigo.Enabled = false;
                txtCodigo.ForeColor = Color.Black;
                txtCodigo.BackColor = Color.White;
                txtDescripción.Enabled = false;
                txtDescripción.ForeColor = Color.Black;
                txtDescripción.BackColor = Color.White;
                txtPosicion.Enabled = false;
                txtPosicion.ForeColor = Color.Black;
                txtPosicion.BackColor = Color.White;
                
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
                    MessageBox.Show("Ingrese el codigo por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (txtDescripción.Text == "" || txtDescripción.EditValue == null)
                {
                    MessageBox.Show("Ingrese la descripción por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (txtPosicion.Text == "" || txtPosicion.EditValue == null)
                {
                    MessageBox.Show("Ingrese la posición por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Visible = true;
                BtnGuardarySalir.Visible = true;
                txtCodigo.Text = "";
                txtDescripción.Text = "";
                txtPosicion.Text = "";
                txtCodigo.Enabled = true;
                txtDescripción.Enabled = true;
                txtPosicion.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                { 
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Get()
        {
            try
            {
                Info.IdEstadoCobro = txtCodigo.Text;
                Info.Descripcion = txtDescripción.Text;
                Info.posicion = Convert.ToInt32(txtPosicion.Text);
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
                txtCodigo.Text = Info.IdEstadoCobro;
                txtDescripción.Text = Info.Descripcion;
                txtPosicion.Text = Info.posicion.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void Guardar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    if (cxcEstBus.Guardar(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro ", Info.IdEstadoCobro);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El registro #" + Info.IdEstadoCobro + " se ha guardado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bloquear_Datos();
                    }
                    else
                    {
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Actualizar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    if (cxcEstBus.ModificarDB(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El registro ", Info.IdEstadoCobro);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El registro #" + Info.IdEstadoCobro + " se ha guardado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bloquear_Datos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido guardar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        
        }

        private void BtnGuardarySalir_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar_Click(sender, e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
