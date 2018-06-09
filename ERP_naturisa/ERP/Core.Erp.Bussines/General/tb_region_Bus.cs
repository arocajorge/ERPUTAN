using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
   public class tb_region_Bus
   {
       tb_region_Data data=new tb_region_Data();
       public List<tb_region_Info> Get_List_Region()
       {
                   try 
	        {	        
		        return data.Get_List_Region();
	        }
	catch (Exception ex)
	{
		
		         Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_BodegasTodas", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
	}
       }
    }
}
