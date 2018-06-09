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
  public  class Aca_Curso_Bus
    {
      private Aca_Curso_Data da;
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      public Aca_Curso_Bus() {
          da = new Aca_Curso_Data();
      }

      public List<Aca_Curso_Info> Get_Lista_Curso(int IdInstitucion)
      {
          List<Aca_Curso_Info> lista = new List<Aca_Curso_Info>();
          try
          {
              lista = da.Get_Lista_Curso(IdInstitucion);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Curso", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
          }
          return lista;
      }

    
      public List<Aca_Curso_Info> Get_List_Curso(int IdInstitucion, int IdSeccion) {
          List<Aca_Curso_Info> lista = new List<Aca_Curso_Info>();
          try
          {
             lista = da.Get_List_Curso(IdInstitucion,IdSeccion);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Curso", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
          }
          return lista;
      }

      public bool GrabarDB(Aca_Curso_Info info,ref int IdCurso,ref string mensaje) {
          bool resultado=false;
          try
          {
             resultado = da.GrabarDB(info,ref IdCurso,ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
          }
          return resultado;
      }

      public bool ActualizarDB(Aca_Curso_Info info,ref string mensaje) {
          bool resultado = false;
          try
          {
              resultado = da.ActualizarDB(info,ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
          }
          return resultado;
      }

      public bool EliminarDB(Aca_Curso_Info info, ref string mensaje)
      {
          bool resultado = false;
          try
          {
              resultado = da.AnularDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
          }
          return resultado;
      }

    }
}
