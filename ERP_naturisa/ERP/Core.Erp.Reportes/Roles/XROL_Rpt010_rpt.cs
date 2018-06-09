/*CLASE: XROL_Rpt010_rpt
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt010_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";


        public XROL_Rpt010_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt010_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XROL_Rpt010_Bus oReporteBus = new XROL_Rpt010_Bus();
                List<XROL_Rpt010_Info> oListado = new List<XROL_Rpt010_Info>();

                int idEmpresa = Convert.ToInt32(Parameters["p_IdEmpresa"].Value);
                decimal idEmpledo= Convert.ToDecimal(Parameters["p_IdEmpleado"].Value);
                decimal IdDepartamento = Convert.ToInt32(Parameters["p_IdDepartamento"].Value);
                DateTime fechaInicial = Convert.ToDateTime(Parameters["s_fechaInicial"].Value);
                DateTime fechaFinal = Convert.ToDateTime(Parameters["s_fechaFinal"].Value);


                if (idEmpledo > 0)
                {
                    oListado = oReporteBus.GetListPorEmpleado(idEmpresa, IdDepartamento, fechaInicial, fechaFinal, ref mensaje).Where(v => v.IdEmpleado == idEmpledo).ToList();

                }
                else
                {
                    oListado = oReporteBus.GetListPorEmpleado(idEmpresa, IdDepartamento, fechaInicial, fechaFinal, ref mensaje);

                }

                this.DataSource = oListado.ToArray();

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
            }
        }

    }
}
