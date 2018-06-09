using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Info
    {

        public int go_IdEmpresa { get; set; }
        public decimal go_IdTransaccion { get; set; }
        public int go_IdDetTrans { get; set; }
        public int lm_IdEmpresa { get; set; }
        public decimal lm_IdListadoMateriales { get; set; }
        public int lm_IdDetalle { get; set; }

        public  com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Info(){}
    }
}
