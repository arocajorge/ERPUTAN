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
    
    public partial class in_transferencia_det_x_in_Guia_x_traspaso_bodega_det
    {
        public int IdEmpresa_trans { get; set; }
        public int IdSucursalOrigen_trans { get; set; }
        public int IdBodegaOrigen_trans { get; set; }
        public decimal IdTransferencia_trans { get; set; }
        public int Secuencia_trans { get; set; }
        public int IdEmpresa_guia { get; set; }
        public decimal IdGuia_guia { get; set; }
        public int Secuencia_guia { get; set; }
        public string Observacion { get; set; }
    
        public virtual in_Guia_x_traspaso_bodega_det in_Guia_x_traspaso_bodega_det { get; set; }
        public virtual in_transferencia_det in_transferencia_det { get; set; }
    }
}
