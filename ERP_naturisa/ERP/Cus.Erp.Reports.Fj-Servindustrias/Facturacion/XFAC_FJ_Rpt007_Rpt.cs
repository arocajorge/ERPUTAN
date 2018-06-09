using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cus.Erp.Reports.FJ.Facturacion;
using System.Collections.Generic;
namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt007_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt007_Rpt()
        {
            InitializeComponent();
        }
        List<XFAC_FJ_Rpt007_Info> lista = new List<XFAC_FJ_Rpt007_Info>();
        XFAC_FJ_Rpt007_Bus bus = new XFAC_FJ_Rpt007_Bus();
        
        private void XFAC_FJ_Rpt007_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int Idempresa = 0;
                int IdPeriod = 0;
                int anio = 0;
                int Mes = 0;
                Idempresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdPeriod = Convert.ToInt32(Parameters["IdPeriodo"].Value);
                anio = Convert.ToInt32(Parameters["Anio"].Value);
                Mes = Convert.ToInt32(Parameters["Mes"].Value);
                lista = bus.Get_List(Idempresa, IdPeriod, anio,Mes);
                this.DataSource = lista;

            }
            catch (Exception)
            {

            }
        }

    }
}
