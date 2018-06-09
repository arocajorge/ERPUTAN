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
    public partial class XROL_Rpt024_frm : Form
    {

        

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XROL_Rpt024_frm()
        {
            InitializeComponent();
        }

       
        private void XROL_Rpt005_frm_Load(object sender, EventArgs e)
        {
        }

        private void pu_Imprimir()
        {
            try
            {
                XROL_Rpt024_rpt Reporte = new XROL_Rpt024_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdEmpleado"].Value = ucRo_Menu.getIdEmpleado();

                Reporte.CreateDocument();
                Reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucRo_Menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pu_Imprimir();
        }







    }
}
