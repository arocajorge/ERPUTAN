using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Contrato_x_Estudiante_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdContrato { get; set; }
        public decimal IdMatricula { get; set; }
        public Nullable<decimal> IdParalelo { get; set; }
        public Nullable<decimal> IdCurso { get; set; }
        public Nullable<decimal> IdSeccion { get; set; }
        public Nullable<decimal> IdJornada { get; set; }
        public int IdSede { get; set; }

        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public decimal IdEstudiante { get; set; }
        public string observacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public bool estado_contrato_con_prefactura { get; set; }
        public bool estado_contrato_pago_garantizado { get; set; }
        public bool estado { get; set; }

        /////  Info de Vistas
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_telefonoOfic { get; set; }
        public DateTime FechaCreacionEstudiante { get; set; }

        public string Institucion { get; set; }
        public string Sede { get; set; }
        public string Jornada { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }

        

        public string CodMatricula { get; set; }
        public DateTime Fecha_matricula { get; set; }
        public string cod_estudiante { get; set; }
        //////////////////////////////////////////////////////
        //public string IdAnioLectivo_Per { get; set; }
        //public Nullable<int> IdPeriodo_Per { get; set; }
        //public Nullable<decimal> IdRubro { get; set; }
        //public string Descripcion_rubro { get; set; }
        //public Nullable<double> Valor { get; set; }
        //public string nom_beca { get; set; }
        //public Nullable<int> TieneBeca { get; set; }

    

        public bool chequear { get; set; }

        public Aca_Contrato_x_Estudiante_Info() {}
    }
}
