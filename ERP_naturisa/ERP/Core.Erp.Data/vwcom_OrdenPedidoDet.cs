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
    
    public partial class vwcom_OrdenPedidoDet
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
        public bool Adjunto { get; set; }
        public string EstadoDetalle { get; set; }
        public string NombreArchivo { get; set; }
        public string NomComprador { get; set; }
    }
}