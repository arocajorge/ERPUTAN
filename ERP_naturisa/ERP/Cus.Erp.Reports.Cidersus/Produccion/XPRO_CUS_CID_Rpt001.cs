using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
using Cus.Erp.Reports.Cidersus.Produccion;
using System.Collections;
using System.Collections.Generic;
namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public partial class XPRO_CUS_CID_Rpt001 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt001()
        {
            InitializeComponent();

        }

        public void loadData(List< XPRO_CUS_CID_Rpt001_Info> Data)
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
