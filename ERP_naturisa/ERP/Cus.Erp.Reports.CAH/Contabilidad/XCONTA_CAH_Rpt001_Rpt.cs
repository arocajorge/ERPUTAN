using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;
namespace Cus.Erp.Reports.CAH.Contabilidad
{
    public partial class XCONTA_CAH_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_CAH_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {

            try
            {

                this.PIdEmpresa.Value = IdEmpresa;
                this.PIdEmpresa.Visible = false;

                this.PIdTipoCbte.Value = IdTipoCbte;
                this.PIdTipoCbte.Visible = false;

                this.PIdCbteCble.Value = IdCbteCble;
                this.PIdCbteCble.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCONTA_CAH_Rpt001_Rpt) };
            }
        }

        private void XCONTA_CAH_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLEmpresa.Text = param.InfoEmpresa.em_nombre;

                lbl_usuario.Text = param.IdUsuario;
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrLFecha.Text = Convert.ToString(param.Fecha_Transac);

                // Reporte.Parameters["S_empresa"].Value = param.EmpresaInfo.em_nombre;

                XCONTA_CAH_Rpt001_Bus repbus = new XCONTA_CAH_Rpt001_Bus();

                List<XCONTA_CAH_Rpt001_Info> ListDataRpt = new List<XCONTA_CAH_Rpt001_Info>();

                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                Decimal IdCbteCble = 0;


                //Decimal IdProveedorFin = 0;
                //DateTime Fecha_OC_Ini = DateTime.Now;
                //DateTime Fecha_OC_Fin = DateTime.Now;
                String mensaje = "";

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdTipoCbte = Convert.ToInt32(this.PIdTipoCbte.Value);
                IdCbteCble = Convert.ToDecimal(this.PIdCbteCble.Value);
                // Fecha_OC_Ini = Convert.ToDateTime(Parameters["Fecha_OC_Ini"].Value);

                ListDataRpt = repbus.consultar_data(IdEmpresa, IdTipoCbte, IdCbteCble, ref  mensaje);


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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_CAH_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_CAH_Rpt001_Rpt) };
            }
        }
    }
}
