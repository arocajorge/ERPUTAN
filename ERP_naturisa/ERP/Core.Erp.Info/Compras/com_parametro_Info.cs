using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_parametro_Info
    {
        public int IdEmpresa { get; set; }
        public string IdEstadoAprobacion_OC { get; set; }
        public int IdMovi_inven_tipo_OC { get; set; }
        public string IdEstadoAnulacion_OC { get; set; }
        public int IdMovi_inven_tipo_dev_compra { get; set; }
        public string IdEstadoAprobacion_SolCompra { get; set; }


        public int IdSucursal_x_Aprob_x_SolComp { get; set; }
        public string  IdEstado_cierre{ get; set; }


        public com_parametro_Info()
        {

        }



    }
}
