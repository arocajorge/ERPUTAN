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
    
    public partial class vwcp_Aprobacion_Ing_Bod_x_OC_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_Ing_Egr_Inv { get; set; }
        public int IdSucursal_Ing_Egr_Inv { get; set; }
        public decimal IdNumMovi_Ing_Egr_Inv { get; set; }
        public int Secuencia_Ing_Egr_Inv { get; set; }
        public double Cantidad { get; set; }
        public double Costo_uni { get; set; }
        public double Descuento { get; set; }
        public double SubTotal { get; set; }
        public double PorIva { get; set; }
        public double valor_Iva { get; set; }
        public double Total { get; set; }
        public string nom_sucursal { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public string IdCtaCble_IVA { get; set; }
        public string IdCentro_Costo_x_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }
        public int IdMovi_inven_tipo_Ing_Egr_Inv { get; set; }
    }
}
