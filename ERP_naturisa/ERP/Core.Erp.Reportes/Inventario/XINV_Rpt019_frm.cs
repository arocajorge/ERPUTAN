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
    public partial class XINV_Rpt019_frm : Form
    {
        #region "Variables y  Propiedades"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion

        #region "Constructor"
        public XINV_Rpt019_frm()
        {
            InitializeComponent();
            ucInv_MenuReportes1.event_tnConsultar_ItemClick += ucInv_MenuReportes1_event_tnConsultar_ItemClick;
            ucInv_MenuReportes1.event_btnImprimir_ItemClick += ucInv_MenuReportes1_event_btnImprimir_ItemClick;
            ucInv_MenuReportes1.event_btnSalir_ItemClick += ucInv_MenuReportes1_event_btnSalir_ItemClick;
        }
        #endregion

        #region "Eventos"
        void ucInv_MenuReportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string TipoMov = string.Empty;
                XINV_Rpt019_Rpt rpt = new XINV_Rpt019_Rpt();
                rpt.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(rpt);
                pt.AutoShowParametersPanel = false;

                rpt.Parameters["IdSucursalIni"].Value = ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0 ? 0 : ucInv_MenuReportes1.cmbSucursal.EditValue;
                rpt.Parameters["IdSucursalFin"].Value = ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0 ? 9999 : ucInv_MenuReportes1.cmbSucursal.EditValue;

                rpt.Parameters["IdBodegaIni"].Value = ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0 ? 0 : ucInv_MenuReportes1.cmbBodega.EditValue;
                rpt.Parameters["IdBodegaFin"].Value = ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0 ? 9999 : ucInv_MenuReportes1.cmbBodega.EditValue;

                rpt.Parameters["IdProductoIni"].Value = ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue) == 0 ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue);
                rpt.Parameters["IdProductoFin"].Value = ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue) == 0 ? 9999 : Convert.ToInt32(ucInv_MenuReportes1.cmbProducto.EditValue);

                rpt.Parameters["FechaIni"].Value = ucInv_MenuReportes1.dtpDesde.Edit == null ? DateTime.Now : (DateTime)ucInv_MenuReportes1.dtpDesde.EditValue;
                rpt.Parameters["FechaFin"].Value = ucInv_MenuReportes1.dtpHasta.Edit == null ? DateTime.Now : (DateTime)ucInv_MenuReportes1.dtpHasta.EditValue;


                rpt.Parameters["nom_sucursal"].Value = ucInv_MenuReportes1.cmbSucursal.Edit.GetDisplayText(ucInv_MenuReportes1.cmbSucursal.EditValue);
                rpt.Parameters["nom_bodega"].Value = ucInv_MenuReportes1.cmbBodega.Edit.GetDisplayText(ucInv_MenuReportes1.cmbBodega.EditValue);
                rpt.Parameters["nom_producto"].Value = ucInv_MenuReportes1.cmbProducto.Edit.GetDisplayText(ucInv_MenuReportes1.cmbProducto.EditValue); 
               
                rpt.Parameters["IdCentro_costo"].Value = (ucInv_MenuReportes1.barEditItemCentroCosto.EditValue == null) || (ucInv_MenuReportes1.barEditItemCentroCosto.EditValue == "Todos") ? "" : ucInv_MenuReportes1.barEditItemCentroCosto.EditValue.ToString();
                rpt.Parameters["IdSubcentro_costo"].Value = (ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue == null) || (ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue == "Todos") ? "" : ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue.ToString();                             
                              
                rpt.Parameters["nom_centro_costo"].Value = ucInv_MenuReportes1.barEditItemCentroCosto.Edit.GetDisplayText(ucInv_MenuReportes1.barEditItemCentroCosto.EditValue);
                rpt.Parameters["nom_subcentro_costo"].Value = ucInv_MenuReportes1.barEditItemSubCentroCosto.Edit.GetDisplayText(ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue);

                rpt.Parameters["IdMovi_inven_tipoIni"].Value = ucInv_MenuReportes1.cmbTipoMovInve.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue) == 0 ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);
                rpt.Parameters["IdMovi_inven_tipoFin"].Value = ucInv_MenuReportes1.cmbTipoMovInve.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue) == 0 ? 9999 : Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);
                rpt.Parameters["nom_tipo_inven"].Value = ucInv_MenuReportes1.cmbTipoMovInve.Edit.GetDisplayText(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);
                
                TipoMov = ucInv_MenuReportes1.barEditItemTipoMovimiento.Edit.GetDisplayText(ucInv_MenuReportes1.barEditItemTipoMovimiento.EditValue);
                rpt.Parameters["nomtipomov"].Value = ucInv_MenuReportes1.barEditItemTipoMovimiento.Edit.GetDisplayText(ucInv_MenuReportes1.barEditItemTipoMovimiento.EditValue);
                switch (TipoMov)
                {
                    case "(+)Ingresos": TipoMov = "+";
                        break;
                    case "(-)Egresos": TipoMov = "-";
                        break;
                    case "Todos": TipoMov = "";
                        break;
                    default:
                        break;
                }
                rpt.Parameters["TipoMovimiento"].Value = TipoMov;
                              
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
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
        #endregion
    }
}
