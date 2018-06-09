using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;


namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public string nomSucursal { get; set; }
        public string nomActivo { get; set; }
        public string nomDepre { get; set; }
        public string nomEstado { get; set; }
        public string IdUsuario { get; set; }

        public XACTF_Rpt003_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XACTF_Rpt003_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XACTF_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt003_Bus busRpt = new XACTF_Rpt003_Bus();
                List<XACTF_Rpt003_Info> lstRpt = new List<XACTF_Rpt003_Info>();

                this.lblIdUsuario.Text = IdUsuario;
                this.lblNomSucursal.Text = nomSucursal;
                this.lblTipoActivo.Text = nomActivo;
                this.lblDepreciacion.Text = nomDepre;
                this.lblEstado.Text = nomEstado;

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdTipoDepreciacion = 0;
                int IdTipoActivo = 0;
                string IdEstadoProceso = "";
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdSucursalIni = Convert.ToInt32(this.IdSucursalIni.Value);
                IdSucursalFin = Convert.ToInt32(this.IdSucursalFin.Value);
                IdTipoDepreciacion = Convert.ToInt32(this.IdTipoDepreciacion.Value);
                IdTipoActivo = Convert.ToInt32(this.IdTipoActivo.Value);
                IdEstadoProceso = Convert.ToString(this.IdEstadoProceso.Value);
                FechaIni = Convert.ToDateTime(this.FechaIni.Value);
                FechaFin = Convert.ToDateTime(this.FechaFin.Value);

                lstRpt = busRpt.get_Activo_Caracteristica(IdEmpresa, IdSucursalIni, IdSucursalFin, IdTipoDepreciacion, IdTipoActivo, IdEstadoProceso, FechaIni, FechaFin);
                this.DataSource = lstRpt.ToArray();                
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt003_rpt) };
            }
        }

    }
}
