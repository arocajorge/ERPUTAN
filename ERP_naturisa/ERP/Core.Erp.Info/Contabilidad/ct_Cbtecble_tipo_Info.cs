using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{//07052013
    public class ct_Cbtecble_tipo_Info
    {

        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string tc_TipoCbte2 { get; set; }
        public string tc_Estado { get; set; }
        public string tc_Interno { get; set; }
        public string tc_Nemonico { get; set; }
        public int? IdTipoCbte_Anul { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string SEstado { get; set; }

        public ct_Cbtecble_tipo_Info() { }

    }
}
