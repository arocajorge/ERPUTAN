using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_Parametros_x_MoviInven_x_ModeloProduccion_Info
	{

		public int IdEmpresa{ get; set; } 
		public int IdModeloProd{ get; set; } 
		public int Secuencia{ get; set; } 
		public int? IdSucursal_IngxProducTermi{ get; set; }
        public int? IdBodega_IngxProducTermi { get; set; }
        public int? IdMovi_inven_tipo_x_IngxProduc_ProdTermi { get; set; }
        public int? IdSucursal_EgrxMateriaPrima { get; set; }
        public int? IdBodega_EgrxMateriaPrima { get; set; }
        public int? IdMovi_inven_tipo_x_EgrxProduc_MatPri { get; set; }
        public decimal? IdProducto_ParaIngreso { get; set; }
        public decimal? IdProducto_ParaEgreso { get; set; }
        public string Bodega { get; set; }
        public string BodegaEgreso { get; set; }
        public string ProductoIngreso { get; set; }
        public string ProductoEgreso { get; set; }


	public prod_Parametros_x_MoviInven_x_ModeloProduccion_Info(){ }

	
	}
}
