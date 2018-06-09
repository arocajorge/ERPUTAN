using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Grupocble_Info
    {
        public string IdGrupoCble { get; set; }
        public string gc_GrupoCble { get; set; }
        public int gc_Orden { get; set; }
        public string gc_estado_financiero { get; set; }
        public int gc_signo_operacion { get; set; }
        public string Estado { get; set; }

        public ct_Grupocble_Info() { }
    }
}
