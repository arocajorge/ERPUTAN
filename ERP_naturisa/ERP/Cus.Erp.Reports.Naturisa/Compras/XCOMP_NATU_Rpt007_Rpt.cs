using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt007_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_NATU_Rpt007_Rpt()
        {
            InitializeComponent();
        }

        private void XCOMP_NATU_Rpt007_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLfecha.Text = DateTime.Now.ToString();
                lblEmpresa.Text = param.NombreEmpresa;
                lbl_usuario.Text = param.IdUsuario;
                lbl_ruc_direccion.Text = param.InfoEmpresa.em_ruc + " - " + param.InfoEmpresa.em_direccion;

                XCOMP_NATU_Rpt007_Bus repbus = new XCOMP_NATU_Rpt007_Bus();
                List<XCOMP_NATU_Rpt007_Info> listDataRpt = new List<XCOMP_NATU_Rpt007_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdOrdenCompra = 0;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdSucursal = Convert.ToInt32(this.PIdSucursal.Value);
                IdOrdenCompra = Convert.ToDecimal(this.PIdOrdenCompra.Value);

                listDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdOrdenCompra, ref mensaje);
                this.DataSource = listDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt001_Rpt) };
            }
        }
    }
}
