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
    public partial class XPRO_CUS_CID_Rpt010 : DevExpress.XtraReports.UI.XtraReport
    {
        public XPRO_CUS_CID_Rpt010()
        {
            InitializeComponent();
        }
        public void loadData(tbPRO_CUS_CID_Rpt010_Info[] data)
        {
            try
            {
                double total = 0;
                foreach (var item in data)
                {
                    total = total + item.PorcentajeEtapa;
                }
                foreach (var item in data)
                {
                    item.totalporcentaje = total;
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
