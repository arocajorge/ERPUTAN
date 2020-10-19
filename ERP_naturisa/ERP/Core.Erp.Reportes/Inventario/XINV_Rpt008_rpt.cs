using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt008_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XINV_Rpt008_Bus busRpt = new XINV_Rpt008_Bus();
        List<XINV_Rpt008_Info> lstRpt = new List<XINV_Rpt008_Info>();
        public string NomEmpresa { get; set; }
        public XINV_Rpt008_rpt()
        {
            InitializeComponent();
        }

        private void XINV_0008_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = NomEmpresa;
                int IdEmpresa = string.IsNullOrEmpty(p_IdEmpresa.Value.ToString()) ? 0 : Convert.ToInt32(p_IdEmpresa.Value);
                int IdTipoCbte = string.IsNullOrEmpty(p_IdTipoCbte.Value.ToString()) ? 0 : Convert.ToInt32(p_IdTipoCbte.Value);
                decimal IdCbteCble = string.IsNullOrEmpty(p_IdCbteCble.Value.ToString()) ? 0 : Convert.ToDecimal(p_IdCbteCble.Value);

                lstRpt = busRpt.GetList(IdEmpresa, IdTipoCbte, IdCbteCble);
                this.DataSource = lstRpt;
             }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
