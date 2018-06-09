using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt003_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble_Ogiro)
        {
            try
            {

                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdTipoCbte.Value = IdTipoCbte;
                this.IdTipoCbte.Visible = false;

                this.IdCbteCble_Ogiro.Value = IdCbteCble_Ogiro;
                this.IdCbteCble_Ogiro.Visible = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt003_Rpt) };
            }
        }

             
        List<XCXP_Rpt003_Info> ListDataRpt = new List<XCXP_Rpt003_Info>();

       

        private void XCXP_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //lblUsuario.Text = param.IdUsuario;
                xrL_fecha.Text = param.Fecha_Transac.ToString();

                XCXP_Rpt003_Bus repbus = new XCXP_Rpt003_Bus();

                int IdEmpresa = 0;
                Decimal IdCbteCble_Ogiro = 0;
                int IdTipoCbte = 0;
                string mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdTipoCbte = Convert.ToInt32(Parameters["IdTipoCbte"].Value);
                IdCbteCble_Ogiro = Convert.ToDecimal(Parameters["IdCbteCble_Ogiro"].Value);
                ListDataRpt = repbus.consultar_data(IdEmpresa, IdTipoCbte, IdCbteCble_Ogiro, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt003_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt003_Rpt) };
            }

        }

       

    }
}
