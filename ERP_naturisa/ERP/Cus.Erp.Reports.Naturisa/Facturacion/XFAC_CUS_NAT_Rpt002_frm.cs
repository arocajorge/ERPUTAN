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
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace Cus.Erp.Reports.Naturisa.Facturacion
{
    public partial class XFAC_CUS_NAT_Rpt002_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;      

        public XFAC_CUS_NAT_Rpt002_frm()
        {
            InitializeComponent();
            ucFa_Menu.event_btnConsultar_ItemClick += ucFa_Menu_event_btnConsultar_ItemClick;
            ucFa_Menu.event_btnSalir_ItemClick += ucFa_Menu_event_btnSalir_ItemClick;
        }

        void ucFa_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucFa_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void XFAC_CUS_NAT_Rpt002_frm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        void CargarDatos()
        {
            try
            {
                XFAC_CUS_NAT_Rpt002_rpt Reporte = new XFAC_CUS_NAT_Rpt002_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursalIni"].Value = (ucFa_Menu.cmbSucursal.EditValue == null) ? 0 : ucFa_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["IdSucursalFin"].Value = (ucFa_Menu.cmbSucursal.EditValue == null || Convert.ToDecimal(ucFa_Menu.cmbSucursal.EditValue) == 0) ? 999999 : ucFa_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["IdClienteIni"].Value = (ucFa_Menu.cmbCliente.EditValue == null) ? 0 : ucFa_Menu.cmbCliente.EditValue;
                Reporte.Parameters["IdClienteFin"].Value = (ucFa_Menu.cmbCliente.EditValue == null || Convert.ToDecimal(ucFa_Menu.cmbCliente.EditValue) == 0) ? 999999 : ucFa_Menu.cmbCliente.EditValue;
                Reporte.Parameters["IdMotivo_VtaIni"].Value = (ucFa_Menu.cmbTipoProducto.EditValue == null) ? 0 : ucFa_Menu.cmbTipoProducto.EditValue;
                Reporte.Parameters["IdMotivo_VtaFin"].Value = (ucFa_Menu.cmbTipoProducto.EditValue == null || Convert.ToDecimal(ucFa_Menu.cmbTipoProducto.EditValue) == 0) ? 999999 : ucFa_Menu.cmbTipoProducto.EditValue;
                Reporte.Parameters["FechaIni"].Value = ucFa_Menu.dtpDesde.EditValue;
                Reporte.Parameters["FechaFin"].Value = ucFa_Menu.dtpHasta.EditValue;                
                Reporte.Parameters["nomCliente"].Value = ucFa_Menu.cmbCliente.Edit.GetDisplayText(ucFa_Menu.cmbCliente.EditValue);
                Reporte.Parameters["nomSucursal"].Value = ucFa_Menu.cmbSucursal.Edit.GetDisplayText(ucFa_Menu.cmbSucursal.EditValue);
                Reporte.Parameters["nomMotivo_Vta"].Value = ucFa_Menu.cmbTipoProducto.Edit.GetDisplayText(ucFa_Menu.cmbTipoProducto.EditValue);


                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
