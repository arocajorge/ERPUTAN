using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
   public class ct_punto_cargo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPunto_cargo { get; set; }
        public string codPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_punto_cargo2 { get; set; }   
        public string Estado { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string IdCentroCosto_Scc { get; set; }
        public string IdCentroCosto_sub_centro_costo_Scc { get; set; }
    }
}
