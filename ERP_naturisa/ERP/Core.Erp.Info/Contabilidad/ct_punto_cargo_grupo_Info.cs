using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_punto_cargo_grupo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPunto_cargo_grupo { get; set; }
        public string cod_Punto_cargo_grupo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string nom_punto_cargo_grupo2 { get; set; }
        public bool estado { get; set; }
        public string IdCtaCble { get; set; }
        public string Estado { get; set; }
    }
}
