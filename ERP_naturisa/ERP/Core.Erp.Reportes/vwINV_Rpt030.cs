//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwINV_Rpt030
    {
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int dt_secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double dt_cantidad { get; set; }
        public string IdEstablecimiento { get; set; }
        public string IdPuntoEmision { get; set; }
        public string NumDocumento_Guia { get; set; }
        public string NumeroAutorizacion { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public string IdentificacionTransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string MotivoGuia { get; set; }
        public string Direc_sucu_Llegada { get; set; }
        public string Direc_sucu_Partida { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Nombre { get; set; }
        public string NombreDestinatario { get; set; }
        public string IdentificacionDestinatario { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Direccion { get; set; }
        public string NombreEmpresa { get; set; }
        public string NumeroContribuyente { get; set; }
        public string em_ruc { get; set; }
    }
}
