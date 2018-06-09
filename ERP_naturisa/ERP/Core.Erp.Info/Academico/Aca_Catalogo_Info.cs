using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Catalogo_Info
    {
        public string IdCatalogo { get; set; }
        public string IdTipoCatalogo { get; set; }        
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
        public string Estado { get; set; }
        public int Orden { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime ? FechaUltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime ? Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public Aca_CatalogoTipo_Info catalogoTipo_Info { get; set; }

        public Aca_Catalogo_Info() {
            catalogoTipo_Info = new Aca_CatalogoTipo_Info();
        }
    }
}
