using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_Ensamblado_Det_CusCider_Info
    {
        public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; } 
		public decimal IdEnsamblado{ get; set; } 
		public int Secuencia{ get; set; } 
		public decimal IdProducto{ get; set; } 
		public  string CodigoBarra{ get; set; } 
		public string Observacion{ get; set; }
        public string Producto { get; set; }
        public int en_cantidad { get; set; }


	public prd_Ensamblado_Det_CusCider_Info(){ }
    }
}
