//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class com_catalogo
    {
        public com_catalogo()
        {
            this.com_ordencompra_local = new HashSet<com_ordencompra_local>();
            this.com_ordencompra_local1 = new HashSet<com_ordencompra_local>();
            this.com_solicitud_compra = new HashSet<com_solicitud_compra>();
            this.com_solicitud_compra_det_pre_aprobacion = new HashSet<com_solicitud_compra_det_pre_aprobacion>();
            this.com_solicitud_compra_det_aprobacion = new HashSet<com_solicitud_compra_det_aprobacion>();
            this.com_solicitud_compra_det_aprobacion1 = new HashSet<com_solicitud_compra_det_aprobacion>();
            this.com_parametro = new HashSet<com_parametro>();
            this.com_parametro1 = new HashSet<com_parametro>();
            this.com_parametro2 = new HashSet<com_parametro>();
            this.com_OrdenPedido = new HashSet<com_OrdenPedido>();
        }
    
        public string IdCatalogocompra { get; set; }
        public string IdCatalogocompra_tipo { get; set; }
        public string CodCatalogo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Abrebiatura { get; set; }
        public string NombreIngles { get; set; }
        public Nullable<int> Orden { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual com_catalogo_tipo com_catalogo_tipo { get; set; }
        public virtual ICollection<com_ordencompra_local> com_ordencompra_local { get; set; }
        public virtual ICollection<com_ordencompra_local> com_ordencompra_local1 { get; set; }
        public virtual ICollection<com_solicitud_compra> com_solicitud_compra { get; set; }
        public virtual ICollection<com_solicitud_compra_det_pre_aprobacion> com_solicitud_compra_det_pre_aprobacion { get; set; }
        public virtual ICollection<com_solicitud_compra_det_aprobacion> com_solicitud_compra_det_aprobacion { get; set; }
        public virtual ICollection<com_solicitud_compra_det_aprobacion> com_solicitud_compra_det_aprobacion1 { get; set; }
        public virtual ICollection<com_parametro> com_parametro { get; set; }
        public virtual ICollection<com_parametro> com_parametro1 { get; set; }
        public virtual ICollection<com_parametro> com_parametro2 { get; set; }
        public virtual ICollection<com_OrdenPedido> com_OrdenPedido { get; set; }
    }
}
