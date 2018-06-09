using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public  class in_Motivo_Inven_Info
    {

        public int IdEmpresa { get; set; }
        public int IdMotivo_Inv { get; set; }
        public string Cod_Motivo_Inv { get; set; }
        public string Desc_mov_inv { get; set; }
        public string Genera_Movi_Inven { get; set; }
        public string Genera_CXP { get; set; }
        public string Exigir_Punto_Cargo { get; set; }
        public string estado { get; set; }
        public string SEstado { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public ein_Inventario_O_Consumo es_Inven_o_Consumo { get; set; }
        public ein_Tipo_Ing_Egr Tipo_Ing_Egr { get; set; }



       /// <summary>
       ///  campos de Auditoria 
       /// </summary>
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
       ////////////////////////////////////////


    }
}
