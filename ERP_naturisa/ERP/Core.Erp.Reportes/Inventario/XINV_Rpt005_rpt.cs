using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt005_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt005_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_Rpt005_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        XINV_Rpt005_Bus Bus = new XINV_Rpt005_Bus();
        private void XINV_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                this.DataSource = Bus.Consultar_Data(Convert.ToInt32(IdEmpresa.Value), Convert.ToInt32(IdSucursal.Value), Convert.ToInt32(IdBodega.Value), Convert.ToDecimal(IdNumMovi.Value), Convert.ToInt32(IdMoviInvenTipo.Value));                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt005_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt005_rpt) };
            }         
        }

    }
}
