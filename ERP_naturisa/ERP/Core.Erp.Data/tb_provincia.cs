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
    
    public partial class tb_provincia
    {
        public tb_provincia()
        {
            this.tb_ciudad = new HashSet<tb_ciudad>();
            this.tb_contacto = new HashSet<tb_contacto>();
        }
    
        public string IdProvincia { get; set; }
        public string Cod_Provincia { get; set; }
        public string Descripcion_Prov { get; set; }
        public string Estado { get; set; }
        public string IdPais { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Cod_Region { get; set; }
    
        public virtual ICollection<tb_ciudad> tb_ciudad { get; set; }
        public virtual ICollection<tb_contacto> tb_contacto { get; set; }
        public virtual tb_pais tb_pais { get; set; }
        public virtual tb_region tb_region { get; set; }
    }
}
