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
    
    public partial class vwGe_tb_sis_Documento_Tipo_Talonario
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumDocumento { get; set; }
        public Nullable<System.DateTime> FechaCaducidad { get; set; }
        public Nullable<bool> Usado { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string NumAutorizacion { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> es_Documento_Electronico { get; set; }
    }
}
