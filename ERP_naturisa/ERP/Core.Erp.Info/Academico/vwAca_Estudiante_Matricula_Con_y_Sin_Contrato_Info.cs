using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info
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
        public Nullable<decimal> IdContrato { get; set; }
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
        public Nullable<System.DateTime> FechaCreacionEstudiante { get; set; }
        public System.DateTime FechaMatricula { get; set; }
        public bool chequeo { get; set; }

        public string pe_nombreCompleto { get; set; }
        public string nombreCompleto { get; set; }

        public string IdPais_Nacionalidad { get; set; }
        public string Nacionalidad { get; set; }
        public string lugar { get; set; }
        public string barrio { get; set; }
        public byte[] foto { get; set; }
        public string cod_alterno { get; set; }
        public string estado { get; set; }
        public decimal IdPersona { get; set; }
        public string IdTipoDocumento { get; set; }
        //public string pe_nombreCompleto { get; set; }
        public string pe_correo { get; set; }
        public string pe_celular { get; set; }
        public string pe_sexo { get; set; }
        public Nullable<System.DateTime> pe_fechaNacimiento { get; set; }

        public vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info() { }

    }
}
