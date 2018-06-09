using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt016_Rpt()
        {
            InitializeComponent();
        }

        
        private void XINV_Rpt016_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                string MensajeError = "";
                XINV_Rpt016_Bus OBUS = new XINV_Rpt016_Bus();

                List<XINV_Rpt016_Info> ListDataRpt = new List<XINV_Rpt016_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                string IdCentroCosto = "";
                string IdSubCentroCosto = "";
                string IdPuntoCargo = "";
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;
                DateTime FechaIni;
                DateTime FechaFin;

                IdEmpresa = Convert.ToInt32(P_IdEmpresa.Value);
                IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                IdCentroCosto = Convert.ToString(P_IdCentroCosto.Value);
                IdSubCentroCosto = Convert.ToString(P_IdSubCentroCosto.Value);
                IdPuntoCargo = Convert.ToString(P_IdPtoCargo.Value);
                IdProductoIni = Convert.ToDecimal(P_IdProductoIni.Value);
                IdProductoFin = Convert.ToDecimal(P_IdProductoFin.Value);
                FechaIni = Convert.ToDateTime(P_FechaIni.Value);
                FechaFin = Convert.ToDateTime(P_FechaFin.Value);


                ListDataRpt = OBUS.Get_List_Consumo_Detalle(IdEmpresa, IdSucursal, IdCentroCosto, IdSubCentroCosto, IdPuntoCargo, IdProductoIni, IdProductoFin, FechaIni, FechaFin, "-", ref MensajeError);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt015_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt016_Rpt) };
            }


        }

    }
}
