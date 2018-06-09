using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        public XCOMP_NATU_Rpt004_Rpt()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void XCOMP_NATU_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLusuario.Text = param.IdUsuario;
                xrLfecha.Text = DateTime.Now.ToString();
                pictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                string msg = "";
                XCOMP_NATU_Rpt004_Bus OBUS = new XCOMP_NATU_Rpt004_Bus();

                List<XCOMP_NATU_Rpt004_Info> ListDataRpt = new List<XCOMP_NATU_Rpt004_Info>();

                DateTime FechaIni;
                DateTime FechaFin;
                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;
                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;


                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);

                IdProductoIni = Convert.ToDecimal(Parameters["IdProductoIni"].Value);
                IdProductoFin = Convert.ToDecimal(Parameters["IdProductoFin"].Value);

                ListDataRpt = OBUS.consultar_data(IdEmpresa, IdSucursal, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin, IdProductoIni, IdProductoFin, ref msg);

               string format="dd/MM/yyyy";
                
                foreach (var item in ListDataRpt)
                {
                    item.fecha = item.Fecha_oc.ToString(format);
                }
                
                
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_NATU_Rpt004_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_NATU_Rpt004_Rpt) };

            }
        }



    }
}
