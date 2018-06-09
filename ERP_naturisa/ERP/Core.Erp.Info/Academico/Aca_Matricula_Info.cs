using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class Aca_Matricula_Info
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public decimal IdMatricula { get; set; }
        public string CodMatricula { get; set; }
        public DateTime Fecha_matricula { get; set; }
        
        
        public decimal IdEstudiante { get; set; }
        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public int IdPeriodoLectivo { get; set; }
        public decimal? IdFamiliar_repre_legal { get; set; }
        public decimal? IdFamiliar_repre_econ { get; set; }
        public string Observacion { get; set; }       
        public string Estado { get; set; }
        public int IdParalelo { get; set; }

        public bool Si_estoy_deacuerdo_foto { get; set; }
        public bool Cod_convivencia_doy_fe { get; set; }
        public bool No_estoy_deacuerdo_foto { get; set; }

       //OBTENER DATA DE LAS VISTAS
        public string cod_estudiante { get; set; }
        public decimal IdContrato { get; set; }
 
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_telefonoOfic { get; set; }
        public DateTime FechaCreacionEstudiante { get; set; } 
        ///////////////////////////////////////////////////
        ////public Nullable<bool> estado_matricula_con_contrato { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public Nullable<bool> tiene_seguro { get; set; }

        //public Aca_Anio_Lectivo Aca_Anio_Lectivo { get; set; }
        //public virtual Aca_estudiante Aca_estudiante { get; set; }
        //public virtual Aca_Familiar Aca_Familiar { get; set; }
        //public virtual Aca_Familiar Aca_Familiar1 { get; set; }
        //public virtual Aca_Paralelo Aca_Paralelo { get; set; }

        public Aca_Estudiante_Info estudianteInfo { get; set; }
        public Aca_Curso_Info cursoInfo { get; set; }
        public List<Aca_Familiar_Info> listaFamiliar = new List<Aca_Familiar_Info>();
        public List<Aca_Matricula_x_Documento_Info> listaDocumento = new List<Aca_Matricula_x_Documento_Info>();
        public Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info Forma_Debito { get; set; }
         


        public Aca_Matricula_Info() {
            estudianteInfo = new Aca_Estudiante_Info();
            Forma_Debito = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
        }
    }
}
