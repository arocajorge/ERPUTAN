using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
   public class ro_Pago_decimos_x_Empleado_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string genero { get; set; }
        public string ocupacion { get; set; }
        public string codigoIESS { get; set; }
        public int diasLaborados { get; set; }
        public string TipoPago { get; set; }
        public string TipoContrato { get; set; }
        public string retencion_Pago_Directo { get; set; }
        public string Retencion_Acreditación_Cuenta { get; set; }
        public double Total_ganado { get; set; }
        public int DiasFaltados { get; set; }

        public ro_Pago_decimos_x_Empleado_Info()
        { }
     
    }
}
