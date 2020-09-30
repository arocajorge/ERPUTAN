using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using DevExpress.XtraRichEdit.API.Word;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt021_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt021_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt021_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_empresa.Text = param.NombreEmpresa;
                lblFechaImpresion.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;

                int idSucursalIni = 0;
                int idSucursalFin = 0;
                int idBodegaIni = 0;
                int idBodegaFin = 0;
                int idProductoIni = 0;
                int idProductoFin = 0;
                int DiasStock = 0;
                DateTime FechaDesde = DateTime.Now;
                DateTime FechaHasta = DateTime.Now;
                Boolean MostrarCero = false;

                idSucursalIni=Convert.ToInt32(this.Parameters["idSucursalIni"].Value);
                idSucursalFin = Convert.ToInt32(this.Parameters["idSucursalFin"].Value);
                idBodegaIni = Convert.ToInt32(this.Parameters["idBodegaIni"].Value);
                idBodegaFin = Convert.ToInt32(this.Parameters["idBodegaFin"].Value);
                idProductoIni = Convert.ToInt32(this.Parameters["idProductoIni"].Value);
                idProductoFin = Convert.ToInt32(this.Parameters["idProductoFin"].Value);
                DiasStock = Convert.ToInt32(this.Parameters["DiasStock"].Value);
                FechaDesde = Convert.ToDateTime(this.Parameters["FechaDesde"].Value);
                FechaHasta = Convert.ToDateTime(this.Parameters["FechaHasta"].Value);
                MostrarCero = Convert.ToBoolean(this.Parameters["MostrarCero"].Value);

                XINV_Rpt021_Bus oBus = new XINV_Rpt021_Bus();
                List<XINV_Rpt021_Info> lstInfo = new List<XINV_Rpt021_Info>();
                lstInfo = oBus.Get_Lista_Reporte(param.IdEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, idProductoIni, idProductoFin, FechaDesde, FechaHasta, DiasStock,MostrarCero);

                this.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt021_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt021_Rpt) };
            }
        }

    }
}
