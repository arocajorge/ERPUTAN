using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.Cidersus
{
    public partial class xrpt_prd_ListadoMateriales : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_prd_ListadoMateriales()
        {
            InitializeComponent();
        }
        public void loadData(tbPRO_CUS_CID_Rpt003_Info[] Data)
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
