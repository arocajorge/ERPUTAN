using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt006_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt006_rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt006_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XINV_Rpt006_Bus Bus = new XINV_Rpt006_Bus();
                int IdEmpresa_ = Convert.ToInt32(IdEmpresa.Value);
                int IdSucursal_ = Convert.ToInt32(IdSucursal.Value);
                int IdBodega_ = Convert.ToInt32(IdBodega.Value);
                int IdNumMovi_ = Convert.ToInt32(IdNumMovi.Value);
                int IdMoviInvenTipo_ = Convert.ToInt32(IdMoviInvenTipo.Value);

                this.DataSource = Bus.Obtener_Data(IdEmpresa_, IdSucursal_, IdBodega_, IdNumMovi_, IdMoviInvenTipo_);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt006_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt006_rpt) };
            }
        }

    }
}
