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

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt024_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XINV_Rpt024_frm()
        {
            InitializeComponent();
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
                Cargar_Reporte();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cargar_Reporte()
        {
            try
            {
                XINV_Rpt024_Rpt Reporte = new XINV_Rpt024_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.PIdEmpresa.Value = param.IdEmpresa;
                Reporte.PIdSucursal.Value = ucInv_MenuReportes1.cmbSucursal.EditValue;
                Reporte.PIdBodega.Value = ucInv_MenuReportes1.cmbBodega.EditValue;
                Reporte.PIdMovi_inven_tipo.Value = ucInv_MenuReportes1.cmbTipoMovInve.EditValue;
                Reporte.PIdNumMovi.Value = ucInv_MenuReportes1.txt_num_transaccion.EditValue;
                Reporte.PTipo.Value = ucInv_MenuReportes1.optOpciones.EditValue;
                Reporte.PFechaIni.Value = Convert.ToDateTime(ucInv_MenuReportes1.dtpDesde.EditValue).ToShortDateString();
                Reporte.PFechaFin.Value = Convert.ToDateTime(ucInv_MenuReportes1.dtpHasta.EditValue).ToShortDateString();

                printControl1.PrintingSystem = Reporte.PrintingSystem;

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
