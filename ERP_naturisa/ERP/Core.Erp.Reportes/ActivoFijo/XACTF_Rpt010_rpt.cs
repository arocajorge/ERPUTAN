using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt010_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public string IdUsuario { get; set; }
        public string nomActivoFijo { get; set; }
        public string Tipo_Af { get; set; }

        public XACTF_Rpt010_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XACTF_Rpt010_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XACTF_Rpt010_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt010_Bus busRpt = new XACTF_Rpt010_Bus();
                List<XACTF_Rpt010_Info> lstInfo = new List<XACTF_Rpt010_Info>();

                this.lblIdActivoFijo.Text = nomActivoFijo;
                this.lblIdUsuario.Text = IdUsuario;
                this.lblTipoActivo.Text = Tipo_Af;

                int IdEmpresa = 0;
                int IdActivoFijo = 0;
                int IdActivoFijoTipo = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdActivoFijo = Convert.ToInt32(this.IdActivoFijo.Value);
                IdActivoFijoTipo = Convert.ToInt32(this.IdActivoFijoTipo.Value);
                FechaIni = Convert.ToDateTime(this.FechaIni.Value);
                FechaFin = Convert.ToDateTime(this.FechaFin.Value);


                lstInfo = busRpt.get_CambioUbica_AF(IdEmpresa, IdActivoFijo, IdActivoFijoTipo, FechaIni, FechaFin);
                this.DataSource = lstInfo.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt010_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt010_rpt) };
            }
        }

    }
}
