using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public partial class XINV_FJ_Rpt002_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_FJ_Rpt002_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_Rpt002_rpt";
        }

        private void XINV_FJ_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

                string msg = "";
                XINV_FJ_Rpt002_Bus OBUS = new XINV_FJ_Rpt002_Bus();

                List<XINV_FJ_Rpt002_Info> ListDataRpt = new List<XINV_FJ_Rpt002_Info>();

                DateTime FechaIni;
                DateTime FechaFin;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;
                string IdCentroCosto = "";
                string IdCentroCosto_sub_centro_costo = "";

                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdBodegaIni = Convert.ToInt32(Parameters["IdBodegaIni"].Value);
                IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                IdProductoIni = Convert.ToDecimal(Parameters["IdProductoIni"].Value);
                IdProductoFin = Convert.ToDecimal(Parameters["IdProductoFin"].Value);
                IdCentroCosto = (Parameters["IdCentroCosto"].Value).ToString();
                IdCentroCosto_sub_centro_costo = (Parameters["IdCentroCosto_sub_centro_costo"].Value).ToString();


                lblFechaInicio.Text = FechaIni.ToShortDateString();
                lblFechaFin.Text = FechaFin.ToShortDateString();
                xrPictureBox_Logo_Emp.Image = Core.Erp.Info.General.Funciones.ArrayAImage(param.InfoEmpresa.em_logo);


                ListDataRpt = OBUS.consultar_data(param.IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,
                    FechaIni, FechaFin, IdCentroCosto, IdCentroCosto_sub_centro_costo, ref msg);


                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_FJ_Rpt002_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_FJ_Rpt002_rpt) };
            }
        }

       



    }
}
