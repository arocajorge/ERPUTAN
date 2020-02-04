using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public class XCOL_Rpt002_Info
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public int IdParalelo { get; set; }
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public string IdAnioLectivo { get; set; }
        public decimal IdMatricula { get; set; }
        public decimal IdEstudiante { get; set; }
        public string Institucion { get; set; }
        public string Sede { get; set; }
        public string Jornada { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }
        public string nombre_estudiante { get; set; }
        public string apellido_estudiante { get; set; }
        public string cedula_estudiante { get; set; }
        public string direccion_estudiante { get; set; }
        public string telefono_casa_estudiante { get; set; }
        public string telefono_oficina_estudiante { get; set; }
        public string cod_estudiante { get; set; }
        public System.DateTime FechaMatricula { get; set; }
        public Nullable<System.DateTime> Fecha_Ingreso_estudiante { get; set; }
        public string sexo_estudiante { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento_estudiante { get; set; }
        public string correo_estudiante { get; set; }
        public string CodCurso { get; set; }
        public string estado_matricula { get; set; }
        public string nacionalidad_estudiante { get; set; }
        public string lugar_estudiante { get; set; }
        public string sector { get; set; }
        public bool Si_estoy_deacuerdo_foto { get; set; }
        public bool No_estoy_deacuerdo_foto { get; set; }
        public bool Cod_convivencia_doy_fe { get; set; }
        public string nombre_familiar { get; set; }
        public string apellido_familiar { get; set; }
        public string cedula_familiar { get; set; }
        public string direccion_familiar { get; set; }
        public string telefonoCasa_familiar { get; set; }
        public string telefonoOficina_familiar { get; set; }
        public string celular_familiar { get; set; }
        public string correo_familiar { get; set; }
        public string profesion_familiar { get; set; }
        public string ocupacion_laboral_familiar { get; set; }
        public string empresa_familiar { get; set; }
        public string direccion_empresa_familiar { get; set; }
        public string nacionalidad_familiar { get; set; }
        public string IdParentesco_cat { get; set; }
        public bool activo { get; set; }

    }
}
