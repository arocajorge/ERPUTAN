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
using DevExpress.XtraReports.UI;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public partial class XCOL_Rpt002_frm : Form
    {
        public XCOL_Rpt002_frm()
        {
            InitializeComponent();
        }

        void CargarGrid()
        {
            try
            {
                XCOL_Rpt002_Rpt Reporte = new XCOL_Rpt002_Rpt();
                Reporte.RequestParameters = false;
                //Reporte.Parameters["pIdSede"].Value = cmb_Sede.EditValue;
                Reporte.Parameters["pIdSede"].Value = 1;

                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                //Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                //Reporte.Parameters["IdUsuario"].Value = 1;

                printControl1.PrintingSystem = Reporte.PrintingSystem;

                Reporte.CreateDocument();
                 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR en REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cargar_reporte_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }


    }
}
