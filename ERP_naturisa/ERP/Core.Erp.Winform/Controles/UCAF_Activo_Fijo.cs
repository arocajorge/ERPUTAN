using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCAF_Activo_Fijo : UserControl
    {
        #region Atributos y variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmAF_ActivoFijo_Mant frm;
        Af_Activo_fijo_Info AF_Info = new Af_Activo_fijo_Info();
        List<Af_Activo_fijo_Info> List_Activo_F = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Bus Bus = new Af_Activo_fijo_Bus();
        #endregion

        #region Delegados
        public delegate void delegate_cmb_Acciones_Click(object sender, EventArgs e);
        public event delegate_cmb_Acciones_Click event_delegate_cmb_Acciones_Click;
        #endregion

        #region Constructores
        public UCAF_Activo_Fijo()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos del control de usuario
        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
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
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
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
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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

        private void cmb_Activo_fijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AF_Info = (Af_Activo_fijo_Info)cmb_Activo_fijo.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        public void Cargar_Combo()
        {
            try
            {
                List_Activo_F = new List<Af_Activo_fijo_Info>(Bus.Get_List_ActivoFijo(param.IdEmpresa));
                cmb_Activo_fijo.Properties.DataSource = List_Activo_F;
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
                        cmb_Activo_fijo.Properties.ReadOnly = false;
                        cmb_Acciones.Enabled = true;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmb_Activo_fijo.Properties.ReadOnly = true;
                        cmb_Acciones.Enabled = false;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmb_Activo_fijo.Properties.ReadOnly = true;
                        cmb_Acciones.Enabled = false;
                        cmb_Acciones.ResetForeColor();
                        cmb_Acciones.ResetBackColor();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        cmb_Activo_fijo.Properties.ReadOnly = true;
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

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmAF_ActivoFijo_Mant();
                
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    AF_Info = (Af_Activo_fijo_Info)cmb_Activo_fijo.EditValue;
                    if (AF_Info !=null)
                    {
                        frm.set_ActivoFijo(AF_Info);
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Para continuar seleccione un registro.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.set_Accion(Accion);
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

        public int GetId_Activo_fijo()
        {
            return (Convert.ToInt32(cmb_Activo_fijo.EditValue));
        }

        public Af_Activo_fijo_Info Get_Activo_fijo()
        {
            try
            {
                if (cmb_Activo_fijo.EditValue != null)
                {
                    int id_AF = Convert.ToInt32(cmb_Activo_fijo.EditValue);
                    return List_Activo_F.FirstOrDefault(q => q.IdActivoFijo == id_AF);
                }
                else
                    return new Af_Activo_fijo_Info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Activo_fijo_Info();
            }
        }

        public void setId_Activo_fijo(int idActivo_fijo)
        {
            cmb_Activo_fijo.EditValue = idActivo_fijo;
        }

        private void UCAF_Activo_Fijo_Load(object sender, EventArgs e)
        {
            
        }

        public void InicializarActivoFijo()
        {
            try
            {
                cmb_Activo_fijo.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
    }
}
