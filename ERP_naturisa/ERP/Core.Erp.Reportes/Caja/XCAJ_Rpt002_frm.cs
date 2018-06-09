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

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt002_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;  
        string TipoIngrEgr = "";

        public XCAJ_Rpt002_frm()
        {
            InitializeComponent();
        }


        private void ucCaj_Menu_Reportes_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (ucCaj_Menu_Reportes.cmb_TipoIngEgr.EditValue.ToString() == null)
                    TipoIngrEgr = "";
                else
                    if (ucCaj_Menu_Reportes.cmb_TipoIngEgr.EditValue.ToString() == "Ingresos")
                        TipoIngrEgr = "+";
                    else
                        if (ucCaj_Menu_Reportes.cmb_TipoIngEgr.EditValue.ToString() == "Egresos")
                            TipoIngrEgr = "-";
                        else
                            TipoIngrEgr = "";
                        

                XCAJ_Rpt002_Rpt Reporte = new XCAJ_Rpt002_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["PIdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["PIdCajaIni"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_Caja.EditValue)==0)? 0: Convert.ToInt32(ucCaj_Menu_Reportes.cmb_Caja.EditValue);
                Reporte.Parameters["PIdCajaFin"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_Caja.EditValue) == 0) ? 99999 : Convert.ToInt32(ucCaj_Menu_Reportes.cmb_Caja.EditValue);
                Reporte.Parameters["PIdTipoMoviIni"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoMovi.EditValue) == 0) ? 0 : Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoMovi.EditValue);
                Reporte.Parameters["PIdTipoMoviFin"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoMovi.EditValue) == 0) ? 99999 : Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoMovi.EditValue);
                Reporte.Parameters["PTipoIngrEgr"].Value = TipoIngrEgr;
                Reporte.Parameters["PFechaIni"].Value = ucCaj_Menu_Reportes.dtFechaIni.EditValue;
                Reporte.Parameters["PFechaFin"].Value = ucCaj_Menu_Reportes.dtFechaFin.EditValue;
                Reporte.Parameters["PIdPersonaIni"].Value = (Convert.ToString(ucCaj_Menu_Reportes.cmb_Beneficiario.EditValue) == "") ? 0 : Convert.ToDecimal(ucCaj_Menu_Reportes.get_Info_Beneficiario().IdPersona);
                Reporte.Parameters["PIdPersonaFin"].Value = (Convert.ToString(ucCaj_Menu_Reportes.cmb_Beneficiario.EditValue) == "") ? 99999 : Convert.ToDecimal(ucCaj_Menu_Reportes.get_Info_Beneficiario().IdPersona);
                Reporte.Parameters["PIdEntidadIni"].Value = (Convert.ToString(ucCaj_Menu_Reportes.cmb_Beneficiario.EditValue) == "") ? 0 : Convert.ToDecimal(ucCaj_Menu_Reportes.get_Info_Beneficiario().IdEntidad);
                Reporte.Parameters["PIdEntidadFin"].Value = (Convert.ToString(ucCaj_Menu_Reportes.cmb_Beneficiario.EditValue) == "") ? 99999 : Convert.ToDecimal(ucCaj_Menu_Reportes.get_Info_Beneficiario().IdEntidad);
                Reporte.Parameters["PIdTipoFlujoIni"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoFlujo.EditValue) == 0) ? 0 : Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoFlujo.EditValue);
                Reporte.Parameters["PIdTipoFlujoFin"].Value = (Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoFlujo.EditValue) == 0) ? 99999 : Convert.ToInt32(ucCaj_Menu_Reportes.cmb_TipoFlujo.EditValue);
                Reporte.Parameters["PIdTipo_Persona"].Value = (Convert.ToString(ucCaj_Menu_Reportes.cmb_Beneficiario.EditValue) == null) ? "" : Convert.ToString(ucCaj_Menu_Reportes.get_Info_Beneficiario().IdTipo_Persona);
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCaj_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
