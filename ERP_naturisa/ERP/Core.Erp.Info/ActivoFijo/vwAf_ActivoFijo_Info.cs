using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class vwAf_ActivoFijo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public string Af_Nombre { get; set; }
        public double Af_costo_compra { get; set; }
        public double Af_ValorSalvamento { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Vida_TipDepre { get; set; }
        public DateTime Af_fecha_ini_depre { get; set; }
        public DateTime Af_fecha_fin_depre { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public double Valor_Depre { get; set; }
        public double Valor_Depreciacion_Acum { get; set; }
        public double Valor_Importe { get; set; }
        public string Estado_ProcesoEstado_Proceso { get; set; }
        public string Concepto_Depre { get; set; }
        public int Ciclo { get; set; }
        public Boolean Es_Activo_x_Mejora { get; set; }

        public string CodActivoFijo { get; set; }
        public Nullable<int> IdActijoFijoTipo { get; set; }
        public string nom_tipo { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public string nom_categoria { get; set; }                

        public vwAf_ActivoFijo_Info()
        {

        }
    }
}
