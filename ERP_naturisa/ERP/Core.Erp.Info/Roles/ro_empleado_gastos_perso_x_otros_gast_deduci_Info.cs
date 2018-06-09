using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Derek 13/12/2013
namespace Core.Erp.Info.Roles
{
    public class ro_empleado_gastos_perso_x_otros_gast_deduci_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Anio_fiscal { get; set; }
        public int secuencia { get; set; }
        public double? Valor_Pension_alim { get; set; }
        public double? Valor_no_cub_x_aseg { get; set; }


        public ro_empleado_gastos_perso_x_otros_gast_deduci_Info() { }

    }
}
