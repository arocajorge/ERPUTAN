using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;

namespace Cus.Erp.Reports.Cidersus
{
    public partial class XRpt_prd_EficienciaPiezas : DevExpress.XtraReports.UI.XtraReport
    {
        public XRpt_prd_EficienciaPiezas()
        {
            InitializeComponent();
        }


        public void cargaData(prd_EficienciaPiezas_Rpt_Info[] Data, string user)
        {
            try
            {
                this.DataSource = Data;
                xrLabelUsuario.Text = user;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
