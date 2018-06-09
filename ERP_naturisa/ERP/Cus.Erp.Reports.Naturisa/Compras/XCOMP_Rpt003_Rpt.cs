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
    public partial class XCOMP_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
        {

            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            
        public XCOMP_Rpt003_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa, int IdSucursal, int IdBodega,decimal IdNumMovi, int IdMovi_inven_tipo)
        {
            try
            {
                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdSucursal.Value = IdSucursal;
                this.IdSucursal.Visible = false;

                this.IdBodega.Value = IdBodega;
                this.IdBodega.Visible = false;

                this.IdNumMovi.Value = IdNumMovi;
                this.IdNumMovi.Visible = false;

                this.IdMovi_inven_tipo.Value = IdMovi_inven_tipo;
                this.IdMovi_inven_tipo.Visible = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt003_Rpt) };
            }
        }

        
     
        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XCOMP_Rpt003_Rpt_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;


                XCOMP_Rpt003_Bus repbus = new XCOMP_Rpt003_Bus();

                List<XCOMP_Rpt003_Info> ListDataRpt = new List<XCOMP_Rpt003_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdNumMovi = 0;
                int IdMovi_inven_tipo = 0;
                int IdBodega = 0;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdNumMovi = Convert.ToDecimal(Parameters["IdNumMovi"].Value);
                IdMovi_inven_tipo = Convert.ToInt32(Parameters["IdMovi_inven_tipo"].Value);
                IdBodega = Convert.ToInt32(Parameters["IdBodega"].Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi, IdBodega, ref mensaje);


                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_Rpt003_Rpt_BeforePrint_1", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt003_Rpt) };
            }

            


        }

        private void xrLabel19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



        }                                                                    
            
    }
}
