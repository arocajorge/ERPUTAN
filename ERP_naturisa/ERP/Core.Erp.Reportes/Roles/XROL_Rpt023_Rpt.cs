using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt023_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROL_Rpt023_Rpt()
        {
            InitializeComponent();
        }

        XROL_Rpt023_Bus bus = new XROL_Rpt023_Bus();
        List<XROL_Rpt023_Info> lista = new List<XROL_Rpt023_Info>();
        private void XROL_Rpt023_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
            int IdEmpresa_ = Convert.ToInt32(Parameters["IdEmpresa"].Value);
            int IdEmpleado_ = Convert.ToInt32(Parameters["IdEmpleado"].Value);
            int IdNovedad_ = Convert.ToInt32(Parameters["IdNovedad"].Value);


            lista = bus.Get_List(IdEmpresa_, IdEmpleado_, IdNovedad_);
            this.DataSource = lista;
            LbNovdad.Text = "ORDEN DE CUENTA POR COBRAR A EMPLEADO Nº " + IdNovedad_;
            }
            catch (Exception)
            {
                
            }
        }

    }
}
