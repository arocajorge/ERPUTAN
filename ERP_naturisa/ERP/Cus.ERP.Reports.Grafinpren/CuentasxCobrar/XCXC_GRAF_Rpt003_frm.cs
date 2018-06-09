using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public partial class XCXC_GRAF_Rpt003_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;   

        public XCXC_GRAF_Rpt003_frm()
        {
            InitializeComponent();
        }

        private void uccxC_MenuReportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXC_GRAF_Rpt003_Rpt rpt = new XCXC_GRAF_Rpt003_Rpt();
                ReportPrintTool pt = new ReportPrintTool(rpt);
                rpt.p_IdCliente.Value = uccxC_MenuReportes1.beiCliente.EditValue == null ? 0 : Convert.ToDecimal(uccxC_MenuReportes1.beiCliente.EditValue);
                rpt.p_IdCliente.Visible = false;
                rpt.p_DiasCredito.Value = uccxC_MenuReportes1.beiDiasCredito.EditValue == null || uccxC_MenuReportes1.beiDiasCredito.EditValue.ToString() == "" ? 0 : Convert.ToInt32(uccxC_MenuReportes1.beiDiasCredito.EditValue);
                rpt.p_DiasCredito.Visible = false;
                printControl1.PrintingSystem = pt.PrintingSystem;                
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void uccxC_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
