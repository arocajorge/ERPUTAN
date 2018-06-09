using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;


namespace Core.Erp.Business.Compras
{
   public class com_Motivo_Orden_Compra_Bus
    {

       com_Motivo_Orden_Compra_Data Odata = new com_Motivo_Orden_Compra_Data();



       public List<com_Motivo_Orden_Compra_Info> Get_List_Motivo_Orden_Compra(int IdEmpresa)
       {
            try 
            {	        
		        return Odata.Get_List_Motivo_Orden_Compra(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Motivo_Orden_Compra", ex.Message), ex) { EntityType = typeof(com_Motivo_Orden_Compra_Bus) };
            }
       }


       public com_Motivo_Orden_Compra_Info Get_Info_Motivo_Orden_Compra(int IdEmpresa, int idMotivo_oc)
       {
           try
           {
               return Odata.Get_Info_Motivo_Orden_Compra(IdEmpresa, idMotivo_oc);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Motivo_Orden_Compra", ex.Message), ex) { EntityType = typeof(com_Motivo_Orden_Compra_Bus) };
           }
       }

       public Boolean AnularDB(com_Motivo_Orden_Compra_Info Info, ref string msg)
       {
           try
           {
               return Odata.AnularDB(Info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_Motivo_Orden_Compra_Bus) };
               
           }
       }




       public Boolean GuardarDB(com_Motivo_Orden_Compra_Info Info, ref int IdMotivo, ref string msg)
       {
           try
           {
               return Odata.GuardarDB(Info, ref IdMotivo, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_Motivo_Orden_Compra_Bus) };

           }
       }




       public Boolean ModificarDB(com_Motivo_Orden_Compra_Info Info, ref string msg)
       {
           try
           {
               return Odata.ModificarDB(Info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_Motivo_Orden_Compra_Bus) };
           }
       }


    }
}
