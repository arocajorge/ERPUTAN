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
    public partial class XBAN_FJ_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XBAN_FJ_Rpt003_Rpt()
        {
            InitializeComponent();
        }
        XBAN_FJ_Rpt002_Bus bus = new XBAN_FJ_Rpt002_Bus();
        List<XBAN_FJ_Rpt002_Info> lista = new List<XBAN_FJ_Rpt002_Info>();
        List<XBAN_FJ_Rpt003_Info> lista_Imprimir = new List<XBAN_FJ_Rpt003_Info>();

        double Valor = 0;

        private void XBAN_FJ_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                DateTime fi = Convert.ToDateTime(this.FechaInicio.Value);
                DateTime ff = Convert.ToDateTime(this.FechaFin.Value);
                lista = bus.Get_List_FlujoEreso(IdEmpresa, fi, ff);


                var Consulta = (from s in lista
                                select s.tc_TipoCbte).Distinct();
                double Total = lista.Sum(v => v.cb_Valor);


                foreach (var item in Consulta)
                {
                    XBAN_FJ_Rpt003_Info info = new XBAN_FJ_Rpt003_Info();
                    
                    double Subtotal = lista.Where(v => v.tc_TipoCbte == item.ToString()).Sum(v => v.cb_Valor);
                    lista.Where(v => v.tc_TipoCbte == item.ToString()).ToList().ForEach(x => x.cb_total = Subtotal);
                    info.cb_Valor = Subtotal;
                    info.tc_TipoCbte = item;
                    info.Porcentaje = Subtotal / Total;
                    lista_Imprimir.Add(info);

                }


                this.DataSource = lista_Imprimir;

            }
            catch (Exception ex)
            {


            }
        }

    }
}
