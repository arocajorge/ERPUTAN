using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_ChatarraTipo_CusTalme_Info
	{
	

		public int IdEmpresa{ get; set; } 
		public int IdTipoChatarra{ get; set; } 
		public string Descripcion{ get; set; } 
		public double Precio{ get; set; }
        public string Estado { get; set; }


	    public prod_ChatarraTipo_CusTalme_Info(){ }

	

	}
}
