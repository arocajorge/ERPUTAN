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
    
    public partial class com_OrdenPedidoPlantilla
    {
        public com_OrdenPedidoPlantilla()
        {
            this.com_OrdenPedidoPlantillaDet = new HashSet<com_OrdenPedidoPlantillaDet>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdPlantilla { get; set; }
        public string op_Codigo { get; set; }
        public string op_Observacion { get; set; }
        public bool Estado { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> FechaUltModi { get; set; }
        public string IdUsuarioAnu { get; set; }
        public Nullable<System.DateTime> FechaUltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public Nullable<bool> EsCompraUrgente { get; set; }
    
        public virtual ICollection<com_OrdenPedidoPlantillaDet> com_OrdenPedidoPlantillaDet { get; set; }
    }
}
