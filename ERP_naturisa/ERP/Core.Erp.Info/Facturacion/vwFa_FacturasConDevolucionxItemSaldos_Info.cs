using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class vwFa_FacturasConDevolucionxItemSaldos_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevolucion { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdCbteVta { get; set; }
        public double vt_cantidad { get; set; }
        public double dv_cantidad { get; set; }
        public double dv_saldo { get; set; }
        public double vt_iva { get; set; }
        public string vt_tieneIVA { get; set; }
        public double vt_PorDesc { get; set; }
        public double vt_DescUni { get; set; }
        public double vt_Precio { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_costo { get; set; }

        public double dv_seguro { get; set; }
        public double dv_flete { get; set; }
        public double dv_interes { get; set; }
        public double dv_OtroValor1 { get; set; }
        public double dv_OtroValor2 { get; set; }

        public vwFa_FacturasConDevolucionxItemSaldos_Info()
        {

        }
    }
}
