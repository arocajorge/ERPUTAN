using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
using System.Linq;


namespace Cus.Erp.Reports.Naturisa.Bancos
{
    public partial class XBAN_NAT_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string MensajeError = "";


        public XBAN_NAT_Rpt001_Rpt()
        {
            InitializeComponent();
            lblfecha.Text = DateTime.Now.ToString();
            lblUsuario.Text = param.IdUsuario;
        }

        private void XBAN_NAT_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XBAN_NAT_Rpt001_Bus OBusRpt = new XBAN_NAT_Rpt001_Bus();
                List<XBAN_NAT_Rpt001_Info> lista = new List<XBAN_NAT_Rpt001_Info>();
                

                int PIdEmpresa = Convert.ToInt32(Parameters["PIdEmpresa"].Value);
                int PIdTipoCbte = Convert.ToInt32(Parameters["PIdTipoCbte"].Value);
                decimal PIdCbteCble = Convert.ToInt32(Parameters["PIdCbteCble"].Value);
                string Pnombre = Convert.ToString(Parameters["PNombreReporte"].Value);




                lista = OBusRpt.Get_Data_Reporte(PIdEmpresa, PIdTipoCbte, PIdCbteCble, ref MensajeError);
               
                XBAN_NAT_Rpt001_Info Registro=  lista.FirstOrDefault();
                if (Registro!= null)
                { lblAnulado.Visible = (Registro.Estado == "I") ? true : false; }

                this.DataSource = lista.ToArray();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_NAT_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_NAT_Rpt001_Rpt) };   
                
            }

        }

    }
}
