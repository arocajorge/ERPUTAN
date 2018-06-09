using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Salario_Digno_Empleado_Info
    {

        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public double Valor { get; set; }       
        public DateTime  FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
       
        public ro_Salario_Digno_Empleado_Info() { }

    }
}
