using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
  public  class Aca_Rubro_Bus
    {
      Aca_Rubro_Data da;
      tb_sis_Log_Error_Vzen_Bus oLog;

      public Aca_Rubro_Bus(){
          da = new Aca_Rubro_Data();
          oLog = new tb_sis_Log_Error_Vzen_Bus();
      }

      public List<Aca_Rubro_Info> Get_List_Rubro()
      {
          List<Aca_Rubro_Info> lista = new List<Aca_Rubro_Info>();
          try
          {
              lista = da.Get_List_Rubro();
              return lista;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
          }
      }

      public Aca_Rubro_Info Get_Info_Rubro_x_Producto(decimal IdProducto)
      {
          try
          {
              return da.Get_Info_Rubro_x_Producto(IdProducto);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
          }
      }

      public bool GrabarDB(Aca_Rubro_Info info, ref int idRubro, ref string mensaje)
      {
          bool resultado = false;
          try
          {
              resultado = da.GrabarDB(info, ref idRubro, ref mensaje);
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
          }
          
      }

      public bool ActualizarDB(Aca_Rubro_Info info, ref string mensaje)
      {
          bool resultado = false;
          try
          {
              resultado = da.ActualizarDB(info, ref mensaje);
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
          }
          
      }

      public bool EliminarDB(Aca_Rubro_Info info, ref string mensaje)
      {
          bool resultado = false;
          try
          {
              resultado = da.AnularDB(info, ref mensaje);
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
          }
          
      }
    



    }
}
