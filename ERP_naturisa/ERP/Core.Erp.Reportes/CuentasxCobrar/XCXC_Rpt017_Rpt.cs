using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt017_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        XCXC_Rpt017_Bus bus_rpt = new XCXC_Rpt017_Bus();
        List<XCXC_Rpt017_Info> lst_rpt = new List<XCXC_Rpt017_Info>();

        public XCXC_Rpt017_Rpt()
        {
            InitializeComponent();
        }        

        private void XCXC_Rpt017_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                DateTime FechaIni = Convert.ToDateTime(p_FechaIni.Value).Date;
                DateTime FechaFin = Convert.ToDateTime(p_FechaFin.Value).Date;

                lst_rpt = bus_rpt.Get_lst_reporte(param.IdEmpresa, FechaIni, FechaFin);
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt017_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt017_Rpt) };
            }
        }

    }
}
