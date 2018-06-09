using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCONTA_Rpt003_rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {

            try
            {

                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;

                this.IdTipoCbte.Value = IdTipoCbte;
                this.IdTipoCbte.Visible = false;

                this.IdCbteCble.Value = IdCbteCble;
                this.IdCbteCble.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt003_rpt) };   
            }
        }


        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           

            
        }

        private void XCONTA_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {
                xrLEmpresa.Text = param.InfoEmpresa.em_nombre;
                
                xrLUsuario.Text = param.IdUsuario;
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                xrLFecha.Text = Convert.ToString(param.Fecha_Transac);

               
               // Reporte.Parameters["S_empresa"].Value = param.EmpresaInfo.em_nombre;

                XCONTA_Rpt003_Bus repbus = new XCONTA_Rpt003_Bus();

                List<XCONTA_Rpt003_Info> ListDataRpt = new List<XCONTA_Rpt003_Info>();

                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                Decimal IdCbteCble = 0;


                //Decimal IdProveedorFin = 0;
                //DateTime Fecha_OC_Ini = DateTime.Now;
                //DateTime Fecha_OC_Fin = DateTime.Now;
                String mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdTipoCbte = Convert.ToInt32(Parameters["IdTipoCbte"].Value);
                IdCbteCble = Convert.ToDecimal(Parameters["IdCbteCble"].Value);
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt003_rpt) };   
            }

            
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
