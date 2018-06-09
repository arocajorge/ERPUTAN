using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt018_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;
        
        int IdProductoIni = 0;
        int IdProductoFin = 0;
        DateTime FechaIni;
        DateTime FechaFin;
        int dias_stock=0;
        string msg = "";
        Boolean mostrar_datos;

        public XINV_Rpt018_Rpt()
        {
            InitializeComponent();
           
        }

        private void XINV_Rpt018_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblFechaImpresion.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;

                XINV_Rpt018_Bus oBus = new XINV_Rpt018_Bus();
                List<XINV_Rpt018_Info> Lista = new List<XINV_Rpt018_Info>();

                IdSucursalIni = Convert.ToInt32(Parameters["PIdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["PIdSucursalFin"].Value);
                IdBodegaIni = Convert.ToInt32(Parameters["PIdBodegaIni"].Value);
                IdBodegaFin = Convert.ToInt32(Parameters["PIdBodegaFin"].Value);
                //IdCategoria = Convert.ToString(Parameters["PIdCategoria"]);
                IdProductoIni = Convert.ToInt32(Parameters["PIdProductoIni"].Value);
                IdProductoFin = Convert.ToInt32(Parameters["PIdProductoFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["PFechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["PFechaFin"].Value);
                dias_stock = Convert.ToInt32(Parameters["Pdias_stock"].Value);
                mostrar_datos = Convert.ToBoolean(Parameters["PMostrar_reg_en_cero"].Value);

                Lista = oBus.Get_List(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, FechaFin, dias_stock, mostrar_datos, ref msg);

                this.DataSource = Lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt018_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt018_Rpt) };
            }
        }
    }
}
