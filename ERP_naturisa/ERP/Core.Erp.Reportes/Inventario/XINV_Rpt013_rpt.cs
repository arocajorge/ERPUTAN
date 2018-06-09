using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt013_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XINV_Rpt013_Info> lst_reporte = new List<XINV_Rpt013_Info>();
        XINV_Rpt013_Bus bus_reporte = new XINV_Rpt013_Bus();
        List<int> lst_bodega = new List<int>();
        List<string> lst_subcentro = new List<string>();

        public XINV_Rpt013_Rpt()
        {
            InitializeComponent();
        }

        public void Set_listas(List<int> _lst_bodega, List<string> _lst_subcentro)
        {
            try
            {
                lst_bodega = _lst_bodega;
                lst_subcentro = _lst_subcentro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_listas", ex.Message), ex) { EntityType = typeof(XINV_Rpt013_Rpt) };
            }
        }

        private void XINV_Rpt013_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                int IdSucursal = 0;
                string IdCentroCosto = "";
                DateTime Fecha_ini = DateTime.Now;
                DateTime Fecha_fin = DateTime.Now;
                decimal IdProducto = 0;

                IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                IdCentroCosto = P_IdCentroCosto.Value.ToString();
                Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                IdProducto = Convert.ToDecimal(P_IdProducto.Value);
                lst_reporte = bus_reporte.Get_list(param.IdEmpresa, IdSucursal, lst_bodega,IdProducto, IdCentroCosto, lst_subcentro, Fecha_ini, Fecha_fin);
                this.DataSource = lst_reporte;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt013_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt013_Rpt) };
            }
        }

    }
}
