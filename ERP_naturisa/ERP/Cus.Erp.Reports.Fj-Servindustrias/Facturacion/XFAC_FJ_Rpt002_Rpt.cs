using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Collections.Generic;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XFAC_FJ_Rpt002_Bus Bus_Rpt002 = new XFAC_FJ_Rpt002_Bus();
        List<XFAC_FJ_Rpt002_Info> List_Rpt002 = new List<XFAC_FJ_Rpt002_Info>();

        public XFAC_FJ_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblLogo.Image = param.InfoEmpresa.em_logo_Image;
                lblIdUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

                int IdEmpresa = 0;
                decimal IdLiquidacion = 0;

                IdEmpresa = Convert.ToInt32(this.P_IdEmpresa.Value);
                IdLiquidacion = Convert.ToDecimal(this.P_Liquidacion.Value);

                List_Rpt002 = Bus_Rpt002.Get_List_Liquidacion(IdEmpresa, IdLiquidacion);

                this.DataSource = List_Rpt002.ToArray();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
