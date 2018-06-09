using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Winform.ActivoFijo;

namespace Core.Erp.Winform.Controles
{
    public partial class UCAf_Activo_Fijo_Grupo : UserControl
    {

        #region Atributos, delegados y variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmAf_Activo_Fijo_Grupo_Mant frm;
        Af_Activo_Fijo_Grupo_Info AF_Grupo_Info = new Af_Activo_Fijo_Grupo_Info();
        List<Af_Activo_Fijo_Grupo_Info> List_Af_Grupo = new List<Af_Activo_Fijo_Grupo_Info>();
        Af_Activo_Fijo_Grupo_Bus Bus_Grupo = new Af_Activo_Fijo_Grupo_Bus();

        public delegate void delegate_cmb_Acciones_Click(object sender, EventArgs e);
        public event delegate_cmb_Acciones_Click event_delegate_cmb_Acciones_Click;
        #endregion

        public UCAf_Activo_Fijo_Grupo()
        {
            InitializeComponent();
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmAf_Activo_Fijo_Grupo_Mant();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    
                    if (AF_Grupo_Info != null)
                    {
                        frm.Set_Af_Grupo(AF_Grupo_Info);
                        frm.Accion = Accion;
                        frm.event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing += frm_event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Para continuar seleccione un registro.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.Accion = Accion;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                Cargar_Combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Activo_fijo_Grupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AF_Grupo_Info = (Af_Activo_Fijo_Grupo_Info)cmb_Activo_fijo_Grupo.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Cargar_Combo()
        {
            try
            {
                List_Af_Grupo = new List<Af_Activo_Fijo_Grupo_Info>(Bus_Grupo.Get_List_ActivoFijo_Grupo(param.IdEmpresa));
                cmb_Activo_fijo_Grupo.Properties.DataSource = List_Af_Grupo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Campos_consulta(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        cmb_Activo_fijo_Grupo.Properties.ReadOnly = false;
                        cmb_Acciones.Enabled = true;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmb_Activo_fijo_Grupo.Properties.ReadOnly = true;
                        cmb_Acciones.Enabled = false;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmb_Activo_fijo_Grupo.Properties.ReadOnly = true;
                        cmb_Acciones.Enabled = false;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        cmb_Activo_fijo_Grupo.Properties.ReadOnly = true;
                        cmb_Acciones.Enabled = false;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public int GetId_Activo_fijo_Grupo()
        {
            return (Convert.ToInt32(cmb_Activo_fijo_Grupo.EditValue));
        }

        public void setId_Activo_fijo_Grupo(int idActivo_fijo)
        {
            cmb_Activo_fijo_Grupo.EditValue = idActivo_fijo;
        }

        private void UCAf_Activo_Fijo_Grupo_Load(object sender, EventArgs e)
        {
            Cargar_Combo();
        }
    }
}
