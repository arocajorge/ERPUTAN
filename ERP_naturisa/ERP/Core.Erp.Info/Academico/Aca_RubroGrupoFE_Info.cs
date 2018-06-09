using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_RubroGrupoFE_Info
    {
        public int IdInstitucion { get; set; }
        public int IdGrupoFE { get; set; }
        public string CodGrupoFE { get; set; }
        public string nom_GrupoFe { get; set; }
        public string estado { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        
       public Aca_RubroGrupoFE_Info()
        {
        }
    }
}
