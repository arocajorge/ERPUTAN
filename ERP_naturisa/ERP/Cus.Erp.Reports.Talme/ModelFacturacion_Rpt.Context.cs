﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cus.Erp.Reports.Talme
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesFacturacion_Rpt : DbContext
    {
        public EntitiesFacturacion_Rpt()
            : base("name=EntitiesFacturacion_Rpt")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwFAC_CUS_TAL_Rpt001> vwFAC_CUS_TAL_Rpt001 { get; set; }
        public DbSet<vwFAC_CUS_TAL_Rpt002> vwFAC_CUS_TAL_Rpt002 { get; set; }
        public DbSet<vwFAC_CUS_TAL_Rpt003> vwFAC_CUS_TAL_Rpt003 { get; set; }
        public DbSet<vwFAC_CUS_TAL_Rpt006> vwFAC_CUS_TAL_Rpt006 { get; set; }
        public DbSet<vwFAC_CUS_TAL_Rpt004> vwFAC_CUS_TAL_Rpt004 { get; set; }
    }
}
