using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
  public  class ro_sala_Info
  {
      public int IdEmpresa { get; set; }
      public int IdSala { get; set; }
      public string Sala { get; set; }
      public bool Estado { get; set; }
      public string IdUsuario { get; set; }
      public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
      public string IdUsuarioUltModi { get; set; }
      public Nullable<System.DateTime> Fecha_UltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
      public string MotivoAnulacion { get; set; }
      public string nom_pc { get; set; }
      public string ip { get; set; }
    }
}
