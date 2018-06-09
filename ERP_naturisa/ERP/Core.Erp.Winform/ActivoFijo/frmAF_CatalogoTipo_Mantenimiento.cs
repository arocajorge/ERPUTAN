using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_CatalogoTipo_Mantenimiento : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        Af_CatalogoTipo_Bus Bus = new Af_CatalogoTipo_Bus();
        public Af_CatalogoTipo_Info _SetInfo { get; set; }
        Af_CatalogoTipo_Info _Info = new Af_CatalogoTipo_Info();
        public delegate void delegate_frmAF_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAF_CatalogoTipo_Mantenimiento_FormClosing Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing;
        
        #endregion
        
        public frmAF_CatalogoTipo_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                   this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guardar()
        {
            try
            {
                if (validar())
                {
                    if (Bus.ValidarCodigoExiste(_Info.IdTipoCatalogo) == false)
                    {                        
                            if (Bus.GuardarDB(_Info))
                            {
                                //BloquearDatos();
                                MessageBox.Show("Se ha ingresado Correctamente el registro #:" + _Info.IdTipoCatalogo);
                                LimpiarDatos();
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        void Modificar()
        {
            try
            {
                if (validar())
                {
                    if (Bus.Modificar(_Info))
                    {
                        txtId.Text = _Info.IdTipoCatalogo.ToString();
                        MessageBox.Show("Se ha Actualizado Correctamente el registro #:" + _Info.IdTipoCatalogo);
                        LimpiarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

         void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _Info = new Af_CatalogoTipo_Info();
                txtId.Text = "";
                txtDescripcion.Text = "";
                txtId.Enabled = true;
                txtDescripcion.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        
        private void frmAF_CatalogoTipo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        txtId.Enabled = false;
                        txtId.BackColor = Color.White;
                        txtId.ForeColor = Color.Black;
                        
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        Set();
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
       
        void Set()
        {
            try
            {
                txtDescripcion.Text = _SetInfo.Descripcion;
                txtId.Text = _SetInfo.IdTipoCatalogo;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        void Get()
        {
            try
            {
                _Info.Descripcion = txtDescripcion.Text;
                _Info.IdTipoCatalogo = txtId.Text; ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      
        Boolean validar()
        {
            try
            {
                if (txtId.EditValue == null || txtId.Text == "")
                {
                    MessageBox.Show("Debe Ingresar El Codigo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
                else if (txtDescripcion.EditValue == null || txtDescripcion.Text == "")
                     {
                         MessageBox.Show("Debe Ingresar La Descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
         
        private void frmAF_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
