
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_RubroTipo_Info
    {
        public int IdTipoRubro { get; set; }
        public string CodTipoRubro { get; set; }
        public string DescripcionTipoRubro { get; set; }
        public string Estado { get; set; }
        public string IdRubroComportamiento_cat { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
      
      public Aca_RubroTipo_Info() { }

    }
}
