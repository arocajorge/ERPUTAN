using System;
using System.Drawing;

using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Core.Erp.Business.General;


namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCOMP_NATU_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XCOMP_NATU_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLusuario.Text = param.IdUsuario;
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrLfecha.Text = DateTime.Now.ToString();

                XCOMP_NATU_Rpt002_Bus repbus = new XCOMP_NATU_Rpt002_Bus();

                List<XCOMP_NATU_Rpt002_Info> ListDataRpt = new List<XCOMP_NATU_Rpt002_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                Decimal IdProveedorIni = 0;


                Decimal IdProveedorFin = 0;
                DateTime Fecha_OC_Ini = DateTime.Now;
                DateTime Fecha_OC_Fin = DateTime.Now;
                String mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                Fecha_OC_Ini = Convert.ToDateTime(Parameters["Fecha_OC_Ini"].Value);
                Fecha_OC_Fin = Convert.ToDateTime(Parameters["Fecha_OC_Fin"].Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdProveedorIni, IdProveedorFin, Fecha_OC_Ini, Fecha_OC_Fin, ref  mensaje);


                if (ListDataRpt.Count == 0)
                {
                    xrLmensaje.Visible = true;
                    xrLmensaje.Text = "No hay datos encontrados para estos filtros";

                }
                else
                {
                    xrLmensaje.Visible = false;
                }

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_NATU_Rpt002_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_NATU_Rpt002_Rpt) };
            }

            
        }

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
