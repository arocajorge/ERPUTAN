using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_GrupoEmpresarial_grupocble : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_GrupoEmpresarial_grupocble_Bus Gru_B = new ct_GrupoEmpresarial_grupocble_Bus();
        ct_GrupoEmpresarial_grupocble_Info Gru_I = new ct_GrupoEmpresarial_grupocble_Info();
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string msj;
        #endregion
       
        public frmCon_GrupoEmpresarial_grupocble()
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

        private bool valida()
        {
            try
            {
                if (txt_id.Text == "")
                {
                    MessageBox.Show("Por favor Ingrese el ID del Grupo Contable...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                if (Gru_B.VericarExisteIdString(txt_id.Text, ref msj))
                {
                    MessageBox.Show(msj);
                    return false;
                }

                if (cmb_estadoFinanciero.SelectedIndex==-1)
                {
                    MessageBox.Show("Por favor seleccione el estado financiero...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Grabar()
        {
            try
            {
                if (valida())
                {
                    Gru_I.IdGrupoCble_gr = txt_id.Text.Trim();
                    Gru_I.gc_GrupoCble_gr = txt_grupo.Text.Trim();
                    Gru_I.gc_Orden = Convert.ToInt32(txt_orden.Value);
                    Gru_I.gc_estado_financiero = (cmb_estadoFinanciero.SelectedText=="Balance General")?"BG":"ER" ;
                    Gru_I.gc_signo_operacion = (opt_suma.Checked == true) ? 1 : 0;

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (Gru_B.GuardarDB(Gru_I))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Grupo Contable ", this.txt_grupo.Text);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se Guardo el Grupo Contable " + this.txt_grupo.Text + " correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, param.Nombre_sistema);
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (Gru_B.ModificarDB(Gru_I))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Grupo Contable ", "");
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se Modifico el Grupo Contable " + this.txt_grupo.Text + " correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Modificar,param.Nombre_sistema);
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Info(ct_GrupoEmpresarial_grupocble_Info info)
        {
            try
            {
                txt_id.Text=info.IdGrupoCble_gr;
                txt_grupo.Text=info.gc_GrupoCble_gr;
                txt_orden.Value=info.gc_Orden;
                cmb_estadoFinanciero.SelectedIndex = (info.gc_estado_financiero == "BG") ? 0 : 1;
                
                if (info.gc_signo_operacion == 1)
                {
                    opt_suma.Checked = true;
                    opt_resta.Checked = false;
                }
                else
                {
                    opt_suma.Checked = false;
                    opt_resta.Checked = true;
                }

                    Gru_I = info;
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
                        ucGe_Menu.Visible_bntAnular = false;
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        txt_id.ReadOnly = true;
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

        private void frmCon_GrupoEmpresarial_grupocble_Load(object sender, EventArgs e)
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
                if (valida())
                {
                    Grabar();
                    this.Close();
                }
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
                Gru_I = new ct_GrupoEmpresarial_grupocble_Info();
                txt_id.Text = "";
                txt_grupo.Text = "";
                txt_orden.Value = 0;
                opt_suma.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
