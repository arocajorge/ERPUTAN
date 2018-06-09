using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt023_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCXP_Rpt023_Bus oBus = new XCXP_Rpt023_Bus();

        public XCXP_Rpt023_Rpt()
        {
            InitializeComponent();
            
        }

        private void XCXP_Rpt023_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblDireccion.Text = param.InfoEmpresa.em_direccion;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;
                lblTelefono.Text = param.InfoEmpresa.em_tel_int;
                xrPictureBoxLogo.Image = param.InfoEmpresa.em_logo_Image;

                decimal idOrdenGiro = 0;
                idOrdenGiro = Convert.ToDecimal(this.Parameters["idOrdenGiro"].Value);

                this.DataSource = oBus.Get_Lista_Comprobante_Retencion(param.IdEmpresa, idOrdenGiro);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
