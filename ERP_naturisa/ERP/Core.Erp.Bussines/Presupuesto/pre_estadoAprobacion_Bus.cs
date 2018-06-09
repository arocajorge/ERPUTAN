using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;

//8-5-2013
namespace Core.Erp.Business.Presupuesto
{
   public  class pre_estadoAprobacion_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";

       pre_estadoAprobacion_Data data=new pre_estadoAprobacion_Data();

       public List<pre_estadoAprobacion_Info> obtenerList()
       {
           try
           {
                  return data.obtenerList();
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerList", ex.Message), ex) { EntityType = typeof(pre_estadoAprobacion_Bus) };

           }

       }
    }
}
