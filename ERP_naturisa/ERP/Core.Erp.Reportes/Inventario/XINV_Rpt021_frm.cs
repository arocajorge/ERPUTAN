using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt021_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt021_frm()
        {
            InitializeComponent();
            ucInv_MenuReportes1.event_tnConsultar_ItemClick += ucInv_MenuReportes1_event_tnConsultar_ItemClick;
            ucInv_MenuReportes1.event_btnSalir_ItemClick += ucInv_MenuReportes1_event_btnSalir_ItemClick;
            ucInv_MenuReportes1.event_btnImprimir_ItemClick += ucInv_MenuReportes1_event_btnImprimir_ItemClick;
        }

        void ucInv_MenuReportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ucInv_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XINV_Rpt021_Rpt rpt = new XINV_Rpt021_Rpt();
                rpt.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(rpt);
                pt.AutoShowParametersPanel = false;

                rpt.Parameters["idSucursalIni"].Value = ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0 ? 0 : ucInv_MenuReportes1.cmbSucursal.EditValue;
                rpt.Parameters["idSucursalFin"].Value = ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0 ? 9999 : ucInv_MenuReportes1.cmbSucursal.EditValue;

                rpt.Parameters["idBodegaIni"].Value = ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0 ? 0 : ucInv_MenuReportes1.cmbBodega.EditValue;
                rpt.Parameters["idBodegaFin"].Value = ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0 ? 9999 : ucInv_MenuReportes1.cmbBodega.EditValue;

                rpt.Parameters["idProductoIni"].Value = ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue) == 0 ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue);
                rpt.Parameters["idProductoFin"].Value = ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue) == 0 ? 9999 : Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue);

                rpt.Parameters["FechaDesde"].Value = ucInv_MenuReportes1.dtpDesde.Edit == null ? DateTime.Now : (DateTime)ucInv_MenuReportes1.dtpDesde.EditValue;
                rpt.Parameters["FechaHasta"].Value = ucInv_MenuReportes1.dtpHasta.Edit == null ? DateTime.Now : (DateTime)ucInv_MenuReportes1.dtpHasta.EditValue;

                rpt.Parameters["DiasStock"].Value = ucInv_MenuReportes1.txtDiasStock.EditValue == null ? 0 : Convert.ToInt32(ucInv_MenuReportes1.txtDiasStock.EditValue);

                rpt.Parameters["nom_sucursal"].Value = ucInv_MenuReportes1.cmbSucursal.Edit.GetDisplayText(ucInv_MenuReportes1.cmbSucursal.EditValue);
                rpt.Parameters["nom_bodega"].Value = ucInv_MenuReportes1.cmbBodega.Edit.GetDisplayText(ucInv_MenuReportes1.cmbBodega.EditValue);
                rpt.Parameters["nom_producto"].Value = ucInv_MenuReportes1.cmbProducto.Edit.GetDisplayText(ucInv_MenuReportes1.cmbProducto.EditValue);

                rpt.Parameters["MostrarCero"].Value = ucInv_MenuReportes1.chkMostrarCero.EditValue;

                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
