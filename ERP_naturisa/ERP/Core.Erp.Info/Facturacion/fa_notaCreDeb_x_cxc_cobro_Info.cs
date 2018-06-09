using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
  public  class fa_notaCreDeb_x_cxc_cobro_Info
    {
      public int IdEmpresa_cbr { get; set; }
      public int IdSucursal_cbr { get; set; }
      public decimal IdCobro_cbr { get; set; }
      public int IdEmpresa_nt { get; set; }
      public int IdSucursal_nt { get; set; }
      public int IdBodega_nt { get; set; }
      public decimal IdNota_nt { get; set; }
      public double Valor_cobro { get; set; }


      public fa_notaCreDeb_x_cxc_cobro_Info() { }
    }
}
