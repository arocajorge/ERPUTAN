using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt013_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_NATU_Rpt013_frm()
        {
            InitializeComponent();
        }

        private void ucCxp_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt013_Rpt rpt = new XCXP_NATU_Rpt013_Rpt();
                rpt.P_IdClaseProveedor.Value = ucCxp_MenuReportes1.bei_clase_prov.EditValue == null ? 0 : Convert.ToInt32(ucCxp_MenuReportes1.bei_clase_prov.EditValue);
                rpt.P_IdProveedor.Value = ucCxp_MenuReportes1.cmbProveedor.EditValue == null ? 0 : Convert.ToDecimal(ucCxp_MenuReportes1.cmbProveedor.EditValue);
                rpt.P_Fecha_ini.Value = ucCxp_MenuReportes1.dtpDesde.EditValue;
                rpt.P_Fecha_fin.Value = ucCxp_MenuReportes1.dtpHasta.EditValue;
                rpt.P_Mostrar_cuenta.Value = ucCxp_MenuReportes1.beiCheck1.EditValue;
                rpt.RequestParameters = false;

                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                splashScreenManager1.ShowWaitForm();
                rpt.CreateDocument();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();    
                }
                
            }
        }

        private void ucCxp_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
