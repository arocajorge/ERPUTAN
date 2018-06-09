using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public partial class XINV_NAT_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_NAT_Rpt004_Rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_NAT_Rpt004_Rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XINV_NAT_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                xrLUsuario.Text = param.IdUsuario;

                XINV_NAT_Rpt004_Bus repbus = new XINV_NAT_Rpt004_Bus();

                List<XINV_NAT_Rpt004_Info> ListDataRpt = new List<XINV_NAT_Rpt004_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdNumMovi = 0;
                int IdMovi_inven_tipo = 0;
                int IdBodega = 0;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdSucursal = Convert.ToInt32(this.PIdSucursal.Value);
                IdNumMovi = Convert.ToDecimal(this.PIdNumMovi.Value);
                IdMovi_inven_tipo = Convert.ToInt32(this.PIdMovi_inven_tipo.Value);
                IdBodega = Convert.ToInt32(this.PIdBodega.Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi, IdBodega, ref mensaje);


                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_Rpt003_Rpt_BeforePrint_1", ex.Message), ex) { EntityType = typeof(XINV_NAT_Rpt004_Rpt) };
            }
        }
    }
}
