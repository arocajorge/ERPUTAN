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
    
    public partial class in_transferencia_det
    {
        public in_transferencia_det()
        {
            this.in_Guia_x_traspaso_bodega_x_in_transferencia_det = new HashSet<in_Guia_x_traspaso_bodega_x_in_transferencia_det>();
            this.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det = new HashSet<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int dt_secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dt_cantidad { get; set; }
        public string tr_Observacion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
    
        public virtual ICollection<in_Guia_x_traspaso_bodega_x_in_transferencia_det> in_Guia_x_traspaso_bodega_x_in_transferencia_det { get; set; }
        public virtual in_transferencia in_transferencia { get; set; }
        public virtual in_UnidadMedida in_UnidadMedida { get; set; }
        public virtual ICollection<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det> in_transferencia_det_x_in_Guia_x_traspaso_bodega_det { get; set; }
        public virtual in_Producto in_Producto { get; set; }
    }
}
