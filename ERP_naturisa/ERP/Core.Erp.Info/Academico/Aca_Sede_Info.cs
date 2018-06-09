using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
 public   class Aca_Sede_Info
    {

        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Aca_Institucion_Info institucionInfo { get; set; }
        public string CodSede { get; set; }
        public string CodAlterno { get; set; }
        public string DescripcionSede { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public string Su_Descripcion { get; set; }
        public string Su_CodigoEstablecimiento { get; set; }

        public Aca_Sede_Info() {
            institucionInfo = new Aca_Institucion_Info();
        }
    }
}
