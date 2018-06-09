using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public  class Aca_CatalogoTipo_Info
    {
       	
       public string IdTipoCatalogo { get; set; }
       public string Descripcion { get; set; }
       public string estado { get; set; }
       public string IdUsuario { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> FechaUltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string MotiAnula { get; set; }


       public Aca_CatalogoTipo_Info() { }
    }
}
