using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
  public  class vwfa_ContabilizarNotaCredDeb_x_Item_Info
    {

      public int IdEmpresa	 { get; set; }
      public int IdSucursal { get; set; }
      public int IdBodega { get; set; }
      public decimal IdNota { get; set; }
      public double ? Iva	 { get; set; }
      public double ? Sub_total	 { get; set; }
      public double ? Total	 { get; set; }
      public double ? Des_total	 { get; set; }
      public int ? IdPunto_cargo_grupo { get; set; }
      public int ?IdPunto_Cargo		 { get; set; }
      public decimal IdProducto { get; set; }
      public string IdCtaCble_Vta { get; set; }
      public string IdCtaCble_Des0 { get; set; }
      public string IdCtaCble_DesIva { get; set; }
      public string IdCod_Impuesto_Iva { get; set; }
      public string IdCod_Impuesto_Ice { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdCentroCosto_sub_centro_costo { get; set; }
      public string IdCtaCble_Iva { get; set; }
      public string IdCtaCble_Ice { get; set; }

    }
}
