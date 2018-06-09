using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public  class in_Motivo_Inven_Borrar_Info
    {

        public int IdEmpresa { get; set; }
        public int IdMotivo_Inv { get; set; }
        public string Cod_Motivo_Inv { get; set; }	
        public string Desc_mov_inv { get; set; }
        public string Genera_Movi_Inven { get; set; }
        public DateTime ? Fecha_Transac { get; set; }
        public string estado { get; set; }
        public string Genera_CXP { get; set; }
    }
}
