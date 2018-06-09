using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_curso_Info
    {
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public string CodCurso { get; set; }
        public string CodAlternoCur { get; set; }
        public string Descripcion_cur { get; set; }
        public string Estado { get; set; }
        public string Descripcion_secc { get; set; }
        public string Descripcion_Jor { get; set; }

        public vwAca_curso_Info()
        {

        }
    }
}
