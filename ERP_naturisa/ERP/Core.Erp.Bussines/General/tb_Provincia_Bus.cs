using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
  public  class tb_Provincia_Bus
    {
        tb_Provincia_Data dataProvi = new tb_Provincia_Data();

        public Boolean Guardar_DB(tb_provincia_Info Info_Pro, ref string IdProvincia, ref string msjError)
        {
            try
            {
                return dataProvi.Guardar_DB(Info_Pro, ref IdProvincia, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
          
            }
        }

        public Boolean Modificar_DB(tb_provincia_Info Info_Pro, ref string msjError)
        {
            try
            {
                return dataProvi.Modificar_DB(Info_Pro, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_DB", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
          
            }
        }


        public Boolean Anular_DB(tb_provincia_Info Info_Pro, ref string msjError)
        {
            try
            {
                return dataProvi.Anular_DB(Info_Pro, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_DB", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
           
            }
        }


          public List<tb_provincia_Info> Get_List_Provincia(string IdPais) 
          {
              try
              {
                  return dataProvi.Get_List_Provincia(IdPais);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Provincia", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
           
              }
          }

          public List<tb_provincia_Info> Get_List_Provincia()
          {
              try
              {
                  return dataProvi.Get_List_Provincia();
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Provincia", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
           
              }
          }


          public tb_provincia_Info Get_Info_Provincia(string IdProvincia)
          {
              try
              {
                  return dataProvi.Get_Info_Provincia(IdProvincia);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Provincia", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
            
              }
          }

          public string GetIdProvincia(string IdCiudad) {
              try
              {
                   return dataProvi.Get_IdProvincia(IdCiudad);
              }
              catch (Exception ex)
              {

                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_IdProvincia", ex.Message), ex) { EntityType = typeof(tb_Provincia_Bus) };
            
              }
          
          }

      public tb_Provincia_Bus() { }
    }
}
