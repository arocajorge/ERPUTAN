using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Derek 13/12/2013
namespace Core.Erp.Info.Roles
{
    public class ro_empleado_gastos_perso_x_Gastos_deduci_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Anio_fiscal { get; set; }
        public int Secuencia { get; set; }
        public string Ruc { get; set; }
        public string Num_CbteVta { get; set; }
        public double? Base_Imponible { get; set; }
        public string IdTipoGastos { get; set; }

        //
        public string descTipoGasto { get; set; }


        public ro_empleado_gastos_perso_x_Gastos_deduci_Info() { }

    }
}
