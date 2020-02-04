using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public partial class XCXC_GRAF_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XCXC_GRAF_Rpt003_Info> lst_reporte = new List<XCXC_GRAF_Rpt003_Info>();
        XCXC_GRAF_Rpt003_Bus bus_reporte = new XCXC_GRAF_Rpt003_Bus();

        public XCXC_GRAF_Rpt003_Rpt()
        {
            InitializeComponent();            
        }

        private void XCXC_GRAF_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblFecha.Text = DateTime.Now.ToString("MMMM' 'd' de 'yyyy");
                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);
                int Dias_credito = Convert.ToInt32(p_DiasCredito.Value);
                lblSaludo.Text = lblSaludo.Text.Replace("{0}", Dias_credito.ToString());
                lst_reporte = bus_reporte.Get_list_reporte(param.IdEmpresa, IdCliente);
                this.DataSource = lst_reporte;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_GRAF_Rpt003_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_GRAF_Rpt003_Rpt) };
            }
        }

    }
}
