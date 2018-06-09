using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{

   public  class tb_PersonaGrid_Info
    {

       public decimal IdPersona { get; set; }
       public string CodPersona { get; set; }
        public string Naturaleza { get; set; }
        public string nombreCompleto { get; set; }
        public string razonSocial { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int   TipoPersona { get; set; }
        public string TipoDocumento { get; set; }
        public string cedulaRuc { get; set; }
        public string direccion { get; set; }
        public string telefonoCasa { get; set; }
        public string telefonoOfic { get; set; }
        public string telefonoInter { get; set; }
        public string telfono_Contacto { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string fax { get; set; }
        public string casilla { get; set; }
        public string sexo { get; set; }
        public string  EstadoCivil { get; set; }
        public DateTime ? fechaNacimiento { get; set; }
        public string estado { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public DateTime? fechaModificacion { get; set; }


        public tb_persona_Info _persona { get; set; }



        public tb_PersonaGrid_Info() { }


    }
}
