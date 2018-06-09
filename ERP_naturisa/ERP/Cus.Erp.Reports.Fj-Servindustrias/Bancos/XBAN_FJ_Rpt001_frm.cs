using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Cus.Erp.Reports.FJ.Bancos
{
    public partial class XBAN_FJ_Rpt001_frm : Form
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XBAN_FJ_Rpt001_frm()
        {
            InitializeComponent();
        }

        private void Imprimir()
        {
            try
            {
             
            XBAN_FJ_Rpt001_Rpt Reporte = new XBAN_FJ_Rpt001_Rpt();
            Reporte.Parameters["Fecha_inicio"].Value = Convert.ToDateTime(ucBa_Menu.get_FchIni());
            Reporte.Parameters["Fecha_fin"].Value = Convert.ToDateTime(ucBa_Menu.get_FchFin());
            Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;

            Reporte.RequestParameters = false;
            ReportPrintTool pt = new ReportPrintTool(Reporte);
            pt.ShowPreviewDialog();
            }
            catch (Exception)
            {
                
            }
        }

        private void ucBa_Menu_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucBa_Menu_event_btnRefrescar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Imprimir();
        }
    }
}
