using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;



namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt002_frm : Form
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<cp_proveedor_Info> listProvee = new List<cp_proveedor_Info>();

        public XCXP_NATU_Rpt002_frm()
        {
            InitializeComponent();
        }
             
        private void XCXP_NATU_Rpt002_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void uccp_menu_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt002_Rpt Reporte = new XCXP_NATU_Rpt002_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdProveedorIni"].Value = (uccp_menu.Get_info_proveedor() == null) ? 0 : uccp_menu.Get_info_proveedor().IdProveedor;
                Reporte.Parameters["IdProveedorFin"].Value = (uccp_menu.Get_info_proveedor() == null) ? 999999 : uccp_menu.Get_info_proveedor().IdProveedor;
                Reporte.Parameters["Fecha_Ini"].Value = Convert.ToDateTime(uccp_menu.dtpDesde.EditValue).Date;
                Reporte.Parameters["Fecha_Fin"].Value = Convert.ToDateTime(uccp_menu.dtpHasta.EditValue).Date;
                Reporte.Parameters["S_proveedor"].Value = (uccp_menu.Get_info_proveedor() == null) ? "TODOS" : uccp_menu.Get_info_proveedor().pr_nombre2.Trim();
                Reporte.Parameters["S_fechaDesde"].Value = Convert.ToDateTime(uccp_menu.dtpDesde.EditValue).Date;
                Reporte.Parameters["S_fechaHasta"].Value = Convert.ToDateTime(uccp_menu.dtpHasta.EditValue).Date;
                Reporte.IdClaseProveedorIni.Value = uccp_menu.Get_info_clase_proveedor() == null ? 0 : uccp_menu.Get_info_clase_proveedor().IdClaseProveedor;
                Reporte.IdClaseProveedorFin.Value = uccp_menu.Get_info_clase_proveedor() == null ? 99999 : uccp_menu.Get_info_clase_proveedor().IdClaseProveedor;
                Reporte.S_claseProveedor.Value = uccp_menu.Get_info_clase_proveedor() == null ? "TODOS" : uccp_menu.Get_info_clase_proveedor().descripcion_clas_prove2.Trim();
                Reporte.PFiltro_fecha_emi.Value = Convert.ToBoolean(uccp_menu.beiCheck1.EditValue);
                Reporte.PObservacion_completa.Value = Convert.ToBoolean(uccp_menu.beiCheck3.EditValue);
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {

            }
        }

        private void uccp_menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
