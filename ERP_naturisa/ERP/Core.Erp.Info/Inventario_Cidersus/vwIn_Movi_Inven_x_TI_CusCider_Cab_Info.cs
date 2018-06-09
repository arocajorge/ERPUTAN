using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwIn_Movi_Inven_x_TI_CusCider_Cab_Info
    {
        public int IdEmpresa{ get; set; } 
		public int IdMovi_inven_tipo{ get; set; } 
		public int IdBodega{ get; set; } 
		public int IdSucursal{ get; set; } 
		public string CodMoviInven{ get; set; } 
		public string cm_tipo{ get; set; } 
		public string cm_observacion{ get; set; } 
		public DateTime cm_fecha{ get; set; } 
		public decimal IdNumMovi{ get; set; } 
		public decimal IdProvedor{ get; set; } 
		public DateTime Fecha_Transac{ get; set; } 
		public string Su_Descripcion{ get; set; } 
		public string bo_Descripcion{ get; set; } 
		public string Codigo{ get; set; } 
		public string tm_descripcion{ get; set; } 
		public string pr_nombre{ get; set; }
        public string CodigoBarra { get; set; }
        public decimal codigoProducto { get; set; }
        //campos vista ensamblado
		public decimal en_IdEnsamblado{ get; set; } 
		public int en_IdSucursal{ get; set; } 
		public int en_IdEmpresa{ get; set; } 

        //campos vista control produccion
        public int cp_IdEmpresa { get; set; }
        public int cp_IdSucursal { get; set; }
        public decimal cp_IdControlProduccionObrero { get; set; } 

        //campos vista conversion
        public int cv_IdEmpresa { get; set; }
        public decimal cv_IdConversion { get; set; }

	public vwIn_Movi_Inven_x_TI_CusCider_Cab_Info(){ }
    }
}
