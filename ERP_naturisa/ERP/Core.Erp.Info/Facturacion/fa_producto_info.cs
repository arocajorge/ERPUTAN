using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_producto_info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public string Codigo_Producto { get; set; }
        public string Producto { get; set; }
        public int idSucursal{ get; set; }
        public decimal IdBodega { get; set; }
        public string Bodega { get; set; }
        public double Stock { get; set; }
        public double Peso { get; set; }
        public double Pedidos { get; set; }
        public double Precio_Publico { get; set; }
        public double Precio_Mayor { get; set; }
        public double Precio_Minimo { get; set; }
        public Boolean Maneja_Iva { get; set; }
        public string Maneja_Series { get; set; }
        public double Costo_FOB { get; set; }
        public double Costo_CIF { get; set; }
        public double Costo_Promedio { get; set; }
        public double Disponibles { get; set; }

        // campos extras

        public string Estado { get; set; }
        public string Su_Descripcion { get; set; }



        public fa_producto_info() { }
    }
}
