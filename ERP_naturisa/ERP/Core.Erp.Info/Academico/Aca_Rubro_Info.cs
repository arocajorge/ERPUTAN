using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public  class Aca_Rubro_Info
    {
        public int IdRubro { get; set; }
        public int IdInstitucion { get; set; }
        public string CodRubro { get; set; }
        public string Descripcion_rubro { get; set; }
        public string estado { get; set; }
        public string CodAlterno { get; set; }
        public string IdTipoServicio { get; set; }
        public Nullable<int> IdGrupoFE { get; set; }
        public int IdTipoRubro { get; set; }
        public string IdCtaCble { get; set; }
        public int NumeroCoutas { get; set; }
        public string Deb_cred { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<int> IdEmpresa_inv { get; set; }
        public Nullable<decimal> IdProducto_inv { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public string IdCentroCosto_ct { get; set; }

        public Aca_Rubro_Info() 
        { 
        }
    }
}
