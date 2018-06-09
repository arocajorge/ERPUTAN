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

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt017_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        public XCXC_Rpt017_frm()
        {
            InitializeComponent();
        }

        private void uccxC_MenuReportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXC_Rpt017_Rpt rpt = new XCXC_Rpt017_Rpt();
                rpt.p_FechaIni.Value = uccxC_MenuReportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uccxC_MenuReportes1.dtpDesde.EditValue);
                rpt.p_FechaFin.Value = uccxC_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue);
                rpt.p_FechaIni.Visible = false;
                rpt.p_FechaFin.Visible = false;
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = pt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uccxC_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
