//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras
{
    using System;
    using System.Collections.Generic;
    
    public partial class com_solicitud_compra_det_pre_aprobacion
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal_SC { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia_SC { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdUsuarioAprueba { get; set; }
        public Nullable<System.DateTime> FechaHoraAprobacion { get; set; }
        public string do_observacion { get; set; }
    
        public virtual com_solicitud_compra_det com_solicitud_compra_det { get; set; }
    }
}
