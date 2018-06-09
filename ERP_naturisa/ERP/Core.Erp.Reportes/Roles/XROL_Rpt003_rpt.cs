using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int idEmpresa = 0;
        decimal idEmpleado = 0;
        int idNominaTipo = 0;
        int idNominaTipoLiqui = 0;
        int idDepartamento = 0;
        int idPeriodo = 0;
        string mensaje = "";
        public XROL_Rpt003_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {
                XROL_Rpt003_Bus oReporteBus = new XROL_Rpt003_Bus();
                List<XROL_Rpt003_Info> oListado = new List<XROL_Rpt003_Info>();

            


            idEmpresa = Convert.ToInt32(Parameters["s_idEmpresa"].Value);
            idEmpleado = Convert.ToDecimal(Parameters["s_idEmpleado"].Value);
            idNominaTipo = Convert.ToInt32(Parameters["s_idNominaTipo"].Value);
            idNominaTipoLiqui = Convert.ToInt32(Parameters["s_idNominaTipoLiqui"].Value);
            idPeriodo = Convert.ToInt32(Parameters["s_idPeriodo"].Value);

            lblFielCopia.Visible = Convert.ToBoolean(this.PVisible_label_FielCopia.Value);

            //INFO
            ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
            List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
            ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        
            oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
            oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(idEmpresa, idNominaTipo, idNominaTipoLiqui);

            info = (from a in oListRo_periodo_x_ro_Nomina_TipoLiqui_Info
                    where a.IdPeriodo == idPeriodo
                    select a).FirstOrDefault();
            oListado.Clear();

            oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);
            this.DataSource = oListado.ToArray(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }


       
    }
}
