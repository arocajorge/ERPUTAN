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
    public partial class XROL_Rpt017_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        XROL_Rpt017_Bus oReporteBus = new XROL_Rpt017_Bus();
        List<XROL_Rpt017_Info> oListado = new List<XROL_Rpt017_Info>();
        public XROL_Rpt017_Rpt()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int idEmpresa = param.IdEmpresa;
                DateTime fechaInicial = Convert.ToDateTime(Parameters["s_fechaInicial"].Value);
                DateTime fechaFinal = Convert.ToDateTime(Parameters["s_fechaFinal"].Value);
                int idnomina = Convert.ToInt32(Parameters["p_idnomina"].Value);
                string CodCtbteCble = (string)Parameters["CodCtbteCble"].Value;


                if (idnomina != 0 )
                {
                    fecha_inicio.Text = fechaInicial.ToString();
                    fecha_fin.Text = fechaFinal.ToString();
                    comprobante.Text = CodCtbteCble;



                    oListado = oReporteBus.Get_Valor_Acumulado_x_empleado(idEmpresa, idnomina,CodCtbteCble,  fechaInicial, fechaFinal);
                    this.DataSource = oListado.ToArray();
                }
               

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
