using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_registro_unidades_x_equipo_det_ini_x_Af_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRegistro { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
    }
}
