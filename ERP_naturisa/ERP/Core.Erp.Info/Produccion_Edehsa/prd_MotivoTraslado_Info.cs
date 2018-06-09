using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Produccion_Edehsa
{
    public class prd_MotivoTraslado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdMotivo_traslado { get; set; }
        public string codMotivo_traslado { get; set; }
        public string descripcion_motivo_traslado { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
    }
}
