using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Info.Inventario
{
  public  class in_Aprobacion_Ing_a_bod_x_OC_Info
    {
      public int IdEmpresa { get; set; }
      public decimal IdAprobacion { get; set; }
      public string Serie { get; set; }
      public string AutoProveedor { get; set; }
      public string AutoImprenta { get; set; }
      public DateTime Fecha_factura { get; set; }
      public double Cargo_Adic_s_iva { get; set; }

      public double Base_Imp0 { get; set; }
      public double Cargo_Adic_iva { get; set; }
      public double Descuento { get; set; }
      public double Subtotal { get; set; }
      public double SubTotal_ant_iva { get; set; }
      public double Valor_iva { get; set; }
      public double Total_fact { get; set; }

      public string Observacion { get; set; }

      public int IdEmpresa_og { get; set; }
      public decimal IdCbteCble_Ogiro_og { get; set; }
      public int IdTipoCbte_Ogiro_og { get; set; }



    }
}
