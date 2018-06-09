using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad_Fj;

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
        public ct_punto_cargo_FJ_Info info_punto_cargo_Fj { get; set; }
        

        public ct_punto_cargo_Info()
        {
            info_punto_cargo_Fj = new ct_punto_cargo_FJ_Info();
        }
    }
}
