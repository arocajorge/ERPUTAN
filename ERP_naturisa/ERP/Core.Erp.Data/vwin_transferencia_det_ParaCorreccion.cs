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
    
    public partial class vwin_transferencia_det_ParaCorreccion
    {
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int dt_secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double dt_cantidad { get; set; }
        public string tr_Observacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<double> dm_cantidad_sinConversion { get; set; }
    }
}
