using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Business.General
{
   public class tb_parroquia_Bus
    {
       tb_parroquia_Data Odata = new tb_parroquia_Data();

       public tb_parroquia_Bus() { }

      string mensaje = "";
      public Boolean Guardar_DB(tb_parroquia_Info Info_Pro, ref string IdParroquia, ref string msjError)
      {
          try
          {
              return Odata.Guardar_DB(Info_Pro, ref IdParroquia, ref msjError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_parroquia_Bus) };  
          }
      }

      

      public Boolean Modificar_DB(tb_parroquia_Info Info_Pro, ref string msjError)
      {
          try
          {
              return Odata.Modificar_DB(Info_Pro, ref msjError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_parroquia_Bus) };  
          }
      }

      public Boolean Anular_DB(tb_parroquia_Info Info_Pro, ref string msjError)
      {
          try
          {
              return Odata.Anular_DB(Info_Pro, ref msjError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_parroquia_Bus) };  
          }
      }



      public List<tb_parroquia_Info> Get_List_Parroquias(string IdCiudad_Canton)
      {
          try
          {
              return Odata.Get_List_Parroquias(IdCiudad_Canton);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_parroquia_Bus) };
          }
      }

      public List<tb_parroquia_Info> Get_List_Parroquia() 
      {                    
          try
          {
              List<tb_parroquia_Info> lstProvincia = new List<tb_parroquia_Info>();
              lstProvincia=Odata.Get_List_Parroquia();
              return lstProvincia;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_parroquia_Bus) };
          }          
      }


        public tb_parroquia_Info Get_Info_Parroquia(string IdParroquia)
        {
            try
            {
                tb_parroquia_Info infoParroquia = new tb_parroquia_Info();
                infoParroquia = Odata.Get_Info_Parroquia(IdParroquia);

                return infoParroquia;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_DB", ex.Message), ex) { EntityType = typeof(tb_parroquia_Bus) };
            }
        }


    }
}
