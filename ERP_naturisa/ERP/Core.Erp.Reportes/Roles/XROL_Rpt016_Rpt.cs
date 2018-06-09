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
   
    public partial class XROL_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        XROL_Rpt016_Bus oReporteBus = new XROL_Rpt016_Bus();
        List<XROL_Rpt016_Info> oListado = new List<XROL_Rpt016_Info>();
        public XROL_Rpt016_Rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt016_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
            int idEmpresa = param.IdEmpresa;
            DateTime fechaInicial = Convert.ToDateTime(Parameters["s_fechaInicial"].Value);
            DateTime fechaFinal = Convert.ToDateTime(Parameters["s_fechaFinal"].Value);
            int IdDepartamento = Convert.ToInt32(Parameters["p_IdDepartamento"].Value);
            int idEmpleado = Convert.ToInt32(Parameters["p_IdEmpleado"].Value);
            int idnomina = Convert.ToInt32(Parameters["p_idnomina"].Value);
            int idRubro =Convert.ToInt32( Parameters["idrubro"].Value);


            if (idEmpleado != 0 && idRubro != 0)
            {
                oListado = oReporteBus.Get_Valor_Acumulado_x_empleado(idEmpresa, idnomina, IdDepartamento, idEmpleado,idRubro, fechaInicial, fechaFinal);
                this.DataSource = oListado.ToArray();
            }
// todos los empleados del rubro seleccionadp
            if (idRubro != 0)
            {

                oListado = oReporteBus.Get_Valor_Acumulado_x_empleado(idEmpresa, idnomina, IdDepartamento,idRubro, fechaInicial, fechaFinal);
                this.DataSource = oListado.ToArray();

            }
// todos los empleados y todos los rubros
            if (idRubro == 0 && idEmpleado==0)
            {

                oListado = oReporteBus.Get_Valor_Acumulado_x_empleado(idEmpresa, idnomina, IdDepartamento, fechaInicial, fechaFinal);
                this.DataSource = oListado.ToArray();

            }

            if (idRubro == 0 && idEmpleado != 0)
            {

                oListado = oReporteBus.Get_Valor_Acumulado_x_empleado(idEmpresa, idnomina, IdDepartamento,Convert.ToDecimal(idEmpleado), fechaInicial, fechaFinal);
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
