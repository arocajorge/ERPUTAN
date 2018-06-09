using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt014_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        int IdEmpresa;
        int IdSucursal;
        int IdTipoAF;
        int IdCategoriaAF;
        DateTime Fecha_corte = DateTime.Now;

        public XACTF_Rpt014_Rpt()
        {
            InitializeComponent();
        }

        private void XACTF_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt014_Bus busRpt = new XACTF_Rpt014_Bus();
                List<XACTF_Rpt014_Info> lstInfo = new List<XACTF_Rpt014_Info>();
                string MensajeError="";


                //asigno a los label de empresa y fecha los respectivos datos quemados
                xrL_fecha.Text = DateTime.Now.ToLongDateString();
                lblEmpresa.Text = param.InfoEmpresa.em_nombre;

                IdEmpresa = Convert.ToInt32(this.PidEmpresa.Value);
                IdSucursal = Convert.ToInt32(PidSucursal.Value);
                IdTipoAF = Convert.ToInt32(PidTipoAF.Value);
                IdCategoriaAF = Convert.ToInt32(PidCategoriaAF.Value);
                Fecha_corte = Convert.ToDateTime(PFecha_corte.Value);
                lstInfo = busRpt.Consultar_Data(IdEmpresa, IdSucursal , IdTipoAF, IdCategoriaAF,Fecha_corte,param.IdUsuario, ref MensajeError);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt014_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt014_Rpt) };
            }
        }

    }
}
