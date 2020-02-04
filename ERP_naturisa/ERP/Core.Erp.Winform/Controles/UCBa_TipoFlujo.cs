using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Winform.Bancos;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCBa_TipoFlujo : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ba_TipoFlujo_Info> listTipoFlujo = new List<ba_TipoFlujo_Info>();
        ba_TipoFlujo_Bus BusTipoFlujo = new ba_TipoFlujo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmBA_TipoDeFlujoMant frm;
        ba_TipoFlujo_Info InfoTipoFlujo = new ba_TipoFlujo_Info();

        decimal _IdTipoFlujo = 0;

        public delegate void delegate_cmbTipoFlujo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbTipoFlujo_EditValueChanged event_cmbTipoFlujo_EditValueChanged;

        public delegate void delegate_cmbTipoFlujo_Validating(object sender, EventArgs e);
        public event delegate_cmbTipoFlujo_Validating event_cmbTipoFlujo_Validating;

        public delegate void delegate_cmbTipoFlujo_Validated(object sender, EventArgs e);
        public event delegate_cmbTipoFlujo_Validated event_cmbTipoFlujo_Validated;
        #endregion

        public UCBa_TipoFlujo()
        {
            InitializeComponent();
            event_cmbTipoFlujo_EditValueChanged += UCBa_TipoFlujo_event_cmbTipoFlujo_EditValueChanged;
            event_cmbTipoFlujo_Validating += UCBa_TipoFlujo_event_cmbTipoFlujo_Validating;
            event_cmbTipoFlujo_Validated += UCBa_TipoFlujo_event_cmbTipoFlujo_Validated;
        }

        void UCBa_TipoFlujo_event_cmbTipoFlujo_Validated(object sender, EventArgs e)
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

        void UCBa_TipoFlujo_event_cmbTipoFlujo_Validating(object sender, EventArgs e)
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

        void UCBa_TipoFlujo_event_cmbTipoFlujo_EditValueChanged(object sender, EventArgs e)
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

        private void UCBa_TipoFlujo_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_TipoFlujo();
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
                get_TipoFlujoInfo();
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
                get_TipoFlujoInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_TipoFlujo()
        {
            try
            {
                listTipoFlujo = new List<ba_TipoFlujo_Info>();
                listTipoFlujo = BusTipoFlujo.Get_List_TipoFlujo(param.IdEmpresa);
                cmbTipoFlujo.Properties.DataSource = listTipoFlujo;
                if (listTipoFlujo.Count > 0)
                {
                    //cmbTipoFlujo.EditValue = listTipoFlujo.First().IdTipoFlujo;
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
                frm = new FrmBA_TipoDeFlujoMant();
                frm.Event_frmba_TipoDeFlujoMant_FormClosing += frm_Event_frmba_TipoDeFlujoMant_FormClosing;                
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.SetInfo = InfoTipoFlujo;
                    frm.SetAccion(Accion);
                }
                else
                    frm.SetAccion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_Event_frmba_TipoDeFlujoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_TipoFlujo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_TipoFlujo()
        {
            try
            {
                cmbTipoFlujo.Properties.ReadOnly = false; //opin 2017/03/27
                cmb_Acciones.Visible = true; //opin 2017/03/27
                cmbTipoFlujo.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_TipoFlujoInfo(decimal? IdTipoFlujo)
        {
            try
            {
                IdTipoFlujo = IdTipoFlujo == 0 ? null : IdTipoFlujo;
                cmbTipoFlujo.EditValue = IdTipoFlujo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ba_TipoFlujo_Info get_TipoFlujoInfo()
        {
            try 
            {
                InfoTipoFlujo = listTipoFlujo.FirstOrDefault(v => v.IdTipoFlujo == Convert.ToDecimal(cmbTipoFlujo.EditValue));
                return InfoTipoFlujo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_TipoFlujo_Info();
            }

        }

        private void MenuAcciones_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cmbTipoFlujo_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void ReadOnly(bool Valor)
        {
            try
            {
                cmbTipoFlujo.Properties.ReadOnly = Valor;
                cmb_Acciones.Visible = !Valor;
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
