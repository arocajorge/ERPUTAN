using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
   public    class tb_provincia_Info
    {
        public string IdProvincia { get; set; }
        public string CodProvincia { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string IdPais { get; set; }
        public string Cod_Region { get; set; }

        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        
       public tb_provincia_Info() { }
    }
}
