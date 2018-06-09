using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
     public class XFAC_CUS_TAL_Rpt004_info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public  string CodCbteVta{ get; set; }
        public string vt_tipoDoc	 { get; set; }
        public string vt_autorizacion { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2	 { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente{ get; set; }
        public int IdVendedor { get; set; }
        public DateTime vt_fecha { get; set; }
        public Decimal vt_plazo { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public string vt_tipo_venta { get; set; } 
        public string vt_Observacion { get; set; }
        public double vt_flete { get; set; }
        public double vt_interes { get; set; }
        public double vt_seguro { get; set; }
        public double vt_OtroValor1 { get; set; }
        public double vt_OtroValor2 { get; set; }
        public int IdCaja { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_DescUnitario { get; set; }          
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total	{ get; set; }
        public double vt_costo { get; set; }
        public double vt_Peso	 { get; set; }
        public string vt_detallexItems { get; set; }
        public string nom_caja { get; set; }
        public string nom_vendedor { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string nom_cliente { get; set; }
        public string razon_social_cliente { get; set; }
        public string cedu_ruc_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string correo_cliente { get; set; }
                 

        public XFAC_CUS_TAL_Rpt004_info()
       {

       }
    }
}