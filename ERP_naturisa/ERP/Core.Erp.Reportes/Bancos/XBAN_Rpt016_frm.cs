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

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt016_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt016_frm()
        {
            InitializeComponent();
            ucBa_Menu_Reportes1.event_btnRefrescar_ItemClick += ucBa_Menu_Reportes1_event_btnRefrescar_ItemClick;
            ucBa_Menu_Reportes1.event_btnsalir_ItemClick += ucBa_Menu_Reportes1_event_btnsalir_ItemClick;
        }

        void ucBa_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ucBa_Menu_Reportes1_event_btnsalir_ItemClick", ex.Message), ex) { EntityType = typeof(XBAN_Rpt016_frm) };

            }
        }

        void ucBa_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XBAN_Rpt016_Rpt rpt = new XBAN_Rpt016_Rpt();
                ReportPrintTool pt = new ReportPrintTool(rpt);

                rpt.Parameters["idPersonaIni"].Value= ucBa_Menu_Reportes1.get_cmbNomBeneficiario()==null ? 0 : ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona;
                rpt.Parameters["idPersonaFin"].Value = ucBa_Menu_Reportes1.get_cmbNomBeneficiario() == null || Convert.ToInt32(ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona) == 0 ? 99999 : ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona; ;
                rpt.Parameters["idBancoIni"].Value= ucBa_Menu_Reportes1.get_idBanco()==null ? 0 : ucBa_Menu_Reportes1.get_idBanco();
                rpt.Parameters["idBancoFin"].Value=ucBa_Menu_Reportes1.get_idBanco()==null || Convert.ToInt32(ucBa_Menu_Reportes1.get_idBanco())==0 ? 9999 : ucBa_Menu_Reportes1.get_idBanco();
                rpt.Parameters["fechaIni"].Value = ucBa_Menu_Reportes1.dtpDesde == null ? DateTime.Now : Convert.ToDateTime(ucBa_Menu_Reportes1.dtpDesde.EditValue);
                rpt.Parameters["fechaFin"].Value = ucBa_Menu_Reportes1.dtpHasta == null ? DateTime.Now : Convert.ToDateTime(ucBa_Menu_Reportes1.dtpHasta.EditValue);

                rpt.Parameters["nom_Banco"].Value= ucBa_Menu_Reportes1.cmbBanco.Edit.GetDisplayText(ucBa_Menu_Reportes1.cmbBanco.EditValue);
                rpt.Parameters["nom_Persona"].Value = ucBa_Menu_Reportes1.cmbBeneficiario.Edit.GetDisplayText(ucBa_Menu_Reportes1.cmbBeneficiario.EditValue);

                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ucBa_Menu_Reportes1_event_btnRefrescar_ItemClick", ex.Message), ex) { EntityType = typeof(XBAN_Rpt016_frm) };

            }
        }

        private void XBAN_Rpt016_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucBa_Menu_Reportes1.cmbTipoDoc = "CHEQ";
                ucBa_Menu_Reportes1.Enable_Doc = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

    }
}
