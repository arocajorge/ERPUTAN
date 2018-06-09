using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Academico
{
    public class Aca_Familiar_x_Estudiante_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public decimal IdFamiliar { get; set; }
        public string IdParentesco_cat { get; set; }
        public bool activo { get; set; }
        public bool esta_autorizado_ret_alum { get; set; }
        public bool esta_autorizado_recibir_not_mail { get; set; }
        public bool Vive_con_el_estudiante { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<int> porcentaje_dual { get; set; }

        public tb_persona_Info Persona_Info { get; set; }
        public Aca_Familiar_Info Familiar_Info { get; set; }
        public Aca_Familiar_x_Estudiante_Info()
        {
            Persona_Info = new tb_persona_Info();
            Familiar_Info = new Aca_Familiar_Info();
        }
    }
}
