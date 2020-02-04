using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_NATU_Rpt003_Rpt()
        {
            InitializeComponent();
        }

        private void XCOMP_NATU_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;
                XCOMP_NATU_Rpt003_Bus OBUS = new XCOMP_NATU_Rpt003_Bus();
                int IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                decimal IdOrdenCompra = Convert.ToDecimal(P_IdOrdenCompra.Value);
                decimal IdProveedor = Convert.ToDecimal(P_IdProveedor.Value);
                decimal IdProducto = Convert.ToDecimal(P_IdProducto.Value);
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                bool Mostrar_anuladas = Convert.ToBoolean(P_Mostrar_anuladas.Value);

                List<XCOMP_NATU_Rpt003_Info> ListDataRpt = new List<XCOMP_NATU_Rpt003_Info>();

                ListDataRpt = OBUS.consultar_data(param.IdEmpresa, IdSucursal, IdOrdenCompra, IdProveedor, IdProducto, Fecha_ini, Fecha_fin, Mostrar_anuladas);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_NATU_Rpt003_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_NATU_Rpt003_Rpt) };
            }

            
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

     

    }
}
