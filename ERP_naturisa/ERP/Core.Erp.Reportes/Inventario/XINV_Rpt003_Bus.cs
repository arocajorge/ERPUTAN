using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt003_Bus
    {
       XINV_Rpt003_Data Data = new XINV_Rpt003_Data();
        public List<XINV_Rpt003_Info> consultar_data(int IdEmpresa,	int IdSucursal, int IdMovi_inven_tipo,decimal IdNumMovi,ref string mensaje)
        {
            try 
	{	        
		 return Data.consultar_data(IdEmpresa,IdSucursal,  IdMovi_inven_tipo, IdNumMovi, ref  mensaje);
	}
	catch (Exception ex )
	{
		
		return new List<XINV_Rpt003_Info>();
	}
    }
        public XINV_Rpt003_Bus()
        {
        }
    }
}