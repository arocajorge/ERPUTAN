using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Plancta_nivel_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNivelCta { get; set; }
        public int nv_NumDigitos { get; set; }
        public string nv_Descripcion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<int> nv_NumDigitos_total { get; set; }

        public ct_Plancta_nivel_Info() { }
    }
}
