using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Winform.Compras;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCom_MotivoCompraCmb : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus= new tb_sis_Log_Error_Vzen_Bus();




        List<com_Motivo_Orden_Compra_Info> listMotivoCompra = new List<com_Motivo_Orden_Compra_Info>();
        com_Motivo_Orden_Compra_Bus BusMotivoCompra = new com_Motivo_Orden_Compra_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCom_Motivo_Orden_Compra_Mant frm;
        com_Motivo_Orden_Compra_Info InfoMotivoCompra = new com_Motivo_Orden_Compra_Info();

        public delegate void delegate_cmbMotivo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbMotivo_EditValueChanged event_cmbMotivo_EditValueChanged;
        public delegate void delegate_cmbMotivo_Validating(object sender, EventArgs e);
        public event delegate_cmbMotivo_Validating event_cmbMotivo_Validating;
        public delegate void delegate_cmbMotivo_Validated(object sender, EventArgs e);
        public event delegate_cmbMotivo_Validated event_cmbMotivo_Validated;
        #endregion

        public UCCom_MotivoCompraCmb()
        {
            InitializeComponent();
            event_cmbMotivo_EditValueChanged += UCCom_MotivoCompraCmb_event_cmbMotivo_EditValueChanged;
            event_cmbMotivo_Validating += UCCom_MotivoCompraCmb_event_cmbMotivo_Validating;
            event_cmbMotivo_Validated += UCCom_MotivoCompraCmb_event_cmbMotivo_Validated;
        }

        void UCCom_MotivoCompraCmb_event_cmbMotivo_Validated(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCCom_MotivoCompraCmb_event_cmbMotivo_Validating(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCCom_MotivoCompraCmb_event_cmbMotivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCom_MotivoCompraCmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_cmbMotivo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_cmbMotivo()
        {
            try
            {
                listMotivoCompra = new List<com_Motivo_Orden_Compra_Info>();
                listMotivoCompra = BusMotivoCompra.Get_List_Motivo_Orden_Compra(param.IdEmpresa);
                cmbMotivo.Properties.DataSource = listMotivoCompra;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbMotivo_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbMotivo_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivo_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbMotivo_Validated(sender, e);
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_MotivoCompra();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
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
                get_MotivoCompra();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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
                frm = new frmCom_Motivo_Orden_Compra_Mant();
                frm.Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing += new frmCom_Motivo_Orden_Compra_Mant.Delegate_frmCom_Motivo_Orden_Compra_Mant_FormClosing(frm_Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_Info(InfoMotivoCompra);
                    frm.set_Accion(Accion);

                }
                else
                    frm.set_Accion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_cmbMotivo();
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
                cmbMotivo.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_MotivoCompra()
        {
            try
            {
                cmbMotivo.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_MotivoCompra(int IdMotivo)
        {
            try
            {
                if (IdMotivo == 0)
                { cmbMotivo.EditValue = null; }
                else
                { cmbMotivo.EditValue = IdMotivo; }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public com_Motivo_Orden_Compra_Info get_MotivoCompra()
        {
            try
            {
                InfoMotivoCompra = listMotivoCompra.FirstOrDefault(v => v.IdMotivo == Convert.ToInt32(cmbMotivo.EditValue));
                return InfoMotivoCompra;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new com_Motivo_Orden_Compra_Info();
            }

        }

    }
}
