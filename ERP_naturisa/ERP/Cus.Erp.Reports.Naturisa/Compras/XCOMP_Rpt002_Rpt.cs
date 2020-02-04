using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;
using DevExpress.XtraReports.Parameters;

using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt002_Rpt()
        { 
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa ,int IdSucursal, decimal IdSolicitudCompra )
        {
           
            try
            {
                
                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdSucursal.Value = IdSucursal;
                this.IdSucursal.Visible = false;

                this.IdSolicitudCompra.Value  = IdSolicitudCompra;
                this.IdSolicitudCompra.Visible = false;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt002_Rpt) };
            }
        }



        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XCOMP_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLfecha.Text = DateTime.Now.ToString();
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrLusuario.Text = param.IdUsuario;

                XCOMP_Rpt002_Bus repbus = new XCOMP_Rpt002_Bus();
                List<XCOMP_Rpt002_Info> listDataRpt = new List<XCOMP_Rpt002_Info>();

                string mensaje = "";
                int IdEmpresa = 0;

                int IdSucursal = 0;
                decimal IdSolicitudCompra = 0;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdSolicitudCompra = Convert.ToDecimal(Parameters["IdSolicitudCompra"].Value);

                listDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdSolicitudCompra, ref mensaje);

                this.DataSource = listDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt002_Rpt) };
            }

            
        }

    }
}
