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
    public partial class UCCon_PlanCtaCmb : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCon_PlanCuenta_Mant frm;
        ct_Plancta_Info InfoPlanCta = new ct_Plancta_Info();
        string MensajeError = "";

        public delegate void delegate_cmbPlanCta_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbPlanCta_EditValueChanged event_cmbPlanCta_EditValueChanged;

        public delegate void delegate_cmbPlanCta_Validating(object sender, EventArgs e);
        public event delegate_cmbPlanCta_Validating event_cmbPlanCta_Validating;

        public delegate void delegate_cmbPlanCta_Validated(object sender, EventArgs e);
        public event delegate_cmbPlanCta_Validated event_cmbPlanCta_Validated;
        #endregion

        public UCCon_PlanCtaCmb()
        {
            InitializeComponent();
            event_cmbPlanCta_EditValueChanged += UCCon_PlanCtaCmb_event_cmbPlanCta_EditValueChanged;
            event_cmbPlanCta_Validating += UCCon_PlanCtaCmb_event_cmbPlanCta_Validating;
            event_cmbPlanCta_Validated += UCCon_PlanCtaCmb_event_cmbPlanCta_Validated;
            
        }

        void UCCon_PlanCtaCmb_event_cmbPlanCta_Validated(object sender, EventArgs e)
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

        void UCCon_PlanCtaCmb_event_cmbPlanCta_Validating(object sender, EventArgs e)
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

        void UCCon_PlanCtaCmb_event_cmbPlanCta_EditValueChanged(object sender, EventArgs e)
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

        private void cmbPlanCta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               event_cmbPlanCta_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbPlanCta_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbPlanCta_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbPlanCta_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbPlanCta_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCon_PlanCtaCmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_PlanCta();
            
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
                get_PlanCtaInfo();
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
                get_PlanCtaInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cmbPlanCta_Enable(Boolean valor)
        {
            try
            {
                cmbPlanCta.Properties.ReadOnly = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargar_PlanCta()
        {
            try
            {
                listPlanCta = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmbPlanCta.Properties.DataSource = listPlanCta;
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
                frm = new frmCon_PlanCuenta_Mant();
                frm.event_frmCon_PlanCuenta_Mant_FormClosing += new frmCon_PlanCuenta_Mant.delegate_frmCon_PlanCuenta_Mant_FormClosing(frm_event_frmCon_PlanCuenta_Mant_FormClosing);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoPlanCta != null)
                    {
                        if (InfoPlanCta.IdEmpresa != 0)
                        {
                            frm.InfoPlanCta = InfoPlanCta;
                            frm.set_accion(Accion);
                            frm.Show();
                        }
                        else
                            MessageBox.Show("Escoja un registro.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    frm.set_accion(Accion);
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

        void frm_event_frmCon_PlanCuenta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_PlanCta();
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
                cmbPlanCta.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbPlanCta()
        {
            try
            {
                cmbPlanCta.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_PlanCtarInfo(string IdPlanCta)
        {
            try
            {
                cmbPlanCta.EditValue = IdPlanCta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_Plancta_Info get_PlanCtaInfo()
        {
            try
            {
                if (cmbPlanCta.EditValue != null)
                {
                    InfoPlanCta = listPlanCta.FirstOrDefault(v => v.IdCtaCble == cmbPlanCta.EditValue.ToString());
                }
                else InfoPlanCta = new ct_Plancta_Info();

                return InfoPlanCta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Plancta_Info();
            }

        }

    }
}
