using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_CatalogoTipoMant : Form
    {
        #region Declaración de variables
        public delegate void delegate_frmRo_CatalogoTipoMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_CatalogoTipoMant_FormClosing Event_frmRo_CatalogoTipoMant_FormClosing;
        ro_CatalogoTipo_Info _Info = new ro_CatalogoTipo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        ro_CatalogoTipo_Bus Bus = new ro_CatalogoTipo_Bus();
        void frmRo_CatalogoTipoMant_Event_frmRo_CatalogoTipoMant_FormClosing(object sender, FormClosingEventArgs e) { }
        public ro_CatalogoTipo_Info _SetInfo { get; set; }
        #endregion

        public frmRo_CatalogoTipoMant()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        void Guardar()
        {
            try
            {
                if (validar())
                {
                    if (Bus.ValidarCodigoExiste(_Info.Codigo) == false)
                    {
                        if (Bus.GuardarDB(ref _Info))
                        {
                            txtId.Text = _Info.IdTipoCatalogo.ToString();
                            MessageBox.Show("Se ha ingresado Correctamente el registro #:" + _Info.IdTipoCatalogo);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
      
        void Modificar()
        {
            try
            {
                if (validar())
                {
                    if (Bus.Modificar(_Info, ""))
                    {
                        txtId.Text = _Info.IdTipoCatalogo.ToString();
                        MessageBox.Show("Se ha Actualizado Correctamente el registro #:" + _Info.IdTipoCatalogo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        private void frmRo_CatalogoTipoMant_Load(object sender, EventArgs e)
        {
            try
            {

                Event_frmRo_CatalogoTipoMant_FormClosing += new delegate_frmRo_CatalogoTipoMant_FormClosing(frmRo_CatalogoTipoMant_Event_frmRo_CatalogoTipoMant_FormClosing);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        //btnAnular.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        //btnAnular.Enabled = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void Set() 
        {
            try
            {
                txtDescripcion.Text = _SetInfo.tc_Descripcion;
                txtCodigo.Text = _SetInfo.Codigo;
                txtId.Text = _SetInfo.IdTipoCatalogo.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        void Get() 
        {
            try
            {
                _Info.tc_Descripcion = txtDescripcion.Text;
                _Info.Codigo = txtCodigo.Text;
                _Info.IdTipoCatalogo = Convert.ToInt32(txtId.EditValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void frmRo_CatalogoTipoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             Event_frmRo_CatalogoTipoMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        Boolean validar() 
        {
            try
            {
                if(txtDescripcion.EditValue == null|| txtDescripcion.Text=="")
                {
                MessageBox.Show("Favor Ingresar Descripcion");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void frmRo_CatalogoTipoMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    ucGe_Menu_event_btnGuardar_Click(sender,e);                    
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
