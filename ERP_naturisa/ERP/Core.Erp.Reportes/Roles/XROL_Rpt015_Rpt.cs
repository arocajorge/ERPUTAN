using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Reportes.Roles;
using System.Collections;
using System.Collections.Generic;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt015_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XROL_Rpt015_Info> lista = new List<XROL_Rpt015_Info>();
        XROL_Rpt015_Bus bus = new XROL_Rpt015_Bus();

        public XROL_Rpt015_Rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt015_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
              int IdEmpresa = 0;
            int IdNomina_Tipo = 0;
            decimal IdEmpleado = 0;
            decimal IdImplemento = 0;


            IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
            IdEmpleado = Convert.ToDecimal(Parameters["IdEmpleado"].Value);
            IdNomina_Tipo = Convert.ToInt32(Parameters["IdNomina_tipo"].Value);
            IdImplemento = Convert.ToInt32(Parameters["Id_Asignacion_impl"].Value);
            lista = bus.Get_Asignacion_x_empleado(IdEmpresa, IdNomina_Tipo, IdEmpleado, IdImplemento);
           this.  DataSource = lista;
            }
            catch (Exception ex)
            {
                
               
            }
        }

    }
}
