using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;

namespace Cus.Erp.Reports.Naturisa.Facturacion
{
    public partial class XFAC_CUS_NAT_Rpt002_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XFAC_CUS_NAT_Rpt002_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XFAC_CUS_NAT_Rpt002_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_CUS_NAT_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                XFAC_CUS_NAT_Rpt002_Bus rptBus = new XFAC_CUS_NAT_Rpt002_Bus();
                List<XFAC_CUS_NAT_Rpt002_Info> lstInfo = new List<XFAC_CUS_NAT_Rpt002_Info>();

                int IdEmpresa = 0, IdSucursalIni = 0, IdSucursalFin = 0, IdMotivo_VtaIni = 0, IdMotivo_VtaFin = 0;
                decimal IdClienteIni = 0;
                decimal IdClienteFin = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdClienteIni = Convert.ToDecimal(Parameters["IdClienteIni"].Value);
                IdClienteFin = Convert.ToDecimal(Parameters["IdClienteFin"].Value);
                IdMotivo_VtaIni = Convert.ToInt32(Parameters["IdMotivo_VtaIni"].Value);
                IdMotivo_VtaFin = Convert.ToInt32(Parameters["IdMotivo_VtaFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);


                lstInfo = rptBus.get_List_Facturas_x_Motivo(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, IdMotivo_VtaIni, IdMotivo_VtaFin, FechaIni, FechaFin);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_CUS_NAT_Rpt002_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_CUS_NAT_Rpt002_rpt) };       
            }
        }

    }
}
