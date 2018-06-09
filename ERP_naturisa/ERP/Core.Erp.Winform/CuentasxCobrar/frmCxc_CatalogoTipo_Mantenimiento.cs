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
    public partial class frmCxc_CatalogoTipo_Mantenimiento : Form
    {
        
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;        
        cxc_CatalogoTipo_Bus Bus = new cxc_CatalogoTipo_Bus();
        public cxc_CatalogoTipo_Info _SetInfo { get; set; }
        cxc_CatalogoTipo_Info _Info = new cxc_CatalogoTipo_Info();
        public delegate void delegate_frmCxc_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCxc_CatalogoTipo_Mantenimiento_FormClosing Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing;
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public frmCxc_CatalogoTipo_Mantenimiento()
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
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
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
        
        void BloquearDatos()
        {
            try
            {
                txtId.BackColor = Color.White;
                txtId.ForeColor = Color.Black;
                txtId.Enabled = false;
                txtDescripcion.Enabled = false;
                txtDescripcion.BackColor = Color.White;
                txtDescripcion.ForeColor = Color.Black;
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
                    if (Bus.ValidarCodigoExiste(_Info.IdCatalogo_tipo) == false)
                    {
                        
                            if (Bus.GuardarDB(_Info))
                            {
                                BloquearDatos();
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro ", _Info.IdCatalogo_tipo);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //MessageBox.Show("Se ha ingresado Correctamente el registro #:" + _Info.IdCatalogo_tipo);
                            }
                        
                    }
                    else
                    {
                        MessageBox.Show("El Codigo Ingresado Ya se encuentra asignado \n Por favor ingrese uno nuevo");
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
                    if (Bus.ModificarDB(_Info))
                    {
                        txtId.Text = _Info.IdCatalogo_tipo.ToString();
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El registro ", _Info.IdCatalogo_tipo);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Se ha Actualizado Correctamente el registro #:" + _Info.IdCatalogo_tipo);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCxc_CatalogoTipo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        btn_guardar.Text = "Guardar";
                        
                        //btnAnular.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        btn_guardar.Text = "Actualizar";
                        btn_guardarysalir.Text = "Actualizar y Salir";
                        txtId.Enabled = false;
                        txtId.BackColor = Color.White;
                        txtId.ForeColor = Color.Black;
                        btn_LimpiarTipoCatalogo.Visible = false;
                        toolStripSeparator1.Visible = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        btn_guardar.Visible = false;
                        btn_guardarysalir.Visible = false;
                        toolStripSeparator1.Visible = false;
                        toolStripSeparator5.Visible = false;
                        toolStripSeparator6.Visible = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btn_guardar.Enabled = false;
                        btn_guardarysalir.Enabled = false;
                        toolStripSeparator1.Visible = false;
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

        void Set()
        {
            try
            {
                txtDescripcion.Text = _SetInfo.Descripcion;
                txtId.Text = _SetInfo.IdCatalogo_tipo;

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
                _Info.Descripcion = txtDescripcion.Text;
                _Info.IdCatalogo_tipo = txtId.Text; ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        Boolean validar()
        {
            try
            {
                if (txtId.EditValue == null || txtId.Text == "")
                {
                    MessageBox.Show("Debe Ingresar El Codigo","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
                else if (txtDescripcion.EditValue == null || txtDescripcion.Text == "")
                     {
                         MessageBox.Show("Debe Ingresar La Descripción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        //boton tipo
        
        private void btn_guardarysalir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    btn_guardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
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

        private void btn_LimpiarTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = "";
                txtDescripcion.Text = "";
                txtId.Enabled = true;
                txtDescripcion.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCxc_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
