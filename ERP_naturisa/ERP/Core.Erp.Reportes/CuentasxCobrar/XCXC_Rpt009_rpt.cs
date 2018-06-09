using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt009_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXC_Rpt009_rpt()
        {
            InitializeComponent();
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXC_Rpt009_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt009_Bus rptBus = new XCXC_Rpt009_Bus();
                List<XCXC_Rpt009_Info> lstRpt = new List<XCXC_Rpt009_Info>();

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdCliente = 0;
                int IdTipoCliente = 0;
                DateTime FechaCorte = DateTime.Now;
                IdEmpresa  =  Convert.ToInt32(this.IdEmpresa.Value );
                IdCliente = Convert.ToInt32(this.PIdCliente.Value);
                IdSucursalIni = Convert.ToInt32(this.IdSucursalIni.Value);
                IdSucursalFin = Convert.ToInt32(this.IdSucursalFin.Value);
                FechaCorte = Convert.ToDateTime(this.FechaCorte.Value).Date;
                IdTipoCliente = Convert.ToInt32(this.PIdTipo_Cliente.Value);
                


                lstRpt = rptBus.get_DetalleCarteraVencida(IdEmpresa, IdCliente, IdSucursalIni, IdSucursalFin, FechaCorte, IdTipoCliente);
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt009_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt009_rpt) };
            }
        }



    }
}
