using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt010_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_NATU_Rpt010_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt010_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrL_Usuario.Text = param.IdUsuario;
                xrLEmpresa.Text = param.NombreEmpresa;
                xrL_fecha.Text = DateTime.Now.ToLongDateString();

                XCXP_NATU_Rpt010_Bus repbus = new XCXP_NATU_Rpt010_Bus();
                List<XCXP_NATU_Rpt010_Info> ListDataRpt = new List<XCXP_NATU_Rpt010_Info>();

                int IdEmpresa = 0;
                Decimal IdCbteCble_Nota = 0;

                string mensaje = "";

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCbteCble_Nota = Convert.ToDecimal(this.PIdCbteCble_Nota.Value);

                ListDataRpt = repbus.consultar_data(IdEmpresa, IdCbteCble_Nota, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt010_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt010_Rpt) };
            }
        }
    }
}
