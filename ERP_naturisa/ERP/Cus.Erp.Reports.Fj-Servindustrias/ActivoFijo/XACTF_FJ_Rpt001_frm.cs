using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public partial class XACTF_FJ_Rpt001_frm : Form
    {
        public XACTF_FJ_Rpt001_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private void cmb_generar_reporte_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
        private void GenerarReporte()
        {
            try
            {
                XACTF_FJ_Rpt001_Rpt Reporte = new XACTF_FJ_Rpt001_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["FechaCorte"].Value = Convert.ToDateTime(de_fecha_desde.EditValue);
                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;


                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
            }
        }


    }
}
