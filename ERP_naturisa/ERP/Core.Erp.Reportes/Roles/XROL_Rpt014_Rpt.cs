using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Collections;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt014_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
             
        
            
        public XROL_Rpt014_Rpt()
        {
            InitializeComponent();
            
        }
        
        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                
                
            }
        }

        public void Set_Lista(List<XROL_Rpt014_Info> list)
        {
            try
            {
                
                this.DataSource = list;
            }
            catch (Exception)
            {
                
               
            }
        }

    }
}
