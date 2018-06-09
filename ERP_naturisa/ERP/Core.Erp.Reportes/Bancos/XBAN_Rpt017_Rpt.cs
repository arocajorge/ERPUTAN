using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt017_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt017_Rpt()
        {
            InitializeComponent();
        }

        public void AsignarLista(List<ba_Cbte_Ban_Info> Lista)
        {
            try
            {
                this.DataSource = Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AsignarLista", ex.Message), ex) { EntityType = typeof(XBAN_Rpt017_Rpt) };
            }
        }

        private void XBAN_Rpt017_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;
                xrPictureBoxLogo.Image = param.InfoEmpresa.em_logo_Image;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt017_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt017_Rpt) };
            }
        }

    }
}
