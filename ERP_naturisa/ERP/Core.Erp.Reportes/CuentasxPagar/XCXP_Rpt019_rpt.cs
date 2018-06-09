using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt019_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        int Id_Empresa=0;
        decimal Id_Conciliacion_Caja = 0;
        string Estado_cierre = "";

        public XCXP_Rpt019_rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa,decimal IdConciliacion_Caja,String EstadoCierre)
        {

            try
            {
                 Id_Empresa = IdEmpresa;
                 Id_Conciliacion_Caja = IdConciliacion_Caja;
                 Estado_cierre = EstadoCierre;
                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdConciliacion_Caja.Value = IdConciliacion_Caja;
                this.IdConciliacion_Caja.Visible = false;             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt019_rpt) };
            }
        }

        private void XCXP_Rpt019_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_Rpt019_Bus repbus = new XCXP_Rpt019_Bus();
                List<XCXP_Rpt019_Info> listDataRpt = new List<XCXP_Rpt019_Info>();


                string mensaje = "";
                int IdEmpresa = 0;

                decimal IdConciliacion_Caja = 0;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdConciliacion_Caja = Convert.ToDecimal(Parameters["IdConciliacion_Caja"].Value);
                
                listDataRpt = repbus.consultar_data(IdEmpresa, IdConciliacion_Caja, ref mensaje);
                this.DataSource = listDataRpt.ToArray();


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt019_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt019_rpt) };

            }

           
        }

       

        private void xrSubreportFactura_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa"].Value = Id_Empresa;
                ((XRSubreport)sender).ReportSource.Parameters["IdConciliacion_Caja"].Value = Id_Conciliacion_Caja;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt019_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt019_rpt) };

            }
        }

        private void xrSubreportValeCaja_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa"].Value = Id_Empresa;
                ((XRSubreport)sender).ReportSource.Parameters["IdConciliacion_Caja"].Value = Id_Conciliacion_Caja;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt019_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt019_rpt) };

            }

        }

        private void xrSubreportOrdenPago_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Estado_cierre == "EST_CIE_CER")
                {
                    GroupHeaderOP.Visible = true;
                    xrSubreportOrdenPago.Visible = true;
                    lbOP.Visible = true;

                    ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa"].Value = Id_Empresa;
                    ((XRSubreport)sender).ReportSource.Parameters["IdConciliacion_Caja"].Value = Id_Conciliacion_Caja;
                }
                else
                {
                    xrSubreportOrdenPago.Visible = false;
                    GroupHeaderOP.Visible = false;
                    lbOP.Visible = false;

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt019_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt019_rpt) };

            }
        }

       

    }
}
