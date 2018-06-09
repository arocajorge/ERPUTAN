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
    public partial class XROL_Rpt001_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";


        public XROL_Rpt001_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt001_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XROL_Rpt001_Bus oReporteBus = new XROL_Rpt001_Bus();
                List<XROL_Rpt001_Info> oListado = new List<XROL_Rpt001_Info>();

                int idnomina = Convert.ToInt32(Parameters["IdNomina"].Value);
                int iddepartamento =Convert.ToInt32( Parameters["IdDepartamento"].Value);
                int idcargo = Convert.ToInt32(Parameters["IdCargo"].Value);
                int idEmpresa = param.IdEmpresa;

                if (idnomina == 0 && iddepartamento == 0 && idcargo == 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa);
                    this.DataSource = oListado.ToArray();
                    return;
                }

                if (idnomina != 0 && iddepartamento == 0 && idcargo == 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa);
                    this.DataSource = oListado.ToArray();
                    return;
                }

                if (idnomina != 0 &&  idcargo != 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa,idnomina,idcargo);
                    this.DataSource = oListado.ToArray();
                    return;
                }


                if (idnomina != 0 && iddepartamento != 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idnomina, iddepartamento);
                    this.DataSource = oListado.ToArray();
                    return;
                }

            }

            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XROL_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XROL_Rpt001_rpt) };
            }
        }

    }
}
