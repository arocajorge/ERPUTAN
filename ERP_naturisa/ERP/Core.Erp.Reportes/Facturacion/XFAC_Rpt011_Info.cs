using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt011_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevolucion { get; set; }
        public string CodDevolucion { get; set; }
        public decimal IdNota { get; set; }
        public decimal IdCbteVta { get; set; }
        public string numDocumento { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_direccion { get; set; }
        public string Ve_Vendedor { get; set; }
        public DateTime dv_fecha { get; set; }
        public string dv_Observacion { get; set; }
        public double dv_interes { get; set; }
        public double dv_cantidad { get; set; }
        public double dv_valor { get; set; }
        public double dv_subtotal { get; set; }
        public double dv_iva { get; set; }
        public double dv_total { get; set; }
        public decimal IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public string bo_Descripcion { get; set; }
        public string IdUsuario { get; set; }
        public string Su_Descripcion { get; set; }
        public double valorFlete { get; set; }
        public Image Logo { get; set; }


        public XFAC_Rpt011_Info()
        {

        }
    }
}
