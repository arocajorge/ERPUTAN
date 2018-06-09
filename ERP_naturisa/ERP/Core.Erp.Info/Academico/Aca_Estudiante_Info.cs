using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Info.Academico
{
    /// <summary>
    /// academico
    /// </summary>
    public class Aca_Estudiante_Info
    {

        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public string cod_estudiante { get; set; }
        public string cod_estudiante2 { get; set; }

        public string NombreCompleto { get; set; }
        public string lugar { get; set; } 
        public string barrio { get; set; }     
        public byte[] foto { get; set; }
        public string estado { get; set; }

        public tb_persona_Info Persona_Info { get; set; }

        public tb_pais_Info Pais_Info { get; set; }
        public tb_pais_Info Pais_Info2 { get; set; }
        public tb_pais_Info Pais_Info3 { get; set; }
        public string cod_alterno { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        /*VISUALIZACION DE DATOS DE ESTUDIANTE*/
        public int IdSede { get; set; }
        public int IdJornada { get; set; }
        public int IdSeccion { get; set; }
        public int IdCurso { get; set; }
        public int IdParalelo { get; set; }

        public string Sede { get; set; }
        public string Jornada { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }

        public decimal IdMatricula { get; set; }
        public Nullable<decimal> IdContrato { get; set; }

        public decimal IdPersona_RepEco { get; set; }
        /*FIN DE VISUALIZACION DATOS ESTUDIANTE*/


        
        public List<Aca_Familiar_Info> listaFamiliar=new List<Aca_Familiar_Info>();

        public Aca_Familiar_Info Info_Familiar_Repre_Econo { get; set; }
        public Aca_Familiar_Info Info_Familiar_Padre { get; set; }
        public Aca_Familiar_Info Info_Familiar_Madre { get; set; }
        public Aca_Familiar_Info Info_Familiar_Repre_Legal { get; set; }




        public List<Aca_Estudiante_x_Alergia_Info> listaAlergias = new List<Aca_Estudiante_x_Alergia_Info>();
        public Aca_ficha_medica_Info FichaMedica_Info;

        public Aca_Estudiante_Info() {
            Persona_Info = new tb_persona_Info();
            Pais_Info = new tb_pais_Info();
            Pais_Info2 = new tb_pais_Info();
            Pais_Info3 = new tb_pais_Info();
            FichaMedica_Info = new Aca_ficha_medica_Info();

            Info_Familiar_Repre_Econo = new Aca_Familiar_Info();
            Info_Familiar_Repre_Legal = new Aca_Familiar_Info();
            Info_Familiar_Padre = new Aca_Familiar_Info();
            Info_Familiar_Madre = new Aca_Familiar_Info();


        }
    }
}
