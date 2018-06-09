
using System;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt025_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        public XROL_Rpt025_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt025_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XROL_Rpt025_Bus oReporteBus = new XROL_Rpt025_Bus();
            List<XROL_Rpt025_Info> oListado = new List<XROL_Rpt025_Info>();

            int idEmpresa = param.IdEmpresa;
            int IdDepartamento=Convert.ToInt32(Parameters["p_IdDepartamento"].Value);
            DateTime fechaInicial = Convert.ToDateTime(Parameters["s_fechaInicial"].Value);
            DateTime fechaFinal = Convert.ToDateTime(Parameters["s_fechaFinal"].Value);
            decimal idEmpleado = Convert.ToDecimal(Parameters["p_IdEmpleado"].Value);
            string IdRubro =Convert.ToString( Parameters["p_IdRubro"].Value);
                        
            //FILTROS
            if ( idEmpleado>0 && IdDepartamento>0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,Convert.ToInt32( idEmpleado), IdDepartamento,IdRubro, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }

            if ( IdDepartamento > 0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, IdDepartamento,IdRubro, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }

          


          


           


        }

    }
}
