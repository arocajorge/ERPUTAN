using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Compras;
namespace Core.Erp.Business.Produc_Cirdesus
{
   public class prd_GenerOCompra_Bus
    {
       prd_GenerOCompra_Data data = new prd_GenerOCompra_Data();
       public Boolean GrabarDB(com_GeneracionOCompra_Info info, ref string msg)
       {
           try
           {
               return data.GrabarDB(info,ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(prd_GenerOCompra_Bus) };
                
           }
       }


       public int getId(int IdEmpresa)
       {
           try
           {
               return data.getId(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(prd_GenerOCompra_Bus) };
                
           }

       }

    }
}
