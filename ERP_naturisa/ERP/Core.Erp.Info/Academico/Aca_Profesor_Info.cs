using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
     public class Aca_Profesor_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdProfesor { get; set; }
        public string CodProfesor { get; set; }
        public decimal IdPersona { get; set; }
        public string estado { get; set; }
        public tb_persona_Info Persona_Info { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string Base { get; set; }
        public string MotivoAnulacion { get; set; }

        public Aca_Profesor_Info(int IdInstitucion_, decimal IdProfesor_, string CodProfesor_
            , decimal IdPersona_, string estado_)
        {
            Persona_Info = new tb_persona_Info();
            IdInstitucion = IdInstitucion_;
            IdProfesor=IdProfesor_;
            CodProfesor = CodProfesor_;
            IdPersona = IdPersona_;
            estado = estado_;
        }

        public Aca_Profesor_Info() {
            Persona_Info = new tb_persona_Info();
        }
    }
}
