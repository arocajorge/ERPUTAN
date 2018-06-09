using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt004_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<int> lst_Motivo = new List<int>();
        List<XFAC_Rpt004_Info> lstInfo = new List<XFAC_Rpt004_Info>();

        public XFAC_Rpt004_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XFAC_Rpt004_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        public void Set_lista_motivo(List<int> _lista)
        {
            try
            {
                lst_Motivo = _lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_lista_motivo", ex.Message), ex) { EntityType = typeof(XFAC_Rpt004_rpt) };
            }
        }


        private void XFAC_Rpt004_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XFAC_Rpt004_Bus rptBus = new XFAC_Rpt004_Bus();
                

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;

                decimal IdClienteIni = 0;
                decimal IdClienteFin = 0;

                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                string TipoPago = "";
                string IdTipoDocumento = "";
                string TipoNota = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdClienteIni = Convert.ToDecimal(Parameters["IdClienteIni"].Value);
                IdClienteFin = Convert.ToDecimal(Parameters["IdClienteFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                TipoPago = Convert.ToString(Parameters["TipoPago"].Value);
                IdTipoDocumento = Convert.ToString(Parameters["IdTipoDocumento"].Value);
                TipoNota = Convert.ToString(this.PTipoNota.Value);
                lstInfo = rptBus.getDatosRpt_NDC_NDB(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaFin, TipoPago, IdTipoDocumento, lst_Motivo, TipoNota);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt004_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt004_rpt) };
            }
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {

                XFAC_Rpt004_Info Info_subrpt=lstInfo.FirstOrDefault();



                ((XRSubreport)sender).ReportSource.DataSource = Info_subrpt.list_resumen_x_Subtotal.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XFAC_Rpt004_rpt) };
            }

        }

    }
}
