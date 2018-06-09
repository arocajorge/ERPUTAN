using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Activo_Fijo_Grupo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdGrupoActivoFijo { get; set; }
        public string codGrupoActivoFijo { get; set; }
        public string nom_GrupoActivoFijo { get; set; }
        public string Af_Grupo_Nombre { get; set; }
        public string estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

    }
}
