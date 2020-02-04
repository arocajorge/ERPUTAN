using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Reports.Produc_Cirdesus
{
    public partial class XPRO_CUS_CID_Rpt009 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt009()
        {
            InitializeComponent();
        }

        public void loadData(tbPRO_CUS_CID_Rpt009_Info[] Data)
        {
            try
            {
                
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                this.xrPictureBox1.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                DataSource = Data;
              
            }
            catch (Exception ex)
            {
                
                
            }
        }

    }
}
