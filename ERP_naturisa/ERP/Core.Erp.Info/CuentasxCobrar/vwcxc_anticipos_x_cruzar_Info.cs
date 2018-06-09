using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
  public  class vwcxc_anticipos_x_cruzar_Info
    {
      public int IdEmpresa_Cobro { get; set; }
      public int IdSucursal_cobro { get; set; }
      public decimal IdCobro_cobro { get; set; }
      public int IdEmpresa { get; set; }
      public decimal IdAnticipo { get; set; }
      public int IdSucursal { get; set; }
      public decimal IdCliente { get; set; }
      public DateTime Fecha { get; set; }
      public string Observacion { get; set; }
      public string  pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string IdCobro_tipo { get; set; }
      public string  cr_Banco { get; set; }
      public string cr_NumDocumento { get; set; }
      public int IdCaja { get; set; }
      public double cr_TotalCobro { get; set; }
      public double Saldo_Pendiente { get; set; }

      public vwcxc_anticipos_x_cruzar_Info() { }
    }
}
