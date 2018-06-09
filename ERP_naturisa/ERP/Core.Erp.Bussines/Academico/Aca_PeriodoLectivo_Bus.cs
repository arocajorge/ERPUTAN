using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;

namespace Core.Erp.Business.Academico
{
  public  class Aca_PeriodoLectivo_Bus
    {
      Aca_PeriodoLectivo_Data da;

      public List<Aca_PeriodoLectivo_Info> Get_List_Anio_Lectivo(int IdInstitucion) {
          List<Aca_PeriodoLectivo_Info> lstAnioLec = new List<Aca_PeriodoLectivo_Info>();
          try
          {
             da = new Aca_PeriodoLectivo_Data();
             lstAnioLec = da.Get_List_Anio_Lectivo(IdInstitucion);
             return lstAnioLec;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Anio_Lectivo", ex.Message), ex) { EntityType = typeof(Aca_PeriodoLectivo_Bus) };
          }
          
      }

      public bool GrabarDB(Aca_PeriodoLectivo_Info info, ref string mensaje) {
          bool resultado = false;
          try
          {
              da = new Aca_PeriodoLectivo_Data();
              resultado = da.Grabar(info, ref mensaje);
              return resultado;      
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_PeriodoLectivo_Bus) };
          }
          
      }

      public bool ActualizarDB(Aca_PeriodoLectivo_Info info,ref string mensaje) {
          bool resultado = false;
          try
          {
              da = new Aca_PeriodoLectivo_Data();
              resultado= da.Actualizar(info, ref mensaje);
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_PeriodoLectivo_Bus) };
          }
          
      }

      public bool EliminarDB(Aca_PeriodoLectivo_Info info,ref string mensaje) {
          bool resultado = false;
          try
          {
              da = new Aca_PeriodoLectivo_Data();
              resultado = da.AnularDB(info, ref mensaje);
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_PeriodoLectivo_Bus) };
          }
          
      }
    }
}
