using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_horario_planificacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCalendario { get; set; }
        public decimal  IdEmpleado { get; set; }
        public decimal  IdRegistro { get; set; }
        public decimal IdHorario { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }

        // campos para presentar el grid

        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public int NomCompleto { get; set; }
        public string DescripcionTurno { get; set; }

    

        public ro_horario_planificacion_Info()
        {

        }
    }
}
