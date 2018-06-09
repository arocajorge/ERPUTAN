using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.General
{
  public  class tb_pais_Bus
    {
      tb_pais_Data oData = new tb_pais_Data();

      public Boolean GuardarDB(tb_pais_Info Info_Pais, ref string IdPais, ref string msjError)
      {
          try
          {
              return oData.GuardarDB(Info_Pais, ref IdPais, ref msjError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_pais_Bus) };
                
          }
      }

      public Boolean ModificarDB(tb_pais_Info Info_Pais, ref string msjError)
      {
          try
          {
              return oData.ModificarDB(Info_Pais, ref msjError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_DB", ex.Message), ex) { EntityType = typeof(tb_pais_Bus) };
                
          }
      }


      public Boolean AnularDB(tb_pais_Info Info_Pais, ref string msjError)
      {
          try
          {
              return oData.AnularDB(Info_Pais, ref msjError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_DB", ex.Message), ex) { EntityType = typeof(tb_pais_Bus) };
               
          }
      }

      public List<tb_pais_Info> Get_List_pais() 
      {
          try
          {
              return oData.Get_List_pais();
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_pais", ex.Message), ex) { EntityType = typeof(tb_pais_Bus) };
               
          }
      }

      public tb_pais_Info Get_Info_pais(string IdPais)
      {
          try
          {
              return oData.Get_Info_pais(IdPais);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_pais", ex.Message), ex) { EntityType = typeof(tb_pais_Bus) };
               
          }
      }

      public string GetIdPais(string IdProvincia) {
          try
          {
              return oData.GetIdPais(IdProvincia);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdPais", ex.Message), ex) { EntityType = typeof(tb_pais_Bus) };
               
          }
      
      }

    }
}
