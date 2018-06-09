using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public string NumDocumento { get; set; }
        public DateTime fecha { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public string NomProducto { get; set; }
        public int IdSucursalOC { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia_OC { get; set; }
        public decimal IdProducto_OC { get; set; }
        public double do_Cantidad_OC { get; set; }
        public double do_precioCompra { get; set; }
        public double do_subtotal { get; set; }
        public DateTime Fecha_OC_Ini { get; set; }
        public DateTime Fecha_OC_Fin { get; set; }
        public string NombProveedorIni { get; set; }
        public string NombProveedorfin { get; set; }
        public decimal IdProveedor { get; set; }
        public string Nom_proveedor { get; set; }
        public double dm_cantidad_Inv { get; set; }
        public double Saldo_x_Ing_a_Inv	 { get; set; }
        public int IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }

      

        public XCOMP_NATU_Rpt002_Info()

        {

        }
    }
}
