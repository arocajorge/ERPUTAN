using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_MovPteGrua_Det_Info
	{

		public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; } 
		public decimal IdMovPteGrua{ get; set; } 
		public int Secuencia{ get; set; } 
		public  string CodigoBarra{ get; set; } 
		public  decimal IdProducto{ get; set; } 
		public  string CodigoBarraMaestro{ get; set; } 
		public  TimeSpan Hora{ get; set; }
        public string pr_descripcion { get; set; }
        public int Cantidad { get; set; }
        public Boolean Checked { get; set; }


	public prd_MovPteGrua_Det_Info(){ }
    }
}
