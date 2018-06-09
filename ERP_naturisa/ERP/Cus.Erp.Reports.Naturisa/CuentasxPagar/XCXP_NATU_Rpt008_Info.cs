using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
   public class XCXP_NATU_Rpt008_Info
    {
   
       public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime co_fechaOg { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_total { get; set; }
        public double co_valorpagar { get; set; }
        public double Total_Retencion { get; set; }
        public double Total_Pagos { get; set; }
        public double Total_NC { get; set; }
        public double Saldo { get; set; }
        public decimal? IdTipoFlujo { get; set; }
        public string IdTipoServicio { get; set; }
        public int? IdSucursal { get; set; }
        public string nom_proveedor { get; set; }
        public string cod_TipoDocumento { get; set; }
        public string nom_TipoDocumento { get; set; }
        public string nom_TipoFlujo { get; set; }
        public string nom_Sucursal { get; set; }
        public int IdClaseProveedor { get; set; }
        public string nom_claseProveedor { get; set; }

        public string S_co_fechaOg { get; set; }
       	
    }
}
