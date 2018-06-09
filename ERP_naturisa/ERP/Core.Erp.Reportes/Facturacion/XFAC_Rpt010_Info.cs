using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt010_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public int Secuencia { get; set; }
        public string CodTipoNota { get; set; }
        public string IdTipoDocumento { get; set; }
        public string numDocumento { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_direccion { get; set; }
        public string Ve_Vendedor { get; set; }
        public DateTime no_fecha { get; set; }
        public DateTime no_fecha_venc { get; set; }
        public int Plazo { get; set; }
        public int IdTipoNota { get; set; }
        public string sc_observacion { get; set; }
        public decimal IdDevolucion { get; set; }
        public double interes { get; set; }
        public double sc_cantidad { get; set; }
        public double sc_Precio { get; set; }
        public double sc_subtotal { get; set; }
        public double sc_iva { get; set; }
        public double sc_total { get; set; }
        public decimal IdProducto { get; set; }
        public string bo_Descripcion { get; set; }
        public string IdUsuario { get; set; }
        public string Su_Descripcion { get; set; }
        public double valorFlete { get; set; }
        public int IdCaja { get; set; }
        public string Caja { get; set; }
        public string nombreProducto { get; set; }

        public XFAC_Rpt010_Info()
        {

        }

    }
}
