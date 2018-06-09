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
    public partial class XBAN_Rpt002_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt002_rpt()
        {
            InitializeComponent();
            this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            this.xrLUsuario.Text = param.IdUsuario.ToString();
        }

        private void XBAN_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XBAN_Rpt002_Bus repbus = new XBAN_Rpt002_Bus();

                List<XBAN_Rpt002_Info> ListDataRpt = new List<XBAN_Rpt002_Info>();

                int IdEmpresa = 0;

                int IdBancoIni = 0;
                int IdBancoFin = 0;

                string idTipoCbte = "";
                decimal IdPersona_Girado = 0;
                string girado_A = "";

                DateTime Fch_Ini = DateTime.Now;
                DateTime Fch_Fin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdBancoIni = Convert.ToInt32(Parameters["IdBanco"].Value);
                IdBancoFin = Convert.ToInt32(Parameters["IdBancoFin"].Value);

                idTipoCbte = Convert.ToString(Parameters["CodTipoCbteBan"].Value);

                Fch_Ini = Convert.ToDateTime(Parameters["Fch_Ini"].Value);
                Fch_Fin = Convert.ToDateTime(Parameters["Fch_Fin"].Value);

                IdPersona_Girado = Convert.ToInt32(Parameters["IdPersonaGirado"].Value);


                girado_A = Convert.ToString(Parameters["S_PersonaGirado"].Value);


                ListDataRpt = repbus.Cargar_data(IdEmpresa, Fch_Ini, Fch_Fin, IdBancoIni, IdBancoFin, idTipoCbte, IdPersona_Girado);

                string format = "dd/MM/yyyy";

                foreach (var item in ListDataRpt)
                {
                    item.SFch_Cbte = item.Fch_Cbte.ToString(format);
                }

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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt002_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt002_rpt) };
            }
        }
    }
}
