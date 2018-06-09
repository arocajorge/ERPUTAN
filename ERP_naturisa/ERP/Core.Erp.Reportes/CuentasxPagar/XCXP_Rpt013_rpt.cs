using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt013_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param =   cl_parametrosGenerales_Bus.Instance;
        public XCXP_Rpt013_rpt()
        {
            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            InitializeComponent();
        }

    }
}
 