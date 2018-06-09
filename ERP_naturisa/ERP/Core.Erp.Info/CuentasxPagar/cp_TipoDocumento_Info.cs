using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_TipoDocumento_Info
    {
        //public int IdTipoDocumento { get; set; }
        public string CodTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public string DeclaraSRI { get; set; }
        public string CodSRI { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string GeneraRetencion { get; set; }
        public string Codigo_Secuenciales_Transaccion{ get; set; }
        public string Sustento_Tributario { get; set; }
        public string Codigo { get; set; }

        
        public cp_TipoDocumento_Info()
        {

        }

    }
}
