using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cus.Erp.Reports.FJ.Bancos;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
namespace Cus.Erp.Reports.FJ.Bancos
{
    public partial class XBAN_FJ_Rpt002_frm : Form
    {
        public XBAN_FJ_Rpt002_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private void ucBa_Menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucBa_Menu_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }




        private void Imprimir()
        {
            try
            {

                XBAN_FJ_Rpt002_Rpt Reporte = new XBAN_FJ_Rpt002_Rpt();
                Reporte.Parameters["Fecha_inicio"].Value = Convert.ToDateTime(ucBa_Menu.get_FchIni());
                Reporte.Parameters["Fecha_fin"].Value = Convert.ToDateTime(ucBa_Menu.get_FchFin());
                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.ShowPreview();



                XBAN_FJ_Rpt003_Rpt Reporte_Graf = new XBAN_FJ_Rpt003_Rpt();
                Reporte_Graf.Parameters["FechaInicio"].Value = Convert.ToDateTime(ucBa_Menu.get_FchIni());
                Reporte_Graf.Parameters["FechaFin"].Value = Convert.ToDateTime(ucBa_Menu.get_FchFin());
                Reporte_Graf.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte_Graf.RequestParameters = false;
                ReportPrintTool ptG = new ReportPrintTool(Reporte_Graf);
                ptG.ShowPreview();

            }
            catch (Exception)
            {

            }
        }

    }
}
