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
    
    public partial class in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble
    {
        public int IdEmpresa { get; set; }
        public string IdCategoria { get; set; }
        public int IdLinea { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubgrupo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSub_centro_costo { get; set; }
        public string IdCtaCble { get; set; }
    
        public virtual in_subgrupo in_subgrupo { get; set; }
    }
}
