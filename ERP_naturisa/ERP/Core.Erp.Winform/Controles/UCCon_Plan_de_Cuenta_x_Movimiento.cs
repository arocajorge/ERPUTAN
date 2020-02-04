using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Winform.Contabilidad;



namespace Core.Erp.Winform.Controles
{
    public partial class UCCon_Plan_de_Cuenta_x_Movimiento : UserControl
    {

        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
        List<ct_Plancta_Info> listPlanCuenta = new List<ct_Plancta_Info>();
        ct_Plancta_Info InfoCuenta = new ct_Plancta_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        frmCon_PlanCuenta_Mant frm;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public UCCon_Plan_de_Cuenta_x_Movimiento()
        {
            InitializeComponent();
        }

        private void cmd_cuentas_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UCCon_Plan_de_Cuenta_x_Movimiento_Load(object sender, EventArgs e)
        {
            try
            {
               listPlanCuenta= BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
               cmb_cuentas.Properties.DataSource = listPlanCuenta;

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
                get_CuentaInfo();
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
                get_CuentaInfo();
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
                frm = new frmCon_PlanCuenta_Mant();

                frm.event_frmCon_PlanCuenta_Mant_FormClosing += new frmCon_PlanCuenta_Mant.delegate_frmCon_PlanCuenta_Mant_FormClosing(frm_event_frmCon_PlanCuenta_Mant_FormClosing);
                // sino es grabar puede ser modificar ,consultar,
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.InfoPlanCta = InfoCuenta;
                    frm._Accion=Accion;
                }
                else
                    frm._Accion = Accion;

                frm.Show();
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
            
        }

        public ct_Plancta_Info get_CuentaInfo()
        {
            try
            {
                if (cmb_cuentas.EditValue != null)
                {
                    InfoCuenta = listPlanCuenta.FirstOrDefault(v => v.IdCtaCble == Convert.ToString(cmb_cuentas.EditValue));
                    return InfoCuenta;
                }
                return new ct_Plancta_Info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Plancta_Info();
            }

        }

        public void set_IdCtaCble(string IdCtaCble)
        {
            try
            {
                if (IdCtaCble != "")
                    cmb_cuentas.EditValue = IdCtaCble;
                else
                    cmb_cuentas.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void Inicializar_cmb_cuentas()
        {
            try
            {
                cmb_cuentas.EditValue = null;
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
