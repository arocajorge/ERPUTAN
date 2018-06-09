using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
  public  class prd_PuenteGrua_Info
    {
      public int idEmpresa { get; set; }
      public int Idsucural { get; set; }
      public int idPuenteGrua { get; set; }
      public string nombre { get; set; }
      public string marca { get; set; }
      public int tonelada_Soporta { get; set; }
      public string IdUsuario { get; set; }
      public int IdOperador { get; set; }
      public DateTime Fecha_Transac { get; set; }
      public string IdUsuarioUltMod { get; set; }
      public DateTime Fecha_UltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public DateTime Fecha_UltAnu { get; set; }
      public string nom_pc { get; set; }
      public string ip { get; set; }
      public string MotiAnula { get; set; }
      public string estado { get; set; }
     
    }
}
