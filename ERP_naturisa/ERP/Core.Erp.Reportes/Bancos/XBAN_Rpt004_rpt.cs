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
    public partial class XBAN_Rpt004_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt004_rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt004_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XBAN_Rpt004_Bus repbus = new XBAN_Rpt004_Bus();


                List<XBAN_Rpt004_Info> ListDataRpt = new List<XBAN_Rpt004_Info>();

                int IdEmpresa = 0;

                int IdBancoIni = 0;
                int IdBancoFin = 0;

                string idTipoCbte = "";
                string girado_A = "";
                bool chkImpreso;
                bool chkfacs;
                string SchkImpreso = "";
                string Schkfacs = "CBTE_PAGO";
                DateTime Fch_Ini = DateTime.Now;
                DateTime Fch_Fin = DateTime.Now;

                decimal IdPersona_Girado = 0;


                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdBancoIni = Convert.ToInt32(Parameters["IdBanco"].Value);
                IdBancoFin = Convert.ToInt32(Parameters["IdBancoFin"].Value);

                IdPersona_Girado = Convert.ToDecimal(Parameters["IdPersona_Girado"].Value);

                idTipoCbte = Convert.ToString(Parameters["CodTipoCbteBan"].Value);

                Fch_Ini = Convert.ToDateTime(Parameters["Fch_Ini"].Value);
                Fch_Fin = Convert.ToDateTime(Parameters["Fch_Fin"].Value);

                girado_A = Convert.ToString(Parameters["S_Chq_Girado_A"].Value);
                chkImpreso = Convert.ToBoolean(Parameters["Es_ChqImpreso"].Value);
                chkfacs = Convert.ToBoolean(Parameters["Detallado"].Value);

                if (girado_A == "TODOS") girado_A = "";

                lblchkImpreso.Text = "Todos";
                if (chkImpreso == true)
                {
                    SchkImpreso = "Impreso";
                    lblchkImpreso.Text = "Solo Impresos";
                }

                lblchkDetalle.Text = "";
                lblchkDetalle.Visible = false;
                if (chkfacs == true)
                {
                    Schkfacs = "";
                    lblchkDetalle.Text = "Detallado";
                    lblchkDetalle.Visible = true;

                    xrLabel39.Visible = false;
                    xrLabel40.Visible = false;
                    xrLabel41.Visible = false;

                }
                else
                {

                    xrLabel13.Visible = false;
                    xrLabel14.Visible = false;
                    xrLabel42.Visible = false;
                    xrLabel43.Visible = false;
                    xrLabel44.Visible = false;
                    xrLabel12.Visible = false;


                }

                ListDataRpt = repbus.Cargar_data(IdEmpresa, Fch_Ini, Fch_Fin, IdBancoIni, IdBancoFin, idTipoCbte, /*girado_A*/IdPersona_Girado, SchkImpreso, Schkfacs);

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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt004_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt004_rpt) };
                
            }

               

            
        }

    }
}
