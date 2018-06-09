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
using Core.Erp.Info.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt018_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XINV_Rpt018_frm()
        {
            InitializeComponent();
            ucInv_MenuReportes1.event_tnConsultar_ItemClick +=ucInv_MenuReportes1_event_tnConsultar_ItemClick;
            ucInv_MenuReportes1.event_btnSalir_ItemClick+=ucInv_MenuReportes1_event_btnSalir_ItemClick;
        }

        private void XINV_Rpt018_frm_Load(object sender, EventArgs e)
        {
            ucInv_MenuReportes1.dtpHasta.EditValue = DateTime.Now;
            ucInv_MenuReportes1.cmbBodega.EditValue = 0;
        }

        void CargarReporte()
        {
            try
            {
                XINV_Rpt018_Rpt Reporte = new XINV_Rpt018_Rpt();
                Reporte.RequestParameters = false;

                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["PIdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["PIdSucursalIni"].Value = (ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue)==0) ? 1 : Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue);
                Reporte.Parameters["PIdSucursalFin"].Value = (ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0) ? 999999999 : Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue);
                Reporte.Parameters["PIdBodegaIni"].Value = (ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0) ? 1 : Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue);
                Reporte.Parameters["PIdBodegaFin"].Value = (ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0) ? 9999999 : Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue);
                Reporte.Parameters["PIdProductoFin"].Value = (ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue) == 0) ? 1 : Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue);
                Reporte.Parameters["PIdProductoFin"].Value = (ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue) == 0) ? 999999999 : Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue);
                Reporte.Parameters["PFechaIni"].Value = (ucInv_MenuReportes1.dtpDesde.EditValue == null) ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpDesde.EditValue);
                Reporte.Parameters["PFechaFin"].Value = (ucInv_MenuReportes1.dtpHasta.EditValue == null) ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpHasta.EditValue);
                Reporte.Parameters["Pdias_stock"].Value = (ucInv_MenuReportes1.txtDiasStock.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.txtDiasStock.EditValue) == 0) ? 0 : Convert.ToInt32(ucInv_MenuReportes1.txtDiasStock.EditValue);
                Reporte.Parameters["PMostrar_reg_en_cero"].Value = Convert.ToBoolean(ucInv_MenuReportes1.chkMostrarCero.EditValue);
                Reporte.Parameters["Pnom_bodega"].Value = ucInv_MenuReportes1.cmbBodega.Edit.GetDisplayText(ucInv_MenuReportes1.cmbBodega.EditValue);
                Reporte.Parameters["Pnom_producto"].Value = ucInv_MenuReportes1.cmbProducto.Edit.GetDisplayText(ucInv_MenuReportes1.cmbBodega.EditValue);
                Reporte.Parameters["Pnom_Sucursal"].Value = ucInv_MenuReportes1.cmbSucursal.Edit.GetDisplayText(ucInv_MenuReportes1.cmbSucursal.EditValue);

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucInv_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CargarReporte();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucInv_MenuReportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
