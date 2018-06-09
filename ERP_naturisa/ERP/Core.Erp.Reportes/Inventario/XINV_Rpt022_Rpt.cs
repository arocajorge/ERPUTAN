using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt022_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        decimal IdDev_Inven = 0;
        string mensaje = "";

        public XINV_Rpt022_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt022_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                xrL_fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

                XINV_Rpt022_Bus oBus = new XINV_Rpt022_Bus();
                List<XINV_Rpt022_Info> Lista = new List<XINV_Rpt022_Info>();

                IdDev_Inven = Convert.ToDecimal(Parameters["PIdDev_Inven"].Value);

                Lista = oBus.Get_List(param.IdEmpresa, IdDev_Inven, ref mensaje);

                this.DataSource = Lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt022_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt022_Rpt) };
            }
        }

    }
}
