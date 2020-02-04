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

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt012_frm : Form
    {
         tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XCXP_NATU_Rpt012_frm()
        {
            InitializeComponent();
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
            }
        }

        private void ucCxp_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt012_Rpt Reporte = new XCXP_NATU_Rpt012_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.P_Fecha_ini.Value = Convert.ToDateTime(ucCxp_MenuReportes1.dtpDesde.EditValue);
                Reporte.P_Fecha_fin.Value = Convert.ToDateTime(ucCxp_MenuReportes1.dtpHasta.EditValue);
                Reporte.P_Mostrar_agrupado.Value = Convert.ToBoolean(ucCxp_MenuReportes1.beiCheck2.EditValue);
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
