using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_Estudiante_con_Matricula_Sin_Contrato_Info
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public int IdParalelo { get; set; }
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public string cod_estudiante { get; set; }

        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }


        public decimal IdMatricula { get; set; }
        public decimal IdEstudiante { get; set; }
        public string Institucion { get; set; }
        public string Sede { get; set; }
        public string Jornada { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_telefonoOfic { get; set; }

        public vwAca_Estudiante_con_Matricula_Sin_Contrato_Info() { }
    }
}
