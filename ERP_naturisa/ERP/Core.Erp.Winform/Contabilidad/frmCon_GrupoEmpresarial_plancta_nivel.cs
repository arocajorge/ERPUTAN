using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_GrupoEmpresarial_plancta_nivel : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        int ID = 0;
        ct_GrupoEmpresarial_plancta_nivel_Info Info = new ct_GrupoEmpresarial_plancta_nivel_Info();
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
       
        public frmCon_GrupoEmpresarial_plancta_nivel()
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

        public void set_Info(ct_GrupoEmpresarial_plancta_nivel_Info _info)
        {
            try
            {
                lblnivel.Text = _info.IdNivelCta_gr.ToString();
                txtdescripcion.Text = _info.nv_Descripcion_gr;
                num_digitos.Value = _info.nv_NumDigitos_gr;
              
                Info = _info;
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void get_Info()
        {
            try
            {
                Info.IdNivelCta_gr = Convert.ToInt32(lblnivel.Text);
                Info.nv_Descripcion_gr = txtdescripcion.Text.Trim();
                Info.nv_NumDigitos_gr = Convert.ToInt32(num_digitos.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                         ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

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

                if (txtdescripcion.Text == "")
                {
                    MessageBox.Show("Antes de continuar debe ingresar la descripción", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return estado;
                }
                if (num_digitos.Value<1 )
                {
                    MessageBox.Show("Antes de continuar debe ingresar Digitos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return estado;
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
                ct_GrupoEmpresarial_plancta_nivel_Bus GE_B = new ct_GrupoEmpresarial_plancta_nivel_Bus();
                get_Info();
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (GE_B.GrabarDB(Info,ref ID))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Nivel del Plan de Cuenta del Grupo Empresarial ", "");
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El Nivel del Plan de Cuenta del Grupo Empresarial se Ingreso correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Visible_btnGuardar = false;
                        lblnivel.Text = ID.ToString();
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
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Nivel del Plan de Cuenta del Grupo Empresarial ", "");
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("El Nivel del Plan de Cuenta del Grupo Empresarial se Actualizo correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Visible_btnGuardar = false;
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Info = new ct_GrupoEmpresarial_plancta_nivel_Info();
                lblnivel.Text = "";
                txtdescripcion.Text = "";
                num_digitos.Value = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
