using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_TablaSectorial_Info
    {
        public int IdCodSectorial { get; set; }
        public string CodigoIESS { get; set; }
        public string Actividad { get; set; }
        public string EstructuraOcupacional { get; set; }
        public string Estado { get; set; }

        public string MotiAnula { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }


        public string nom_pc { get; set; }
        public string ip { get; set; }

        public ro_TablaSectorial_Info()
        {

        }
    }

   
   
}
