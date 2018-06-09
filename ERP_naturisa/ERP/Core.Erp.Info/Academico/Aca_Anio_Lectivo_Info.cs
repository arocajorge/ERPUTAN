using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Anio_Lectivo_Info
    {
        public int IdInstitucion { get; set; }
        
        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public Aca_Anio_Lectivo_Info() { }
    }
}
