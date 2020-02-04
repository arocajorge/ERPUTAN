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

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public partial class XCXC_GRAF_Rpt002_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;   

        public XCXC_GRAF_Rpt002_frm()
        {
            InitializeComponent();
        }

        private void uccxC_MenuReportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                decimal IdCliente = uccxC_MenuReportes1.beiCliente.EditValue==null ? 0 : Convert.ToDecimal(uccxC_MenuReportes1.beiCliente.EditValue);
                decimal IdVendedor = uccxC_MenuReportes1.beiVendedor.EditValue == null ? 0 : Convert.ToDecimal(uccxC_MenuReportes1.beiVendedor.EditValue);
                DateTime FechaCorte = uccxC_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue);
                string nom_Cliente = uccxC_MenuReportes1.beiCliente.EditValue == null ? "TODOS" :uccxC_MenuReportes1.beiCliente.Edit.GetDisplayText(uccxC_MenuReportes1.beiCliente.EditValue);
                string nom_Vendedor = uccxC_MenuReportes1.beiVendedor.EditValue == null ? "TODOS" : uccxC_MenuReportes1.beiVendedor.Edit.GetDisplayText(uccxC_MenuReportes1.beiVendedor.EditValue);
                bool Mostrar_solo_vencidas = uccxC_MenuReportes1.barEditItemChk.EditValue == null ? false : (bool)uccxC_MenuReportes1.barEditItemChk.EditValue;

                XCXC_GRAF_Rpt002_Rpt rpt = new XCXC_GRAF_Rpt002_Rpt();
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = pt.PrintingSystem;
                rpt.set_parametros(IdVendedor, IdCliente, FechaCorte, nom_Vendedor, nom_Cliente,Mostrar_solo_vencidas);
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void uccxC_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
