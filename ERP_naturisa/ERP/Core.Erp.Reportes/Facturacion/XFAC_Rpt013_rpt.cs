using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;


namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt013_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();



        public XFAC_Rpt013_rpt()
        {
            InitializeComponent();
        }

        private void XFAC_Rpt013_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                xrLFecha.Text = DateTime.Now.ToString();
                xrLusuario.Text = param.IdUsuario;

                XFAC_Rpt013_Bus oReporteBus = new XFAC_Rpt013_Bus();
                List<XFAC_Rpt013_Info> oListado = new List<XFAC_Rpt013_Info>();

                int IdEmpresa = 0;
                decimal IdCliente = 0;
                DateTime FechaIni;
                DateTime FechaFin;


                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdCliente = Convert.ToInt32(PIdCliente.Value);
                FechaIni = Convert.ToDateTime(PFechaIni.Value);
                FechaFin = Convert.ToDateTime(PFechaFin.Value);
                
                oListado = oReporteBus.Get_List_Data_Reporte(IdEmpresa,IdCliente,FechaIni,FechaFin, ref mensaje);

                this.DataSource = oListado.ToArray(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt013_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt013_rpt) };
            }
        }
    }
}
