using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt027_Rpt_detallado : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XINV_Rpt027_Info> Lista = new List<XINV_Rpt027_Info>();
        XINV_Rpt027_Bus bus_Rpt = new XINV_Rpt027_Bus();
        List<int> lst_bodega = new List<int>();

        public XINV_Rpt027_Rpt_detallado()
        {
            InitializeComponent();
        }

        public void Set_lst_bodega(List<int> lst_bodega_int)
        {
            try
            {
                lst_bodega = lst_bodega_int;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt026_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt025_Rpt) };
            }
        }

        private void XINV_Rpt027_Rpt_detallado_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = param.Fecha_Transac.ToString();
                bool Mostrar_detallado = Convert.ToBoolean(P_Mostrar_detallado.Value);
                Lista = bus_Rpt.Get_List(Convert.ToDateTime(P_Fecha_desde.Value), Convert.ToDateTime(P_Fecha_hasta.Value), param.IdEmpresa, Convert.ToInt32(P_IdSucursal.Value), lst_bodega, Convert.ToDecimal(P_IdProducto.Value),param.IdUsuario,Convert.ToBoolean(P_Mostrar_registros_0.Value), Mostrar_detallado);
                this.DataSource = Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt026_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt025_Rpt) };
            }
        }

    }
}
