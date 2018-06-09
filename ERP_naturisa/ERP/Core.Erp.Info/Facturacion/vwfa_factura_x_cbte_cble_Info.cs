using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
   public class vwfa_factura_x_cbte_cble_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public decimal IdCbteVta { get; set; }
       public string Su_Descripcion { get; set; }
       public string CodCbteVta { get; set; }
       public string num_factura { get; set; }
       public DateTime vt_fecha { get; set; }
       public string vt_Observacion { get; set; }
       public decimal IdCliente { get; set; }
       public string pe_nombreCompleto { get; set; }
       public double ? vt_Subtotal { get; set; }
       public double ? vt_iva { get; set; }
       public double ? vt_total { get; set; }
       public decimal ? IdCbteCble { get; set; }
       public string nom_tipo_cbte { get; set; }
       public DateTime ? cb_Fecha { get; set; }
       public double ? cb_Valor { get; set; }
       public string cb_Observacion { get; set; }
       public bool BContabilizar { get; set; }


    }
}
