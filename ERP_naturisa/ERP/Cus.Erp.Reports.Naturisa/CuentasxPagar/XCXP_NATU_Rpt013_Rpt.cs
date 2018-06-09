using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt013_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XCXP_NATU_Rpt013_Info> lst_rpt = new List<XCXP_NATU_Rpt013_Info>();
        XCXP_NATU_Rpt013_Bus bus_rpt = new XCXP_NATU_Rpt013_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public XCXP_NATU_Rpt013_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt013_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                int IdClaseProveedor = Convert.ToInt32(P_IdClaseProveedor.Value);
                decimal IdProveedor = Convert.ToDecimal(P_IdProveedor.Value);
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                bool Mostrar_cuenta = Convert.ToBoolean(P_Mostrar_cuenta.Value);
                
                if (!Mostrar_cuenta)
                    cel_cuenta_observacion_cab.Text = "Detalle";
                else
                    cel_cuenta_observacion_cab.Text = "Cuenta";

                lst_rpt = bus_rpt.Get_list(param.IdEmpresa,IdClaseProveedor, IdProveedor, Fecha_ini, Fecha_fin, Mostrar_cuenta);
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
