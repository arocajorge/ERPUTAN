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
    
    public partial class vwcom_OrdenPedidoDet_Cotizacion
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public int Secuencia { get; set; }
        public string pr_descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdSucursalDestino { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public double opd_Cantidad { get; set; }
        public double opd_CantidadApro { get; set; }
        public string opd_EstadoProceso { get; set; }
        public string opd_Detalle { get; set; }
        public string IdUnidadMedida_Consumo { get; set; }
        public Nullable<double> Stock { get; set; }
        public string nom_solicitante { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string IdUsuario_com { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public decimal IdSolicitante { get; set; }
        public decimal IdDepartamento { get; set; }
        public Nullable<decimal> IdComprador { get; set; }
        public Nullable<bool> EsCompraUrgente { get; set; }
        public bool Adjunto { get; set; }
        public System.DateTime op_Fecha { get; set; }
        public string op_Observacion { get; set; }
        public string NombreArchivo { get; set; }
        public string Grupo { get; set; }
        public Nullable<System.DateTime> FechaCantidad { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public Nullable<double> cd_precioCompra { get; set; }
        public Nullable<double> cd_porc_des { get; set; }
        public Nullable<double> cd_descuento { get; set; }
        public Nullable<double> cd_precioFinal { get; set; }
        public Nullable<double> cd_subtotal { get; set; }
        public Nullable<double> Por_Iva { get; set; }
        public Nullable<double> cd_iva { get; set; }
        public Nullable<double> cd_total { get; set; }
        public string cd_DetallePorItem { get; set; }
        public string EstadoDetalle { get; set; }
        public string ObservacionGA { get; set; }
        public string su_Descripcion { get; set; }
        public string CodigoOC { get; set; }
    }
}
