using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_ModeloProduccion_CusTalme_Info
	{
	

	    public int IdModeloProd{ get; set; } 
	    public string Descripcion{ get; set; } 
	    public string Estado{ get; set; } 
        public string Tipo { get; set; }
        public int? IdSucursal_IngxProduc	{ get; set; } 
        public int? IdBodega_IngxProduc	{ get; set; } 
        public int? IdMovi_inven_tipo_x_IngxProduc_ProdTermi	{ get; set; } 
        public int? IdMovi_inven_tipo_x_EgrxProduc_MatPri	{ get; set; } 
        public int? IdCargo_JefeTurno	{ get; set; } 
        public int? IdSucursal_EgrxMateriaPrima	{ get; set; }
        public int? IdBodega_EgrxMateriaPrima { get; set; } 

	public prod_ModeloProduccion_CusTalme_Info(){ }


    
    }
}
