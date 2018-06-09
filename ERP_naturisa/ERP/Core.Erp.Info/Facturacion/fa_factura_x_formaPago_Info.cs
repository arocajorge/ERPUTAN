using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
  public  class fa_factura_x_formaPago_Info
    {
      public int IdEmpresa { get; set; }
      public int IdSucursal { get; set; }
      public int IdBodega { get; set; }
      public decimal IdCbteVta { get; set; }
      public string IdFormaPago { get; set; }
      public string observacion { get; set; }

      
      public fa_factura_x_formaPago_Info() { }
    }
}
