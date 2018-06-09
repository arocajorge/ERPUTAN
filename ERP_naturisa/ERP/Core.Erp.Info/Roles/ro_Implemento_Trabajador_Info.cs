using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Implemento_Trabajador_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdImplemento { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> IdProducto_Inv { get; set; }
        public int IdTipoImplemento { get; set; }
        public System.DateTime FechaCompra { get; set; }
        public double CostoCompra { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Maneja_Invent { get; set; }
    }
}
