using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt015_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 
        public XCXC_Rpt015_rpt()
        {
            InitializeComponent();
        }

        private void XCXC_Rpt015_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt015_Bus rptBus = new XCXC_Rpt015_Bus();
                List<XCXC_Rpt015_Info> lstRpt = new List<XCXC_Rpt015_Info>();
                
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                int si_clientes_legales = 0;
                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                FechaIni = Convert.ToDateTime(this.p_FechaIni.Value).Date;
                FechaFin = Convert.ToDateTime(this.p_FechaFin.Value).Date;
                si_clientes_legales = (int)Parameters["Clientes_legales"].Value;

                lstRpt = rptBus.get_DetalleCarteraVencida(IdEmpresa,0, IdSucursalIni, IdSucursalFin, FechaIni, FechaFin, si_clientes_legales);
                this.DataSource = lstRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt015_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt015_rpt) };
            }
        }

    }
}
