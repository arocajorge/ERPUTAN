using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt020_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROL_Rpt020_rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        XROL_Rpt020_Bus oReporteBus = new XROL_Rpt020_Bus();
        List<XROL_Rpt020_Info> oListado = new List<XROL_Rpt020_Info>();

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void XROL_Rpt020_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int idEmpresa = param.IdEmpresa;
                DateTime fechaInicial = Convert.ToDateTime(Parameters["fechaInicial"].Value);
                DateTime fechaFinal = Convert.ToDateTime(Parameters["fechaFinal"].Value);
                int IdDepartamento = Convert.ToInt32(Parameters["IdDepartamento"].Value);
                int idnomina = Convert.ToInt32(Parameters["idnomina"].Value);
                lb_fecha_desde.Text = fechaInicial.ToString();
                lb_fecha_hasta.Text = fechaFinal.ToString();



                if (IdDepartamento != 0)
                {

                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, IdDepartamento, idnomina, fechaInicial, fechaFinal);
                    this.DataSource = oListado.ToArray();

                }
                else
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idnomina, fechaInicial, fechaFinal);
                    this.DataSource = oListado.ToArray();

                }


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
