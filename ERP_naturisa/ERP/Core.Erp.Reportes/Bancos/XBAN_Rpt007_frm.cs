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

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt007_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 
        
        public XBAN_Rpt007_frm()
        {
            InitializeComponent();
        }

        private void ucBa_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!splashScreenManager1.IsSplashFormVisible) splashScreenManager1.ShowWaitForm();

                bool Mostrar_detallado = ucBa_Menu_Reportes1.get_Mostrar_detallado();
                
                XBAN_Rpt007_rpt Reporte = new XBAN_Rpt007_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                Reporte.P_Fecha_ini.Value = ucBa_Menu_Reportes1.get_FchIni();
                Reporte.P_Fecha_fin.Value = ucBa_Menu_Reportes1.get_FchFin();
                Reporte.P_Mostrar_detallado.Value = Mostrar_detallado;
                Reporte.set_parametros(ucBa_Menu_Reportes1.Get_list_tipo_flujo_chk());
                Reporte.P_IdBanco.Value = ucBa_Menu_Reportes1.cmbBanco.EditValue == null ? 0 : Convert.ToInt32(ucBa_Menu_Reportes1.cmbBanco.EditValue);
                Reporte.P_Mostrar_solo_conciliado.Value = ucBa_Menu_Reportes1.get_chkImpreso();
                Reporte.P_Mostrar_beneficiario.Value = ucBa_Menu_Reportes1.chkFacs.EditValue == null ? false : Convert.ToBoolean(ucBa_Menu_Reportes1.chkFacs.EditValue);
                pt.AutoShowParametersPanel = false;
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

                if (splashScreenManager1.IsSplashFormVisible) splashScreenManager1.CloseWaitForm();
                
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) splashScreenManager1.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucBa_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
