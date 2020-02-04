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
    public partial class XACTF_FJ_Rpt003_frm : Form
    {
        public XACTF_FJ_Rpt003_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        private void btn_Impromir_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }


        private void GenerarReporte()
        {
            try
            {
                XACTF_FJ_Rpt003_Rpt Reporte = new XACTF_FJ_Rpt003_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdCentro"].Value =uCct_CentroCosto1.Get_IdCentroCosto();
                Reporte.Parameters["IsSubcentro"].Value = uCct_CentroCosto1.Get_IdSubCentro_Costo();


                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
            }
        }

    }
}
