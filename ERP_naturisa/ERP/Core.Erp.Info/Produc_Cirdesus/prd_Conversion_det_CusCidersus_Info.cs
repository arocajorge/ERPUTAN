using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produc_Cirdesus
{

	public class prd_Conversion_det_CusCidersus_Info
	{
	

		    public int IdEmpresa{ get; set; } 
		    public decimal IdConversion{ get; set; } 
		    public int IdSucursal{ get; set; } 
		    public int IdBodega{ get; set; } 
		    public int Secuencial{ get; set; } 
		    public decimal IdProducto{ get; set; } 
		    public string CodBarra{ get; set; } 
		    public string TipoPro{ get; set; } 
              public string Observacion { get; set; }

              public string pr_descripcion { get; set; }
              public double pr_alto { get; set; }
              public double pr_largo { get; set; }

	public prd_Conversion_det_CusCidersus_Info(){ }





  
    }
}
