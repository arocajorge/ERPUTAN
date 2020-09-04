using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_SeguimientoOrdenCompraContable_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string CodigoOC { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioFinal { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double Por_Iva { get; set; }
        public double do_total { get; set; }
        public string tm_descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public Nullable<decimal> IdNumMovi { get; set; }
        public Nullable<System.DateTime> cm_fecha { get; set; }
        public Nullable<double> dm_cantidad_sinConversion { get; set; }
        public Nullable<decimal> IdAprobacion { get; set; }
        public string pe_nombrecompletoAprobacion { get; set; }
        public Nullable<System.DateTime> Fecha_Factura { get; set; }
        public string num_documento { get; set; }
        public string UsuarioIngresa { get; set; }
        public string UsuarioAprobacion { get; set; }
        public string ObservacionAprobacion { get; set; }
    }
}
