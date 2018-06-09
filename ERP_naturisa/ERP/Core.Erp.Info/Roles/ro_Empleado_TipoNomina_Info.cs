using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Empleado_TipoNomina_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }

        public string pe_nombreCompleto { get; set; }
        public string Descripcion { get; set; }

        public ro_Empleado_TipoNomina_Info()
        {
        }

    }
}
