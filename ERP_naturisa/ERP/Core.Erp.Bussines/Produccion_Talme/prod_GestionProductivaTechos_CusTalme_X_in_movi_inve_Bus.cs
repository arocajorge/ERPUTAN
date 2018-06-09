using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
   public class prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";

       prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Data Data = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Data();
       
       public Boolean Guardar(prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info Info, ref string Men)
       {
           try
           {
             return Data.GuardarDB(Info, ref Men);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus) };

           }

       }
       public List<prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info> ObjtenerListaPorGestion(int IdEmpresa, decimal IdGestionProd)
       {
           try
           {
             return Data.Get_List_GestionProductivaTechos_CusTalme_X_in_movi_inv(IdEmpresa, IdGestionProd);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObjtenerListaPorGestion", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus) };

           }

       }
    }
}
