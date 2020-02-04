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
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCon_Parametro : UserControl
    {
        public UCCon_Parametro()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Cbtecble_tipo_Bus TIPO = new ct_Cbtecble_tipo_Bus();
        ct_Parametro_Bus busPara = new ct_Parametro_Bus();
        ct_Parametro_Info Info = new ct_Parametro_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        private void UCCon_Parametro_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSaldoInicial.Properties.DataSource = TIPO.Get_list_Cbtecble_tipo(param.IdEmpresa,ref MensajeError);
                cmbCierreAnual.Properties.DataSource = TIPO.Get_list_Cbtecble_tipo(param.IdEmpresa,ref MensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdTipoCbte_SaldoInicial = Convert.ToInt32(cmbSaldoInicial.EditValue);
                Info.IdTipoCbte_AsientoCierre_Anual = Convert.ToInt32(cmbCierreAnual.EditValue);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (busPara.GuardarDB(Info))
                {
                    MessageBox.Show("Se Guardado Correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
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
