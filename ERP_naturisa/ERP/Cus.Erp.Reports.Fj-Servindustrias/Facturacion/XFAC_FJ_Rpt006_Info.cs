using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt006_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdPreFacturacion { get; set; }
       public string observacion_det { get; set; }
       public Nullable<double> Cantidad { get; set; }
       public Nullable<double> Costo_Uni { get; set; }
       public Nullable<double> Subtotal { get; set; }
       public Nullable<bool> Aplica_Iva { get; set; }
       public Nullable<double> Por_Iva { get; set; }
       public Nullable<double> Valor_Iva { get; set; }
       public Nullable<double> Total { get; set; }
       public Nullable<System.DateTime> cm_fecha { get; set; }
       public string oc_NumDocumento { get; set; }
       public Nullable<decimal> IdProveedor { get; set; }
       public Nullable<decimal> IdProducto { get; set; }
       public string nom_Cliente { get; set; }
       public string nom_Centro_costo_sub_centro_costo { get; set; }
       public string nom_Centro_costo { get; set; }
       public string nom_punto_cargo { get; set; }
       public string nom_Producto { get; set; }
       public string nom_Proveedor { get; set; }
       public string co_serie { get; set; }
       public string co_factura { get; set; }
       public int IdPeriodo { get; set; }
       public decimal IdNumMovi_mov_inv { get; set; }
       public decimal Valor { get; set; }


       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }
    }
}
