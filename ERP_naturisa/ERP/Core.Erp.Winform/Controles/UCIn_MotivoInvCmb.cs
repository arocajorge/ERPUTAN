using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_MotivoInvCmb : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        List<in_Motivo_Inven_Info> listMotivoInv = new List<in_Motivo_Inven_Info>();
        in_Motivo_Inven_Bus BusMotivoInv = new in_Motivo_Inven_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmIn_Motivo_Inven_Mant frm;
        in_Motivo_Inven_Info InfoMotivoInv = new in_Motivo_Inven_Info();

        public delegate void delegate_cmbMotivoInv_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbMotivoInv_EditValueChanged event_cmbMotivoInv_EditValueChanged;

        public delegate void delegate_cmbMotivoInv_Validating(object sender, EventArgs e);
        public event delegate_cmbMotivoInv_Validating event_cmbMotivoInv_Validating;

        public delegate void delegate_cmbMotivoInv_Validated(object sender, EventArgs e);
        public event delegate_cmbMotivoInv_Validated event_cmbMotivoInv_Validated;
        #endregion

        public  ein_Tipo_Ing_Egr  Tipo_Ing_Egr { get; set; }

        public UCIn_MotivoInvCmb()
        {
            InitializeComponent();
            event_cmbMotivoInv_EditValueChanged += UCIn_MotivoInvCmb_event_cmbMotivoInv_EditValueChanged;
            event_cmbMotivoInv_Validating += UCIn_MotivoInvCmb_event_cmbMotivoInv_Validating;
            event_cmbMotivoInv_Validated += UCIn_MotivoInvCmb_event_cmbMotivoInv_Validated;
            if (Tipo_Ing_Egr == 0) { Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING; }
        }

        void UCIn_MotivoInvCmb_event_cmbMotivoInv_Validated(object sender, EventArgs e)
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

        void UCIn_MotivoInvCmb_event_cmbMotivoInv_Validating(object sender, EventArgs e)
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

        void UCIn_MotivoInvCmb_event_cmbMotivoInv_EditValueChanged(object sender, EventArgs e)
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

        private void UCIn_MotivoInvCmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_MotivoInv();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivoInv_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbMotivoInv_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivoInv_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbMotivoInv_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivoInv_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbMotivoInv_Validating(sender, e);
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
                get_MotivoInvInfo();
                if (InfoMotivoInv != null)
                {
                    llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                {
                    MessageBox.Show("Escoja un motivo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                get_MotivoInvInfo();
                if (InfoMotivoInv != null)
                {
                    llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                {
                    MessageBox.Show("Escoja un motivo.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_MotivoInv()
        {
            try
            {
                listMotivoInv = new List<in_Motivo_Inven_Info>();
                listMotivoInv = BusMotivoInv.Get_List_Motivo_Inven(param.IdEmpresa, Tipo_Ing_Egr.ToString());
                cmbMotivoInv.Properties.DataSource = listMotivoInv;
                cmbMotivoInv.EditValue = listMotivoInv.First(q=>q.Genera_Movi_Inven == "S").IdMotivo_Inv;
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
                frm = new FrmIn_Motivo_Inven_Mant();
                frm.event_FrmIn_Motivo_Inven_Mant_FormClosing += new FrmIn_Motivo_Inven_Mant.delegate_FrmIn_Motivo_Inven_Mant_FormClosing(frm_event_FrmIn_Motivo_Inven_Mant_FormClosing);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    if (InfoMotivoInv != null)
                    {
                        frm.set_Info(InfoMotivoInv);
                        frm.set_Accion(Accion);
                    }
                    else
                    {
                        MessageBox.Show("Escoja un motivo.", "SIstemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        void frm_event_FrmIn_Motivo_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_MotivoInv();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Perfil_Lectura(bool Lectura)
        {
            try
            {
                cmb_Acciones.Enabled = !Lectura;
                cmbMotivoInv.Properties.ReadOnly = Lectura;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbMotivoInv()
        {
            try
            {
                cmbMotivoInv.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_MotivoInvInfo(int IdMotivo_Inv)
        {
            try
            {
                cmbMotivoInv.EditValue = IdMotivo_Inv;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_Motivo_Inven_Info get_MotivoInvInfo()
        {
            try
            {
                if (cmbMotivoInv.EditValue == null) return null;
                
                InfoMotivoInv = listMotivoInv.FirstOrDefault(v => v.IdMotivo_Inv == Convert.ToInt32(cmbMotivoInv.EditValue));
                return InfoMotivoInv;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }
    }
}
