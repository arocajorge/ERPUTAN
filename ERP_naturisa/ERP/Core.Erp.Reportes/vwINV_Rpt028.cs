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
    
    public partial class vwINV_Rpt028
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_prod { get; set; }
        public string pr_descripcion { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public decimal IdProveedor { get; set; }
        public string cod_provee { get; set; }
        public string nom_provee { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public double do_Cantidad { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
    }
}
