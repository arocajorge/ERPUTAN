using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections;
using System.Collections.Generic;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt013_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XROL_Rpt013_Info> Listado = new List<XROL_Rpt013_Info>();
        XROL_Rpt013_Info info = new XROL_Rpt013_Info();

        public XROL_Rpt013_rpt()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            info = new XROL_Rpt013_Info();

            this.DataSource = Listado.ToArray();

            foreach (var item in Listado)
            {
                info.tot_Ingreso = info.tot_Ingreso + item.tot_Ingreso;
                
            }

            if (info != null)
            {
                double ValorDiasAdicional = Math.Round((info.tot_Ingreso / 360) * Convert.ToInt32(ro_dias_adicionales.Value), 2);
                double vacaciones = Math.Round(info.tot_Ingreso / 24, 2);
                lb_Valor_adicional.Text =Convert.ToString( ValorDiasAdicional);
                lbtotal.Text = Convert.ToString(Math.Round(ValorDiasAdicional + vacaciones, 2));
                double Iess = Math.Round(Convert.ToDouble(((ValorDiasAdicional + vacaciones) * 9.45) / 100), 2);
                lb_IESS.Text =Convert.ToString( Iess);
                lb_neto_recibir.Text = Convert.ToString((vacaciones + ValorDiasAdicional) - Iess);
                lb_vacaciones.Text = Convert.ToString(vacaciones);
                tot_ingreso_bruto.Text =Math.Round(info.tot_Ingreso,2).ToString();
            }
        }


      public  void Set(List<XROL_Rpt013_Info> Lista)
        {

            try
            {
                Listado = Lista;
               
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
