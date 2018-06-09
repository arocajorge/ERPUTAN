/*CLASE: XROL_Rpt007_rpt
 *CREADA POR: ALBERTO MENA
 *FECHA: 24-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt007_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";

        public XROL_Rpt007_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt007_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XROL_Rpt007_Bus oReporteBus = new XROL_Rpt007_Bus();
                List<XROL_Rpt007_Info> oListado = new List<XROL_Rpt007_Info>();

                int idEmpresa = Convert.ToInt32(Parameters["p_IdEmpresa"].Value);
                decimal idEmpleado = Convert.ToDecimal(Parameters["p_IdEmpleado"].Value);
                decimal idActaFiniquito = Convert.ToDecimal(Parameters["p_IdActaFiniquito"].Value);


                oListado = oReporteBus.GetListPorIdActa(idEmpresa, idEmpleado, idActaFiniquito, ref mensaje);
                //oListado = oReporteBus.GetListPorIdActa(1, 302, 5, ref mensaje);

                lbUsuario.Text = "Elaborado por; " + param.IdUsuario;
                  

                this.DataSource = oListado.ToArray();
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
            }
        }
        

    }
}
