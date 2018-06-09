using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produccion_Talme
{
    public class prod_ParametrosPorCampos_Info
    {
        public int IdEmpresa { get; set; }
        public int Secuencia { get; set; }
        public string NombreLaber { get; set; }
        public string NompreCampo { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string TipoModeloProduccion { get; set; }
    }
}
