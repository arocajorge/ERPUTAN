using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;

using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt011_rpt()
        {
            InitializeComponent();
        }
        public void set_parametros(int IdEmpresa, int IdBanco, int IdConciliacion)
        {

            try
            {

                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdBanco.Value = IdBanco;
                this.IdBanco.Visible = false;

                this.IdConciliacion.Value = IdConciliacion;
                this.IdConciliacion.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XBAN_Rpt011_rpt) };   

            }
        }
        
        private void XBAN_Rpt011_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblElaborado.Text = lblElaborado.Text.Replace("{0}", param.IdUsuario);
                lblFechaActual.Text = param.Fecha_Transac.ToString();
                XBAN_Rpt011_Bus repbus = new XBAN_Rpt011_Bus();
                List<XBAN_Rpt011_Info> listDataRpt = new List<XBAN_Rpt011_Info>();


                string mensaje = "";
                int IdEmpresa = 0;
                int IdBanco = 0;
                int IdConciliacion = 0;


                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdBanco = Convert.ToInt32(Parameters["IdBanco"].Value);
                IdConciliacion = Convert.ToInt32(Parameters["IdConciliacion"].Value);


                listDataRpt = repbus.Get_Data_Reporte(IdEmpresa, IdBanco, IdConciliacion, ref mensaje);
                this.DataSource = listDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt011_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt011_rpt) };   
                
            }
        }

    }
}
