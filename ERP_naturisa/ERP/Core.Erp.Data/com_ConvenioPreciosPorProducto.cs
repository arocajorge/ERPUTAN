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
    
    public partial class com_ConvenioPreciosPorProducto
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdProveedor { get; set; }
        public decimal IdComprador { get; set; }
        public string IdTerminoPago { get; set; }
        public string IdUnidadMedida { get; set; }
        public double PrecioUnitario { get; set; }
        public double PorDescuento { get; set; }
        public double Descuento { get; set; }
        public double PrecioFinal { get; set; }
        public int TiempoEntrega { get; set; }
        public System.DateTime FechaFin { get; set; }
        public bool SaltaPaso2 { get; set; }
        public bool SaltaPaso3 { get; set; }
        public bool SaltoPaso4 { get; set; }
        public bool SaltoPaso5 { get; set; }
    
        public virtual com_comprador com_comprador { get; set; }
        public virtual com_TerminoPago com_TerminoPago { get; set; }
    }
}
