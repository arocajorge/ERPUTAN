//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_dev_compra_con_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string Tipo { get; set; }
        public System.DateTime dv_fecha { get; set; }
        public double dv_flete { get; set; }
        public string dv_observacion { get; set; }
        public string Estado { get; set; }
        public string cod_proveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dv_Cantidad { get; set; }
        public double dv_precioCompra { get; set; }
        public double dv_porc_des { get; set; }
        public double dv_descuento { get; set; }
        public double dv_subtotal { get; set; }
        public double dv_iva { get; set; }
        public double dv_total { get; set; }
        public bool dv_ManejaIva { get; set; }
        public string dv_Costeado { get; set; }
        public double dv_peso { get; set; }
        public string dvt_observacion { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public Nullable<int> ocdet_IdEmpresa { get; set; }
        public Nullable<int> ocdet_IdSucursal { get; set; }
        public Nullable<decimal> ocdet_IdOrdenCompra { get; set; }
        public Nullable<int> ocdet_Secuencia { get; set; }
    }
}
