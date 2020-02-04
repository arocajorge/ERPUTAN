using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;
using System.Xml.Serialization;
using System.IO;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt005_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        public XCXP_NATU_Rpt005_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro,int  IdTipoCbte_Ogiro)
        {
            try
            {

                this.IdEmpresa_Ogiro.Value = IdEmpresa_Ogiro;
                this.IdEmpresa_Ogiro.Visible = false;

                this.IdTipoCbte_Ogiro.Value = IdTipoCbte_Ogiro;
                this.IdTipoCbte_Ogiro.Visible = false;

                this.IdCbteCble_Ogiro.Value = IdCbteCble_Ogiro;
                this.IdCbteCble_Ogiro.Visible = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt005_Rpt) };       
            }
        }

        private void XCXP_NATU_Rpt005_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                xrL_nomEmpresa.Text = param.InfoEmpresa.em_nombre;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrL_fecha.Text = DateTime.Now.ToLongDateString();

                XCXP_NATU_Rpt005_Bus repbus = new XCXP_NATU_Rpt005_Bus();


                List<XCXP_NATU_Rpt005_Info> ListDataRpt = new List<XCXP_NATU_Rpt005_Info>();

                int IdEmpresa_Ogiro = 0;
                Decimal IdCbteCble_Ogiro = 0;
                int IdTipoCbte_Ogiro = 0;
                string mensaje = "";

                IdEmpresa_Ogiro = Convert.ToInt32(Parameters["IdEmpresa_Ogiro"].Value);
                IdTipoCbte_Ogiro = Convert.ToInt32(Parameters["IdTipoCbte_Ogiro"].Value);
                IdCbteCble_Ogiro = Convert.ToDecimal(Parameters["IdCbteCble_Ogiro"].Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa_Ogiro, IdTipoCbte_Ogiro, IdCbteCble_Ogiro, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt005_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt005_Rpt) };       
            }

            
        }

    }
}
