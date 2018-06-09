using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
  public  class tb_Ciudad_Bus
    {
        List<tb_ciudad_Info> lstCiudad = new List<tb_ciudad_Info>();
        tb_Ciudad_Data dataCiu = new tb_Ciudad_Data();

        public Boolean GuardarDB(tb_ciudad_Info Info_Ciu, ref string IdCiudad, ref string msjError)
        {
            try
            {
                return dataCiu.Guardar_DB(Info_Ciu, ref IdCiudad, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_Ciudad_Bus) };
         
            }
        }

        public Boolean ModificarDB(tb_ciudad_Info Info_Ciu, ref string msjError)
        {
            try
            {
                return dataCiu.Modificar_DB(Info_Ciu, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_DB", ex.Message), ex) { EntityType = typeof(tb_Ciudad_Bus) };
         
            }
        }


        public Boolean AnularDB(tb_ciudad_Info Info_Ciu, ref string msjError)
        {
            try
            {
                return dataCiu.Anular_DB(Info_Ciu, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_DB", ex.Message), ex) { EntityType = typeof(tb_Ciudad_Bus) };
         
            }
        }

      public List<tb_ciudad_Info> Get_List_Ciudad(string idProvincia) 
      {
          try
          {
              return dataCiu.Get_List_Ciudad(idProvincia);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ciudad", ex.Message), ex) { EntityType = typeof(tb_Ciudad_Bus) };
         
          }         
      }

      public List<tb_ciudad_Info> Get_List_Ciudad()
      {
          try
          {
              return dataCiu.Get_List_Ciudad();
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ciudad", ex.Message), ex) { EntityType = typeof(tb_Ciudad_Bus) };

          }
      }

      public tb_ciudad_Info Get_Info_Ciudad(string IdCiudad)
      {
          try
          {
              return dataCiu.Get_Info_Ciudad(IdCiudad);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Ciudad", ex.Message), ex) { EntityType = typeof(tb_Ciudad_Bus) };
         
          }
      }


      public tb_Ciudad_Bus() { }

    }
}
