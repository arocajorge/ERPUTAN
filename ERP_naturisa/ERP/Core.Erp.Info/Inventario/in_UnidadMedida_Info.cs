using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_UnidadMedida_Info
    {
       public string IdUnidadMedida { get; set; }
       public string cod_alterno  { get; set; }
       public string Descripcion { get; set; }
       public string Descripcion2 { get; set; }
       public string Usado_en_Movimiento { get; set; }
       public string Estado { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltMod { get; set; }

       public List<in_UnidadMedida_Equiv_conversion_Info>  listUnidadMedida_Equiv_conversion { get; set; }



       public in_UnidadMedida_Info()
       {
           listUnidadMedida_Equiv_conversion = new List<in_UnidadMedida_Equiv_conversion_Info>();
       }
      

    }
}
