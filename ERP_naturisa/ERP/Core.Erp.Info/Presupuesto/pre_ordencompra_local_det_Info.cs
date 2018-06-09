using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Presupuesto
{
   public class pre_ordencompra_local_det_Info
    {
       public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; }
		public decimal IdOrdenCompra{ get; set; }
		public int Secuencia{ get; set; }
		public decimal IdPedidoXPre{ get; set; } 
		public int Secuencia_reg_ped{ get; set; } 
		public decimal IdPresupuesto_pre{ get; set; } 
		public int IdAnio_pre{ get; set; } 
		public int Secuencia_pre{ get; set; } 
		public string Producto{ get; set; } 
		public double do_Cantidad{ get; set; } 
		public double do_precioCompra{ get; set; } 
		public double do_porc_des{ get; set; } 
		public double do_descuento{ get; set; } 
		public double do_subtotal{ get; set; } 
		public double do_iva{ get; set; } 
		public double do_total{ get; set; } 
		public string do_ManejaIva{ get; set; } 
		public string do_observacion{ get; set; }
        public string do_NumDocumento { get; set; }

        public string NPresupuesto_pre { get; set; }
        public Boolean chek { get; set; }

        public pre_ordencompra_local_det_Info(){}
    }
}
