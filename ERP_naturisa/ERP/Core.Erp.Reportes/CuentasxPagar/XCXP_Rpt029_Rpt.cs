using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;
using System.IO;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt029_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt029_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt029_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                xlbl_idReporte.Text = "XCXP_Rpt029_Rpt";

                string msg = "";
                XCXP_Rpt029_Bus Bus = new XCXP_Rpt029_Bus();
                List<XCXP_Rpt029_Info> lista = new List<XCXP_Rpt029_Info>();

                int IdEmpresa = 0;

                DateTime FechaIni, FechaFin;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                FechaIni = Convert.ToDateTime(this.PFechaIni.Value);
                FechaFin = Convert.ToDateTime(this.PFechaFin.Value);

                lista = Bus.Get_List_Data(IdEmpresa, FechaIni, FechaFin, ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt029_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt029_Rpt) };
            }
        }

    }
}
