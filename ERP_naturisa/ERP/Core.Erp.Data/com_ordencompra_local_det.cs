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
    
    public partial class com_ordencompra_local_det
    {
        public com_ordencompra_local_det()
        {
            this.com_dev_compra_det = new HashSet<com_dev_compra_det>();
            this.com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider = new HashSet<com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider>();
            this.com_ordencompra_local_det_x_com_solicitud_compra_det = new HashSet<com_ordencompra_local_det_x_com_solicitud_compra_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_precioFinal { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public bool do_ManejaIva { get; set; }
        public string do_Costeado { get; set; }
        public double do_peso { get; set; }
        public string do_observacion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string IdUnidadMedida { get; set; }
        public double Por_Iva { get; set; }
        public string IdCod_Impuesto { get; set; }
        public Nullable<int> IdSucursalDestino { get; set; }
    
        public virtual ICollection<com_dev_compra_det> com_dev_compra_det { get; set; }
        public virtual ICollection<com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider> com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider { get; set; }
        public virtual com_ordencompra_local com_ordencompra_local { get; set; }
        public virtual ICollection<com_ordencompra_local_det_x_com_solicitud_compra_det> com_ordencompra_local_det_x_com_solicitud_compra_det { get; set; }
    }
}
