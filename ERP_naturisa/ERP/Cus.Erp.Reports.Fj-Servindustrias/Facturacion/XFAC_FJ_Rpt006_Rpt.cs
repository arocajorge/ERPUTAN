using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cus.Erp.Reports.FJ.Facturacion;
using System.Collections.Generic;
namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt006_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt006_Rpt()
        {
            InitializeComponent();
        }
        List<XFAC_FJ_Rpt006_Info> lista = new List<XFAC_FJ_Rpt006_Info>();
        XFAC_FJ_Rpt006_Bus bus = new XFAC_FJ_Rpt006_Bus();
        
        private void XFAC_FJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int Idempresa = 0;
                int IdPeriod = 0;

                Idempresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdPeriod = Convert.ToInt32(Parameters["IdPeriodo"].Value);

                lista = bus.Get_List(Idempresa, IdPeriod);
                this.DataSource = lista;

            }
            catch (Exception)
            {

            }
        }

    }
}
