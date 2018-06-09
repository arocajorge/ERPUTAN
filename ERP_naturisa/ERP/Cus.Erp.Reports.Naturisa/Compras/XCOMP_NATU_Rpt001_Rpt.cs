using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        public XCOMP_NATU_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XCOMP_NATU_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCOMP_NATU_Rpt001_Bus repbus = new XCOMP_NATU_Rpt001_Bus();

                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;

                List<XCOMP_NATU_Rpt001_Info> ListDataRpt = new List<XCOMP_NATU_Rpt001_Info>();
                int IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                int IdGrupo = Convert.ToInt32(P_IdGrupo.Value);
                int IdPunto_cargo = Convert.ToInt32(P_IdPunto_cargo.Value);
                decimal IdProducto = Convert.ToDecimal(P_IdProducto.Value);
                decimal IdProveedor = Convert.ToDecimal(P_IdProveedor.Value);
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
               decimal IdOrdenCompra = Convert.ToDecimal(P_IdOrdenCompra.Value);
               bool Mostrar_anuladas = Convert.ToBoolean(P_Mostrar_anuladas.Value);
               ListDataRpt = repbus.consultar_data(param.IdEmpresa, IdSucursal, IdOrdenCompra, IdProveedor, IdProducto, IdGrupo, IdPunto_cargo, Fecha_ini, Fecha_fin, Mostrar_anuladas);
                
                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_NATU_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_NATU_Rpt001_Rpt) };
            }

            
  

        }

        private void PageFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        

    }
}
