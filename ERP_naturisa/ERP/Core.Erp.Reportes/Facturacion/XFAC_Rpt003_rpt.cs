using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XFAC_Rpt003_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XFAC_Rpt003_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XFAC_Rpt003_Bus rptBus = new XFAC_Rpt003_Bus();
                List<XFAC_Rpt003_Info> lstInfo = new List<XFAC_Rpt003_Info>();

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                decimal IdClienteIni = 0;
                decimal IdClienteFin = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                string TipoPago = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdClienteIni = Convert.ToDecimal(Parameters["IdClienteIni"].Value);
                IdClienteFin = Convert.ToDecimal(Parameters["IdClienteFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                TipoPago = Convert.ToString(Parameters["TipoPago"].Value);


                lstInfo = rptBus.getDatosRptVentasProduc(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaFin, TipoPago);
                this.DataSource = lstInfo.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt003_rpt) };
            }
        }



    }
}
