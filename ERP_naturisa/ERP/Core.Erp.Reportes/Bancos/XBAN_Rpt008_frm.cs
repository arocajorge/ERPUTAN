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
    public partial class XBAN_Rpt008_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 
        
        public XBAN_Rpt008_frm()
        {
            InitializeComponent();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            try
            {
                XBAN_Rpt008_rpt Reporte = new XBAN_Rpt008_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["FechaIni"].Value = dte_FechaIni.EditValue;
                Reporte.Parameters["FechaFin"].Value = dte_FechaFin.EditValue;

                Reporte.Parameters["S_FechaIni"].Value = Convert.ToDateTime(dte_FechaIni.EditValue).ToShortDateString();
                Reporte.Parameters["S_FechaFin"].Value = Convert.ToDateTime(dte_FechaFin.EditValue).ToShortDateString();

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XBAN_Rpt008_frm_Load(object sender, EventArgs e)
        {
            try
            {
                dte_FechaIni.EditValue = DateTime.Now;
                dte_FechaFin.EditValue = DateTime.Now; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
