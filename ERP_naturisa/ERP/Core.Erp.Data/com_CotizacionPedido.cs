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
    
    public partial class com_CotizacionPedido
    {
        public com_CotizacionPedido()
        {
            this.com_CotizacionPedidoDet = new HashSet<com_CotizacionPedidoDet>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProveedor { get; set; }
        public string IdTerminoPago { get; set; }
        public System.DateTime cp_Fecha { get; set; }
        public int cp_Plazo { get; set; }
        public int cp_PlazoEntrega { get; set; }
        public string cp_Observacion { get; set; }
        public decimal IdComprador { get; set; }
        public decimal IdSolicitante { get; set; }
        public decimal IdDepartamento { get; set; }
        public string EstadoJC { get; set; }
        public string EstadoGA { get; set; }
        public Nullable<int> oc_IdOrdenCompra { get; set; }
    
        public virtual com_departamento com_departamento { get; set; }
        public virtual com_TerminoPago com_TerminoPago { get; set; }
        public virtual ICollection<com_CotizacionPedidoDet> com_CotizacionPedidoDet { get; set; }
    }
}