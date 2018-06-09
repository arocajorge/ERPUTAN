using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Estudiante_x_Alergia_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public bool Activo { get; set; }
        public string IdAlergiaCatalogo { get; set; }
        public string NombreAlergia { get; set; }
        public string Comentario { get; set; }
        public string Esta_en_Base { get; set; }
        public Aca_Estudiante_x_Alergia_Info() { }
    }
}
