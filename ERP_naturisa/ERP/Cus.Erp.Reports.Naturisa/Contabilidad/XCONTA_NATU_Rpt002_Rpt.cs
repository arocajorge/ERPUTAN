using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    public partial class XCONTA_NATU_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_NATU_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_NATU_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLEmpresa.Text = param.InfoEmpresa.em_nombre;
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = Convert.ToString(param.Fecha_Transac);


                // Reporte.Parameters["S_empresa"].Value = param.EmpresaInfo.em_nombre;

                XCONTA_NATU_Rpt002_Bus repbus = new XCONTA_NATU_Rpt002_Bus();

                List<XCONTA_NATU_Rpt002_Info> ListDataRpt = new List<XCONTA_NATU_Rpt002_Info>();

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

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_NATU_Rpt002_Rpt) };
            }
        }
    }
}
