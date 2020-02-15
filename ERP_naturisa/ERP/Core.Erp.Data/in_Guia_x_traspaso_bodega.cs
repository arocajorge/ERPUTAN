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
    
    public partial class in_Guia_x_traspaso_bodega
    {
        public in_Guia_x_traspaso_bodega()
        {
            this.in_Guia_x_traspaso_bodega_det = new HashSet<in_Guia_x_traspaso_bodega_det>();
            this.in_Guia_x_traspaso_bodega_det_sin_oc = new HashSet<in_Guia_x_traspaso_bodega_det_sin_oc>();
            this.in_Guia_x_traspaso_bodega_x_in_transferencia_det = new HashSet<in_Guia_x_traspaso_bodega_x_in_transferencia_det>();
            this.in_transferencia_x_in_Guia_x_traspaso_bodega = new HashSet<in_transferencia_x_in_Guia_x_traspaso_bodega>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public string NumGuia { get; set; }
        public Nullable<int> IdSucursal_Partida { get; set; }
        public Nullable<int> IdSucursal_Llegada { get; set; }
        public string Direc_sucu_Partida { get; set; }
        public string Direc_sucu_Llegada { get; set; }
        public Nullable<decimal> IdTransportista { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Fecha_Traslado { get; set; }
        public Nullable<System.DateTime> Fecha_llegada { get; set; }
        public string IdMotivo_Traslado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public Nullable<System.TimeSpan> Hora_Traslado { get; set; }
        public Nullable<System.TimeSpan> Hora_Llegada { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string IdEstablecimiento { get; set; }
        public string IdPuntoEmision { get; set; }
        public string NumDocumento_Guia { get; set; }
        public string NombreDestinatario { get; set; }
        public string IdentificacionDestinatario { get; set; }
        public string Placa { get; set; }
        public string NumeroAutorizacion { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
    
        public virtual in_Catalogo in_Catalogo { get; set; }
        public virtual ICollection<in_Guia_x_traspaso_bodega_det> in_Guia_x_traspaso_bodega_det { get; set; }
        public virtual ICollection<in_Guia_x_traspaso_bodega_det_sin_oc> in_Guia_x_traspaso_bodega_det_sin_oc { get; set; }
        public virtual ICollection<in_Guia_x_traspaso_bodega_x_in_transferencia_det> in_Guia_x_traspaso_bodega_x_in_transferencia_det { get; set; }
        public virtual ICollection<in_transferencia_x_in_Guia_x_traspaso_bodega> in_transferencia_x_in_Guia_x_traspaso_bodega { get; set; }
    }
}
