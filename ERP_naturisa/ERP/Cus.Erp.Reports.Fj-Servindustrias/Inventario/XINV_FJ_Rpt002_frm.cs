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
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public partial class XINV_FJ_Rpt002_frm : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        List<tb_Bodega_Info> listBodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        #endregion
        

        public XINV_FJ_Rpt002_frm()
        {
            InitializeComponent();
            ucInv_Menu.event_btnSalir_ItemClick += ucInv_Menu_event_btnSalir_ItemClick;
            ucInv_Menu.event_tnConsultar_ItemClick += ucInv_Menu_event_tnConsultar_ItemClick;
        }

        void ucInv_Menu_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucInv_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      
        void CargarGrid()
        {
            try
            {
                XINV_FJ_Rpt002_rpt Reporte = new XINV_FJ_Rpt002_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdSucursalIni"].Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["IdSucursalFin"].Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                Reporte.Parameters["IdBodegaIni"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : ucInv_Menu.cmbBodega.EditValue;
                Reporte.Parameters["IdBodegaFin"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                Reporte.Parameters["IdProductoIni"].Value = (ucInv_Menu.cmbProducto.EditValue == null) ? 0 : ucInv_Menu.cmbProducto.EditValue;
                Reporte.Parameters["IdProductoFin"].Value = (ucInv_Menu.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue);
                Reporte.Parameters["FechaIni"].Value = ucInv_Menu.dtpDesde.EditValue;
                Reporte.Parameters["FechaFin"].Value = ucInv_Menu.dtpHasta.EditValue;

                Reporte.Parameters["IdCentroCosto"].Value = (ucInv_Menu.barEditItemCentroCosto.EditValue == null) || (ucInv_Menu.barEditItemCentroCosto.EditValue == "Todos") ? "" : ucInv_Menu.barEditItemCentroCosto.EditValue.ToString();
                Reporte.Parameters["IdCentroCosto_sub_centro_costo"].Value = (ucInv_Menu.barEditItemSubCentroCosto.EditValue == null) || (ucInv_Menu.barEditItemSubCentroCosto.EditValue == "Todos") ? "" : ucInv_Menu.barEditItemSubCentroCosto.EditValue.ToString();

                Reporte.Parameters["nom_Sucursal"].Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                Reporte.Parameters["nom_Bodega"].Value = ucInv_Menu.cmbBodega.Edit.GetDisplayText(ucInv_Menu.cmbBodega.EditValue);
                Reporte.Parameters["nom_Producto"].Value = ucInv_Menu.cmbProducto.Edit.GetDisplayText(ucInv_Menu.cmbProducto.EditValue);

                Reporte.Parameters["IdCentroCosto"].Value = (ucInv_Menu.barEditItemCentroCosto.EditValue == null) || (ucInv_Menu.barEditItemCentroCosto.EditValue == "Todos") ? "" :ucInv_Menu.barEditItemCentroCosto.EditValue.ToString();
                Reporte.Parameters["IdCentroCosto_sub_centro_costo"].Value = (ucInv_Menu.barEditItemSubCentroCosto.EditValue == null) || (ucInv_Menu.barEditItemSubCentroCosto.EditValue == "Todos") ? "" : ucInv_Menu.barEditItemSubCentroCosto.EditValue.ToString();

                Reporte.Parameters["nom_CentroCosto"].Value = ucInv_Menu.barEditItemCentroCosto.Edit.GetDisplayText(ucInv_Menu.barEditItemCentroCosto.EditValue);
                Reporte.Parameters["nom_CentroCosto_sub_centro_costo"].Value = ucInv_Menu.barEditItemSubCentroCosto.Edit.GetDisplayText(ucInv_Menu.barEditItemSubCentroCosto.EditValue);

                printControl_report.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void XINV_FJ_Rpt002_frm_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }     
       
    }
}
