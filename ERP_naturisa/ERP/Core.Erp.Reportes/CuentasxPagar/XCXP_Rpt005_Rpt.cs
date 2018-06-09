using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt005_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        int IdEmpresa_op = 0;
        decimal IdOrdenPago_op = 0;

        public XCXP_Rpt005_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa, decimal IdEntidad, decimal IdOrdenPago)
        {

            try
            {

                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdOrdenPago.Value = IdOrdenPago;
                this.IdOrdenPago.Visible = false;

                this.IdEntidad.Value = IdEntidad;
                this.IdEntidad.Visible = false;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt005_Rpt) };
            }
        }

        private void XCXP_Rpt005_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XCXP_Rpt005_Bus repbus = new XCXP_Rpt005_Bus();
                List<XCXP_Rpt005_Info> ListDataRpt = new List<XCXP_Rpt005_Info>();

                int IdEmpresa = 0;
                Decimal IdOrdenPago = 0;
                Decimal IdEntidad = 0;
                string mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdOrdenPago = Convert.ToDecimal(Parameters["IdOrdenPago"].Value);
                IdEntidad = Convert.ToDecimal(Parameters["IdEntidad"].Value);

                IdEmpresa_op = IdEmpresa;
                IdOrdenPago_op = IdOrdenPago;

                ListDataRpt = repbus.consultar_data(IdEmpresa, IdOrdenPago, IdEntidad, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt005_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt005_Rpt) };
            }

            
        }

        private void sub_repor_CONTA_008_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["PIdEmpresa_op"].Value = IdEmpresa_op;
                ((XRSubreport)sender).ReportSource.Parameters["PIdCbteCble"].Value = IdOrdenPago_op;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt005_Rpt) };
            }
        }

        //private void xrSubreport1_BeforePrint(object sender, PrintEventArgs e)
        //{
        //    ((XRSubreport)sender).ReportSource.Parameters["CatID"].Value =
        //        Convert.ToInt32(GetCurrentColumnValue("CategoryID"));
        //}
    }
}
