using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class vwfa_ContabilizacionFactura_x_Item_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        //public bool vt_tieneIVA { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> iva { get; set; }
        public Nullable<double> Total { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string vt_tipo_venta { get; set; }
        public decimal vt_plazo { get; set; }
        public string IdCtaCble_DesIva { get; set; }
        public string IdCtaCble_Des0 { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public string IdCod_Impuesto_Ice { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdCtaCble_Imp_Iva { get; set; }
        public string IdCtaCble_Imp_Ice { get; set; }
        public Nullable<int> IdPunto_Cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public vwfa_ContabilizacionFactura_x_Item_Info()
        {

        }
    }
}
