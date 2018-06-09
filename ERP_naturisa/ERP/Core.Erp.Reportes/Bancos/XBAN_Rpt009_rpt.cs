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
    public partial class XBAN_Rpt009_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public XBAN_Rpt009_rpt()
        {
            InitializeComponent();
            this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XBAN_Rpt009_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                

                xrLEmpresa.Text = param.InfoEmpresa.em_nombre;

                XBAN_Rpt009_Bus rptBus = new XBAN_Rpt009_Bus();
                List<XBAN_Rpt009_Info> lstInfo = new List<XBAN_Rpt009_Info>();

                int IdEmpresa = 0;
                DateTime fecha;
                DateTime FechaCorte;

                string S_fecha = "";
                string S_FechaCorte = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                fecha = Convert.ToDateTime(Parameters["fecha"].Value);
                FechaCorte = Convert.ToDateTime(Parameters["FechaCorte"].Value);

                S_fecha = Convert.ToString(Parameters["S_fecha"].Value);
                S_FechaCorte = Convert.ToString(Parameters["S_FechaCorte"].Value);

                lstInfo = rptBus.get_ReporteSaldoBancos(IdEmpresa, fecha, FechaCorte);

                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt009_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt009_rpt) };   
            }
        }

    }
}
