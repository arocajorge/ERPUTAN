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
    
    public partial class Af_Departamento
    {
        public Af_Departamento()
        {
            this.Af_CambioUbicacion_Activo = new HashSet<Af_CambioUbicacion_Activo>();
            this.Af_CambioUbicacion_Activo1 = new HashSet<Af_CambioUbicacion_Activo>();
            this.Af_Activo_fijo = new HashSet<Af_Activo_fijo>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdDepartamento { get; set; }
        public string estado { get; set; }
        public string nom_departamento { get; set; }
    
        public virtual ICollection<Af_CambioUbicacion_Activo> Af_CambioUbicacion_Activo { get; set; }
        public virtual ICollection<Af_CambioUbicacion_Activo> Af_CambioUbicacion_Activo1 { get; set; }
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo { get; set; }
    }
}
