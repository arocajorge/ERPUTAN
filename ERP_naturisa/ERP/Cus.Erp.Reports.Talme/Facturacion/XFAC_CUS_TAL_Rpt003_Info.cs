using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
   public class XFAC_CUS_TAL_Rpt003_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public decimal IdGuiaRemision { get; set; }
       public string CodGuiaRemision { get; set; }
       public string Serie1 { get; set; }
       public string Serie2 { get; set; }
       public string NumGuia_Preimpresa { get; set; }
       public decimal IdCliente { get; set; }
       public int IdVendedor { get; set; }
       public decimal IdTransportista { get; set; }
       public DateTime gi_fecha { get; set; }
       public decimal gi_plazo { get; set; }
       public DateTime  gi_fech_venc { get; set; }
       public string gi_Observacion { get; set; }
       public double gi_TotalKilos { get; set; }
       public double gi_TotalQuintales { get; set; }
       public string IdUsuario { get; set; }
       public double gi_flete { get; set; }
       public double gi_interes { get; set; }
       public double gi_seguro { get; set; }
       public double gi_OtroValor1 { get; set; }
       public double gi_OtroValor2 { get; set; }
       public int Secuencia { get; set; }
       public decimal IdProducto { get; set; }
       public double gi_cantidad { get; set; }
       public double gi_Precio { get; set; }
       public double gi_PorDescUnitario { get; set; }
       public double gi_DescUnitario { get; set; }
       public double gi_PrecioFinal { get; set; }
       public double gi_Subtotal { get; set; }
       public double gi_iva { get; set; }
       public double gi_total { get; set; }
       public string gi_detallexItems { get; set; }
       public double gi_peso { get; set; }
       public string nom_empresa { get; set; }
       public string ruc_empresa { get; set; }
       public string logo_empresa { get; set; }
       public string nom_sucursal { get; set; }
       public string nom_bodega { get; set; }
       public string nom_cliente { get; set; }
       public string cod_producto { get; set; }
       public string nom_producto { get; set; }
       public string nom_transportista { get; set; }
       public string razon_social_transportista { get; set; }
       public string cedula_ruc_transportista { get; set; }
	   public string cedula_ruc_cliente { get; set; }
       public string direccion_cliente { get; set; }
       public string direccion_empresa { get; set; }

       public XFAC_CUS_TAL_Rpt003_Info()
       {

       }

    }
}
