using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt005_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public List<XCOMP_Rpt005_Info> lstIdSolicitud { get; set; }

        public XCOMP_Rpt005_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XCOMP_Rpt005_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCOMP_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                XCOMP_Rpt005_Bus busRpt = new XCOMP_Rpt005_Bus();
                List<XCOMP_Rpt005_Info> lstInfo = new List<XCOMP_Rpt005_Info>();
                
                lstInfo = busRpt.get_PreAprobacion_Solicitud(lstIdSolicitud);
                this.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_Rpt005_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt005_rpt) };   
            }
        }

    }
}
