using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Reflection;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt014_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXC_Rpt014_Rpt()
        {
            InitializeComponent();
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            lblUsuario.Text = param.IdUsuario;
        }

        private void XCXC_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt014_Bus rptBus = new XCXC_Rpt014_Bus();
                List<XCXC_Rpt014_Info> lstInfo = new List<XCXC_Rpt014_Info>();

                int IdEmpresa = 0, IdVendedor = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdVendedor = Convert.ToInt32(PIdVendedor.Value);
                FechaIni = Convert.ToDateTime(PFechaIni.Value);
                FechaFin = Convert.ToDateTime(PFechaFin.Value);


                lstInfo = rptBus.Get_Data_Reporte(IdEmpresa, IdVendedor, FechaIni, FechaFin);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt006_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt013_Rpt) };
            }
        }

    }
}
