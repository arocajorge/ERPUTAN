using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_ordencompra_ext_x_ct_cbtecble_Info
    {

        public int imp_IdEmpresa{ get; set; }
        public int imp_IdSucusal{ get; set; }
        public decimal imp_IdOrdenCompraExt { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte{ get; set; }
        public decimal ct_IdCbteCble { get; set; }
        public String TipoReg { get; set; }

        public imp_ordencompra_ext_x_ct_cbtecble_Info()
        {

        }

    }
}
