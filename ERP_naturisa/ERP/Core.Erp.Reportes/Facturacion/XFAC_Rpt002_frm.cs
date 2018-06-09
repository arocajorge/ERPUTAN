using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt002_frm : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;        

        public XFAC_Rpt002_frm()
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucFa_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarDatos()
        {
            try
            {
                XFAC_Rpt002_rpt Reporte = new XFAC_Rpt002_rpt();
                string tipoPago = "";

                if (ucFa_Menu.cmbTipoPago.EditValue == "Todos")
                    tipoPago = "TODO";

                if (ucFa_Menu.cmbTipoPago.EditValue == "Pendientes por Cobrar")
                    tipoPago = "PENDI";

                if (ucFa_Menu.cmbTipoPago.EditValue == "Pagados")
                    tipoPago = "PAGAD";


                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursalIni"].Value = (ucFa_Menu.cmbSucursal.EditValue == null) ? 0 : ucFa_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["IdSucursalFin"].Value = (ucFa_Menu.cmbSucursal.EditValue == null || Convert.ToDecimal(ucFa_Menu.cmbSucursal.EditValue) == 0) ? 999999 : ucFa_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["IdClienteIni"].Value = (ucFa_Menu.cmbCliente.EditValue == null) ? 0 : ucFa_Menu.cmbCliente.EditValue;
                Reporte.Parameters["IdClienteFin"].Value = (ucFa_Menu.cmbCliente.EditValue == null || Convert.ToDecimal(ucFa_Menu.cmbCliente.EditValue) == 0) ? 999999 : ucFa_Menu.cmbCliente.EditValue;
                Reporte.Parameters["TipoPago"].Value = tipoPago;
                Reporte.Parameters["FechaIni"].Value = ucFa_Menu.dtpDesde.EditValue;
                Reporte.Parameters["FechaFin"].Value = ucFa_Menu.dtpHasta.EditValue;
                Reporte.Parameters["IdUsuario"].Value = param.IdUsuario;
                Reporte.Parameters["nomCliente"].Value = ucFa_Menu.cmbCliente.Edit.GetDisplayText(ucFa_Menu.cmbCliente.EditValue);
                Reporte.Parameters["nomSucursal"].Value = ucFa_Menu.cmbSucursal.Edit.GetDisplayText(ucFa_Menu.cmbSucursal.EditValue);
                Reporte.PEfectoTributario.Value = chkefectoTributario.Checked;

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
