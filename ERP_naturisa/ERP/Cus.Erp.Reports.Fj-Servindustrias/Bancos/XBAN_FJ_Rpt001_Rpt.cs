using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Collections;
namespace Cus.Erp.Reports.FJ.Bancos
{
    public partial class XBAN_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XBAN_FJ_Rpt001_Bus bus = new XBAN_FJ_Rpt001_Bus();
        List<XBAN_FJ_Rpt001_Info> lista = new List<XBAN_FJ_Rpt001_Info>();
        public XBAN_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XBAN_FJ_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                DateTime fi = Convert.ToDateTime(this.Fecha_inicio.Value);
                DateTime ff = Convert.ToDateTime(this.Fecha_fin.Value);
                int idempresa = Convert.ToInt32(this.IdEmpresa.Value);

                lista = bus.Get_List_Conciliacion(idempresa,fi,ff );
                this.DataSource = lista;
            }
            catch (Exception)
            {
                
            }
        }

    }
}
