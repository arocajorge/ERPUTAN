using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_orden_giro_pagos_sri_Info
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string codigo_pago_sri { get; set; }
        public string formas_pago_sri { get; set; }
        public bool check { get; set; }

       public cp_orden_giro_pagos_sri_Info(){}
    }
}
