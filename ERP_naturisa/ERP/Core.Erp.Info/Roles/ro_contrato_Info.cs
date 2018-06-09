using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
   public  class ro_contrato_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdContrato { get; set; }
        public string IdContrato_Tipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string MotiAnula { get; set; }
        public string NomCatalogo { get; set; }
        public string EstadoContrato { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }
        public string Cedula { get; set; }
        public string Estado_Contrato { get; set; }

       //Dato para presentar en EMPLEADO
        public string ca_descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }

        public ro_contrato_Info()
        {

        }

    }
}
