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

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt003_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public XBAN_Rpt003_frm()
        {
            InitializeComponent();
        }

        private void ucBa_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int idBanco = 0;
                int idBancoFin = 0;
                if (this.ucBa_Menu_Reportes1.get_idBanco() == 0)
                {
                    idBanco = 1;
                    idBancoFin = 999999;
                }
                else
                {
                    idBanco = Convert.ToInt32(ucBa_Menu_Reportes1.get_idBanco());
                    idBancoFin = idBanco;
                }

                XBAN_Rpt003_rpt Reporte = new XBAN_Rpt003_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdBanco"].Value = idBanco;
                Reporte.Parameters["IdBancoFin"].Value = idBancoFin;
                Reporte.Parameters["CodTipoCbteBan"].Value = "CHEQ";//ucBa_Menu_Reportes1.get_tipoCbtes();
                Reporte.Parameters["Fch_Ini"].Value = ucBa_Menu_Reportes1.get_FchIni();
                Reporte.Parameters["Fch_Fin"].Value = ucBa_Menu_Reportes1.get_FchFin();
                Reporte.Parameters["S_Empresa"].Value = param.NombreEmpresa;
                Reporte.Parameters["S_Banco"].Value = ucBa_Menu_Reportes1.get_NomBanco();
                Reporte.Parameters["S_CbteDescripcion"].Value = "CHEQ"; //ucBa_Menu_Reportes1 Sale error por haber seteado O_O
                Reporte.Parameters["num_cheque"].Value = ucBa_Menu_Reportes1.txtCheque.EditValue;
                if (ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona != 0)
                {
                    Reporte.Parameters["IdPersonaGirado"].Value = ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona;

                    Reporte.Parameters["S_Chq_Girado_A"].Value = String.IsNullOrEmpty(ucBa_Menu_Reportes1.get_cmbNomBeneficiario().pe_nombreCompleto) ? "TODOS" : ucBa_Menu_Reportes1.get_cmbNomBeneficiario().pe_nombreCompleto;

                }
                else
                {
                    Reporte.Parameters["S_Chq_Girado_A"].Value = "TODOS";
                
                }
                
             
                Reporte.Parameters["Detallado"].Value = ucBa_Menu_Reportes1.get_chkfaks();
                Reporte.Parameters["Es_ChqImpreso"].Value = ucBa_Menu_Reportes1.get_chkImpreso();
                                               

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XBAN_Rpt003_frm_Load(object sender, EventArgs e)
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
