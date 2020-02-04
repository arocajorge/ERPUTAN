using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public partial class XCOL_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string estado = "";

        public XCOL_Rpt001_Rpt()
        {
            InitializeComponent();
        }
        public void set_parametros(int pIdSede,int pIdSeccion)
        {
            try
            {
                this.pIdSede.Value = pIdSede;
                this.pIdSeccion.Value = pIdSeccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCOL_Rpt001_Rpt) };
            }
        }

        private void XCOL_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //xrLfecha.Text = DateTime.Now.ToString();
                //lblEmpresa.Text = param.NombreEmpresa;
                ////pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                //lbl_ruc_direccion.Text = "Dir: " + param.InfoEmpresa.em_direccion;
                //lblRuc.Text = "Ruc: " + param.InfoEmpresa.em_ruc;
                this.pFechaReporte.Value = DateTime.Now.ToString();
                this.pEmpresa.Value = param.InfoEmpresa.em_nombre;
                this.pDireccion.Value = param.InfoEmpresa.em_direccion;
                //this.pRuc.Value = "";
                lblRuc.Text = param.InfoEmpresa.em_ruc;
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XCOL_Rpt001_Bus repbus = new XCOL_Rpt001_Bus();
                List<XCOL_Rpt001_Info> listDataRpt = new List<XCOL_Rpt001_Info>();

                string mensaje = "";
                int IdSede = 0;
                int IdSeccion = 0;

                IdSede = Convert.ToInt32(this.pIdSede.Value);
                IdSeccion = Convert.ToInt32(this.pIdSeccion.Value);

                listDataRpt = repbus.consultar_data(IdSede);
                this.DataSource = listDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_CAH_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOL_Rpt001_Rpt) };
            }
        }
    }
}
