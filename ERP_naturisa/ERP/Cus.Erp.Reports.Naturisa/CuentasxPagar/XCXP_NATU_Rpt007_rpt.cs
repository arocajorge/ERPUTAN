using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.IO;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt007_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<XCXP_NATU_Rpt007_Resumen_Info> list_resumen = new List<XCXP_NATU_Rpt007_Resumen_Info>();

        
        public XCXP_NATU_Rpt007_rpt()
        {
            InitializeComponent();
        }

       

        private void XCXP_NATU_Rpt007_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt007_Bus repbus = new XCXP_NATU_Rpt007_Bus();


                List<XCXP_NATU_Rpt007_Info> ListDataRpt = new List<XCXP_NATU_Rpt007_Info>();

                xrL_empresa.Text = param.InfoEmpresa.em_nombre;
                xrL_fecha.Text = DateTime.Now.ToLongDateString();

                int IdEmpresa = 0;

                Decimal IdProveedorIni = 0;
                Decimal IdProveedorFin = 0;

                DateTime co_fechaOg_Ini = DateTime.Now;
                DateTime co_fechaOg_Fin = DateTime.Now;
                String mensaje = "";


                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                co_fechaOg_Ini = Convert.ToDateTime(Parameters["FechaIni"].Value);
                co_fechaOg_Fin = Convert.ToDateTime(Parameters["FechaFin"].Value);


                list_resumen = new List<XCXP_NATU_Rpt007_Resumen_Info>();
                ListDataRpt = repbus.consultar_Data(IdEmpresa, IdProveedorIni, IdProveedorFin, co_fechaOg_Ini, co_fechaOg_Fin,ref list_resumen, ref  mensaje);


                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt007_rpt) };       
              
            }
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {
                ((XRSubreport)sender).ReportSource.DataSource = list_resumen;
                ((XRSubreport)sender).ReportSource.FillDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt007_rpt) };
            }

        }


      
       

    }
}
