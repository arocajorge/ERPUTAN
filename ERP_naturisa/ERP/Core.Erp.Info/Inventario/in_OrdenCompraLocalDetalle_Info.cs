using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_OrdenCompraLocalDetalle_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdOrdenTaller { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_costo { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public string do_ManejaIva { get; set; }
        public string do_Costeado { get; set; }
        public double do_costo_promedio_hist { get; set; }
        public double do_peso { get; set; }
        public string do_observacion { get; set; }

        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }

        public string Referencia { get; set; }
        public string CodOrdenTaller { get; set; }

        public in_OrdenCompraLocalDetalle_Info() { }
    }
}
