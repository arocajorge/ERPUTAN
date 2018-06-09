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

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt025_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt025_frm()
        {
            InitializeComponent();
            ucCxp_MenuReportes1.event_btnSalir_ItemClick += ucCxp_MenuReportes1_event_btnSalir_ItemClick;
            //ucCxp_MenuReportes1.event_btnImprimir_ItemClick += ucCxp_MenuReportes1_event_btnImprimir_ItemClick;
            ucCxp_MenuReportes1.event_tnConsultar_ItemClick += ucCxp_MenuReportes1_event_tnConsultar_ItemClick;
        }

        void ucCxp_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_Rpt025_Rpt rpt = new XCXP_Rpt025_Rpt();
                
                rpt.Parameters["idCentroCosto"].Value = (ucCxp_MenuReportes1.barEditItemCentroCosto.EditValue == null) || (ucCxp_MenuReportes1.barEditItemCentroCosto.EditValue == "Todos") ? "" : ucCxp_MenuReportes1.barEditItemCentroCosto.EditValue.ToString();
                rpt.Parameters["idSubcentroCosto"].Value = (ucCxp_MenuReportes1.barEditItemSubCentroCosto.EditValue == null) || (ucCxp_MenuReportes1.barEditItemSubCentroCosto.EditValue == "Todos") ? "" : ucCxp_MenuReportes1.barEditItemSubCentroCosto.EditValue.ToString();


                rpt.Parameters["nom_CentroCosto"].Value = ucCxp_MenuReportes1.barEditItemCentroCosto.Edit.GetDisplayText(ucCxp_MenuReportes1.barEditItemCentroCosto.EditValue);
                rpt.Parameters["nom_SubcentroCosto"].Value = ucCxp_MenuReportes1.barEditItemSubCentroCosto.Edit.GetDisplayText(ucCxp_MenuReportes1.barEditItemSubCentroCosto.EditValue);

                rpt.Parameters["fechaIni"].Value = ucCxp_MenuReportes1.dtpDesde.EditValue==null ? DateTime.Now : Convert.ToDateTime(ucCxp_MenuReportes1.dtpDesde.EditValue);
                rpt.Parameters["fechaFin"].Value = ucCxp_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucCxp_MenuReportes1.dtpHasta.EditValue);

                rpt.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(rpt);
                pt.AutoShowParametersPanel = false;

                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ucCxp_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
