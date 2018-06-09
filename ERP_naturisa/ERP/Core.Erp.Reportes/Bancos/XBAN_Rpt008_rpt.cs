using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt008_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public XBAN_Rpt008_rpt()
        {
            InitializeComponent();

            

       }

        private void XBAN_Rpt008_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                xrPictureBox1.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                xrL_Empresa.Text = param.InfoEmpresa.em_nombre;
                
                XBAN_Rpt008_Bus rptBus = new XBAN_Rpt008_Bus();
                List<XBAN_Rpt008_Info> lstInfo = new List<XBAN_Rpt008_Info>();

                int IdEmpresa = 0;
                DateTime FechaIni;
                DateTime FechaFin;

                string S_FechaIni = "";
                string S_FechaFin = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);

                S_FechaIni = Convert.ToString(Parameters["S_FechaIni"].Value);
                S_FechaFin = Convert.ToString(Parameters["S_FechaFin"].Value);

                lstInfo = rptBus.get_ReporteFlujoCajaResumido(IdEmpresa, FechaIni, FechaFin);

                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt008_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt008_rpt) };   
            }
        }

    }
}
