using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt005_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XCAJ_Rpt005_Rpt()
        {
            InitializeComponent();
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void XCAJ_Rpt005_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCAJ_Rpt005_Bus Rpt_Bus = new XCAJ_Rpt005_Bus();
                List<XCAJ_Rpt005_Info> ListRpt = new List<XCAJ_Rpt005_Info>();

                int IdEmpresa = 0;
                int IdCaja_ = 0;
                DateTime FechaIni_;
                DateTime FechaFin_;


                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);

                IdCaja_ = Convert.ToInt32(this.IdCaja.Value);
               
                FechaIni_ = Convert.ToDateTime(Parameters["Fecha_inicio"].Value);
                FechaFin_ = Convert.ToDateTime(Parameters["Fecha_Fin"].Value);
                if(IdCaja_>0)
                ListRpt = Rpt_Bus.Get_List(IdEmpresa, IdCaja_, FechaIni_, FechaFin_);
                else
                    ListRpt = Rpt_Bus.Get_List(IdEmpresa, FechaIni_, FechaFin_);

                this.DataSource = ListRpt.ToArray();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCAJ_Rpt002_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt002_Rpt) };
            }
        }

    }
}
