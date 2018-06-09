using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
   public class com_ordencompra_local_det_x_com_solicitud_compra_det_Info
    {

        public int ocd_IdEmpresa { get; set; }
        public int ocd_IdSucursal { get; set; }
        public decimal ocd_IdOrdenCompra { get; set; }
        public int ocd_Secuencia { get; set; }

        public int scd_IdEmpresa { get; set; }
        public int scd_IdSucursal { get; set; }
        public decimal scd_IdSolicitudCompra { get; set; }
        public int scd_Secuencia { get; set; }

        public string observacion { get; set; }




        public  com_ordencompra_local_det_x_com_solicitud_compra_det_Info(){}
    }
}
