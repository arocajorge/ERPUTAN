using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Info
    {

        public int IdEmpresa { get; set; }
        public int IdAprobacion { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha_Aprobacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        

        public List<cp_Aprobacion_Orden_Pago_Det_Info> Detalle { get; set; }

        public cp_Aprobacion_Orden_Pago_Info()
        {
            Detalle = new List<cp_Aprobacion_Orden_Pago_Det_Info>();
        }
    }
}
