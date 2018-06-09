/*CLASE: XROL_Rpt009_rpt
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
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
    public partial class XROL_Rpt009_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";

        public XROL_Rpt009_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt009_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XROL_Rpt009_Bus oReporteBus = new XROL_Rpt009_Bus();
                List<XROL_Rpt009_Info> oListado = new List<XROL_Rpt009_Info>();

                int idEmpresa = Convert.ToInt32(Parameters["p_IdEmpresa"].Value);
                int idPeriodoFiscal = Convert.ToInt32(Parameters["p_PeriodoFiscal"].Value);
                int idNominaTipo = Convert.ToInt32(Parameters["p_IdNominaTipo"].Value);

                oListado = oReporteBus.GetListPorIdPeriodo(idEmpresa,idNominaTipo, idPeriodoFiscal, ref mensaje);

                this.DataSource = oListado.ToArray();

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
            }
        }





    }
}
