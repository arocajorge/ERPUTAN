using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class in_movi_inve_detalle_CusCidersus_Info
    {
        
       
        public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; } 
		public int IdBodega{ get; set; } 
		public int IdMovi_inven_tipo{ get; set; } 
		public decimal IdNumMovi{ get; set; } 
		public int Secuencia{ get; set; } 
		public string mv_tipo_movi{ get; set; } 
		public decimal IdProducto{ get; set; }
        public string Producto { get; set; }
		public double dm_cantidadsolicitada{ get; set; }
        public double dm_cantidad_pendiente { get; set; } 
		public string  dm_observacion{ get; set; }
        public string CodOT { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public double dm_cantidad { get; set; } 


        public in_movi_inve_detalle_CusCidersus_Info() { }


     
    

    }
}
