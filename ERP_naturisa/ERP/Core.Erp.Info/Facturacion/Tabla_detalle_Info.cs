using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class Tabla_detalle_Info
    {
        public decimal IdProducto { get; set; }
        public string Producto { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Porc_Descuento { get; set; }
        public double Descuento_Unidad { get; set; }
        public double PrecioFinal { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public Boolean Paga_Iva { get; set; }
        public string DetallexItems { get; set; }

        public Tabla_detalle_Info() { }
    }
}
