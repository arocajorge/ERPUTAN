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
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Marca_Mant : Form
    {

        #region Variables
        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        public in_Marca_Info marcaI = new in_Marca_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus logError = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_FrmIn_Marca_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Marca_Mant_FormClosing event_FrmIn_Marca_Mant_FormClosing;

        #endregion

        public FrmIn_Marca_Mant()
        {
            InitializeComponent();
        }

        private void frmIN_MantMarca_Load(object sender, EventArgs e)
        {
            try
            {
                 txt_descripcion.Focus();
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:

                    chk_estado.Checked = true;
                    chk_estado.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                
                    
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    
                    break;
                default:
                    break;
            }
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set_Info(in_Marca_Info info)
        {
            try
            {
                txt_idMarca.Text = info.IdMarca.ToString();
                txt_descripcion.Text = info.Descripcion;                              
                chk_estado.Checked = (info.Estado == "A") ? true : false;

                if (chk_estado.Checked == false)
                {
                    lblAnulado.Visible = true;
                }
                else {
                    lblAnulado.Visible = false;
                }
               
                marcaI= info;
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public in_Marca_Info get_Info()
        {
            try
            {

                marcaI.IdEmpresa = param.IdEmpresa;
                if (txt_idMarca.Text != "")
                {
                    marcaI.IdMarca = Convert.ToInt32(txt_idMarca.Text);
                }
                marcaI.Descripcion = txt_descripcion.Text.Trim();
                marcaI.Estado = (chk_estado.Checked == true) ? "A" : "I";
                return marcaI;

            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;                
            }

        }

        Boolean Grabar() 
        {
            try
            {
                Boolean bolResult = false;
                if (txt_descripcion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_descripcion.Focus();
                    return false;
                }
                if (chk_estado.Checked == false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " estado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    chk_estado.Focus();
                    return false;
                }
                get_Info();

                string msg = "";
                string mensajeRecurso = "";
                in_marca_bus marcaB = new in_marca_bus();
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (marcaB.GrabarDB(marcaI, ref msg))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Marca", marcaI.IdMarca);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Enabled_btnGuardar = false;
                        bolResult = true;
                        LimpiarDatos();
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, msg);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    }
                }



                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (marcaB.ModificarDB(marcaI, ref msg))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Marca", marcaI.IdMarca);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Enabled_btnGuardar = false;
                        bolResult = true;
                        LimpiarDatos();
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, msg);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    }

                }
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (marcaB.AnularDB(marcaI))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Marca", marcaI.IdMarca);
                        MessageBox.Show(smensaje, param.Nombre_sistema); 
                        this.Parent.Parent.Dispose();
                        bolResult = true;
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, msg);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    }
                }

                return bolResult;
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                txt_idMarca.Text = "";
                txt_descripcion.Text = "";
                marcaI = new in_Marca_Info();
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
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
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void FrmIn_Marca_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (event_FrmIn_Marca_Mant_FormClosing != null)
                {
                    event_FrmIn_Marca_Mant_FormClosing(sender, e);
                }
            }
            catch (Exception ex)
            {
                logError.Log_Error(ex.ToString());
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
                logError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
