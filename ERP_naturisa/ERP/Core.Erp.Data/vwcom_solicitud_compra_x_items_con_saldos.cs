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
    
    public partial class vwcom_solicitud_compra_x_items_con_saldos
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public string NumDocumento { get; set; }
        public decimal IdPersona_Solicita { get; set; }
        public decimal IdDepartamento { get; set; }
        public System.DateTime fecha { get; set; }
        public int plazo { get; set; }
        public System.DateTime fecha_vtc { get; set; }
        public string observacion { get; set; }
        public string Estado { get; set; }
        public string Sucursal { get; set; }
        public string nom_EstadoAprobacion { get; set; }
        public string IdUsuarioAprobo { get; set; }
        public string MotivoAprobacion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string NomProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public double cant_solicitada { get; set; }
        public double Cantidad_aprobada { get; set; }
        public double cant_aprobada_OC { get; set; }
        public double Saldo_can_SolCom { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdUsuarioAprueba { get; set; }
        public Nullable<System.DateTime> FechaHoraAprobacion { get; set; }
        public string observacion_Aprob { get; set; }
        public Nullable<decimal> IdProveedor_SC { get; set; }
        public Nullable<int> IdMotivo { get; set; }
        public string IdUnidadMedida { get; set; }
        public decimal IdComprador { get; set; }
        public string Comprador { get; set; }
        public string pr_ManejaIva { get; set; }
        public string Nomsub_centro_costo { get; set; }
        public Nullable<double> do_precioCompra { get; set; }
        public Nullable<double> do_porc_des { get; set; }
        public Nullable<double> do_descuento { get; set; }
        public Nullable<double> do_subtotal { get; set; }
        public Nullable<double> do_iva { get; set; }
        public Nullable<double> do_total { get; set; }
        public Nullable<bool> do_ManejaIva { get; set; }
        public string do_observacion { get; set; }
        public Nullable<int> ocd_IdEmpresa { get; set; }
        public Nullable<int> ocd_IdSucursal { get; set; }
        public Nullable<decimal> ocd_IdOrdenCompra { get; set; }
        public string IdEstadoPreAprobacion { get; set; }
        public string Solicitante { get; set; }
        public string Nom_Centro_costo { get; set; }
        public string departamento { get; set; }
        public Nullable<double> Stock { get; set; }
        public string IdCod_Impuesto_iva { get; set; }
    }
}
