
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Acta_Finiquito_Detalle_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdActaFiniquito { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdSecuencia { get; set; }
        public string Observacion { get; set; }
        public string IdRubro { get; set; }
        public string Signo { get; set; }
        public double Valor { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public Nullable<double> Otros_valor { get; set; }

        public ro_Acta_Finiquito_Detalle_Info() { }
    }
}
