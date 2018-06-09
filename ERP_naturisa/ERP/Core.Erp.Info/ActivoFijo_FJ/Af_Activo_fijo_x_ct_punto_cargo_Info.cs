using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo_FJ
{
    public class Af_Activo_fijo_x_ct_punto_cargo_Info
    {
        public int IdEmpresa_AF { get; set; }
        public int IdActivoFijo_AF { get; set; }
        public int IdEmpresa_PC { get; set; }
        public int IdPunto_cargo_PC { get; set; }
        public string observacion { get; set; }
    }
}
