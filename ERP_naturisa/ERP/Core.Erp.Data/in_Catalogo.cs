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
    
    public partial class in_Catalogo
    {
        public in_Catalogo()
        {
            this.in_ajusteFisico = new HashSet<in_ajusteFisico>();
            this.in_movi_inve = new HashSet<in_movi_inve>();
            this.in_Motivo_Inven = new HashSet<in_Motivo_Inven>();
            this.in_Motivo_Inven1 = new HashSet<in_Motivo_Inven>();
            this.in_Guia_x_traspaso_bodega = new HashSet<in_Guia_x_traspaso_bodega>();
            this.in_parametro = new HashSet<in_parametro>();
            this.in_parametro1 = new HashSet<in_parametro>();
        }
    
        public string IdCatalogo { get; set; }
        public int IdCatalogo_tipo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Abrebiatura { get; set; }
        public string NombreIngles { get; set; }
        public Nullable<int> Orden { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    
        public virtual ICollection<in_ajusteFisico> in_ajusteFisico { get; set; }
        public virtual in_CatalogoTipo in_CatalogoTipo { get; set; }
        public virtual ICollection<in_movi_inve> in_movi_inve { get; set; }
        public virtual ICollection<in_Motivo_Inven> in_Motivo_Inven { get; set; }
        public virtual ICollection<in_Motivo_Inven> in_Motivo_Inven1 { get; set; }
        public virtual ICollection<in_Guia_x_traspaso_bodega> in_Guia_x_traspaso_bodega { get; set; }
        public virtual ICollection<in_parametro> in_parametro { get; set; }
        public virtual ICollection<in_parametro> in_parametro1 { get; set; }
    }
}
