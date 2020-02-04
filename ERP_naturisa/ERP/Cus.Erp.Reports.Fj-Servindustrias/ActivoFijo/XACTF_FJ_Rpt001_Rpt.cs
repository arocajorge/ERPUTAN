using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Collections;
namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public partial class XACTF_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XACTF_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }
        List<XACTF_FJ_Rpt001_Info> lista = new List<XACTF_FJ_Rpt001_Info>();
        XACTF_FJ_Rpt001_Bus bus = new XACTF_FJ_Rpt001_Bus();
        private void XACTF_FJ_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            { 
                DateTime Fecha_corte_ = Convert.ToDateTime(Parameters["FechaCorte"].Value);
                int IdEmpresa_ = Convert.ToInt32(Parameters["IdEmpresa"].Value);

                lista = bus.Get_List_Activos_Prendados(IdEmpresa_, Fecha_corte_);
                this.DataSource = lista;
            }
            catch (Exception )
            {
                
                
            }
        }

    }
}
