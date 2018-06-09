using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt012_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string tipo_AF { get; set; }
        public int IdCategoriaAF { get; set; }
        public string Categoria_AF { get; set; }
        public double Af_costo_compra { get; set; }
        public Nullable<double> Af_Depreciacion_acum { get; set; }
        public Nullable<double> Costo_actual { get; set; }
        public double valor_ult_depreciacion { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }

        public XACTF_Rpt012_Info()
        {

        }
    }
}
