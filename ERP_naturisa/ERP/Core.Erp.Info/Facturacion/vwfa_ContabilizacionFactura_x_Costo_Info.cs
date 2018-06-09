using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class vwfa_ContabilizacionFactura_x_Costo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public decimal IdProducto { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public double vt_costo { get; set; }

        public string IdCentro_Costo_Costo { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }

        public vwfa_ContabilizacionFactura_x_Costo_Info()
        {
                
        }
    }
}
