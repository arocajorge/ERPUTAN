using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;
using DevExpress.XtraReports.Parameters;

using Core.Erp.Business.General;


namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public partial class XINV_NAT_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XINV_NAT_Rpt001_Rpt()
        {
            
            InitializeComponent();
        }

        private void XINV_NAT_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrlEmpresa.Text = param.NombreEmpresa;

                XINV_NAT_Rpt001_Bus repbus = new XINV_NAT_Rpt001_Bus();
                List<XINV_NAT_Rpt001_Info> ListDataRpt = new List<XINV_NAT_Rpt001_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                decimal IdGuia = 0;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdGuia = Convert.ToDecimal(this.PIdGuia.Value);
                ListDataRpt = repbus.consultar_data(IdEmpresa, IdGuia, ref mensaje);
                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_NAT_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_NAT_Rpt001_Rpt) };       
            }

        }

    }
}
