using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cus.ERP.Reports.Grafinpren.Facturacion;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
    public partial class XFAC_GRAF_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public List<XFAC_GRAF_Rpt001_Info> lstRpt { get; set; }
        public XFAC_GRAF_Rpt001_Rpt()
        {
            InitializeComponent();
            lblLogo.Image = param.InfoEmpresa.em_logo_Image;
            lblIdUsuario.Text = param.IdUsuario;
            lblhora_fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_GRAF_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lstRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_GRAF_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_GRAF_Rpt001_Rpt) };
            }
        }
    }
}
