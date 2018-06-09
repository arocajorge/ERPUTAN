using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
  public  class prd_Operador_Info
    {
       public int IdOperador { get; set; }
       public int IdEmpleado { get; set; }
       public string NomEmpleado { get; set; }
       public string IdUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string MotiAnula { get; set; }
       public string Estado { get; set; }
    }
}
