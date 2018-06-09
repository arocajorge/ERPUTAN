using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt004_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XCONTA_Rpt004_rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt004_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLFecha.Text = DateTime.Now.ToString();
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrLusuario.Text = param.IdUsuario;

                XCONTA_Rpt004_Bus oReporteBus = new XCONTA_Rpt004_Bus();
                List<XCONTA_Rpt004_Info> oListado = new List<XCONTA_Rpt004_Info>();

                int idEmpresa = 0;

                idEmpresa = Convert.ToInt32(Parameters["idEmpresa"].Value);
                oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, ref mensaje);

                this.DataSource = oListado.ToArray(); 

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt004_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt004_rpt) };   
                
            }

            

        }

    }
}
