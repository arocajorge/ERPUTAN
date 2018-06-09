using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//05/07/2013
namespace Core.Erp.Info.Roles
{
    public class ro_Empleado_estudios_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Secuencia { get; set; }
        public string IdInstitucion { get; set; }
        public string Carrera { get; set; }
        public string IdEstudios { get; set; }
        public string Observacion { get; set; }

        public ro_Empleado_estudios_Info ()
        {
        }

    }
}
