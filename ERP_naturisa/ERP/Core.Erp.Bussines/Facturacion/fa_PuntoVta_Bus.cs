using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
   public class fa_PuntoVta_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        
        fa_PuntoVta_Data Data = new fa_PuntoVta_Data();

       public List<fa_PuntoVta_Info> Get_List_PuntoVta(int IdEmpresa)
      {
           try
            {
                return Data.Get_List_PuntoVta(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PuntoVta", ex.Message), ex) { EntityType = typeof(fa_PuntoVta_Bus) };
            }
        }

       public List<fa_PuntoVta_Info> Get_List_PuntoVta(int IdEmpresa, int IdSucursal)
       {
           try
           {
               return Data.Get_List_PuntoVta(IdEmpresa, IdSucursal);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PuntoVta", ex.Message), ex) { EntityType = typeof(fa_PuntoVta_Bus) };
           }
       }

       public bool GrabarDB(fa_PuntoVta_Info info, ref string msg)
       {
           try
           {

               return Data.GrabarDB(info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PuntoVta", ex.Message), ex) { EntityType = typeof(fa_PuntoVta_Bus) };
           }
       }

       public bool ModificarDB(fa_PuntoVta_Info info, ref string msg)
       {
           try
           {
               return Data.ModificarDB(info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PuntoVta", ex.Message), ex) { EntityType = typeof(fa_PuntoVta_Bus) };
           }
       }

       public bool AnularDB(fa_PuntoVta_Info info, ref string msg)
       {
           try
           {
               return Data.AnularDB(info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PuntoVta", ex.Message), ex) { EntityType = typeof(fa_PuntoVta_Bus) };
           }
       }
    }
}
