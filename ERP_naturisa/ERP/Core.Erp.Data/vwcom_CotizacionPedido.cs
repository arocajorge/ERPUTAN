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
    
    public partial class vwcom_CotizacionPedido
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProveedor { get; set; }
        public string IdTerminoPago { get; set; }
        public System.DateTime cp_Fecha { get; set; }
        public int cp_Plazo { get; set; }
        public string cp_Observacion { get; set; }
        public decimal IdComprador { get; set; }
        public decimal IdSolicitante { get; set; }
        public decimal IdDepartamento { get; set; }
        public string EstadoJC { get; set; }
        public string EstadoGA { get; set; }
        public string Su_Descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string TerminoPago { get; set; }
        public string Comprador { get; set; }
        public string nom_solicitante { get; set; }
        public string nom_departamento { get; set; }
        public Nullable<bool> Pasado { get; set; }
        public int cp_PlazoEntrega { get; set; }
        public Nullable<decimal> opd_IdOrdenPedido { get; set; }
        public string cp_ObservacionAdicional { get; set; }
    }
}
