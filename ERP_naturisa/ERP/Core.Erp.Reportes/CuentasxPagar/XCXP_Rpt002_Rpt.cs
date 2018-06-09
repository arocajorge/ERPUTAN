using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XCXP_Rpt002_Bus repbus = new XCXP_Rpt002_Bus();

                List<XCXP_Rpt002_Info> ListDataRpt = new List<XCXP_Rpt002_Info>();

                int IdEmpresa = 0;
                decimal IdProveedor = 0;

                int IdClaseProveedorIni = 0;
                int IdClaseProveedorFin = 0;

                DateTime Fecha_Ini = DateTime.Now;
                DateTime Fecha_Fin = DateTime.Now;
                String mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdProveedor = Convert.ToDecimal(Parameters["IdProveedor"].Value);
                Fecha_Ini = Convert.ToDateTime(Parameters["Fecha_Ini"].Value);
                Fecha_Fin = Convert.ToDateTime(Parameters["Fecha_Fin"].Value);
                IdClaseProveedorIni = Convert.ToInt32(Parameters["IdClaseProveedorIni"].Value);
                IdClaseProveedorFin = Convert.ToInt32(Parameters["IdClaseProveedorFin"].Value);
                ListDataRpt = repbus.consultar_data(IdEmpresa, IdProveedor, Fecha_Ini, Fecha_Fin, IdClaseProveedorIni, IdClaseProveedorFin, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt002_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt002_Rpt) };
            }

            
        }

    }
}
