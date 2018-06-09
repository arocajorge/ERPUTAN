using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt023_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        XINV_Rpt023_Bus oBus = new XINV_Rpt023_Bus();

        public XINV_Rpt023_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt023_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.InfoEmpresa.em_nombre;
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = DateTime.Now.ToString();
                xrPictureBoxLogo.Image = param.InfoEmpresa.em_logo_Image;

                int idEmpresa = param.IdEmpresa;
                decimal idDev_Inv = 0;
                idDev_Inv = Convert.ToDecimal(this.Parameters["idDev_Inv"].Value);

                this.DataSource = oBus.Get_Lista_Reporte(idEmpresa, idDev_Inv);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt023_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt022_Rpt) };
            }
        }

    }
}
