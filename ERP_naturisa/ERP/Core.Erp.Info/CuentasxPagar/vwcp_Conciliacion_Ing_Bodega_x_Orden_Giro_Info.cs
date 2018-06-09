using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public int IdEmpresa_Apro_Ing { get; set; }
        public decimal IdAprobacion_Apro_Ing { get; set; }
        public int IdEmpresa_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Serie { get; set; }
        public string Serie2 { get; set; }
        public string num_documento { get; set; }
        public string num_Factura { get; set; }
        public string num_auto_Proveedor { get; set; }
        public string num_auto_Imprenta { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double Descuento { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public DateTime Fecha_Conciliacion { get; set; }
        public string Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }


        public vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info()
        {

        }
    }
}
