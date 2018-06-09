using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;

using Core.Erp.Business.General;

using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        
        public XCXP_Rpt011_rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt011_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                xrL_fecha.Text = DateTime.Now.ToLongDateString();
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.NombreEmpresa;
                XCXP_Rpt011_Bus repbus = new XCXP_Rpt011_Bus();

                List<XCXP_Rpt011_Info> ListDataRpt = new List<XCXP_Rpt011_Info>();
                  
               int IdEmpresa = 0;

               Decimal IdProveedorIni = 0;
               Decimal IdProveedorFin = 0;

               DateTime FechaIni = DateTime.Now;
               DateTime FechaFin = DateTime.Now;
               String mensaje = "";
                                           
              IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
              IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
              IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
              FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
              FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);

            

             ListDataRpt = repbus.consultar_data(IdEmpresa, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin, ref  mensaje);

             string format = "dd/MM/yyyy";

             foreach (var item in ListDataRpt)
             {
                 item.s_Fecha = item.co_FechaFactura.ToString(format);
             }


             this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt011_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt011_rpt) };
            }
        }

      

    }
}
