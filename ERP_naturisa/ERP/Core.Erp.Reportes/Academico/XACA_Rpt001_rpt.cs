using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;



namespace Core.Erp.Reportes.Academico
{
    public partial class XACA_Rpt001_rpt : DevExpress.XtraReports.UI.XtraReport
    {

        public XACA_Rpt001_rpt()
        {
            InitializeComponent();
        }

        private void XACA_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string mensaje = "";
                int IdEmpresa = 0;
                int IdEstudiante = 0;
                XACA_Rpt001_Bus odbus = new XACA_Rpt001_Bus();
                List<XACA_Rpt001_Info> odinfo = new List<XACA_Rpt001_Info>();

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdEstudiante = Convert.ToInt32(this.IdEstudiante.Value);
                odinfo = odbus.Consultar_data(IdEmpresa, IdEstudiante, ref mensaje);
                this.DataSource = odinfo;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACA_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACA_Rpt001_rpt) };
            }
        }

    }
}
