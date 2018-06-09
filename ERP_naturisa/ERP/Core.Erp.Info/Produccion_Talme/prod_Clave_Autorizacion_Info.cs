using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_Clave_Autorizacion_Info
	{
	

		public int IdEmpresa{ get; set; } 
		public decimal IdGeneracion{ get; set; } 
		public int Secuencia{ get; set; } 
		public Nullable<int> IdModeloProduccion{ get; set; } 
		public string Clave{ get; set; } 
		public string IdUsuarioUsoDeClave{ get; set; } 
		public Nullable<DateTime> FechaUsoDeClave{ get; set; } 
		public string IdUsuarioGeneracion{ get; set; } 
		public Nullable<DateTime> FechaGeneracion{ get; set; } 
		public Nullable<decimal> IdTransaccion{ get; set; } 
		public  string Activo{ get; set; } 


	public prod_Clave_Autorizacion_Info(){ }

	

	}
}
