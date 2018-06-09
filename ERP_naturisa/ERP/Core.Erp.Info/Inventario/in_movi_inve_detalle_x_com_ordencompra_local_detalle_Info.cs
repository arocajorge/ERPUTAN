using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info
    {
        public int mi_IdEmpresa { get; set; }
        public int mi_IdSucursal { get; set; }
        public int mi_IdBodega { get; set; }
        public int mi_IdMovi_inven_tipo { get; set; }
        public decimal mi_IdNumMovi { get; set; }
        public int mi_Secuencia { get; set; }
        public int ocd_IdEmpresa { get; set; }
        public int ocd_IdSucursal { get; set; }
        public decimal ocd_IdOrdenCompra { get; set; }
        public int ocd_Secuencia { get; set; }
        public string observacion { get; set; }

       public  in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info(){}
    }
}
