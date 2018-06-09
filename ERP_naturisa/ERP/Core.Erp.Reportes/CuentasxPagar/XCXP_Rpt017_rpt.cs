using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt017_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public XCXP_Rpt017_rpt()
        {
            InitializeComponent();

            this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXP_Rpt017_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;


                lblEmpresa.Text = param.InfoEmpresa.em_nombre;


                XCXP_Rpt017_Bus rptBus = new XCXP_Rpt017_Bus();
                List<XCXP_Rpt017_Info> lstInfo = new List<XCXP_Rpt017_Info>();

                int IdEmpresa = 0;
                DateTime FechaCorte;
                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;
               


                string S_FechaCorte = "";
                string S_Proveedor = "";
               

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                FechaCorte = Convert.ToDateTime(Parameters["FechaCorte"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);

                S_FechaCorte = Convert.ToString(Parameters["S_FechaCorte"].Value);
                S_Proveedor = Convert.ToString(Parameters["S_Proveedor"].Value);

                lstInfo = rptBus.get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin);

                this.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt017_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt017_rpt) };
            }
        }

    }
}
