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
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt005_frm : Form
    {
        public XCAJ_Rpt005_frm()
        {
            InitializeComponent();
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;  
        private void ucCaj_Menu_Reportes_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCAJ_Rpt005_Rpt Reporte = new XCAJ_Rpt005_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["PIdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdCaja"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_Caja.EditValue) == 0) ? 0 : Convert.ToInt32(ucCaj_Menu_Reportes.cmb_Caja.EditValue);
                Reporte.Parameters["Fecha_inicio"].Value = ucCaj_Menu_Reportes.dtFechaIni.EditValue;
                Reporte.Parameters["Fecha_Fin"].Value = ucCaj_Menu_Reportes.dtFechaFin.EditValue;

                Reporte.CreateDocument();
                Reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
