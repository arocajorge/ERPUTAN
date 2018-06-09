using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar
{
  public  class cxc_cobro_det_x_ct_cbtecble_det_Info
    {
      public int IdEmpresa_cb { get; set; }
      public int IdSucursal_cb { get; set; }
      public decimal IdCobro_cb { get; set; }
      public int secuencial_cb { get; set; }
      public int IdEmpresa_ct { get; set; }
      public int IdTipoCbte_ct { get; set; }
      public decimal IdCbteCble_ct { get; set; }
      public int secuencia_ct { get; set; }
      public int secuencia_reg { get; set; }
      public string observacion	 { get; set; }


    }
}
