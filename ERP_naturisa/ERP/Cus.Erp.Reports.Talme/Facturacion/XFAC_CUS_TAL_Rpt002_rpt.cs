using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Cus.Erp.Reports.Talme.Facturacion
{
    public partial class XFAC_CUS_TAL_Rpt002_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_CUS_TAL_Rpt002_rpt()
        {
            InitializeComponent();
        }

        public void cargar_datos(XFAC_CUS_TAL_Rpt002_Info[] data )
        {
            try
            {
                this.DataSource = data;

            }
            catch (Exception ex)
            {
                
                
            }
        }

    }
}
