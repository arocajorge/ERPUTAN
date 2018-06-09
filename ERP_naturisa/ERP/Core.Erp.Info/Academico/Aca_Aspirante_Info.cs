using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Aspirante_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdAspirante { get; set; }
        public string CodAspirante { get; set; }
        public string Lugar { get; set; }        
        public string Barrio { get; set; }
        public byte[] Foto { get; set; }
        public string Estado { get; set; }
        public string CodAlterno { get; set; }
        public tb_persona_Info Persona_Info { get; set; }
        public tb_pais_Info Pais_Info { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public Aca_Aspirante_Info() {
            Persona_Info = new tb_persona_Info();
            Pais_Info = new tb_pais_Info();
        }
    }
}
