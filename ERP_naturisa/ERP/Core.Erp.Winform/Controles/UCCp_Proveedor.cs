using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Winform.CuentasxPagar;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_Proveedor : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCP_Proveedor_Mant frm;
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
        tb_persona_bus PersoBus = new tb_persona_bus();
        tb_persona_Info InfoPerso = new tb_persona_Info();

        public delegate void delegate_cmb_proveedor_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_proveedor_EditValueChanged event_cmb_proveedor_EditValueChanged;

        public delegate void delegate_cmb_proveedor_Validating(object sender, EventArgs e);
        public event delegate_cmb_proveedor_Validating event_cmb_proveedor_Validating;

        public delegate void delegate_cmb_proveedor_Validated(object sender, EventArgs e);
        public event delegate_cmb_proveedor_Validated event_cmb_proveedor_Validated;
        #endregion
        
        public UCCp_Proveedor()
        {
            InitializeComponent();

            event_cmb_proveedor_EditValueChanged += UCCp_Proveedor_event_cmb_proveedor_EditValueChanged;
            event_cmb_proveedor_Validating += UCCp_Proveedor_event_cmb_proveedor_Validating;
            event_cmb_proveedor_Validated +=UCCp_Proveedor_event_cmb_proveedor_Validated;

        }

        private void cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_proveedor_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCCp_Proveedor_event_cmb_proveedor_Validated(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        void UCCp_Proveedor_event_cmb_proveedor_Validating(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        void UCCp_Proveedor_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {


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

            }

        }

        private void MenuAcciones_Opening(object sender, CancelEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {

            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_ProveedorInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {

            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_ProveedorInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_proveedores()
        {
            try
            {
                listProveedor = new List<cp_proveedor_Info>();
                listProveedor = BusProveedor.Get_List_proveedor (param.IdEmpresa);
                cmb_proveedor.Properties.DataSource = listProveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCp_Proveedor_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_proveedores();
            }
            catch (Exception ex)
            {

            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmCP_Proveedor_Mant();

                frm.event_frmCP_MantProveedor_FormClosing += new frmCP_Proveedor_Mant.delegate_frmCP_MantProveedor_FormClosing(frm_event_frmCP_MantProveedor_FormClosing);
                // sino es grabar puede ser modificar ,consultar,
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoProveedor != null)
                    {
                        frm.set_ProveedorInfo(InfoProveedor);
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Escoja un proveedor para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void frm_event_frmCP_MantProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_proveedores();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_proveedor.Properties.ReadOnly = true;
             
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbProveedor()
        {
            try
            {
                cmb_proveedor.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_ProveedorInfo(decimal IdProveedor)
        {
            try
            {
                if (IdProveedor!=0)
                {
                    cmb_proveedor.EditValue = IdProveedor;    
                }
                else
                    cmb_proveedor.EditValue = null;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public cp_proveedor_Info get_ProveedorInfo()
        {
            try
            {
                decimal IdProveedor = (cmb_proveedor.EditValue == null) ? 0 : Convert.ToDecimal(cmb_proveedor.EditValue);
                InfoProveedor = listProveedor.FirstOrDefault(v => v.IdProveedor == IdProveedor);                
                return InfoProveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }

        }

        private void cmb_proveedor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_proveedor_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmb_proveedor_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmb_proveedor_Validated(sender, e);

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
