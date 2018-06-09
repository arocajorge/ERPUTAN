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
    public partial class XFAC_Rpt004_Resumen_rpt : DevExpress.XtraReports.UI.XtraReport
    {

        public XFAC_Rpt004_Resumen_rpt()
        {
            InitializeComponent();
        }

        private void XFAC_Rpt004_Resumen_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

    }
}
