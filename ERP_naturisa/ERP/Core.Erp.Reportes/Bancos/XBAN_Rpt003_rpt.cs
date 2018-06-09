using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt003_rpt()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XBAN_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {

                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XBAN_Rpt003_Bus repbus = new XBAN_Rpt003_Bus();


                List<XBAN_Rpt003_Info> ListDataRpt = new List<XBAN_Rpt003_Info>();

                int IdEmpresa = 0;

                int IdBancoIni = 0;
                int IdBancoFin = 0;

                string idTipoCbte = "";
                string girado_A = "";
                bool chkImpreso;
                bool chkfacs;
                string SchkImpreso = "S";
                string Schkfacs = "CBTE_CHEQ";
                DateTime Fch_Ini = DateTime.Now;
                DateTime Fch_Fin = DateTime.Now;
                string Cheque = "";
                decimal IdPersona_Girado = 0;



                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdBancoIni = Convert.ToInt32(Parameters["IdBanco"].Value);
                IdBancoFin = Convert.ToInt32(Parameters["IdBancoFin"].Value);

                idTipoCbte = Convert.ToString(Parameters["CodTipoCbteBan"].Value);

                Fch_Ini = Convert.ToDateTime(Parameters["Fch_Ini"].Value);
                Fch_Fin = Convert.ToDateTime(Parameters["Fch_Fin"].Value);

                IdPersona_Girado = Convert.ToDecimal(Parameters["IdPersonaGirado"].Value);

                girado_A = Convert.ToString(Parameters["S_Chq_Girado_A"].Value);
                Cheque = Convert.ToString(Parameters["num_cheque"].Value);
                chkImpreso = Convert.ToBoolean(Parameters["Es_ChqImpreso"].Value);
                chkfacs = Convert.ToBoolean(Parameters["Detallado"].Value);

                if (girado_A == "TODOS") girado_A = "";

                if (chkImpreso == true)
                {
                    SchkImpreso = "Impreso";
                    lblchkImpreso.Text = "Solo Impresos";
                }
                else
                {
                    lblchkImpreso.Text = "Todos";
                    SchkImpreso = "";
                }

                if (chkfacs == true)
                {
                    Schkfacs = "";
                    lblchkDetalle.Text = "Detallado";
                    lblchkDetalle.Visible = true;

                    xrLabel32.Visible = false;
                    xrLabel33.Visible = false;
                    xrLabel34.Visible = false;


                }
                else
                {

                    Schkfacs = "CBTE_PAGO";
                    lblchkDetalle.Text = "";
                    lblchkDetalle.Visible = false;


                    xrLabel15.Visible = false;
                    xrLabel14.Visible = false;
                    xrLabel35.Visible = false;
                    xrLabel36.Visible = false;
                    xrLabel37.Visible = false;
                    xrLabel42.Visible = false;


                }


                ListDataRpt = repbus.Cargar_data(IdEmpresa, Fch_Ini, Fch_Fin, IdBancoIni, IdBancoFin, idTipoCbte,/*girado_A*/IdPersona_Girado, SchkImpreso, Schkfacs, Cheque);



                if (ListDataRpt.Count == 0)
                {
                    xrLmensaje.Visible = true;
                    xrLmensaje.Text = "No hay datos encontrados para estos filtros";
                }
                else
                {
                    xrLmensaje.Visible = false;
                }

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt003_rpt) };
            }
   
            
  
        }
       

    }
}
