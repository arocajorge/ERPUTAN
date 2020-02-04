using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Collections;
using System.Collections.Generic;
namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public partial class XPRO_CUS_CID_Rpt002 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt002()
        {
            InitializeComponent();
        }
        public void loadData(List< XPRO_CUS_CID_Rpt002_Info> data)
        {
            try
            {
                
                DataSource = data;
                

            }
            catch (Exception ex)
            {


            }


        }

        private void Credito_No_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
