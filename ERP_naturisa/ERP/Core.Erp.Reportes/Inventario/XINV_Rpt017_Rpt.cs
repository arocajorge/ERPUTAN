using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt017_Rpt : DevExpress.XtraReports.UI.XtraReport
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XINV_Rpt017_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt017_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int IdSucursal_origen = 0;
                int IdBodega_origen = 0;
                decimal IdTransferencia = 0;

                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                lblEmpresa.Text = param.NombreEmpresa;
                string MensajeError = "";

                XINV_Rpt017_Bus OBUS = new XINV_Rpt017_Bus();
                List<XINV_Rpt017_Info> ListDataRpt = new List<XINV_Rpt017_Info>();

                IdSucursal_origen = Convert.ToInt32(P_IdSucursal_origen.Value);
                IdBodega_origen = Convert.ToInt32(P_IdBodega_origen.Value);
                IdTransferencia = Convert.ToDecimal(P_IdTransferencia.Value);

                ListDataRpt = OBUS.Get_List(param.IdEmpresa,IdSucursal_origen,IdBodega_origen, IdTransferencia, ref MensajeError);
                
                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt017_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt017_Rpt) };

            }
        }

    }
}
