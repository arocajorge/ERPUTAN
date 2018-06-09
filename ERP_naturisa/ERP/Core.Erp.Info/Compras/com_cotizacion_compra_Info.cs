using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
   public class com_cotizacion_compra_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdSucursal { get; set; }
        public int IdProveedor { get; set; }
        public string Observacion { get; set; }
        public List<com_cotizacion_compra_det_Info> Detalle { get; set; }
        public string estado { get; set; }
        public string nom_sucursal { get; set; }
        public string idUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime FechaHoraAnul { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public string motiAnulacion { get; set; }
        public  com_cotizacion_compra_Info()
        {
            Detalle = new List<com_cotizacion_compra_det_Info>();
        }
        
    }
}
