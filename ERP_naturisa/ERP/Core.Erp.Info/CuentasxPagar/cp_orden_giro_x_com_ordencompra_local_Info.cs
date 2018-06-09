using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_giro_x_com_ordencompra_local_Info
    {

        public int og_IdEmpresa{ get; set; }
        public decimal og_IdCbteCble{ get; set; }
        public int og_IdTipoCbte{ get; set; }
        public int com_IdEmpresa{ get; set; }
        public int com_IdSucursal{ get; set; }
        public decimal com_IdOrdenCompraLocal{ get; set; }
        public string og_Observacion{ get; set; }


        public cp_orden_giro_x_com_ordencompra_local_Info(){}
    }
}
