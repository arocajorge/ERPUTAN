using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;
using System.Linq;


namespace Core.Erp.Reportes.Bancos
{
    public partial class 
        XBAN_Rpt014_rpt : DevExpress.XtraReports.UI.XtraReport
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string MensajeError = "";


        public XBAN_Rpt014_rpt()
        {
            InitializeComponent();
            lblfecha.Text = DateTime.Now.ToString();
            lblUsuario.Text = param.IdUsuario;
        }

        private void XBAN_Rpt014_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XBAN_Rpt014_Bus OBusRpt = new XBAN_Rpt014_Bus();
                List<XBAN_Rpt014_Info> lista = new List<XBAN_Rpt014_Info>();
                

                int PIdEmpresa = Convert.ToInt32(Parameters["PIdEmpresa"].Value);
                int PIdTipoCbte = Convert.ToInt32(Parameters["PIdTipoCbte"].Value);
                decimal PIdCbteCble = Convert.ToInt32(Parameters["PIdCbteCble"].Value);



                lista = OBusRpt.Get_Data_Reporte(PIdEmpresa, PIdTipoCbte, PIdCbteCble, ref MensajeError);
               
                XBAN_Rpt014_Info Registro=  lista.FirstOrDefault();
                if (Registro!= null)
                { lblAnulado.Visible = (Registro.Estado == "I") ? true : false; }

                this.DataSource = lista.ToArray();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt013_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_rpt) };   

            }

        }


        

        private void xrSubreportDet_Depositado_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                int IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                int IdTipoCbte = Convert.ToInt32(this.PIdTipoCbte.Value);
                decimal IdCbteCble = Convert.ToInt32(this.PIdCbteCble.Value);


                ((XRSubreport)sender).ReportSource.Parameters["PIdEmpresa"].Value = IdEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["PIdTipoCbte"].Value = IdTipoCbte;
                ((XRSubreport)sender).ReportSource.Parameters["PIdCbteCble"].Value = IdCbteCble;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "xrSubreportDet_Depositado_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_rpt) };   

            }


        }


    }
}
