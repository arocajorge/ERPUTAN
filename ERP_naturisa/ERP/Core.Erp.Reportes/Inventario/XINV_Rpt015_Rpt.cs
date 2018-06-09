using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.IO;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Reportes;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt015_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<int> lst_bodega = new List<int>();
        List<string> lst_subcentro = new List<string>();

        public XINV_Rpt015_Rpt()
        {
            InitializeComponent();
        }

        public void Set_listas(List<int> _lst_bod, List<string> _lst_sub)
        {
            try
            {
                lst_bodega = _lst_bod;
                lst_subcentro = _lst_sub;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt015_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt015_Rpt) };
            }
        }

      private void XINV_Rpt015_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XINV_Rpt015_Bus repbus = new XINV_Rpt015_Bus();
                List<XINV_Rpt015_Info> ListDataRpt = new List<XINV_Rpt015_Info>();
                lblEmpresa.Text = param.NombreEmpresa;
                int IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                decimal IdProducto = Convert.ToDecimal(P_IdProducto.Value);
                string IdCentroCosto = Convert.ToString(P_IdCentroCosto.Value);
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                bool Mostrar_anuladas = Convert.ToBoolean(P_Mostrar_anuladas.Value);

                ListDataRpt = repbus.consultar_data(param.IdEmpresa, IdSucursal, lst_bodega, IdProducto, IdCentroCosto, lst_subcentro, Fecha_ini, Fecha_fin, Mostrar_anuladas);
                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt015_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt015_Rpt) };
            }

        }

    }
}
