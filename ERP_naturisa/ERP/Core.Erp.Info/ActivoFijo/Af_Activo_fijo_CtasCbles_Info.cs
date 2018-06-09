using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Activo_fijo_CtasCbles_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdTipoCuenta { get; set; }
        public int Secuencia { get; set; }
        public double porc_distribucion { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string Observacion { get; set; }
        public int IdActijoFijoTipo { get; set; }
    }
}
