using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt004_frm : Form
    {
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_NATU_Rpt004_frm()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt004_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void ucCp_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt004_Rpt Reporte = new XCXP_NATU_Rpt004_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdProveedorIni"].Value = uccp_menu.Get_info_proveedor() == null ? 0 : uccp_menu.Get_info_proveedor().IdProveedor;
                Reporte.Parameters["IdProveedorFin"].Value = uccp_menu.Get_info_proveedor() == null ? 99999 : uccp_menu.Get_info_proveedor().IdProveedor;

                Reporte.Parameters["FechaIni"].Value = uccp_menu.dtpDesde.EditValue;
                Reporte.Parameters["FechaFin"].Value = uccp_menu.dtpHasta.EditValue;
                Reporte.P_IdClaseProveedor.Value = uccp_menu.Get_info_clase_proveedor() == null ? 0 : uccp_menu.Get_info_clase_proveedor().IdClaseProveedor;
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucCp_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
