using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_giro_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string IdUnidadMedida { get; set; }
        public double Cantidad { get; set; }
        public double CostoUni { get; set; }
        public double PorDescuento { get; set; }
        public double DescuentoUni { get; set; }
        public double CostoUniFinal { get; set; }
        public double Subtotal { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public double PorIva { get; set; }
        public double ValorIva { get; set; }
        public double Total { get; set; }
        public string IdCtaCbleInv { get; set; }
        public Nullable<int> IdEmpresa_oc { get; set; }
        public Nullable<int> IdSucursal_oc { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<int> Secuencia_oc { get; set; }
    }
}
