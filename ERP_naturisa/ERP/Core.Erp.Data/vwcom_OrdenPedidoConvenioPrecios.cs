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
    
    public partial class vwcom_OrdenPedidoConvenioPrecios
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdSucursalDestino { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public double opd_Cantidad { get; set; }
        public double opd_CantidadApro { get; set; }
        public string opd_EstadoProceso { get; set; }
        public string opd_Detalle { get; set; }
        public bool Adjunto { get; set; }
        public string NombreArchivo { get; set; }
        public string IdUsuarioCantidad { get; set; }
        public Nullable<System.DateTime> FechaCantidad { get; set; }
        public string IdUsuarioCotizacion { get; set; }
        public Nullable<System.DateTime> FechaCotizacion { get; set; }
        public System.DateTime op_Fecha { get; set; }
        public string op_Observacion { get; set; }
        public decimal IdDepartamento { get; set; }
        public decimal IdSolicitante { get; set; }
        public string IdCatalogoEstado { get; set; }
        public bool Estado { get; set; }
        public decimal IdProveedor { get; set; }
        public decimal IdComprador { get; set; }
        public string IdTerminoPago { get; set; }
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
        public string IdUsuarioCreacion { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public double porcentaje { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public int Dias { get; set; }
    }
}
