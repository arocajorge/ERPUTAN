using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produc_Cirdesus
{

	public class prd_ControlProduccion_Obrero_x_in_movi_inve_Info
	{


		public int cp_IdEmpresa{ get; set; } 
		public int cp_IdSucursal{ get; set; } 
		public decimal cp_IdControlProduccionObrero{ get; set; } 
		public int mv_IdEmpresa{ get; set; } 
		public int mv_IdSucursal{ get; set; } 
		public int mv_IdBodega{ get; set; } 
		public int mv_IdMovi_inven_tipo{ get; set; } 
		public decimal mv_IdNumMovi{ get; set; }

        //vista
        public string TipoMovimiento { get; set; }
        public string CodigoMov { get; set; }

	public prd_ControlProduccion_Obrero_x_in_movi_inve_Info(){ }

	

	}
}
