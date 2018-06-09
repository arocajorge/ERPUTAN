using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt026_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XINV_Rpt026_Info> Lista = new List<XINV_Rpt026_Info>();
        XINV_Rpt026_Bus bus_Rpt = new XINV_Rpt026_Bus();

        public XINV_Rpt026_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt026_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;

                int IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                int IdBodega = Convert.ToInt32(P_IdBodega.Value);
                string IdCategoria = P_IdCategoria.Value.ToString();
                int IdLinea =  Convert.ToInt32(P_IdLinea.Value);
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                Lista = bus_Rpt.Get_list_reporte(param.IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Fecha_ini, Fecha_fin);
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
