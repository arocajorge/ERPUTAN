using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
  public  class Aca_Institucion_Bus
    {
      Aca_Institucion_Data da;
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();


      public Aca_Institucion_Bus() {
          da = new Aca_Institucion_Data();
      }

      #region "Get"
      public int GetIdInstitucion(int IdEmpresa) {
          try
          {
             return da.GetIdInstitucion(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdInstitucion", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
      }

      public List<Aca_Institucion_Info> Get_List_Institucion(int IdEmpresa) {
          List<Aca_Institucion_Info> lista = new List<Aca_Institucion_Info>();
          try
          {
              lista = da.Get_List_Institucion(IdEmpresa);
              return lista;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Institucion", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
          
      }

      public Aca_Institucion_Info Get_Info_Institucion(int IdInstitucion)
      {
          Aca_Institucion_Info InfoInsti = new  Aca_Institucion_Info();
          try
          {
              InfoInsti = da.Get_Info_Institucion(IdInstitucion);
              return InfoInsti;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Institucion", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
      
      }

      #endregion

      #region "Grabar,Actualizar,Eliminar"
      public bool GrabarDB(Aca_Institucion_Info info,ref int idInstitucion, ref string mensaje) {
          bool resultado = false;
          try
          {
             resultado = da.GrabarDB(info, ref idInstitucion,ref mensaje);
             return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
          
      }

      public bool ActualizarDB(Aca_Institucion_Info info,ref string mensaje) {
          bool resultado = false;
          try
          {
              resultado = da.ActualizarDB(info, ref mensaje);
              return resultado;

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
          
      }

      public bool EliminarDB(Aca_Institucion_Info info,ref string mensaje) {
          bool resultado = false;
          try
          {
              resultado = da.AnularDB(info,ref mensaje);
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
          
      }
      #endregion

      #region "Validacion"
      public bool ExisteInstitucion(int IdEmpresa) {
          bool respuesta = false;
          try
          {
              respuesta = da.ExisteInstitucion(IdEmpresa);
              return respuesta;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteInstitucion", ex.Message), ex) { EntityType = typeof(Aca_Institucion_Bus) };
          }
          
      }
      #endregion

    }
}
