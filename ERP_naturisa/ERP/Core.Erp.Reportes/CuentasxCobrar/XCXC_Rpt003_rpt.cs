using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public List<XCXC_Rpt003_Info> lstRpt { get; set; }

        public XCXC_Rpt003_rpt()
        {
            InitializeComponent();
        }

        public XCXC_Rpt003_rpt(string IdUsuario)
        {
            InitializeComponent();
            lblIdUsuario.Text = IdUsuario;
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXC_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt003_rpt) };
            }
        }



    }
}
