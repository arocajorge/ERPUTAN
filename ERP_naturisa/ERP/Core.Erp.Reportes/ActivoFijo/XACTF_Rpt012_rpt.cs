using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt012_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        int IdEmpresa;
        int IdSucursal;
        int IdDepartamento;
        int IdTipoAF;
        DateTime FechaCorte;
        int IdCategoriaAF;

        public XACTF_Rpt012_rpt()
        {
            InitializeComponent();
        }

        private void XACTF_Rpt012_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt012_Bus busRpt = new XACTF_Rpt012_Bus();
                List<XACTF_Rpt012_Info> lstInfo = new List<XACTF_Rpt012_Info>();
                string MensajeError = "";


                //asigno a los label de empresa y fecha los respectivos datos quemados
                xrL_fecha.Text = DateTime.Now.ToLongDateString();
                lblEmpresa.Text = param.InfoEmpresa.em_nombre;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdSucursal = Convert.ToInt32(PIdSucursal.Value);
                IdDepartamento = Convert.ToInt32(PIdDepartamento.Value);
                IdTipoAF = Convert.ToInt32(PIdTipoAF.Value);
                FechaCorte = Convert.ToDateTime(PFechaCorte.Value);
                IdCategoriaAF = Convert.ToInt32(PIdCategoriaAF.Value);

                lstInfo = busRpt.Consultar_Data(IdEmpresa, IdTipoAF, IdCategoriaAF, IdSucursal, IdDepartamento, FechaCorte,param.IdUsuario, ref MensajeError);
                this.DataSource = lstInfo.ToArray();

            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt012_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt012_rpt) };
            }
        }

        private void XACTF_Rpt012_rpt_AfterPrint(object sender, EventArgs e)
        {
           
        }

    }
}
