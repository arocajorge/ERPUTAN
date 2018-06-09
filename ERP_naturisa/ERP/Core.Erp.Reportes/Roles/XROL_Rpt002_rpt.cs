using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt002_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public XROL_Rpt002_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XROL_Rpt002_Bus oReporteBus = new XROL_Rpt002_Bus();
                List<XROL_Rpt002_Info> oListado = new List<XROL_Rpt002_Info>();

                int idEmpresa = 0;
                int idNominaTipo = 0;
                int idNominaTipoLiqui = 0;
                int idPeriodo = 0;
                int idDivision = 0;
                int idArea = 0;
                int idDepartamento = 0;
                string idCentroCosto = "";
                string mensaje = "";

                //string format = "dd/MM/yyyy";

                idEmpresa = Convert.ToInt32(Parameters["s_idEmpresa"].Value);
                idNominaTipo = Convert.ToInt32(Parameters["s_idNominaTipo"].Value);
                idNominaTipoLiqui = Convert.ToInt32(Parameters["s_idNominaTipoLiqui"].Value);
                idPeriodo = Convert.ToInt32(Parameters["s_idPeriodo"].Value);
                idDivision = Convert.ToInt32(Parameters["p_IdDivision"].Value);
                idCentroCosto = Parameters["p_IdCentroCosto"].Value.ToString();
                idArea = Convert.ToInt32(Parameters["p_IdArea"].Value);
                idDepartamento = Convert.ToInt32(Parameters["p_IdDepartamento"].Value);

                //FILTROS


                if (idDivision == 0 && idDepartamento == 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo);
                    this.DataSource = oListado.ToArray();
                    lb_total_Registros.Text = "TOTAL DE REGISTROS: " + oListado.Select(v => v.secuencia).Max().ToString();
                    return;
                }



                if (idDepartamento != 0 && idDivision == 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, idDepartamento, ref mensaje);
                    this.DataSource = oListado.ToArray();
                    lb_total_Registros.Text = "TOTAL DE REGISTROS: " + oListado.Select(v => v.secuencia).Max().ToString();
                    return;
                }


                if (idDepartamento != 0 && idDivision != 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo,idDivision, idDepartamento, ref mensaje);
                    this.DataSource = oListado.ToArray();
                    lb_total_Registros.Text = "TOTAL DE REGISTROS: " + oListado.Select(v => v.secuencia).Max().ToString();
                    return;
                }

                if (idDivision != 0 )
                {
                    oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, idDivision);
                    this.DataSource = oListado.ToArray();
                    lb_total_Registros.Text = "TOTAL DE REGISTROS: " + oListado.Select(v => v.secuencia).Max().ToString();
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
