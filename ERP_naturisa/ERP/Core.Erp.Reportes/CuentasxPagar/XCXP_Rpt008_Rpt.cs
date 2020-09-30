using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using DevExpress.XtraRichEdit.API.Word;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt008_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XCXP_Rpt008_Info> lst_rpt = new List<XCXP_Rpt008_Info>();
        XCXP_Rpt008_Bus bus_rpt = new XCXP_Rpt008_Bus();

        public XCXP_Rpt008_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt008_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                int IdClase = Convert.ToInt32(P_IdClase_prov.Value);
                decimal IdProveedor = Convert.ToDecimal(P_IdProveedor.Value);               
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                bool Mostrar_anuladas = Convert.ToBoolean(P_Mostrar_anuladas.Value);
                bool Mostrar_saldo_0 = Convert.ToBoolean(P_Mostrar_saldo_0.Value);

                lst_rpt = bus_rpt.Get_list(param.IdEmpresa, IdClase, IdProveedor, Fecha_fin,Mostrar_anuladas,Mostrar_saldo_0);
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
