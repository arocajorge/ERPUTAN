using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cus.Erp.Reports.FJ.Bancos;
using System.Collections.Generic;
using System.Linq;
using System.IO.Compression;
namespace Cus.Erp.Reports.FJ.Bancos
{
    public partial class XBAN_FJ_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XBAN_FJ_Rpt002_Bus bus = new XBAN_FJ_Rpt002_Bus();
        List<XBAN_FJ_Rpt002_Info> lista = new List<XBAN_FJ_Rpt002_Info>();
        double Valor = 0;
        public XBAN_FJ_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XBAN_FJ_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                DateTime fi = Convert.ToDateTime(this.Fecha_inicio.Value);
                DateTime ff = Convert.ToDateTime(this.Fecha_fin.Value);
                lista = bus.Get_List_FlujoEreso(IdEmpresa, fi, ff);

            
                var Consulta = (from s in lista
                                select s.tc_TipoCbte).Distinct();

                foreach (var item in Consulta)
                {
                    double tot = lista.Where(v => v.tc_TipoCbte == item.ToString()).Sum(v=>v.cb_Valor);
                   lista.Where(v => v.tc_TipoCbte == item.ToString()).ToList().ForEach(x=>x.cb_total=tot);
                    
                }


                this.DataSource = lista;

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void lb_total_SummaryReset(object sender, EventArgs e)
        {
            try
            {
                Valor = 0;
            }
            catch (Exception)
            {
                
               
            }
        }

        private void lb_total_SummaryRowChanged(object sender, EventArgs e)
        {
            try
            {
                
                string codigo_Subgrupo = "";
                codigo_Subgrupo = Convert.ToString(GetCurrentColumnValue("tc_TipoCbte"));                
                double total_x_subGrupo = 0;
                total_x_subGrupo = lista.Where(v => v.tc_TipoCbte == codigo_Subgrupo).Sum(v => v.cb_Valor);                
                Valor += Convert.ToDouble(GetCurrentColumnValue("cb_Valor"));
            }
            catch (Exception)
            {


            }
        }

        private void lb_total_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            try
            {
               double tot = Convert.ToDouble(GetCurrentColumnValue("cb_Valor"));
               e.Result =  (tot/Valor)*100;
                e.Handled = true;
            }
            catch (Exception)
            {


            }
        }

        private void lb_total_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
           
        }

       
      

    }
}
