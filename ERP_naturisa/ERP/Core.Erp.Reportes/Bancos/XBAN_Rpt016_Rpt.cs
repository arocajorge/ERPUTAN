using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        XBAN_Rpt016_Bus oBus = new XBAN_Rpt016_Bus();
        List<XBAN_Rpt016_Info> lstInfo = new List<XBAN_Rpt016_Info>();

        public XBAN_Rpt016_Rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt016_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;
                xrPictureBoxLogo.Image = param.InfoEmpresa.em_logo_Image;

                int idEmpresa = 0;
                int idPersonaIni = 0;
                int idPersonaFin = 0;
                int idBancoIni = 0;
                int idBancoFin = 0;
                DateTime fechaIni = DateTime.Now;
                DateTime fechaFin = DateTime.Now;

                idEmpresa = param.IdEmpresa;
                idPersonaIni = Convert.ToInt32(this.Parameters["idPersonaIni"].Value);
                idPersonaFin = Convert.ToInt32(this.Parameters["idPersonaFin"].Value);
                idBancoIni = Convert.ToInt32(this.Parameters["idBancoIni"].Value);
                idBancoFin = Convert.ToInt32(this.Parameters["idBancoFin"].Value);
                fechaIni = Convert.ToDateTime(this.Parameters["fechaIni"].Value);
                fechaFin = Convert.ToDateTime(this.Parameters["fechaFin"].Value);


                lstInfo = oBus.Get_Lista_Reporte(idEmpresa, idPersonaIni, idPersonaFin, idBancoIni, idBancoFin, fechaIni, fechaFin);

                if (lstInfo.Count == 0)
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "No hay datos encontrados para estos filtros";
                }
                else
                {
                    lblMensaje.Visible = false;
                }

                this.DataSource = lstInfo;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt002_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt016_Rpt) };
            }
        }

    }
}
