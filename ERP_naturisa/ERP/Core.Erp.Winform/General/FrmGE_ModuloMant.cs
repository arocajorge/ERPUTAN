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
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGE_ModuloMant : Form
    {
        #region Declaración de Variables
        public tb_modulo_Bus bus_mod = new tb_modulo_Bus();
        public tb_modulo_Info info_mod = new tb_modulo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public delegate void delegate_FrmGE_ModuloMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGE_ModuloMant_FormClosing event_FrmGE_ModuloMant_FormClosing;
        #endregion

        public FrmGE_ModuloMant()
        {
            InitializeComponent();
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
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
                Procesar();
                Close();
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

        public void set_Modulo(tb_modulo_Info info)
        {
            try
            {
                txtcodigo.Text = info.CodModulo;
                txtdescripcion.Text = info.Descripcion;
                txtcarpeta.Text = info.Nom_Carpeta;
                chk_Se_cierra.Checked = info_mod.Se_Cierra == null ? false : (bool)info_mod.Se_Cierra;
                info_mod = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public tb_modulo_Info get_modulo()
        {
            try
            {
                info_mod.CodModulo = txtcodigo.Text;
                info_mod.Descripcion = txtdescripcion.Text;
                info_mod.Nom_Carpeta = txtcarpeta.Text;
                info_mod.Se_Cierra = chk_Se_cierra.Checked;
                return info_mod;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_modulo_Info();
            }

        }

        private void Grabar()
        {
            try
            {
                get_modulo();

                if (bus_mod.GuardarDB(info_mod))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Módulo ", info_mod.CodModulo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Modificar()
        {
            try
            {
                get_modulo();

                if (bus_mod.ModificarDB(info_mod))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Módulo ", info_mod.CodModulo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Procesar()
        {
            try
            {
                get_modulo();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Grabar();
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

        private void FrmGE_ModuloMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGE_ModuloMant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGE_ModuloMant_Load(object sender, EventArgs e)
        {

            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
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
    }
}
