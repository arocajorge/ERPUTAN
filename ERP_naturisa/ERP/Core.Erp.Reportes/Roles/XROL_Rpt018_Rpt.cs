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
    public partial class XROL_Rpt018_Rpt : DevExpress.XtraReports.UI.XtraReport
    { cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        XROL_Rpt018_Bus oReporteBus = new XROL_Rpt018_Bus();
        List<XROL_Rpt018_Info> Lista = new List<XROL_Rpt018_Info>();
        public XROL_Rpt018_Rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt018_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
                Lista = oReporteBus.Get_Ingreso_Egreso_Empleado(idEmpresa, idnomina, IdDepartamento, idEmpleado,idRubro, fechaInicial, fechaFinal);
                this.DataSource = Lista.ToArray();
            }
// todos los empleados del rubro seleccionadp
            if (idRubro != 0 && idEmpleado==0)
            {

                Lista = oReporteBus.Get_Ingreso_Egreso_Empleado(idEmpresa, idnomina, IdDepartamento,idRubro, fechaInicial, fechaFinal);
                this.DataSource = Lista.ToArray();

            }


            if (idRubro == 0 && idEmpleado != 0)
            {

                Lista = oReporteBus.Get_Ingreso_Egreso_Empleado(idEmpresa, idnomina, IdDepartamento,Convert.ToDecimal(idEmpleado), fechaInicial, fechaFinal);
                this.DataSource = Lista.ToArray();

            }


            if (idRubro !=0 && idEmpleado == 0 && IdDepartamento==0)
            {

                Lista = oReporteBus.Get_Ingreso_Egreso_Empleado(idEmpresa, idnomina, idRubro, fechaInicial, fechaFinal);
                this.DataSource = Lista.ToArray();
            

            }


                 if(Lista.Count>0)
                 {
                     ln_NumRegistro.Text = Convert.ToString(Lista.Max(v => v.secuencia));
                
                 }
            }
            catch (Exception)
            {
                
                throw;
            }

        }
        }

    }

