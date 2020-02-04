using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;



namespace Cus.Erp.Reports.Talme.Facturacion
{
    public partial class XFAC_CUS_TAL_Rpt005_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_CUS_TAL_Rpt005_rpt()
        {
            InitializeComponent();


            lblhora_fecha.Text = DateTime.Now.ToString();


        }

        public void cargar_datos(XFAC_CUS_TAL_Rpt003_Info[] datos)
        {

            try
            {
                this.DataSource = datos;

            }
            catch (Exception ex)
            {
                
                
            }
        }

    }
}
