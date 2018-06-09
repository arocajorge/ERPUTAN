using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_GrupoEmpresarial : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public frmCon_GrupoEmpresarial()
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
        
        ct_GrupoEmpresarial_Info Info=new ct_GrupoEmpresarial_Info();

        private void get_Info()
        {
            try
            {
                Info.GrupoEmpresarial = txt_GrupoEmpresarial.Text.Trim();
                Info.IdGrupoEmpresarial = txt_IdGrupoEmpre.Text.Trim();
                Info.Estado = (this.chk_estado.Checked == true) ? "A" : "I";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void set_Info(ct_GrupoEmpresarial_Info _info)
        {
            try
            {
                txt_GrupoEmpresarial.Text=_info.GrupoEmpresarial;
                txt_IdGrupoEmpre.Text=_info.IdGrupoEmpresarial;
                this.chk_estado.Checked = (_info.Estado == "I") ? false : true;
                
                Info = _info;
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txt_IdGrupoEmpre.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
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

        private bool validar()
        {
           try
           {
               bool estado = true;

               if (txt_IdGrupoEmpre.Text=="")
               {
                   MessageBox.Show("Antes de continuar debe ingresar el ID del Grupo Empresarial", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
               if (txt_GrupoEmpresarial.Text == "")
               {
                   MessageBox.Show("Antes de continuar debe ingresar el Grupo Empresarial", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }

               return estado;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }
        }

        private void Grabar()
        {
            try
            {
                if(validar())
                {

                ct_GrupoEmpresarial_Bus GE_B = new ct_GrupoEmpresarial_Bus();
                get_Info();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (GE_B.GrabarDB(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Grupo Empresarial ", txt_GrupoEmpresarial.Text);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El Grupo Empresarial " + txt_GrupoEmpresarial.Text + "se Ingreso correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //_Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        LimpiarDatos();
                        return;
                    }
                    else
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (GE_B.ModificarDB(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Grupo Empresarial ", txt_GrupoEmpresarial.Text);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El Grupo Empresarial " + txt_GrupoEmpresarial.Text + "se Actualizo correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (GE_B.AnularDB(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Grupo Empresarial ", txt_GrupoEmpresarial.Text);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El Grupo Empresarial " + txt_GrupoEmpresarial.Text + "se Anulo correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chk_estado.Checked = false;
                    }
                    else
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Anular, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                _Accion = Cl_Enumeradores.eTipo_action.Anular;
                Grabar();
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
                 Grabar();
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
                if (validar())
                {
                    Grabar();
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
                Info = new ct_GrupoEmpresarial_Info();
                txt_GrupoEmpresarial.Text = "";
                txt_IdGrupoEmpre.Text = "";
                chk_estado.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
