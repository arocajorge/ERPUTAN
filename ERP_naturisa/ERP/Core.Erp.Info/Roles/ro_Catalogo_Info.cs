using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Roles
{

	public class ro_Catalogo_Info
	{
	

		public int IdCatalogo{ get; set; } 
		public int IdTipoCatalogo{ get; set; } 
		public string CodCatalogo{ get; set; } 
		public string ca_descripcion{ get; set; } 
		public string ca_estado{ get; set; } 
		public int ca_orden{ get; set; }
        public string MotiAnula { get; set; }


	public ro_Catalogo_Info(){ }



	}
}
