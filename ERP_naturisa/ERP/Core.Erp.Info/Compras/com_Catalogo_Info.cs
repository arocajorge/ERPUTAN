using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_Catalogo_Info
    {

        public string IdCatalogocompra { get; set; } 
        public string IdCatalogocompra_tipo { get; set; }
        public string CodCatalogo { get; set; }
        public string IdTipoCatalogo { get; set; } 
		public string descripcion{ get; set; } 
		public string estado{ get; set; }
        public int ? orden { get; set; } 
        public string Abrebiatura { get; set; }
		public string Nombre{ get; set; }
        public string name { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }


        public string IdEstadoAprobacion { get; set; }


        public com_Catalogo_Info() { }

    }
}
