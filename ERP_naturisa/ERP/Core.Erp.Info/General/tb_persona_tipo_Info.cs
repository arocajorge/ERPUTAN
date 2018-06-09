using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
   public class tb_persona_tipo_Info
    {
       public string IdTipo_Persona { get; set; }
       public string Descripcion { get; set; }

       public tb_persona_tipo_Info() { }

       public tb_persona_tipo_Info(string _IdTipo_Persona, string _Descripcion)
       {
           Descripcion = _Descripcion;
           IdTipo_Persona=_IdTipo_Persona;
       }
    }
}
