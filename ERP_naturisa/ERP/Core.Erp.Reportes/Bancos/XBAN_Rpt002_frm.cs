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
    public partial class XBAN_Rpt002_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt002_frm()
        {
            InitializeComponent();
            //ucBa_Menu_Reportes1.event_btnRefrescar_ItemClick += ucBa_Menu_Reportes1_event_btnRefrescar_ItemClick;
            //ucBa_Menu_Reportes1.event_btnsalir_ItemClick += ucBa_Menu_Reportes1_event_btnsalir_ItemClick;
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ucBa_Menu_Reportes1_event_btnsalir_ItemClick", ex.Message), ex) { EntityType = typeof(XBAN_Rpt002_frm) };

            }
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

                XBAN_Rpt002_rpt Reporte = new XBAN_Rpt002_rpt();
                
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdBanco"].Value = idBanco;
                Reporte.Parameters["IdBancoFin"].Value = idBancoFin;
                Reporte.Parameters["CodTipoCbteBan"].Value = ucBa_Menu_Reportes1.get_tipoCbtes();
                Reporte.Parameters["Fch_Ini"].Value = ucBa_Menu_Reportes1.get_FchIni();
                Reporte.Parameters["Fch_Fin"].Value = ucBa_Menu_Reportes1.get_FchFin();
                Reporte.Parameters["S_Empresa"].Value = param.NombreEmpresa;
                Reporte.Parameters["S_Banco"].Value = ucBa_Menu_Reportes1.get_NomBanco();
                Reporte.Parameters["S_CbteDescripcion"].Value = ucBa_Menu_Reportes1.get_DesTipoCbtes();

                if (ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona != 0)
                {                                                       
                    Reporte.Parameters["IdPersonaGirado"].Value = ucBa_Menu_Reportes1.get_cmbNomBeneficiario().IdPersona;
                    Reporte.Parameters["S_PersonaGirado"].Value = ucBa_Menu_Reportes1.get_cmbNomBeneficiario().pe_nombreCompleto;
                }
                else
                {
                    Reporte.Parameters["S_PersonaGirado"].Value = "TODOS";
                }

                
               
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
