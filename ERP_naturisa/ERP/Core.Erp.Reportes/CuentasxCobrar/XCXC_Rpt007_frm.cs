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

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt007_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        public XCXC_Rpt007_frm()
        {
            InitializeComponent();
            uccxC_Menu.event_btnConsultar_ItemClick += uccxC_Menu_event_btnConsultar_ItemClick;
            uccxC_Menu.event_btnSalir_ItemClick += uccxC_Menu_event_btnSalir_ItemClick;
        }

        void uccxC_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void uccxC_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (uccxC_Menu.beiCliente.EditValue == null || Convert.ToInt32(uccxC_Menu.beiCliente.EditValue) == 0)                
                    MessageBox.Show("Debe Seleccionar el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                else                
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
                XCXC_Rpt007_rpt Reporte = new XCXC_Rpt007_rpt();      
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.PIdEmpresa.Value = param.IdEmpresa;      
                Reporte.PFechaCorte.Value = uccxC_Menu.dtpDesde.EditValue;                
                Reporte.PIdSucursalIni.Value = (uccxC_Menu.beiSucursal.EditValue == null) ? 0 : uccxC_Menu.beiSucursal.EditValue;
                Reporte.PIdSucursalFin.Value = (uccxC_Menu.beiSucursal.EditValue == null || Convert.ToInt32(uccxC_Menu.beiSucursal.EditValue) == 0) ? 999999 : uccxC_Menu.beiSucursal.EditValue;
                Reporte.PIdCliente.Value = (uccxC_Menu.beiCliente.EditValue == null) ? 0 : uccxC_Menu.beiCliente.EditValue;
                Reporte.PMostar_cbtes_con_saldo.Value = chkMostrar_solo_cbtes_con_saldo.Checked;

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXC_Rpt007_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uccxC_Menu.dtpDesde.EditValue = DateTime.Now;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
