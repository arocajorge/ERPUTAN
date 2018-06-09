using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        
        public XCXP_NATU_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                xrL_fecha.Text = DateTime.Now.ToLongDateString();


                lblEmpresa.Text = param.NombreEmpresa;




                XCXP_NATU_Rpt002_Bus repbus = new XCXP_NATU_Rpt002_Bus();

                List<XCXP_NATU_Rpt002_Info> ListDataRpt = new List<XCXP_NATU_Rpt002_Info>();


                int IdEmpresa = 0;

                Decimal IdProveedorIni = 0;
                Decimal IdProveedorFin = 0;
                int IdClaseProveedor_ini = 0;
                int IdClaseProveedor_fin = 0;
             
                DateTime Fecha_Ini = DateTime.Now;
                DateTime Fecha_Fin = DateTime.Now;
                bool Filtrar_fecha_emi = true;
                String mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                Fecha_Ini = Convert.ToDateTime(Parameters["Fecha_Ini"].Value).Date;
                Fecha_Fin = Convert.ToDateTime(Parameters["Fecha_Fin"].Value).Date;
                IdClaseProveedor_ini = Convert.ToInt32(IdClaseProveedorIni.Value);
                IdClaseProveedor_fin = Convert.ToInt32(IdClaseProveedorFin.Value);
                Filtrar_fecha_emi = Convert.ToBoolean(PFiltro_fecha_emi.Value);

                if (Convert.ToBoolean(PObservacion_completa.Value))
                    celObservacion.WordWrap = true;
                else
                    celObservacion.WordWrap = false;

                ListDataRpt = repbus.consultar_data(IdEmpresa, IdProveedorIni, IdProveedorFin, Fecha_Ini, Fecha_Fin,IdClaseProveedor_ini,IdClaseProveedor_fin,Filtrar_fecha_emi, ref mensaje);
                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt002_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt002_Rpt) };      
            }
            
            
        }

    }
}
