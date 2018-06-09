using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Compras
{
   public  class com_dev_compra_det_Bus
    {
       public com_dev_compra_det_Bus()
       {

       }

       com_dev_compra_det_Data Odata_det = new com_dev_compra_det_Data();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";



       public Boolean GuardarDB(List<com_dev_compra_det_Info> LstInfo, ref string msg)
       {
           try
           {
               return  Odata_det.GuardarDB(LstInfo, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_det_Bus) };
           }

       }

       public Boolean ModificarDB(com_dev_compra_Info Info, ref  string msg)
       {
           try
           {
               return Odata_det.ModificarDB(Info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_det_Bus) };
               
               
           }
       }

       public Boolean AnularDB(com_dev_compra_Info Info, ref  string msg)
       {
           try
           {
               return Odata_det.AnularDB(Info, ref msg);

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_det_Bus) };
           }
       }


       public List<com_dev_compra_det_Info> Get_List_dev_compra_det(int idempresa, int idsucursal, decimal idDevCompra)
       {
           try
           {
               return Odata_det.Get_List_dev_compra_det(idempresa, idsucursal, idDevCompra);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_dev_compra_det", ex.Message), ex) { EntityType = typeof(com_dev_compra_det_Bus) };
           }
       }


       public Boolean EliminarDetalle(int idempresa, int idsucursal, int idbodega, decimal IdDev_Compra, ref string msg)
       {
           try
           {
               return Odata_det.EliminarDB(idempresa, idsucursal, idbodega, IdDev_Compra, ref msg);

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_det_Bus) };
           }
       }
    }
}
