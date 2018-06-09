using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XCAJ_Rpt003_Rpt()
        {
            InitializeComponent();
            lblusuario.Text = param.IdUsuario.ToString();
            lblfechaHoy.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void XCAJ_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCAJ_Rpt003_Bus Rpt_Bus = new XCAJ_Rpt003_Bus();
                List<XCAJ_Rpt003_Info> ListRpt = new List<XCAJ_Rpt003_Info>();
                lblEmpresa.Text = param.NombreEmpresa;
                int IdEmpresa = 0;
                decimal IdConciliacion_Caja = 0;

                xrPictureBoxLogo.Image = param.InfoEmpresa.em_logo_Image;
                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdConciliacion_Caja = Convert.ToDecimal(this.PIdConciliacion_Caja.Value);
                
                ListRpt = Rpt_Bus.Get_List_Conciliacion_Caja_X_Usuario(IdEmpresa, IdConciliacion_Caja);

                this.DataSource = ListRpt.ToArray();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCAJ_Rpt003_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt003_Rpt) };
            }
        }
    }
}
