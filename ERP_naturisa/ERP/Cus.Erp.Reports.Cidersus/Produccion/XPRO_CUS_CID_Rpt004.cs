using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
namespace Cus.Erp.Reports.Cidersus
{
    public partial class XPRO_CUS_CID_Rpt004 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt004()
        {
            InitializeComponent();
        }

        public void loaddata(tbPRO_CUS_CID_Rpt004_Info[] data)
        {
            try
            {
                double total = 0;
                double subtotal = 0;
                double totaliva = 0;
                double totalpeso = 0;
                foreach (var item in data)
                {
                    subtotal = subtotal + Convert.ToDouble(item.valortotal);
                    totaliva = totaliva + Convert.ToDouble(item.ivaxreg);
                    totalpeso = totalpeso + Convert.ToDouble(item.pesoxreg);
                    if (item.pesoxreg > 0)
                    {
                        lblpesos.Visible = true;
                        lblproducto.WidthF = 600;
                    
                    }
                    
                }
                total = subtotal + totaliva;

                foreach (var item in data)
                {
                    item.subtotal = subtotal;
                    item.totaiva = totaliva;
                    item.total = total;
                    
                    
                }
                if (totalpeso > 0)
                {
                    this.lblTotalPeso.Text = Convert.ToString(totalpeso);
                }
                else {
                    lblTotalPeso.Visible = false;
                    lblPeso.Visible = false;
                }
                this.DataSource = data;
            }
            catch (Exception ex)
            {
                
                
            }
        
        }

    }
}
