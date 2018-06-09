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
 public   class Aca_Paralelo_Bus
    {
     private Aca_Paralelo_Data da;
     tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

     public Aca_Paralelo_Bus() {
         da = new Aca_Paralelo_Data();
     }

     public List<Aca_Paralelo_Info> Get_List_Paralelo(int IdCurso) {
         try
         {
             return da.Get_List_Paralelo(IdCurso);
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Paralelo", ex.Message), ex) { EntityType = typeof(Aca_Paralelo_Bus) };
         }     
     }

     public bool GrabarDB(Aca_Paralelo_Info info,ref int IdParalelo,ref string mensaje) {
         bool resultado = false;
         try
         {
            resultado = da.GrabarDB(info,ref IdParalelo,ref mensaje);
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Paralelo_Bus) };
         }
         return resultado;     
     }

     public bool ActualizarDB(Aca_Paralelo_Info info,ref string mensaje) {
         bool resultado = false;
         try
         {
             resultado = da.ActualizarDB(info,ref mensaje);
             return resultado;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Paralelo_Bus) };
         }
         
     }

     public bool EliminarDB(Aca_Paralelo_Info info, ref string mensaje)
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
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Paralelo_Bus) };
         }
         
     }

    }
}
