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
    
    public partial class vwcp_Aprobacion_Ing_Bod_x_OC_det_PorAprobar
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public Nullable<double> mv_costo_sinConversion { get; set; }
        public double do_porc_des { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string IdCategoria { get; set; }
        public int IdLinea { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubGrupo { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia_oc { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public double Por_Iva { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public decimal IdProveedor { get; set; }
        public int oc_plazo { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string es_Inven_o_Consumo { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> ValorIVA { get; set; }
        public Nullable<double> Total { get; set; }
    }
}
