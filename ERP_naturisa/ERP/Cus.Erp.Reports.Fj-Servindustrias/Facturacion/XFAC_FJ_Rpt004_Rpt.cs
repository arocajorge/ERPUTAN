using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using System.Collections;
using System.Collections.Generic;
namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt004_Rpt()
        {
            InitializeComponent();
        }
        List<fa_liquidacion_gastos_Info> lista = new List<fa_liquidacion_gastos_Info>();

        private void XFAC_FJ_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lista;
            }
            catch (Exception ex)
            {
                
                
            }

          
        }


        public void Set(List<fa_liquidacion_gastos_Info> lista_)
        {
            try
            {
                lista = lista_;
            }
            catch (Exception)
            {
                
            }
        }

       

      

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int idEmpresa = ((fa_liquidacion_gastos_Info)GetCurrentRow()).IdEmpresa;
                decimal IdLiquidacion = ((fa_liquidacion_gastos_Info)GetCurrentRow()).IdLiquidacion;
                string periodo=((fa_liquidacion_gastos_Info)GetCurrentRow()).Periodo;

                ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["IdLiquidacion"].Value = IdLiquidacion;
                ((XRSubreport)sender).ReportSource.Parameters["Periodo"].Value = periodo;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;

                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
