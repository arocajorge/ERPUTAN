using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cus.Erp.Reports.FJ.Facturacion;
using System.Collections.Generic;
namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt011_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt011_Rpt()
        {
            InitializeComponent();
        }
        List<XFAC_FJ_Rpt011_Info> lista = new List<XFAC_FJ_Rpt011_Info>();
        XFAC_FJ_Rpt011_Bus bus = new XFAC_FJ_Rpt011_Bus();
        
        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int Idempresa = 0;
                int IdPeriod = 0;
                string Periodo = "";
                Idempresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdPeriod = Convert.ToInt32(Parameters["IdPeriodo"].Value);
                Periodo = Convert.ToString(Parameters["Periodo"].Value);

                lista = bus.Get_List_Conciliacion(Idempresa, IdPeriod);
                this.DataSource = lista;

            }
            catch (Exception)
            {
                
            }


        }

    }
}
