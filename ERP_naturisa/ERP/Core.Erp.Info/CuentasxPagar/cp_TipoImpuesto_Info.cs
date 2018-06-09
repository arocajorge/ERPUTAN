using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_TipoImpuesto_Info
    {
        public int IdTipoImpuesto { get; set; }
        public string ti_descripcion { get; set; }
        public double  ti_porImpuesto { get; set; }
        public string ti_ctaCble { get; set; }
        public string ti_estado{get;set;}


        public string IdUsuario { get; set; }
        public DateTime  Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }

        public cp_TipoImpuesto_Info() { }

    }
}
