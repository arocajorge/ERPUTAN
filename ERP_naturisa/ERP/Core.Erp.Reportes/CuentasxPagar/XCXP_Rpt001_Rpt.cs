using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Extensions;

using Core.Erp.Info.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt001_Rpt()
        {
            
            InitializeComponent();
        }


        private void XCXP_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                xrL_fecha.Text = DateTime.Now.ToLongDateString();
                lblEmpresa.Text = param.InfoEmpresa.em_nombre;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XCXP_Rpt001_Bus repbus = new XCXP_Rpt001_Bus();
                List<XCXP_Rpt001_Info> ListDataRpt = new List<XCXP_Rpt001_Info>();

                int IdEmpresa = 0;
                Decimal IdProveedor = 0;
                DateTime co_fechaOg_Ini = DateTime.Now;
                DateTime co_fechaOg_Fin = DateTime.Now;
                string sEstado_Pago = "";
                string sMuestra_Pago = "";

                String mensaje = "";

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdProveedor = Convert.ToDecimal(this.IdProveedor.Value);
                co_fechaOg_Ini = Convert.ToDateTime(this.co_fechaOg_Ini.Value);
                co_fechaOg_Fin = Convert.ToDateTime(this.co_fechaOg_Fin.Value);

                sEstado_Pago = String.IsNullOrEmpty(Convert.ToString(P_Estado_Pago.Value)) ? "" : Convert.ToString(this.P_Estado_Pago.Value);
                sMuestra_Pago = Convert.ToString(this.P_Muestra_Pagos.Value);

                eFiltro_Estado_Pago eEstadoPago;
                eFiltro_Mostrar_Pagos eConPago_sin_pago;


                eEstadoPago = (eFiltro_Estado_Pago)Enum.Parse(typeof(eFiltro_Estado_Pago), sEstado_Pago);



                eConPago_sin_pago = (eFiltro_Mostrar_Pagos)Enum.Parse(typeof(eFiltro_Mostrar_Pagos), sMuestra_Pago);


                ListDataRpt = repbus.consultar_data(IdEmpresa, IdProveedor, co_fechaOg_Ini, co_fechaOg_Fin, eEstadoPago, eConPago_sin_pago, ref  mensaje);
                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt001_Rpt) };
                
            }

            
        }

    }
}
