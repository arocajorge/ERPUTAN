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
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt013_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXC_Rpt013_frm()
        {
            InitializeComponent();
        }

        private void uccxC_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uccxC_MenuReportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXC_Rpt013_Rpt Reporte = new XCXC_Rpt013_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.PIdEmpresa.Value = param.IdEmpresa;
                Reporte.PFecha_Ini.Value = Convert.ToDateTime(uccxC_MenuReportes1.dtpDesde.EditValue).ToShortDateString();
                Reporte.PFecha_Fin.Value = Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue).ToShortDateString();
                Reporte.p_Mostrar_fact_sin_rt.Value = uccxC_MenuReportes1.barEditItemChk.EditValue == null ? false : (bool)uccxC_MenuReportes1.barEditItemChk.EditValue;

                Reporte.P_Fecha_por_buscar.Value = cmb_fecha_filtro.Text;
                Reporte.P_IdCliente.Value =(uccxC_MenuReportes1.beiCliente.EditValue==null)?0: Convert.ToDecimal(uccxC_MenuReportes1.beiCliente.EditValue);

                
                
                printControl.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXC_Rpt013_frm_Load(object sender, EventArgs e)
        {
            cmb_fecha_filtro.SelectedIndex = 0;
        }
    }
}
