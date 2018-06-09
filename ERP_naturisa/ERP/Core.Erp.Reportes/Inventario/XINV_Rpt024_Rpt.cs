using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;
using System.IO;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt024_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string msg = "";
        public XINV_Rpt024_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt024_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                xlbl_idReporte.Text = "XINV_Rpt024_Rpt";

                string msg = "";
                XINV_Rpt024_Bus Bus = new XINV_Rpt024_Bus();
                List<XINV_Rpt024_Info> lista = new List<XINV_Rpt024_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                int IdBodega = 0;
                int IdMovi_inven_tipo = 0;
                decimal IdNumMovi = 0;
                string Tipo = "";
                
                DateTime FechaIni, FechaFin;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdSucursal = Convert.ToInt32(this.PIdSucursal.Value);
                IdBodega = Convert.ToInt32(this.PIdBodega.Value);
                IdMovi_inven_tipo = Convert.ToInt32(this.PIdMovi_inven_tipo.Value);
                IdNumMovi = Convert.ToDecimal(this.PIdNumMovi.Value);
                Tipo = Convert.ToString(this.PTipo.Value);
                FechaIni = Convert.ToDateTime(this.PFechaIni.Value);
                FechaFin = Convert.ToDateTime(this.PFechaFin.Value);

                lista = Bus.GetList_Data(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi, Tipo, FechaIni, FechaFin, ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt024_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt024_Rpt) };
            }
        }

    }
}
