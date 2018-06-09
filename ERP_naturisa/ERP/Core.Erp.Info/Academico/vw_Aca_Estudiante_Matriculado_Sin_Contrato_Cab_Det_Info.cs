using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public int IdParalelo { get; set; }
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public decimal IdMatricula { get; set; }
        public string cod_estudiante { get; set; }
        public decimal IdContrato { get; set; }
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
        public Nullable<int> IdAnioLectivo_Rubro_x_Periodo { get; set; }
        public decimal IdEstudiante { get; set; }
        public Nullable<int> IdRubro { get; set; }
        public Nullable<double> Valor { get; set; }
        public Nullable<int> IdPeriodo_Per { get; set; }
        public Nullable<int> IdInstitucion_per { get; set; }
        public vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info(){}
    }
}
