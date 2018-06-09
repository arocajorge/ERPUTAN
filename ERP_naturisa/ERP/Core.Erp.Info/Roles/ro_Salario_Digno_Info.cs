using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Salario_Digno_Info
    {
        public List<ro_Salario_Digno_Empleado_Info> oListRo_Salario_Digno_Empleado_Info = new List<ro_Salario_Digno_Empleado_Info>();

        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdPeriodo { get; set; }
        public double SueldoDigno { get; set; }
        public string Observacion { get; set; }
        public double UtilidadRepartir { get; set; }
        public DateTime  FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string   UsuarioModifica { get; set; }

        public ro_Salario_Digno_Info() { }

    }
}
