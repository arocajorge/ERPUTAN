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
    
    public partial class com_CotizacionPedidoDet
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int Secuencia { get; set; }
        public int opd_IdEmpresa { get; set; }
        public decimal opd_IdOrdenPedido { get; set; }
        public int opd_Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double cd_Cantidad { get; set; }
        public double cd_precioCompra { get; set; }
        public double cd_porc_des { get; set; }
        public double cd_descuento { get; set; }
        public double cd_precioFinal { get; set; }
        public double cd_subtotal { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double Por_Iva { get; set; }
        public double cd_iva { get; set; }
        public double cd_total { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public bool EstadoJC { get; set; }
        public bool EstadoGA { get; set; }
        public string cd_DetallePorItem { get; set; }
    
        public virtual com_CotizacionPedido com_CotizacionPedido { get; set; }
        public virtual com_OrdenPedidoDet com_OrdenPedidoDet { get; set; }
    }
}
