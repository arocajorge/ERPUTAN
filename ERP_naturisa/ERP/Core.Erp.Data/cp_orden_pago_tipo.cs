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
    
    public partial class cp_orden_pago_tipo
    {
        public cp_orden_pago_tipo()
        {
            this.cp_orden_pago_tipo_x_empresa = new HashSet<cp_orden_pago_tipo_x_empresa>();
            this.cp_orden_pago = new HashSet<cp_orden_pago>();
        }
    
        public string IdTipo_op { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string GeneraDiario { get; set; }
    
        public virtual ICollection<cp_orden_pago_tipo_x_empresa> cp_orden_pago_tipo_x_empresa { get; set; }
        public virtual ICollection<cp_orden_pago> cp_orden_pago { get; set; }
    }
}
