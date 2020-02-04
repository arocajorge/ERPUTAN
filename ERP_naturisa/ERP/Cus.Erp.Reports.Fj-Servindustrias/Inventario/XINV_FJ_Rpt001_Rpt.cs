using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public partial class XINV_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        public void CargarReporte(List<XINV_FJ_Rpt001_Info> Lista)
        {
            try
            {
                this.DataSource = Lista;
                lblFecha.Text = DateTime.Now.ToShortDateString();
                lblUsuario.Text = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CargarReporte", ex.Message), ex) { EntityType = typeof(XINV_FJ_Rpt001_Rpt) };
            }
        }
    }
}
