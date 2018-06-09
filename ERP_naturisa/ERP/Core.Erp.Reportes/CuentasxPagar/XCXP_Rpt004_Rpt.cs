using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt004_Rpt()
        {
            InitializeComponent();
        }


        public void set_parametros(int IdEmpresa_, int IdTipoCbte_OG_, decimal IdCbteCble_Ogiro_)
        {
            try
            {

                this.IdEmpresa.Value = IdEmpresa_;
                this.IdEmpresa.Visible = false;

                this.IdTipoCbte_OG.Value = IdTipoCbte_OG_;
                this.IdTipoCbte_OG.Visible = false;

                this.IdCbteCble_Ogiro.Value = IdCbteCble_Ogiro_;
                this.IdCbteCble_Ogiro.Visible = false;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt004_Rpt) };

            }
        }

        private void XCXP_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrL_nomEmpresa.Text = param.InfoEmpresa.em_nombre;
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = DateTime.Now.ToString();

                XCXP_Rpt004_Bus repbus = new XCXP_Rpt004_Bus();

                List<XCXP_Rpt004_Info> ListDataRpt = new List<XCXP_Rpt004_Info>();

                int IdEmpresa_ = 0;
                Decimal IdCbteCble_Ogiro_ = 0;
                int IdTipoCbte_OG_ = 0;
                string mensaje = "";

                IdEmpresa_ = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdTipoCbte_OG_ = Convert.ToInt32(Parameters["IdTipoCbte_OG"].Value);
                IdCbteCble_Ogiro_ = Convert.ToDecimal(Parameters["IdCbteCble_Ogiro"].Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa_, IdTipoCbte_OG_, IdCbteCble_Ogiro_, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt004_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt004_Rpt) };
            }

            
        }

    }
}
