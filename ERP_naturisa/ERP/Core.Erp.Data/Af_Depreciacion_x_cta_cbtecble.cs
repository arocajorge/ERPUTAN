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
    
    public partial class Af_Depreciacion_x_cta_cbtecble
    {
        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }
    
        public virtual Af_Depreciacion Af_Depreciacion { get; set; }
    }
}
