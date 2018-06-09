using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produc_Cirdesus
{

	public class prd_Conversion_CusCidersus_Info
	{
		public int IdEmpresa{ get; set; } 
		public decimal IdConversion{ get; set; } 
		public int IdSucursal{ get; set; } 
		public int IdBodega{ get; set; } 
		public string CodObra{ get; set; } 
		public decimal IdOrdenTaller{ get; set; } 
		public string CodBarraProducto{ get; set; } 
		public string NomProducto{ get; set; } 
		public DateTime Fecha{ get; set; } 
		public string IdUsuario{ get; set; } 
		public DateTime Fecha_transaccion{ get; set; } 
		public string IdUsuarioAnu{ get; set; } 
		public DateTime Fecha_Anu{ get; set; } 
		public string Estado{ get; set; }
        public string Obra { get; set; }
        public string Codigo { get; set; }
        public int IdEtapa { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public decimal IdMovi_inven_Tipo { get; set; }
        public decimal IdNumMov { get; set; }
        public string OrdenTallernom { get; set; }
        public string Observacion { get; set; }
        public List<prd_Conversion_det_CusCidersus_Info > ListDetalle { get; set; }

	public prd_Conversion_CusCidersus_Info()
    {
        ListDetalle = new List<prd_Conversion_det_CusCidersus_Info>();
    }




    
    }
}
