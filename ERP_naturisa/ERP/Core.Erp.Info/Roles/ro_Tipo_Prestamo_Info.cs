using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Tipo_Prestamo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoPrestamo { get; set; }
        public string tp_Descripcion { get; set; }
        public Nullable<int> tp_Antiguedad { get; set; }
        public Nullable<int> tp_Monto { get; set; }
        public Nullable<double> tp_Indice { get; set; }
        public Nullable<int> tp_Orden { get; set; }
        public string tp_Estado { get; set; }

        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }

        public ro_Tipo_Prestamo_Info()
        {
        }

    }
}
