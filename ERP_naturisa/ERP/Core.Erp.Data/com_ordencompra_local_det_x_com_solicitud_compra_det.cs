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
    
    public partial class com_ordencompra_local_det_x_com_solicitud_compra_det
    {
        public int ocd_IdEmpresa { get; set; }
        public int ocd_IdSucursal { get; set; }
        public decimal ocd_IdOrdenCompra { get; set; }
        public int ocd_Secuencia { get; set; }
        public int scd_IdEmpresa { get; set; }
        public int scd_IdSucursal { get; set; }
        public decimal scd_IdSolicitudCompra { get; set; }
        public int scd_Secuencia { get; set; }
        public string observacion { get; set; }
    
        public virtual com_ordencompra_local_det com_ordencompra_local_det { get; set; }
    }
}
