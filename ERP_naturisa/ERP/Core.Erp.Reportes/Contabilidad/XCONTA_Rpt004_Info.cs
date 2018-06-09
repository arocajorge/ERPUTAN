using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt004_Info
    {


        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public string IdCtaCblePadre { get; set; }
        public string pc_Naturaleza { get; set; }
        public int IdNivelCta { get; set; }
        public string IdGrupoCble { get; set; }
        public string IdTipoCtaCble { get; set; }
        public string pc_Estado { get; set; }
        public string pc_EsMovimiento { get; set; }
        public string pc_es_flujo_efectivo { get; set; }
        public string pc_clave_corta { get; set; }

        public XCONTA_Rpt004_Info() { }

    }
}
