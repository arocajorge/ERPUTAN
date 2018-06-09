using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Business.General
{
   public  class tb_rango_fecha_busqueda_x_periodo_Bus
    {

       List<tb_rango_fecha_busqueda_x_periodo_Info> listado = new List<tb_rango_fecha_busqueda_x_periodo_Info>();

       tb_rango_fecha_busqueda_x_periodo_Data OData = new tb_rango_fecha_busqueda_x_periodo_Data();



       public List<tb_rango_fecha_busqueda_x_periodo_Info> Obtener_Listado_Rango_fechas()
       {
           try
           {
               return OData.Obtener_Listado_Rango_fechas();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Listado_Rango_fechas", ex.Message), ex) { EntityType = typeof(tb_rango_fecha_busqueda_x_periodo_Bus) };
         
           }
       }

    }
}
