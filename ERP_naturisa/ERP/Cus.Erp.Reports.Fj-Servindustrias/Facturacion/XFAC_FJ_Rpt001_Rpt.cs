using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt001_Info> Lst_Rpt = new List<XFAC_FJ_Rpt001_Info>();
        XFAC_FJ_Rpt001_Bus bus_Rpt = new XFAC_FJ_Rpt001_Bus();

        public XFAC_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblLogo.Image = param.InfoEmpresa.em_logo_Image;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;

                int idEmpresa = 0;
                decimal idOrdenTrabajo = 0;

                idEmpresa = Convert.ToInt32(this.idEmpresa_P.Value);
                idOrdenTrabajo = Convert.ToDecimal(this.idOrdenTrabajo.Value);

                Lst_Rpt = bus_Rpt.Get_Orden_Trabajo(idEmpresa, idOrdenTrabajo);
                this.DataSource = Lst_Rpt;
                
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
