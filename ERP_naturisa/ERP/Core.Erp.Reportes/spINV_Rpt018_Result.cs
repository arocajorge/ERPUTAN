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
    
    public partial class spINV_Rpt018_Result
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<decimal> Idproducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public Nullable<double> egresos { get; set; }
        public Nullable<double> stock_fecha_desde { get; set; }
        public Nullable<double> stock_fecha_hasta { get; set; }
        public Nullable<double> promedio { get; set; }
        public Nullable<double> indice { get; set; }
        public Nullable<double> stock_minimo { get; set; }
        public Nullable<double> stock_hoy { get; set; }
        public Nullable<double> cant_a_comprar { get; set; }
    }
}
