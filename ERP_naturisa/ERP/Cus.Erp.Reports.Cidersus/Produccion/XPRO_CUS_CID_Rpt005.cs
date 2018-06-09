using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
namespace Cus.Erp.Reports.Cidersus
{
    public partial class XPRO_CUS_CID_Rpt005 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt005()
        {
            InitializeComponent();
        }
        public void loaddata(tbPRO_CUS_CID_Rpt005_Info[] data)
        {
            try 
	{
                double totalpeso =0;
        foreach (var item in data )
        {
            totalpeso = Convert.ToDouble(item.pesoxcant) + totalpeso;
        }

        foreach (var item in data)
        {
            item.pesototal = totalpeso;
            item.producto = item.producto + "CB:"+item.CodigoBarraMaestro;
        }
        if (totalpeso == 0)
        {
            lblkg.Visible = false;
            lblpesototal.Visible = false;
        }
        DataSource = data;
	}
	catch (Exception)
	{
		
		throw;
	}
        
        }

    }
}
