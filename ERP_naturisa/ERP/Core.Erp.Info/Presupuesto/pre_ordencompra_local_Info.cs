using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Presupuesto
{
   public class pre_ordencompra_local_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal? IdProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public DateTime oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public DateTime? co_fecha_aprobacion { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public string IdUsuario_Reprue { get; set; }
        public DateTime? co_fechaReproba { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; } 
        public DateTime? FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string EstadoRecepcion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string IdTerminoPago { get; set; }
        public string FormaEnvio { get; set; }
        public string CondicionPago { get; set; }
        public string IdUsuario { get; set; }


        public List<pre_ordencompra_local_det_Info> LstPedidoOC_det { get; set; }


       public pre_ordencompra_local_Info(){}
    }
}
