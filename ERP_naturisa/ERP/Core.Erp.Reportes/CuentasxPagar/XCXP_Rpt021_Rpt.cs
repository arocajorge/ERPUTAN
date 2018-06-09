using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt021_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt021_Rpt()
        {
            InitializeComponent();
        }


        public void set_parametros(int IdEmpresa, decimal IdCbteCble_OG,int IdTipoCbte_OG)
        {
            try
            {
                this.PIdCbteCble_OG.Value = IdCbteCble_OG;
                this.PIdCbteCble_OG.Visible = false;

                this.PIdEmpresa.Value = IdEmpresa;
                this.PIdEmpresa.Visible = false;

                this.PIdTipoCbte_OG.Value = IdTipoCbte_OG;
                this.PIdTipoCbte_OG.Visible = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt003_Rpt) };
            }
        }

        private void XCXP_Rpt021_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_Rpt021_Bus busReporte = new XCXP_Rpt021_Bus();
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.NombreEmpresa;


                this.DataSource = busReporte.Get_Lista_Orden_Giro(Convert.ToInt32(this.PIdEmpresa.Value),
                    Convert.ToDecimal(this.PIdCbteCble_OG.Value), Convert.ToInt32(this.PIdTipoCbte_OG.Value));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt021_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt) };
            }
        }

        private void xrSubreportNotaCredito_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["idCbte_cxp"].Value = Convert.ToDecimal(this.PIdCbteCble_OG.Value);
                ((XRSubreport)sender).ReportSource.Parameters["idEmpresa"].Value = param.IdEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["idTipoCbte_cxp"].Value = Convert.ToInt32(this.PIdTipoCbte_OG.Value);
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "xrSubreportNotaCredito_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt) };
            }
        }

        private void xrSubreportRetenciones_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["idOrdenGiro"].Value = Convert.ToDecimal(this.PIdCbteCble_OG.Value);
                ((XRSubreport)sender).ReportSource.Parameters["p_IdTipoCbte"].Value = Convert.ToInt32(this.PIdTipoCbte_OG.Value);
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "xrSubreportRetenciones_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt) };
            }
        }

    }
}
