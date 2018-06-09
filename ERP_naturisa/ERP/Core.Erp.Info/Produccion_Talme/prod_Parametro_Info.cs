using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_Parametro_Info
	{


		public int IdEmpresa{ get; set; } 
		public int IdSucursal_IngxProduc{ get; set; } 
		public int IdBodega_IngxProduc{ get; set; } 
		public int IdMovi_inven_tipo_x_IngxProduc_ProdTermi{ get; set; } 
		public int IdMovi_inven_tipo_x_EgrxProduc_MatPri{ get; set; } 
		public int IdCargo_JefeTurno{ get; set; } 


	public prod_Parametro_Info(){ }



    public string IdBodega_EgrxMateriaPrima { get; set; }

    public int? IdSucursal_EgrxMateriaPrima { get; set; }

    public int? IdMovi_inven_tipo_x_IngCompraChatarra { get; set; }

    public decimal? IdProducto_ChatarraIngreso { get; set; }

    public int IdMovi_inven_tipo_x_IngXProdAceriaProdTerm { get; set; }
    }
}
