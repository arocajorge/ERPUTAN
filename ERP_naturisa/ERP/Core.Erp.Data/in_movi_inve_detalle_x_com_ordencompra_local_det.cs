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
    
    public partial class in_movi_inve_detalle_x_com_ordencompra_local_det
    {
        public int mi_IdEmpresa { get; set; }
        public int mi_IdSucursal { get; set; }
        public int mi_IdBodega { get; set; }
        public int mi_IdMovi_inven_tipo { get; set; }
        public decimal mi_IdNumMovi { get; set; }
        public int mi_Secuencia { get; set; }
        public int ocd_IdEmpresa { get; set; }
        public int ocd_IdSucursal { get; set; }
        public decimal ocd_IdOrdenCompra { get; set; }
        public int ocd_Secuencia { get; set; }
        public string observacion { get; set; }
    
        public virtual in_movi_inve_detalle in_movi_inve_detalle { get; set; }
    }
}
