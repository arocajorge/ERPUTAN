using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCon_TipoCbteCble : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ct_Cbtecble_tipo_Info> listTipoCbteCble = new List<ct_Cbtecble_tipo_Info>();
        ct_Cbtecble_tipo_Bus BusTipoCbteCble = new ct_Cbtecble_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCon_TipoCbteCble_Mant frm;
        string MensajeError = "";
        ct_Cbtecble_tipo_Info InfoTipoCbteCble = new ct_Cbtecble_tipo_Info();
        public delegate void delegate_cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbTipoCbteCble_EditValueChanged event_cmbTipoCbteCble_EditValueChanged;
        public delegate void delegate_cmbTipoCbteCble_Validating(object sender, EventArgs e);
        public event delegate_cmbTipoCbteCble_Validating event_cmbTipoCbteCble_Validating;
        public delegate void delegate_cmbTipoCbteCble_Validated(object sender, EventArgs e);
        public event delegate_cmbTipoCbteCble_Validated event_cmbTipoCbteCble_Validated;
        #endregion

        public UCCon_TipoCbteCble()
        {
            InitializeComponent();
            event_cmbTipoCbteCble_EditValueChanged += UCCon_TipoCbteCble_event_cmbTipoCbteCble_EditValueChanged;
            event_cmbTipoCbteCble_Validated += UCCon_TipoCbteCble_event_cmbTipoCbteCble_Validated;
            event_cmbTipoCbteCble_Validating += UCCon_TipoCbteCble_event_cmbTipoCbteCble_Validating;
        }

        void UCCon_TipoCbteCble_event_cmbTipoCbteCble_Validating(object sender, EventArgs e)
        {
            
        }

        void UCCon_TipoCbteCble_event_cmbTipoCbteCble_Validated(object sender, EventArgs e)
        {
            
        }

        void UCCon_TipoCbteCble_event_cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void UCCon_TipoCbteCble_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_TipoCbteCble();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbTipoCbteCble_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoCbteCble_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbTipoCbteCble_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoCbteCble_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbTipoCbteCble_Validating(sender, e);
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
                get_TipoCbteCble();
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
                get_TipoCbteCble();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_TipoCbteCble()
        {
            try
            {
                listTipoCbteCble = new List<ct_Cbtecble_tipo_Info>();
                listTipoCbteCble = BusTipoCbteCble.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                cmbTipoCbteCble.Properties.DataSource = listTipoCbteCble;
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
                frm = new frmCon_TipoCbteCble_Mant();
                frm.event_frmCon_TipoCbteCble_Mant_FormClosing += new frmCon_TipoCbteCble_Mant.delegate_frmCon_TipoCbteCble_Mant_FormClosing(frm_event_frmCon_TipoCbteCble_Mant_FormClosing);                
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_TipoCbtecble(InfoTipoCbteCble);
                    frm.set_accion(Accion);

                }
                else
                    frm.set_accion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_frmCon_TipoCbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_TipoCbteCble();
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
                cmbTipoCbteCble.Properties.ReadOnly = true;
             
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbTipoCbteCble()
        {
            try
            {
                cmbTipoCbteCble.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_TipoCbteCble(int IdTipoCbte)
        {
            try
            {
                cmbTipoCbteCble.EditValue = IdTipoCbte;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_Cbtecble_tipo_Info get_TipoCbteCble()
        {
            try
            {
                InfoTipoCbteCble = listTipoCbteCble.FirstOrDefault(v => v.IdTipoCbte == Convert.ToInt32(cmbTipoCbteCble.EditValue));
                return InfoTipoCbteCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_tipo_Info();
            }

        }

    }
}
