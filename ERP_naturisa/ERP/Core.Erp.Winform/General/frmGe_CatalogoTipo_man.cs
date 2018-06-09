using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.General
{
    public partial class FrmGe_CatalogoTipo_man : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Catalogo_Bus Bus = new tb_Catalogo_Bus();
        int _IdTipoCatalogo;
        private Cl_Enumeradores.eTipo_action _Accion;
        public tb_Catalogo_Info SetInfo { get; set; }
        tb_Catalogo_Info GetInfo = new tb_Catalogo_Info();
        public delegate void delegate_frmGe_CatalogoTipo_man_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_CatalogoTipo_man_FormClosing Event_frmGe_CatalogoTipo_man_FormClosing;
        #endregion
                
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
        
        public FrmGe_CatalogoTipo_man()
        {
            try
            {
                InitializeComponent();

                Event_frmGe_CatalogoTipo_man_FormClosing += frmGe_CatalogoTipo_man_Event_frmGe_CatalogoTipo_man_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }
       
        public FrmGe_CatalogoTipo_man(int IdTipoCatalogo)
            : this()
        {
            try
            {
                _IdTipoCatalogo = IdTipoCatalogo;
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
                GetInfo.ca_estado = chkEstado.Checked == true ? "A" : "I";
                GetInfo.ca_descripcion = txtDescripcion.Text.Trim();
                GetInfo.ca_orden = Convert.ToInt32(numericUpDown1.Value);
                GetInfo.CodCatalogo = txtCodigo.Text;
                GetInfo.IdCatalogo = Convert.ToInt32(txtIdcatalogo.Text == "" ? "0" : txtIdcatalogo.Text);
                GetInfo.IdTipoCatalogo = _IdTipoCatalogo;
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
                 txtCodigo.Text = SetInfo.CodCatalogo;
                txtDescripcion.Text = SetInfo.ca_descripcion;
                txtIdcatalogo.Text = SetInfo.IdCatalogo.ToString();
                chkEstado.Checked = SetInfo.ca_estado =="A"? true:false;
                numericUpDown1.Value = SetInfo.ca_orden;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
       
        }
      
        private void frmGe_CatalogoTipo_man_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_bntAnular = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Visible_bntAnular = false;
                    txtCodigo.Properties.ReadOnly = true;
                    Set();
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    txtCodigo.Properties.ReadOnly = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    Set();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntAnular = false;
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
      
        private void frmGe_CatalogoTipo_man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmGe_CatalogoTipo_man_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
           
        }
       
        void frmGe_CatalogoTipo_man_Event_frmGe_CatalogoTipo_man_FormClosing(object sender, FormClosingEventArgs e)
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
        
        void Guardar() 
        {
            try
            {
                
                string men  = "";
                int Id=0;
                if (Bus.GrabarDB(GetInfo, ref men, ref Id))
                {
                    txtIdcatalogo.Text = Id.ToString();
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                    LimpiarDatos();
                }
            MessageBox.Show(men);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
       
        void Actualizar() 
        {
            try
            {
                
                    string men = "";
                    if (Bus.ModificarDB(GetInfo, ref men))
                    {
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Visible_btnGuardar = false;
                        LimpiarDatos();
                    }
                    MessageBox.Show(men);
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
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Ingrese Descripcion");
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                ucGe_Menu_event_btnGuardar_Click(sender,e);
                Close();
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
                if (!Validar())
                    return;
                Get();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                string men = "";
                Get();
                if (Bus.Anular(GetInfo, ref men))
                {
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                }
                MessageBox.Show(men);
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
                GetInfo = new tb_Catalogo_Info();
                chkEstado.Checked = true;
                txtDescripcion.Text = "";
                numericUpDown1.Value = 0;
                txtCodigo.Text = "";
                txtIdcatalogo.Text = "";
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

    }
}
