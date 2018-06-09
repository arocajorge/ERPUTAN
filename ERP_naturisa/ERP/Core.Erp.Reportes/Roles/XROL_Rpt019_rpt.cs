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
    public partial class XROL_Rpt019_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public XROL_Rpt019_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XROL_Rpt019_Bus oReporteBus = new XROL_Rpt019_Bus();
                List<XROL_Rpt019_Info> oListado = new List<XROL_Rpt019_Info>();


                string mensaje = "";

                //string format = "dd/MM/yyyy";

                int idNominaTipo = Convert.ToInt32(Parameters["idNominaTipo"].Value);
                int idNominaTipoLiqui  = Convert.ToInt32(Parameters["idNominaTipoLiqui"].Value);
                int idDepartamento = Convert.ToInt32(Parameters["IdDepartamento"].Value);
                DateTime fecha_inicio = Convert.ToDateTime(Parameters["fecha_inicio"].Value);
                DateTime fecha_fin = Convert.ToDateTime(Parameters["fecha_fin"].Value);
                lb_fecha_fin.Text = fecha_fin.ToShortDateString();
                lb_fechainicio.Text = fecha_inicio.ToShortDateString();
                lb_fechaimpresion.Text = DateTime.Now.ToString();
                lb_usuario.Text = param.IdUsuario;
                //FILTROS
                if (idDepartamento != 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(param.IdEmpresa, idNominaTipo, idNominaTipoLiqui, fecha_inicio,fecha_fin, idDepartamento, ref mensaje);
                }
                else
                {
                    oListado = oReporteBus.GetListConsultaGeneral(param.IdEmpresa, idNominaTipo, idNominaTipoLiqui, fecha_inicio,fecha_fin, ref mensaje);


                }

                
                this.DataSource = oListado.ToArray();

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
