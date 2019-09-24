using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt008_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XCOMP_NATU_Rpt008_Bus bus_rpt = new XCOMP_NATU_Rpt008_Bus();
        public string Empresa { get; set; }
        List<XCOMP_NATU_Rpt008_Info> Lista = new List<XCOMP_NATU_Rpt008_Info>();
        public XCOMP_NATU_Rpt008_Rpt()
        {
            InitializeComponent();
        }

        private void XCOMP_NATU_Rpt008_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = Empresa;
                Lista = bus_rpt.GetList(Convert.ToInt32(p_IdEmpresa.Value), Convert.ToDecimal(p_IdOrdenPedido.Value));
                this.DataSource = Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
