using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Core.Erp.Reportes.Facturacion
{
   public class XFAC_Rpt007_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string CodCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string numComprobante { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string Ve_Vendedor { get; set; }
        public DateTime vt_fecha { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public decimal vt_plazo { get; set; }
        public string vt_tipo_venta { get; set; }
        public string vt_Observacion { get; set; }
        public int IdPeriodo { get; set; }
        public int vt_anio { get; set; }
        public int vt_mes { get; set; }
        public double vt_Flete { get; set; }
        public double vt_interes { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total { get; set; }
        public decimal IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public string vt_autorizacion { get; set; }
        public string IdUsuario { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public Image Logo { get; set; }
        public string pe_telefonoCasa { get; set; }

       public XFAC_Rpt007_Info()
       {

       }
    }
}
