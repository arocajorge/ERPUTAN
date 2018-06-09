using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
   public class tb_persona_direccion_tipo_Info
    {

       public int IdTipoDireccion { get; set; }
       public string nom_TipoDireccion { get; set; }

       public tb_persona_direccion_tipo_Info()
       {

       }
       public tb_persona_direccion_tipo_Info(int _IdTipoDireccion, string _nom_TipoDireccion)
       {
           IdTipoDireccion = _IdTipoDireccion;
           nom_TipoDireccion = _nom_TipoDireccion;

            
       }
    }
}
