
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_CatalogoMant : Form
    {

        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_CatalogoTipo_Bus BusTipoCatalogo = new tb_CatalogoTipo_Bus();        
        private Cl_Enumeradores.eTipo_action _Accion;        
        public tb_CatalogoTipo_Info SetInfo { get; set; }
        tb_CatalogoTipo_Info GetInfo = new tb_CatalogoTipo_Info();
        public delegate void Delegate_frmGE_CatalogoMant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmGE_CatalogoMant_FormClosing Event_frmGE_CatalogoMant_FormClosing;
        #endregion

        void frmGE_CatalogoMant_Event_frmGE_CatalogoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        public FrmGe_CatalogoMant()
        {
            try
            {
          InitializeComponent(); Event_frmGE_CatalogoMant_FormClosing += frmGE_CatalogoMant_Event_frmGE_CatalogoMant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
          }
        
        private void frmGE_CatalogoMant_Load(object sender, EventArgs e)
        {
            try
            {
                        switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
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

        private void Set()
        {
            try
            {
            txtCodigo.Text = SetInfo.Codigo;
            txtDescripcion.Text = SetInfo.tc_Descripcion;
            txtIdcatalogo.Text = SetInfo.IdTipoCatalogo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }
        
        private void Get()
        {
            try
            {
            //GetInfo = new tb_CatalogoTipo_Info();
            GetInfo.Codigo = txtCodigo.Text;
            GetInfo.tc_Descripcion=txtDescripcion.Text;
            GetInfo.IdTipoCatalogo = Convert.ToInt32(txtIdcatalogo.Text == "" ? "0" : txtIdcatalogo.Text);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void frmGE_CatalogoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 Event_frmGE_CatalogoMant_FormClosing(sender, e);
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
                
                int IdCatalogoTipo =0;
                string Mensaje ="";
                if (BusTipoCatalogo.GrabaItem(GetInfo, ref Mensaje, ref IdCatalogoTipo))
                {
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                    LimpiarDatos();
                }
                MessageBox.Show(Mensaje);
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
                string Mensaje = "";
            if (BusTipoCatalogo.ModificaItem(GetInfo, ref Mensaje))
            {
                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                //ucGe_Menu.Visible_btnGuardar = false;
                LimpiarDatos();
            }
            MessageBox.Show(Mensaje);
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucGe_Menu_event_btnGuardar_Click(sender,e);
                this.Close();
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
                GetInfo = new tb_CatalogoTipo_Info();
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtIdcatalogo.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
