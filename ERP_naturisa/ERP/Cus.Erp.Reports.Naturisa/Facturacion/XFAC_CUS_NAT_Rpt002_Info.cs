using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cus.Erp.Reports.Naturisa.Facturacion
{
    public class XFAC_CUS_NAT_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public double vt_DescUnitario { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total { get; set; }
        public string vt_estado { get; set; }
        public string vt_tieneIVA { get; set; }
        public string vt_detallexItems { get; set; }
        public Nullable<double> vt_Peso { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public decimal vt_plazo { get; set; }
        public System.DateTime vt_fech_venc { get; set; }
        public string vt_tipo_venta { get; set; }
        public string vt_Observacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string Ve_Vendedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string vt_autorizacion { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int IdCaja { get; set; }
        public Nullable<int> IdMotivo_Vta { get; set; }
        public string descripcion_motivo_vta { get; set; }
        public string NomEmpresa { get; set; }
        public Image Logo { get; set; }
        public string num_Factura { get; set; }


        public XFAC_CUS_NAT_Rpt002_Info()
        {

        }
    }
}
