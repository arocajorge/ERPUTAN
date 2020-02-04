using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.CAH.Compras
{
    public partial class XCOMP_CAH_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string estado = "";

        public XCOMP_CAH_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int PIdEmpresa, int PIdSucursal, decimal PIdOrdenCompra, string Estado)
        {
            try
            {
                this.PIdEmpresa.Value = PIdEmpresa;
                this.PIdEmpresa.Visible = false;

                this.PIdSucursal.Value = PIdSucursal;
                this.PIdSucursal.Visible = false;

                this.PIdOrdenCompra.Value = PIdOrdenCompra;
                this.PIdOrdenCompra.Visible = false;

                estado = Estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCOMP_CAH_Rpt001_Rpt) };
            }
        }

        private void XCOMP_CAH_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLfecha.Text = DateTime.Now.ToString();
                lblEmpresa.Text = param.NombreEmpresa;
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lbl_ruc_direccion.Text = "Ruc: " + param.InfoEmpresa.em_ruc + " / Dir: " + param.InfoEmpresa.em_direccion;

                if (estado == "I")
                {
                    xrTable6.Visible = true;
                    lbl_anulado.Visible = true;
                    lbl_motivo_anulacion.Visible = true;
                    lbl_concepto_anulacion.Visible = true;
                }

                XCOMP_CAH_Rpt001_Bus repbus = new XCOMP_CAH_Rpt001_Bus();
                List<XCOMP_CAH_Rpt001_Info> listDataRpt = new List<XCOMP_CAH_Rpt001_Info>();

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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_CAH_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_CAH_Rpt001_Rpt) };
            }
        }
    }
}
