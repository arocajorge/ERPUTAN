using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwIn_Movi_Inven_x_CodBarra_CusCider_Info
    {
        public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; } 
		public int IdBodega{ get; set; } 
		public int IdMovi_inven_tipo{ get; set; } 
		public decimal IdNumMovi{ get; set; } 
		public string CodMoviInven{ get; set; } 
		public string cm_tipo{ get; set; } 
		public string cm_observacion{ get; set; } 
		public DateTime cm_fecha{ get; set; } 
		public decimal IdProducto{ get; set; } 
		public double dm_cantidad{ get; set; } 
		public double dm_stock_ante{ get; set; } 
		public double dm_stock_actu{ get; set; } 
		public double dm_precio{ get; set; } 
		public double mv_costo{ get; set; } 
		public string  CodigoBarra{ get; set; } 
		public double? dm_cantidadCodBarra{ get; set; } 
		public  string dm_observacion{ get; set; } 
		public int? et_IdEmpresa{ get; set; } 
		public int? et_IdProcesoProductivo{ get; set; } 
		public int? et_IdEtapa{ get; set; } 
		public int? ot_IdEmpresa{ get; set; } 
		public int? ot_IdSucursal{ get; set; } 
		public string ot_CodObra{ get; set; } 
		public decimal? ot_IdOrdenTaller{ get; set; }


        public vwIn_Movi_Inven_x_CodBarra_CusCider_Info() { }
    }
}
