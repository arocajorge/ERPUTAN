using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt008_frm : Form
    {
        public XCXP_Rpt008_frm()
        {
            InitializeComponent();
        }

        private void ucCxp_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucCxp_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_Rpt008_Rpt rpt = new XCXP_Rpt008_Rpt();
                rpt.P_IdClase_prov.Value = ucCxp_MenuReportes1.bei_clase_prov.EditValue == null ? 0 : Convert.ToInt32(ucCxp_MenuReportes1.bei_clase_prov.EditValue);
                rpt.P_IdProveedor.Value = ucCxp_MenuReportes1.cmbProveedor.EditValue == null ? 0 : Convert.ToDecimal(ucCxp_MenuReportes1.cmbProveedor.EditValue);               
                rpt.P_Fecha_fin.Value = ucCxp_MenuReportes1.dtpHasta.EditValue;
                rpt.P_Mostrar_anuladas.Value = ucCxp_MenuReportes1.beiCheck1.EditValue;
                rpt.P_Mostrar_saldo_0.Value = ucCxp_MenuReportes1.beiCheck2.EditValue;
                rpt.RequestParameters = false;

                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;

                rpt.CreateDocument();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
