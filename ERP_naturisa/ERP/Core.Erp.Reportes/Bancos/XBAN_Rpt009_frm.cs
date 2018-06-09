using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt009_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 
        
        public XBAN_Rpt009_frm()
        {
            InitializeComponent();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            try
            {
                XBAN_Rpt009_rpt Reporte = new XBAN_Rpt009_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["fecha"].Value = dte_fecha.EditValue;
                Reporte.Parameters["FechaCorte"].Value = dte_FechaCorte.EditValue;

                Reporte.Parameters["S_fecha"].Value = Convert.ToDateTime(dte_fecha.EditValue).ToShortDateString();
                Reporte.Parameters["S_FechaCorte"].Value = Convert.ToDateTime(dte_FechaCorte.EditValue).ToShortDateString();

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XBAN_Rpt009_frm_Load(object sender, EventArgs e)
        {
            dte_fecha.EditValue = DateTime.Now;
            dte_FechaCorte.EditValue = DateTime.Now; 
        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
