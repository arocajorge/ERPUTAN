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
    
    public partial class com_departamento
    {
        public com_departamento()
        {
            this.com_solicitante = new HashSet<com_solicitante>();
            this.com_solicitante_aprobador = new HashSet<com_solicitante_aprobador>();
            this.com_solicitante_x_com_departamento = new HashSet<com_solicitante_x_com_departamento>();
            this.com_CotizacionPedido = new HashSet<com_CotizacionPedido>();
            this.com_OrdenPedido = new HashSet<com_OrdenPedido>();
            this.com_ordencompra_local = new HashSet<com_ordencompra_local>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdDepartamento { get; set; }
        public string nom_departamento { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<com_solicitante> com_solicitante { get; set; }
        public virtual ICollection<com_solicitante_aprobador> com_solicitante_aprobador { get; set; }
        public virtual ICollection<com_solicitante_x_com_departamento> com_solicitante_x_com_departamento { get; set; }
        public virtual ICollection<com_CotizacionPedido> com_CotizacionPedido { get; set; }
        public virtual ICollection<com_OrdenPedido> com_OrdenPedido { get; set; }
        public virtual ICollection<com_ordencompra_local> com_ordencompra_local { get; set; }
    }
}
