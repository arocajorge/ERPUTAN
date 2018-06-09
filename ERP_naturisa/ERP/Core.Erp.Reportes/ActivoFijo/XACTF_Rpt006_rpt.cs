using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt006_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public string IdUsuario { get; set; }
        public string nomActivoFijo { get; set; }
        public string Tipo_Af { get; set; }

        public XACTF_Rpt006_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XACTF_Rpt006_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XACTF_Rpt006_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt006_Bus busRpt = new XACTF_Rpt006_Bus();
                List<XACTF_Rpt006_Info> lstRpt = new List<XACTF_Rpt006_Info>();

                this.lblIdUsuario.Text = IdUsuario;
                this.lblIdActivoFijo.Text = nomActivoFijo;
                this.lblTipo.Text = Tipo_Af;

                int IdEmpresa = 0;
                int IdActivoFijo = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                string Estado = "A";
                string Id_Tipo = "";

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                Id_Tipo = Convert.ToString(this.Tipo.Value);
                IdActivoFijo = Convert.ToInt32(this.IdActivoFijo.Value);
                FechaIni = Convert.ToDateTime(this.FechaIni.Value);
                FechaFin = Convert.ToDateTime(this.FechaFin.Value);

                lstRpt = busRpt.get_MejoraBaja_ActivoFijo(IdEmpresa, Id_Tipo, IdActivoFijo, Estado, FechaIni, FechaFin);
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt006_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt006_rpt) };
            }
        }

    }
}
