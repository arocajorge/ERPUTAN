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
    
    public partial class tb_contacto
    {
        public int IdEmpresa { get; set; }
        public decimal IdContacto { get; set; }
        public decimal IdPersona { get; set; }
        public string CodContacto { get; set; }
        public string Organizacion { get; set; }
        public string Cargo { get; set; }
        public string Mostrar_como { get; set; }
        public System.DateTime Fecha_alta { get; set; }
        public System.DateTime Fecha_Ult_Contacto { get; set; }
        public string IdCiudad { get; set; }
        public string IdNacionalidad { get; set; }
        public string Notas { get; set; }
        public string Pagina_Web { get; set; }
        public string Codigo_postal { get; set; }
        public byte[] foto { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string Estado { get; set; }
        public string IdPais { get; set; }
        public string IdProvincia { get; set; }
    
        public virtual tb_ciudad tb_ciudad { get; set; }
        public virtual tb_pais tb_pais { get; set; }
        public virtual tb_pais tb_pais1 { get; set; }
        public virtual tb_empresa tb_empresa { get; set; }
        public virtual tb_provincia tb_provincia { get; set; }
        public virtual tb_persona tb_persona { get; set; }
    }
}
