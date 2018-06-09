using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario_Fj
{
    public class in_Orden_servicio_x_Activo_fijo_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenSer_x_Af { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public Nullable<bool> Maneja_Iva { get; set; }
        public string pr_codigo { get; set; }
    }
}
