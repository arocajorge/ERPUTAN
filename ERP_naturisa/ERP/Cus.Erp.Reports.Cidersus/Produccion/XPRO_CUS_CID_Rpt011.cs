using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.Cidersus
{
    public partial class XPRO_CUS_CID_Rpt011 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt011()
        {
            InitializeComponent();
        }
         public void loadData(tbPRO_CUS_CID_Rpt005_Info[] data)
        {
            try
            {
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                this.picture_logo.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);

                DataSource = data;
            }
            catch (Exception ex)
            {
                
                
            }
 
        
        
        }
    }
}
