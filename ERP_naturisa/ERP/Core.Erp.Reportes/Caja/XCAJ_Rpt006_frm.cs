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

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt006_frm : Form
    {
        public XCAJ_Rpt006_frm()
        {
            InitializeComponent();
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;  

        private void ucCaj_Menu_Reportes1_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCAJ_Rpt006_Rpt Reporte = new XCAJ_Rpt006_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;
                
                Reporte.P_IdCaja.Value = ucCaj_Menu_Reportes1.get_cmbCaja();
                Reporte.P_IdTipoMovi.Value = ucCaj_Menu_Reportes1.get_TipoMovi();
                Reporte.P_IdConciliacion.Value = ucCaj_Menu_Reportes1.txt_IdConciliacion.EditValue == null ? 0 : Convert.ToDecimal(ucCaj_Menu_Reportes1.txt_IdConciliacion.EditValue);
                Reporte.P_Fecha_ini.Value = ucCaj_Menu_Reportes1.dtFechaIni.EditValue;
                Reporte.P_Fecha_fin.Value = ucCaj_Menu_Reportes1.dtFechaFin.EditValue;
                Reporte.P_IdPunto_cargo.Value = ucCaj_Menu_Reportes1.bei_punto_cargo.EditValue == null ? 0 : Convert.ToInt32(ucCaj_Menu_Reportes1.bei_punto_cargo.EditValue);

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCaj_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
