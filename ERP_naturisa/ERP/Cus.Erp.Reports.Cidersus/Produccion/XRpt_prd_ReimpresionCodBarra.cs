using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;


namespace Cus.Erp.Reports.Cidersus
{
    public partial class XRpt_prd_ReimpresionCodBarra : DevExpress.XtraReports.UI.XtraReport
    {
        public XRpt_prd_ReimpresionCodBarra()
        {
            InitializeComponent();
        }

      


        public void loadData(in_movi_inve_detalle_x_Producto_CusCider_Info[] Data, String Estado)
        {
            try
            {

                this.DataSource = Data;

            }
            catch (Exception ex)
            {
            }
        }
    }
}
