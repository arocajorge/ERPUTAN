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
    
    public partial class vwcp_orden_giro_det_liqui_comp_fac_elect
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string IdUnidadMedida { get; set; }
        public double Cantidad { get; set; }
        public double CostoUni { get; set; }
        public double PorDescuento { get; set; }
        public double DescuentoUni { get; set; }
        public double CostoUniFinal { get; set; }
        public double Subtotal { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public double PorIva { get; set; }
        public double ValorIva { get; set; }
        public double Total { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_descripcion_2 { get; set; }
        public Nullable<int> IdSucursal { get; set; }
    }
}