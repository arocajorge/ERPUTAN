using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt007_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXC_Rpt007_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XCXC_Rpt007_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            lblusuario.Text = param.IdUsuario;
        }

        private void XCXC_Rpt007_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt007_Bus rptBus = new XCXC_Rpt007_Bus();
                List<XCXC_Rpt007_Info> lstInfo = new List<XCXC_Rpt007_Info>();

                int IdEmpresa = 0;
                DateTime FechaCorte = DateTime.Now;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                decimal IdCliente = 0;
                bool Mostrar_solo_cbtes_con_saldo = true;

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value );
                FechaCorte = Convert.ToDateTime(PFechaCorte.Value );
                IdSucursalIni = Convert.ToInt32(PIdSucursalIni.Value );
                IdSucursalFin = Convert.ToInt32(PIdSucursalFin.Value );
                IdCliente = Convert.ToInt32(PIdCliente.Value);
                Mostrar_solo_cbtes_con_saldo = Convert.ToBoolean(PMostar_cbtes_con_saldo.Value);

                lstInfo = rptBus.get_ReporteCarteraVencida(IdEmpresa, IdSucursalIni, IdSucursalFin, IdCliente, FechaCorte, Mostrar_solo_cbtes_con_saldo);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt007_rpt) };
            }
        }

    }
}
