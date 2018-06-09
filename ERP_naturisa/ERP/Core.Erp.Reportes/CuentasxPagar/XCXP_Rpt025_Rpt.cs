using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt025_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCXP_Rpt025_Bus oBus = new XCXP_Rpt025_Bus();

        public XCXP_Rpt025_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt025_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;

                
                int idEmpresa = 0;
                DateTime fechaIni = DateTime.Now;
                DateTime fechaFin = DateTime.Now;
                string idCentroCosto = string.Empty;
                string idSubcentroCosto = string.Empty;
                
                idEmpresa = param.IdEmpresa;
                idCentroCosto = (this.Parameters["idCentroCosto"].Value).ToString();
                idSubcentroCosto = (this.Parameters["idSubcentroCosto"].Value).ToString();
                fechaIni = Convert.ToDateTime(this.Parameters["fechaIni"].Value);
                fechaFin = Convert.ToDateTime(this.Parameters["fechaFin"].Value);

                this.DataSource = oBus.Get_Lista_Reporte(idEmpresa, idCentroCosto, idSubcentroCosto, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
