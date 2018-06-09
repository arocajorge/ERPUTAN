
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
   public class tb_pais_Info
    {
        public string IdPais { get; set; }
        public string CodPais { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string estado { get; set; }

       public string IdUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string MotivoAnula { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       

        public tb_pais_Info(){}
    }
}
