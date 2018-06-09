using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_TipoNota_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoNota { get; set; }
        public string CodTipoNota { get; set; }
        public string Tipo { get; set; }
        public string no_Descripcion { get; set; }
        public string IdCtaCble { get; set; }
        public string Nemonico { get; set; }
        public string InternoSis { get; set; }
        public string SeDeclaraSRI { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }

        public fa_TipoNota_Info() { }

        
    }
}
