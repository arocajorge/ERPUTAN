using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XINV_Rpt004_Rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_Rpt004_Rpt";
        }


        private void XINV_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

                string mensaje = "";

                XINV_Rpt004_Bus Ingrdata = new XINV_Rpt004_Bus();

                List<XINV_Rpt004_Info> lista = new List<XINV_Rpt004_Info>();

                DateTime Fecha_oc_Ini;
                DateTime Fecha_oc_Fin;
                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;
                int IdEmpresa = 0;
                int IdSucursal_inv_Ini = 0;
                int IdSucursal_inv_Fin = 0;
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;

                Fecha_oc_Ini = Convert.ToDateTime(Parameters["Fecha_oc_Ini"].Value);
                Fecha_oc_Fin = Convert.ToDateTime(Parameters["Fecha_oc_Fin"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal_inv_Ini = Convert.ToInt32(Parameters["IdSucursal_inv_Ini"].Value);
                IdSucursal_inv_Fin = Convert.ToInt32(Parameters["IdSucursal_inv_Fin"].Value);
                IdProductoIni = Convert.ToDecimal(Parameters["IdProductoIni"].Value);
                IdProductoFin = Convert.ToDecimal(Parameters["IdProductoFin"].Value);

                lista = Ingrdata.consultar_data(IdEmpresa, IdSucursal_inv_Ini, IdSucursal_inv_Fin, IdProductoIni, IdProductoFin, IdProveedorIni, IdProveedorFin, Fecha_oc_Ini, Fecha_oc_Fin, ref mensaje);

                this.DataSource = lista;
        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt004_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt004_Rpt) };
             
            }
        }

    }
}
