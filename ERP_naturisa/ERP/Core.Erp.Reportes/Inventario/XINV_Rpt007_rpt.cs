using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.IO;
namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt007_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XINV_Rpt007_rpt()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            lblEmpresa.Text = param.NombreEmpresa;
            lblUsuario.Text = param.IdUsuario;

        }

        XINV_Rpt007_Bus Bus = new XINV_Rpt007_Bus();
        private void XINV_Rpt007_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {   
                this.DataSource = Bus.Obtener_Data(Convert.ToInt32(IdEmpresa.Value), Convert.ToInt32(IdSucursal.Value), Convert.ToInt32(IdBodega.Value), Convert.ToDecimal(IdNunAjusteFisico.Value));                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt007_rpt) };
            }
       }
    }
}
