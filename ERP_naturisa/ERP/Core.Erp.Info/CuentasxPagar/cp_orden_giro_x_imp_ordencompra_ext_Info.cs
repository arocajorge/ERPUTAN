using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public  class cp_orden_giro_x_imp_ordencompra_ext_Info
    {
        
        public	int	og_IdEmpresa { get; set; }
        public	decimal og_IdCbteCble { get; set; }
        public	int	og_IdTipoCbte { get; set; }
        public	int	imp_IdEmpresa { get; set; }
        public	int	imp_IdSucursal { get; set; }
        public	decimal	imp_IdOrdenCompraExt { get; set; }

        public cp_orden_giro_x_imp_ordencompra_ext_Info(){}
    }
}
