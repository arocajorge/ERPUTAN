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
    
    public partial class SPINV_GetMovimientosPorContabilizar_Result
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string Su_Descripcion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string cm_observacion { get; set; }
        public string signo { get; set; }
        public string tm_descripcion { get; set; }
        public Nullable<double> TotalInventario { get; set; }
        public Nullable<double> TotalContabilidad { get; set; }
        public Nullable<double> Diferencia { get; set; }
    }
}