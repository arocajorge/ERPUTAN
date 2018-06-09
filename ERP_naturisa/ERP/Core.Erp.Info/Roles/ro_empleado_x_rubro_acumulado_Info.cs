using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_empleado_x_rubro_acumulado_Info
    {
        public int IdEmpresa {get;set;}
        public  decimal IdEmpleado {get;set;}
        public  string IdRubro {get;set;}
        public DateTime FechaIngresa {get;set;}
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica {get;set;}
        public string UsuarioModifica {get;set;}
        public DateTime? Fec_Inicio_Acumulacion { get; set; }
        public DateTime? Fec_Fin_Acumulacion { get; set; }
        public ro_empleado_x_rubro_acumulado_Info() { }

    }
}
