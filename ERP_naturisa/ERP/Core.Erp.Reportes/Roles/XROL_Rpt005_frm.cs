using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt005_frm : Form
    {

        int _idEmpresa=0;
        decimal _idPrestamo=0;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XROL_Rpt005_frm()
        {
            InitializeComponent();
        }

        public XROL_Rpt005_frm(int idEmpresa, decimal idPrestamo)
        {
            InitializeComponent();

             _idEmpresa=idEmpresa;
            _idPrestamo=idPrestamo;
        }

        private void XROL_Rpt005_frm_Load(object sender, EventArgs e)
        {
            pu_Imprimir();
        }

        private void pu_Imprimir()
        {
            try
            {
                XROL_Rpt005_rpt Reporte = new XROL_Rpt005_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["s_idEmpresa"].Value = _idEmpresa;
                Reporte.Parameters["s_idPrestamo"].Value = _idPrestamo;

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }







    }
}
