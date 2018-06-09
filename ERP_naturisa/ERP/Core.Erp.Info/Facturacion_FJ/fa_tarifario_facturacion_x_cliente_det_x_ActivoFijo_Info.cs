using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTarifario { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<double> Valor_x_Unidad { get; set; }
        public Nullable<double> Unidades_minimas { get; set; }

        public string Af_Nombre { get; set; }
        public bool Seleccionado { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }

        public string nom_Categoria { get; set; }
        public string nom_UnidadFact { get; set; }
        public int Num_empleado_relacionado { get; set; }
    }
}
