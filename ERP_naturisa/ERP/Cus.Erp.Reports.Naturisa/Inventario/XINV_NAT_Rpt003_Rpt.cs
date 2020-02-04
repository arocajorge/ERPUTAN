using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public partial class XINV_NAT_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_NAT_Rpt003_Rpt()
        {
            InitializeComponent();
            lblEmpresa.Text = param.NombreEmpresa;
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void XINV_NAT_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblUsuario.Text = param.IdUsuario;

                XINV_NAT_Rpt003_Bus repbus = new XINV_NAT_Rpt003_Bus();
                List<XINV_NAT_Rpt003_Info> ListDataRpt = new List<XINV_NAT_Rpt003_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                int IdSucursal = 0;
                int IdBodega = 0;
                int IdMovi_inven_tipo = 0;
                decimal IdNumMovi = 0;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdSucursal = Convert.ToInt32(this.PIdSucursal.Value);
                IdBodega = Convert.ToInt32(this.PIdBodega.Value);
                IdMovi_inven_tipo = Convert.ToInt32(this.PIdMovi_inven_tipo.Value);
                IdNumMovi = Convert.ToInt32(this.PIdNumMovi.Value);

                ListDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_NAT_Rpt003_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_NAT_Rpt003_Rpt) };
            }
        }
    }
}
