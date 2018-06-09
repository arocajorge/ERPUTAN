using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt028_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XINV_Rpt028_Bus bus_rpt = new XINV_Rpt028_Bus();
        List<XINV_Rpt028_Info> lst_rpt = new List<XINV_Rpt028_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt028_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt028_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                decimal IdProducto = 0;
                decimal IdProveedor = 0;
                decimal IdOrdenCompra = 0;
                int IdSucursal = 0;
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);

                IdProducto = Convert.ToDecimal(P_IdProducto.Value);
                IdProveedor = Convert.ToDecimal(P_IdProveedor.Value);
                IdOrdenCompra = Convert.ToDecimal(P_IdOrdenCompra.Value);
                IdSucursal = Convert.ToInt32(P_IdSucursal.Value);

                lst_rpt = bus_rpt.Get_list(param.IdEmpresa, IdProducto, IdProveedor, IdSucursal,IdOrdenCompra,Fecha_ini,Fecha_fin);
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt028_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt025_Rpt) };
            }
        }

    }
}
