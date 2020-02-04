using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.Cidersus
{
    public partial class XPRO_CUS_CID_Rpt007 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt007()
        {
            InitializeComponent();
        }
        public void loaddata(tbPRO_CUS_CID_Rpt007_Info[] data)
        {
            try
            {
                int sec = 0;
                foreach (var item in data)
                {
                    item.RptSecuencia = ++sec;
                    item.dm_cantidad = 1;
                }

                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                this.xrPictureBox1.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                DataSource = data;
              
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
