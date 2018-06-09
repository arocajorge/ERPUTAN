using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt006_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<XCAJ_Rpt006_Info> lst_rpt = new List<XCAJ_Rpt006_Info>();
        XCAJ_Rpt006_Bus bus_rpt = new XCAJ_Rpt006_Bus();
        public XCAJ_Rpt006_Rpt()
        {
            InitializeComponent();
        }

        private void XCAJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;

                int IdCaja = Convert.ToInt32(P_IdCaja.Value);
                int IdTipoMovi = Convert.ToInt32(P_IdTipoMovi.Value);
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                decimal IdConciliacion = Convert.ToDecimal(P_IdConciliacion.Value);
                int IdPunto_cargo = Convert.ToInt32(P_IdPunto_cargo.Value);
                lst_rpt = bus_rpt.Get_list_reporte(param.IdEmpresa, IdCaja, IdTipoMovi, IdConciliacion, Fecha_ini, Fecha_fin, IdPunto_cargo);
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
