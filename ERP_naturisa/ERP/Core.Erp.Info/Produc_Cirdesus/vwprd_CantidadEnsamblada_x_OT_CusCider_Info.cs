using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwprd_CantidadEnsamblada_x_OT_CusCider_Info
    {
        public int CantEnsamblada { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string CodObra { get; set; }
        public decimal CantidadPieza { get; set; }


        public vwprd_CantidadEnsamblada_x_OT_CusCider_Info() { }

    }
}
