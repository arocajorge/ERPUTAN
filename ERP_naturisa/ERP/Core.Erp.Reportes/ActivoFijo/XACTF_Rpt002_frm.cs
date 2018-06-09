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

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt002_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;  

        public XACTF_Rpt002_frm()
        {
            InitializeComponent();
            ucactF_Menu.event_btnGenerar_ItemClick += ucactF_Menu_event_btnGenerar_ItemClick;
            ucactF_Menu.event_btnSalir_ItemClick += ucactF_Menu_event_btnSalir_ItemClick;
        }

        void ucactF_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucactF_Menu_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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


        void CargarReporte()
        {
            try
            {
                XACTF_Rpt002_rpt reporte = new XACTF_Rpt002_rpt();
                reporte.RequestParameters = false;

                ReportPrintTool rpt = new ReportPrintTool(reporte);
                rpt.AutoShowParametersPanel = false;

                reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                reporte.Parameters["IdSucursalIni"].Value = (ucactF_Menu.barEditItemSucursal.EditValue == null) ? 0 : ucactF_Menu.barEditItemSucursal.EditValue;
                reporte.Parameters["IdSucursalFin"].Value = (ucactF_Menu.barEditItemSucursal.EditValue == null || Convert.ToInt32(ucactF_Menu.barEditItemSucursal.EditValue) == 0 ) ? 99999 : ucactF_Menu.barEditItemSucursal.EditValue;
                reporte.Parameters["IdTipoDepreciacion"].Value = (ucactF_Menu.barEditItemTipo.EditValue == null) ? 0 : ucactF_Menu.barEditItemTipo.EditValue;
                reporte.Parameters["IdTipoActivo"].Value = (ucactF_Menu.barEditItemTipoActivo.EditValue == null) ? 0 : ucactF_Menu.barEditItemTipoActivo.EditValue;
                reporte.Parameters["IdEstadoProceso"].Value = (ucactF_Menu.barEditItemEstado.EditValue == null) ? 0 : ucactF_Menu.barEditItemEstado.EditValue;
                reporte.Parameters["FechaIni"].Value = ucactF_Menu.dtpFechaIni.EditValue;
                reporte.Parameters["FechaFin"].Value = ucactF_Menu.dtpFechaFin.EditValue;
                reporte.Parameters["IdUsuario"].Value = param.IdUsuario;
                reporte.Parameters["nomSucursal"].Value = ucactF_Menu.barEditItemSucursal.Edit.GetDisplayText(ucactF_Menu.barEditItemSucursal.EditValue);
                reporte.Parameters["nomActivo"].Value = ucactF_Menu.barEditItemTipoActivo.Edit.GetDisplayText(ucactF_Menu.barEditItemTipoActivo.EditValue);
                reporte.Parameters["nomDepre"].Value = ucactF_Menu.barEditItemTipo.Edit.GetDisplayText(ucactF_Menu.barEditItemTipo.EditValue);
                reporte.Parameters["nomEstado"].Value = ucactF_Menu.barEditItemEstado.Edit.GetDisplayText(ucactF_Menu.barEditItemEstado.EditValue);

                printControlReporte.PrintingSystem = reporte.PrintingSystem;
                reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
