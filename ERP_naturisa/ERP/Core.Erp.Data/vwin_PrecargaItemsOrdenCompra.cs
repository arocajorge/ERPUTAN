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
    
    public partial class vwin_PrecargaItemsOrdenCompra
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdPrecarga { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdOrdenTaller { get; set; }
        public decimal IdProveedor { get; set; }
        public System.DateTime pre_fecha { get; set; }
        public double pre_subtotal { get; set; }
        public double pre_iva { get; set; }
        public double pre_descuento { get; set; }
        public short pre_pordesc { get; set; }
        public double pre_total { get; set; }
        public double pre_Base_conIva { get; set; }
        public double pre_Base_sinIva { get; set; }
        public string pre_observacion { get; set; }
        public System.DateTime Fechreg { get; set; }
        public string Estado { get; set; }
        public string pre_NumDocumento { get; set; }
        public Nullable<double> pre_PesoTotal { get; set; }
        public Nullable<System.DateTime> pre_fecha_emision { get; set; }
        public string Su_Descripcion { get; set; }
        public string CodCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string pr_nombre { get; set; }
        public int NumeroOT { get; set; }
        public string CodOrdenTaller { get; set; }
    }
}
