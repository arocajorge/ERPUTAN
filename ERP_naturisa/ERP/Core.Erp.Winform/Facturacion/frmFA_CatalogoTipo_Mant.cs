using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_CatalogoTipo_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        fa_catalogo_tipo_Bus Bus = new fa_catalogo_tipo_Bus();
        public delegate void delegate_frmFA_CatalogoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_CatalogoTipo_Mant_FormClosing event_frmFA_CatalogoTipo_Mant_FormClosing;
        fa_catalogo_tipo_Info _Info = new fa_catalogo_tipo_Info();
        public fa_catalogo_tipo_Info _SetInfo { get; set; }

        #endregion

        public frmFa_CatalogoTipo_Mant()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                 ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                 ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmFA_CatalogoTipo_Mant_FormClosing += frmFA_CatalogoTipo_Mant_event_frmFA_CatalogoTipo_Mant_FormClosing;
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
                Close();
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
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtCodigo.Enabled = true;
                txtDescripcion.Enabled = true;
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
                if (validar())
                    if (guardarDatos())
                        Close();
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
                if (validar())
                    guardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = true;
                Get();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       bolResult= Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                      bolResult=  Modificar();
                        break;
                    default:
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

        void frmFA_CatalogoTipo_Mant_event_frmFA_CatalogoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e){}

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
      
        void Get()
        {
            try
            {
                _Info.Descripcion = txtDescripcion.Text;
                _Info.IdCatalogo_tipo = Convert.ToInt32(txtCodigo.Text);
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
                txtCodigo.Text = Convert.ToString(_SetInfo.IdCatalogo_tipo);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Boolean Guardar()
        {
            try
            {
                Boolean bolResult = false;
                if (validar())
                {
                    if (Bus.ValidarCodigoExiste(_Info.IdCatalogo_tipo) == false)
                    {
                        if (Bus.GuardarDB(ref _Info))
                        {
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            bolResult = true;
                        
                            MessageBox.Show("Se ha ingresado correctamente el registro # :" + _Info.IdCatalogo_tipo);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El código ingresado ya se encuentra asignado \n Por favor ingrese uno nuevo");
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

        Boolean Modificar()
        {
            try
            {
                Boolean bolResult = false;
                if (validar())
                {
                    if (Bus.ModificarDB(ref _Info))
                    {
                        txtCodigo.Text = _Info.IdCatalogo_tipo.ToString();
                        MessageBox.Show("Se ha actualizado correctamente el registro # :" + _Info.IdCatalogo_tipo);
                        bolResult = true;
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

        Boolean validar()
        {
            try
            {
                if (txtCodigo.EditValue == null || txtCodigo.Text == "")
                {
                    MessageBox.Show("Ingrese el código. Por favor", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (txtDescripcion.EditValue == null || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Ingrese la descripción. Por favor", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmFA_CatalogoTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;

                        //btnAnular.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                      
                        this.txtCodigo.Enabled = false;
                        this.txtCodigo.BackColor = System.Drawing.Color.White;
                        this.txtCodigo.ForeColor = System.Drawing.Color.Black;

                        ucGe_Menu.Visible_bntLimpiar = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
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
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFA_CatalogoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 event_frmFA_CatalogoTipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
