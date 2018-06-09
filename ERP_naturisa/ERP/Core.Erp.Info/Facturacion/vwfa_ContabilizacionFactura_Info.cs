using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class vwfa_ContabilizacionFactura_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string IdCategoria { get; set; }
        public bool vt_tieneIVA { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> iva { get; set; }
        public Nullable<double> Total { get; set; }
        public vwfa_ContabilizacionFactura_Info()
        {

        }

        public string IdCtaCble { get; set; }

        public double? Descuento { get; set; }
    }
}
