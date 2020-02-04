using System;
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

namespace Cus.Erp.Reports.Talme.Roles
{
    public partial class XROL_TALME_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int idEmpresa = 0;
        decimal idEmpleado = 0;
        int idNominaTipo = 0;
        int idNominaTipoLiqui = 0;
        int idDepartamento = 0;
        int idPeriodo = 0;
        string mensaje = "";

        public XROL_TALME_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XROL_TALME_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XROL_TALME_Rpt001_Bus oReporteBus = new XROL_TALME_Rpt001_Bus();
                List<XROL_TALME_Rpt001_Info> oListado = new List<XROL_TALME_Rpt001_Info>();

                idEmpresa = Convert.ToInt32(this.P_idEmpresa.Value);
                idEmpleado = Convert.ToDecimal(this.P_idEmpleado.Value);
                idNominaTipo = Convert.ToInt32(this.P_idNominaTipo.Value);
                idNominaTipoLiqui = Convert.ToInt32(this.P_idNominaTipoLiqui.Value);
                idPeriodo = Convert.ToInt32(this.P_idPeriodo.Value);

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
