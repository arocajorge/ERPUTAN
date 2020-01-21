using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt030_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        #region Variables
        List<XINV_Rpt030_Info> LstRpt;
        XINV_Rpt030_Bus busRpt;
        cl_parametrosGenerales_Bus param;
        #endregion
        public XINV_Rpt030_rpt()
        {
            InitializeComponent();
            busRpt = new XINV_Rpt030_Bus();
            LstRpt = new List<XINV_Rpt030_Info>();
            param = cl_parametrosGenerales_Bus.Instance;
        }

        private void XINV_Rpt030_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblFechaAutorizacion.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                pbLogo.Image = param.InfoEmpresa.em_logo_Image;
                int IdSucursal = string.IsNullOrEmpty(pIdSucursal.Value.ToString()) ? 0 : Convert.ToInt32(pIdSucursal.Value.ToString());
                int IdBodega = string.IsNullOrEmpty(pIdBodega.Value.ToString()) ? 0 : Convert.ToInt32(pIdBodega.Value.ToString());
                decimal IdTransferencia = string.IsNullOrEmpty(pIdTransferencia.Value.ToString()) ? 0 : Convert.ToDecimal(pIdTransferencia.Value.ToString());

                LstRpt = busRpt.Get_list(param.IdEmpresa, IdSucursal, IdBodega, IdTransferencia);
                this.DataSource = LstRpt;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
