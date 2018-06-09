using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_x_ct_cbtecble_Info
    {
        public int cbr_IdEmpresa { get; set; }
        public int cbr_IdSucursal { get; set; }
        public decimal cbr_IdCobro { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }


        public cxc_cobro_x_ct_cbtecble_Info() { }
    }
}
