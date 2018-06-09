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
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Cus.Erp.Reports.CAH.Inventario;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt009_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        List<tb_Bodega_Info> listBodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();

        public XINV_Rpt009_frm()
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
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarGrid()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:

                        XINV_Rpt009_rpt Reporte = new XINV_Rpt009_rpt();
                        Reporte.RequestParameters = false;
                        ReportPrintTool pt = new ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;

                        Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte.Parameters["IdSucursal"].Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                        Reporte.Parameters["IdSucursalFin"].Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte.Parameters["IdBodega"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : ucInv_Menu.cmbBodega.EditValue;
                        Reporte.Parameters["IdBodegaFin"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                        Reporte.Parameters["FechaIni"].Value = ucInv_Menu.dtpDesde.EditValue;
                        Reporte.Parameters["FechaFin"].Value = ucInv_Menu.dtpHasta.EditValue;
                        Reporte.PIdCategoria.Value = ucInv_Menu.cmbCategoria.EditValue;
                        Reporte.PIdLinea.Value = ucInv_Menu.cmbLinea.EditValue;
                        Reporte.Parameters["nom_Sucursal"].Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte.Parameters["nom_Bodega"].Value = ucInv_Menu.cmbBodega.Edit.GetDisplayText(ucInv_Menu.cmbBodega.EditValue);
                        Reporte.PRegistro_Cero.Value = ucInv_Menu.beiCheck1.EditValue;
                        Reporte.P_toma_física.Value = ucInv_Menu.beiCheck2.EditValue;
                        Reporte.P_IdProducto.Value = ucInv_Menu.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_Menu.cmbProducto.EditValue);
                        printControl1.PrintingSystem = Reporte.PrintingSystem;

                        Reporte.CreateDocument();
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.CAH:

                        XINV_CAH_Rpt001_Rpt Reporte_CAH = new XINV_CAH_Rpt001_Rpt();
                        Reporte_CAH.RequestParameters = false;
                        ReportPrintTool pt_CAH = new ReportPrintTool(Reporte_CAH);
                        pt_CAH.AutoShowParametersPanel = false;

                        Reporte_CAH.PIdEmpresa.Value = param.IdEmpresa;
                        Reporte_CAH.PIdSucursal.Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                        Reporte_CAH.PIdSucursalFin.Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte_CAH.PIdBodega.Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : ucInv_Menu.cmbBodega.EditValue;
                        Reporte_CAH.PIdBodegaFin.Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                        Reporte_CAH.PFechaIni.Value = ucInv_Menu.dtpDesde.EditValue;
                        Reporte_CAH.PFechaFin.Value = ucInv_Menu.dtpHasta.EditValue;
                        Reporte_CAH.PIdCategoria.Value = ucInv_Menu.cmbCategoria.EditValue;
                        Reporte_CAH.PIdLinea.Value = ucInv_Menu.cmbLinea.EditValue;
                        Reporte_CAH.PNom_Sucursal.Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte_CAH.PNom_Bodega.Value = ucInv_Menu.cmbBodega.Edit.GetDisplayText(ucInv_Menu.cmbBodega.EditValue);
                        Reporte_CAH.PRegistro_Cero.Value = ucInv_Menu.beiCheck1.EditValue;
                        Reporte_CAH.PToma_Física.Value = ucInv_Menu.beiCheck2.EditValue;
                        printControl1.PrintingSystem = Reporte_CAH.PrintingSystem;

                        Reporte_CAH.CreateDocument();
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:

                        XINV_Rpt009_rpt Reporte_General = new XINV_Rpt009_rpt();
                        Reporte_General.RequestParameters = false;
                        ReportPrintTool pt_general = new ReportPrintTool(Reporte_General);
                        pt_general.AutoShowParametersPanel = false;

                        Reporte_General.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte_General.Parameters["IdSucursal"].Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                        Reporte_General.Parameters["IdSucursalFin"].Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte_General.Parameters["IdBodega"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : ucInv_Menu.cmbBodega.EditValue;
                        Reporte_General.Parameters["IdBodegaFin"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                        Reporte_General.Parameters["FechaIni"].Value = ucInv_Menu.dtpDesde.EditValue;
                        Reporte_General.Parameters["FechaFin"].Value = ucInv_Menu.dtpHasta.EditValue;
                        Reporte_General.PIdCategoria.Value = ucInv_Menu.cmbCategoria.EditValue;
                        Reporte_General.PIdLinea.Value = ucInv_Menu.cmbLinea.EditValue;
                        Reporte_General.Parameters["nom_Sucursal"].Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte_General.Parameters["nom_Bodega"].Value = ucInv_Menu.cmbBodega.Edit.GetDisplayText(ucInv_Menu.cmbBodega.EditValue);
                        Reporte_General.PRegistro_Cero.Value = ucInv_Menu.beiCheck1.EditValue;
                        Reporte_General.P_toma_física.Value = ucInv_Menu.beiCheck2.EditValue;
                        Reporte_General.P_IdProducto.Value = ucInv_Menu.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_Menu.cmbProducto.EditValue);
                        printControl1.PrintingSystem = Reporte_General.PrintingSystem;

                        Reporte_General.CreateDocument();
                        break;

                    default:
                        XINV_Rpt009_rpt Reporte_default = new XINV_Rpt009_rpt();

                        Reporte_default.RequestParameters = false;
                        ReportPrintTool pt_defaulft = new ReportPrintTool(Reporte_default);
                        pt_defaulft.AutoShowParametersPanel = false;

                        Reporte_default.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte_default.Parameters["IdSucursal"].Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                        Reporte_default.Parameters["IdSucursalFin"].Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte_default.Parameters["IdBodega"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : ucInv_Menu.cmbBodega.EditValue;
                        Reporte_default.Parameters["IdBodegaFin"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                        Reporte_default.Parameters["FechaIni"].Value = ucInv_Menu.dtpDesde.EditValue;
                        Reporte_default.Parameters["FechaFin"].Value = ucInv_Menu.dtpHasta.EditValue;
                        Reporte_default.PIdCategoria.Value = ucInv_Menu.cmbCategoria.EditValue;
                        Reporte_default.PIdLinea.Value = ucInv_Menu.cmbLinea.EditValue;
                        Reporte_default.Parameters["nom_Sucursal"].Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                        Reporte_default.Parameters["nom_Bodega"].Value = ucInv_Menu.cmbBodega.Edit.GetDisplayText(ucInv_Menu.cmbBodega.EditValue);
                        Reporte_default.PRegistro_Cero.Value = ucInv_Menu.beiCheck1.EditValue;
                        Reporte_default.P_IdProducto.Value = ucInv_Menu.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_Menu.cmbProducto.EditValue);
                        Reporte_default.P_toma_física.Value = ucInv_Menu.beiCheck2.EditValue;
                        printControl1.PrintingSystem = Reporte_default.PrintingSystem;


                        Reporte_default.CreateDocument();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XINV_Rpt009_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucInv_Menu.dtpHasta.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
