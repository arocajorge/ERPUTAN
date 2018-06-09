using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;

using Core.Erp.Business.General;
namespace Cus.Erp.Reports.Cidersus
{
    public partial class XRpt_prd_CodigoBarraProductoTerminado : DevExpress.XtraReports.UI.XtraReport
    {
        public XRpt_prd_CodigoBarraProductoTerminado()
        {
            InitializeComponent();
        }

        //public void loadData(tbPRD_Rpt_RPRD001_Info[] Data)
        //{
        //    try
        //    {

        //        this.DataSource = Data;

        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}


        public void loadData(in_movi_inve_detalle_x_Producto_CusCider_Info[] Data)
        {
            try
            {
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                this.xrPictureBox1.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                this.DataSource = Data;

            }
            catch (Exception ex)
            {
            }
        }
    }
}
