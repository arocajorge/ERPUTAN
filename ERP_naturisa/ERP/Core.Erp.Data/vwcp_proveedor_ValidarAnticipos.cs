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
    
    public partial class vwcp_proveedor_ValidarAnticipos
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public double Valor_a_pagar { get; set; }
        public double MontoAplicado { get; set; }
        public double Diferencia { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdPersona { get; set; }
        public string Observacion { get; set; }
        public System.DateTime Fecha { get; set; }
    }
}
