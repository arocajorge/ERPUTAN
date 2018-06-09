using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
   public  class com_Motivo_Orden_Compra_Info
    {

       public int IdEmpresa { get; set; }
       public int IdMotivo { get; set; }
       public string Cod_Motivo { get; set; }
       public string Descripcion { get; set; }
       public string SEstado { get; set; }
       public string estado { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime FechaHoraAnul { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public string MotivoAnulacion { get; set; }

    }
}
