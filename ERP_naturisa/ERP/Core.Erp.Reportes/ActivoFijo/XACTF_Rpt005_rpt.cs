using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt005_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public string IdUsuario { get; set; }
        public string nomDepre { get; set; }
        public string nomActivoFijo { get; set; }
        public string PeriodoIni { get; set; }
        public string PeriodoFin { get; set; }

        public XACTF_Rpt005_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XACTF_Rpt005_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XACTF_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt005_Bus busRpt = new XACTF_Rpt005_Bus();
                List<XACTF_Rpt005_Info> lstRpt = new List<XACTF_Rpt005_Info>();

                this.lblIdUsuario.Text = IdUsuario;
                this.lblIdActivoFijo.Text = nomActivoFijo;
                this.lblDepreciacion.Text = nomDepre;
                this.lblPeriodoIni.Text = PeriodoIni;
                this.lblPeriodoFin.Text = PeriodoFin;
                

                int IdEmpresa = 0;
                int IdTipoDepreciacion = 0;
                int IdActivoFijo = 0;
                int IdPeriodoIni = 0;
                int IdPeriodoFin = 0;

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdTipoDepreciacion = Convert.ToInt32(this.IdTipoDepreciacion.Value);
                IdActivoFijo = Convert.ToInt32(this.IdActivoFijo.Value);
                IdPeriodoIni = Convert.ToInt32(this.IdPeriodoIni.Value);
                IdPeriodoFin = Convert.ToInt32(this.IdPeriodoFin.Value);

                lstRpt = busRpt.get_RptImporteMensual(IdEmpresa, IdTipoDepreciacion, IdActivoFijo, IdPeriodoIni, IdPeriodoFin);
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt005_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt005_rpt) };
            }
        }

    }
}
