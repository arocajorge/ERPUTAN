//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cus.Erp.Reports.Naturisa
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCXP_NATU_Rpt002
    {
        public int IdEmpresa { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string cod_tipo_doc { get; set; }
        public string tipo_doc { get; set; }
        public string Documento { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime co_FechaFactura_vct { get; set; }
        public string Observacion { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string Nom_Proveedor { get; set; }
        public Nullable<double> SubTotal { get; set; }
        public double Iva { get; set; }
        public Nullable<double> Total { get; set; }
        public double Total_a_Pagar { get; set; }
        public Nullable<double> Saldo_x_pagar { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
    }
}
