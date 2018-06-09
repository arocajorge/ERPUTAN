using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
 public   class vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info
    {

        public int IdEmpresa { get; set; }
        public string ID { get; set; }
        public string IdPadre { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public int Nivel { get; set; }
        public int? IdInstitucion { get; set; }
        public int? IdSede { get; set; }
        public int? IdJornada { get; set; }
        public int? IdSeccion { get; set; }
        public int? IdCurso { get; set; }
        public int? IdParalelo { get; set; }

        public string Tipo { get; set; }

        public vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info() { }
    }
}
