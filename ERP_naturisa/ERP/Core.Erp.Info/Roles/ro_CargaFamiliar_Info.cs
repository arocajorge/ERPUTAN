using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_CargaFamiliar_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCargaFamiliar { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string TipoFamiliar { get; set; }
        public string Nombres { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public Boolean Estado { get; set; }
        public DateTime? FechaDefucion { get; set; }
        public String Parentezco { get; set; }

        public ro_CargaFamiliar_Info() { }
    }
}
