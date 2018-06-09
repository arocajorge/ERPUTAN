using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Tipo_Depreciacion_Info
    {
        public int IdTipoDepreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public string estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public Af_Tipo_Depreciacion_Info() { }
    }
}
