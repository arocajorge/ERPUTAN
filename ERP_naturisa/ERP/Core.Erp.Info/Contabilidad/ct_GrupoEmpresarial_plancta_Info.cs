using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_GrupoEmpresarial_plancta_Info
    {
        public string IdCuenta_gr { get; set; }
        public string pc_Cuenta_gr { get; set; }
        public string IdCuentaPadre_gr { get; set; }
        public string pc_Naturaleza { get; set; }
        public int IdNivelCta_gr { get; set; }
        public string IdGrupoCble_gr { get; set; }
        public string pc_EsMovimiento { get; set; }
        public string pc_Estado { get; set; }


        public ct_GrupoEmpresarial_plancta_Info() { }

    }
}
