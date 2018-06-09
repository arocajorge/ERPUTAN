using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Centro_costo_nivel_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNivel { get; set; }
        public string ni_descripcion { get; set; }
        public int ni_digitos { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }


        public ct_Centro_costo_nivel_Info() { }
    }
}
