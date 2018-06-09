using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_LiquidacionChatarraDetalle_Info
	{

		public int IdEmpresa{ get; set; } 
		public decimal IdLiquidacion{ get; set; } 
		public int Secuencia{ get; set; } 
		public Nullable<double> LLeno{ get; set; } 
		public Nullable<double> Vacio{ get; set; } 
		public Nullable<double> Merma{ get; set; } 
		public Nullable<double> Neta{ get; set; } 
		public Nullable<DateTime> fecha_pesaje_lleno{ get; set; } 
		public Nullable<DateTime> fecha_pesaje_vacion{ get; set; } 
		public string Placa{ get; set; }
        public string Clave { get; set; }


	public prod_LiquidacionChatarraDetalle_Info(){ }



	}
}
