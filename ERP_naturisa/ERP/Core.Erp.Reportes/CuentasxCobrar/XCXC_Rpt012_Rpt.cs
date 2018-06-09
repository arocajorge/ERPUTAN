using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt012_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public XCXC_Rpt012_Rpt()
        {
            InitializeComponent();
        }

        private void XCXC_Rpt012_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XCXC_Rpt012_Bus oReporteBus = new XCXC_Rpt012_Bus();
                List<XCXC_Rpt012_Info> oListado = new List<XCXC_Rpt012_Info>();

                int IdEmpresa = 0;
                decimal IdCliente = 0;
                DateTime FechaFin;


                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdCliente = Convert.ToInt32(PIdCliente.Value);
                
                FechaFin = Convert.ToDateTime(PFechaCorte.Value);

                oListado = oReporteBus.get_DetalleDiasxVencer(IdEmpresa, IdCliente, FechaFin);

                this.DataSource = oListado.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt012_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt012_Rpt) };
            }
        }

    }
}
