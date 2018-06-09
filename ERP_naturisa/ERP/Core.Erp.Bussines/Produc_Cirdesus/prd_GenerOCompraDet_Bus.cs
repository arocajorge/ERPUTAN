using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Compras;
namespace Core.Erp.Business.Produc_Cirdesus
{
    
  public  class prd_GenerOCompraDet_Bus
    {
      prd_GenerOCompraDet_Data data = new prd_GenerOCompraDet_Data();

      public Boolean GuardarDB(List<prd_GenerOCompra_Info> LstInfo)
      {
          try
          {
              return data.GuardarDB(LstInfo);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_GenerOCompraDet_Bus) };
                
              
          }
      }

      public List<com_ListadoMateriales_Det_Info> ConsultaDetalleGODxDetListMateriales(int idempresa, decimal idlistadoMat, int iddetalle)
      {
          try
          {
              return data.ConsultaDetalleGODxDetListMateriales(idempresa, idlistadoMat, iddetalle);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDetalleGODxDetListMateriales", ex.Message), ex) { EntityType = typeof(prd_GenerOCompraDet_Bus) };
                
          }
      }
      public List<com_ListadoMateriales_Det_Info> ConsultaDetalleGOD(int idempresa, decimal idtrans)
      {
          try
          {
              return data.ConsultaDetalleGOD(idempresa, idtrans);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDetalleGOD", ex.Message), ex) { EntityType = typeof(prd_GenerOCompraDet_Bus) };
               
          }
      }

      public Boolean ModificarDB(List<prd_GenerOCompra_Info> LstInfo)
      {
          try
          {

              return data.ModificarDB(LstInfo);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_GenerOCompraDet_Bus) };
               
          }
      }

    }
}
