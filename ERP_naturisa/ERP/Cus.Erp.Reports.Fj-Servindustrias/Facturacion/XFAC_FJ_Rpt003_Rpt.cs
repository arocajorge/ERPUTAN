using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        XFAC_FJ_Rpt003_Bus Bus = new XFAC_FJ_Rpt003_Bus();
        public List<XFAC_FJ_Rpt003_Info> lstRpt { get; set; }

        public XFAC_FJ_Rpt003_Rpt()
        {
            InitializeComponent();
            lblLogo.Image = param.InfoEmpresa.em_logo_Image;
            lblIdUsuario.Text = param.IdUsuario;
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_FJ_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                int IdEmpresa =Convert.ToInt32( Parameters["IdEmpresa"].Value);
                int IdLiquidaciones = Convert.ToInt32(Parameters["IdLiquidacion"].Value);
                lstRpt = Bus.Get_Liquidaciones_x_Cliente(IdEmpresa, Convert.ToDecimal(IdLiquidaciones));
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_FJ_Rpt003_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_FJ_Rpt003_Rpt) };
            }
        }
    }
}
