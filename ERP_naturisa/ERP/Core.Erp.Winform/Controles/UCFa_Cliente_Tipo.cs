using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Cliente_Tipo : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_cliente_tipo_Info> lstInfo = new List<fa_cliente_tipo_Info>();
        fa_cliente_tipo_Bus busCli = new fa_cliente_tipo_Bus();
        fa_cliente_tipo_Info Info = new fa_cliente_tipo_Info();
        public delegate void delegate_cmbClienteTipo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbClienteTipo_EditValueChanged event_cmbClienteTipo_EditValueChanged;

        public UCFa_Cliente_Tipo()
        {
            InitializeComponent();
            event_cmbClienteTipo_EditValueChanged += UCFa_Cliente_Tipo_event_cmbClienteTipo_EditValueChanged;
        }

        void UCFa_Cliente_Tipo_event_cmbClienteTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCFa_Cliente_Tipo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void CargarDatos()
        {
            try
            {
                lstInfo = busCli.Get_List_fa_cliente_tipo(param.IdEmpresa);
                cmbClienteTipo.Properties.DataSource = lstInfo;
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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmFa_ClienteTipo_Mant frm = new frmFa_ClienteTipo_Mant();
                frm.event_frmFa_ClienteTipo_Mant_FormClosing += frm_event_frmFa_ClienteTipo_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (cmbClienteTipo.EditValue != null)
                    {
                        Info = lstInfo.Where(q => q.Idtipo_cliente == Convert.ToInt32(cmbClienteTipo.EditValue)).First();
                        frm.setAccion(Accion);
                        frm.setInfo(Info);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Seleccione un Tipo de Cliente.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.setAccion(Accion);
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

        void frm_event_frmFa_ClienteTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarDatos();
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
                cmbClienteTipo.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void Inicializar_Catalogos()
        {
            try
            {
                cmbClienteTipo.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void set_ClienteTipoInfo(int IdTipoCliente)
        {
            try
            {
                cmbClienteTipo.EditValue = IdTipoCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public fa_cliente_tipo_Info get_ClienteTipoInfo()
        {
            try
            {
                if (cmbClienteTipo.EditValue != null && lstInfo.Count() > 0)
                    Info = lstInfo.First(v => v.Idtipo_cliente == Convert.ToInt32(cmbClienteTipo.EditValue));
                else
                    return null;
                return Info;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return null;
            }

        }

        private void cmbClienteTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UCFa_Cliente_Tipo_event_cmbClienteTipo_EditValueChanged(sender, e);
                event_cmbClienteTipo_EditValueChanged(sender, e);
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
