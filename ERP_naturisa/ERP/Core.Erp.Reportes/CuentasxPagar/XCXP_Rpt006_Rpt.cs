using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt006_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param =cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt006_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa,decimal IdCbteCble_Nota)
        {

            try
            {

                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;



                this.IdCbteCble_Nota.Value = IdCbteCble_Nota;
                this.IdCbteCble_Nota.Visible = false;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt006_Rpt) };
            }
        }


        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XCXP_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrLEmpresa.Text = param.NombreEmpresa;
                xrL_fecha.Text = DateTime.Now.ToLongDateString();

                XCXP_Rpt006_Bus repbus = new XCXP_Rpt006_Bus();
                List<XCXP_Rpt006_Info> ListDataRpt = new List<XCXP_Rpt006_Info>();

                int IdEmpresa = 0;
                Decimal IdCbteCble_Nota = 0;

                string mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdCbteCble_Nota = Convert.ToDecimal(Parameters["IdCbteCble_Nota"].Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa, IdCbteCble_Nota, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt006_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt006_Rpt) };
            }


        }

    }
}
