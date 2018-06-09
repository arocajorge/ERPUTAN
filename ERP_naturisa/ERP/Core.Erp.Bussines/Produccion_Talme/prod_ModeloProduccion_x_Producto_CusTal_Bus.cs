using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
   public  class prod_ModeloProduccion_x_Producto_CusTal_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       prod_ModeloProduccion_x_Producto_CusTal_Data Data = new prod_ModeloProduccion_x_Producto_CusTal_Data();

       public Boolean GuardarDB(prod_ModeloProduccion_x_Producto_CusTal_Info Info, ref String Mensaje)
       {
           try
           {
              return Data.GuardarDB(Info, ref Mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_ModeloProduccion_x_Producto_CusTal_Bus) };

           }

       }
       public Boolean Borrar(int IdEmpresa, int IdModeloProduccion, Decimal IdProducto)
       {
           try
           {
            return Data.Borrar(IdEmpresa, IdModeloProduccion, IdProducto);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Borrar", ex.Message), ex) { EntityType = typeof(prod_ModeloProduccion_x_Producto_CusTal_Bus) };

           }

       }

       public List<prod_ModeloProduccion_x_Producto_CusTal_Info> ConsultarXModeloDeProduccion(int IdEmpresa, int IdModeloProd)
       {
           try
           {
                 return Data.ConsultarXModeloDeProduccion(IdEmpresa, IdModeloProd);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarXModeloDeProduccion", ex.Message), ex) { EntityType = typeof(prod_ModeloProduccion_x_Producto_CusTal_Bus) };

           }
  
       }
    }
}
