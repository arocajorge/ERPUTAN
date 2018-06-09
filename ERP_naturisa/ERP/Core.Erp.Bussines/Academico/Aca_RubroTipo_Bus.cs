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
 public   class Aca_RubroTipo_Bus
    {
     Aca_RubroTipo_Data da;
     tb_sis_Log_Error_Vzen_Bus oLog;

     public Aca_RubroTipo_Bus() {
         da = new Aca_RubroTipo_Data();
         oLog = new tb_sis_Log_Error_Vzen_Bus();
     }

     public List<Aca_RubroTipo_Info> Get_List_RubroTipo()
     {
         List<Aca_RubroTipo_Info> lista = new List<Aca_RubroTipo_Info>();
         try
         {
             lista = da.Get_List_RubroTipo();
             return lista;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_RubroTipo", ex.Message), ex) { EntityType = typeof(Aca_RubroTipo_Bus) };
         }
         
     }


     public bool GrabarDB(Aca_RubroTipo_Info info, ref int idTipoRubro, ref string mensaje)
     {
         bool resultado = false;
         try
         {
             resultado = da.GrabarDB(info, ref idTipoRubro, ref mensaje);
             return resultado;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_RubroTipo_Bus) };
         }
         
     }

     public bool ActualizarDB(Aca_RubroTipo_Info info, ref string mensaje)
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
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_RubroTipo_Bus) };
         }
         
     }

     public bool EliminarDB(Aca_RubroTipo_Info info, ref string mensaje)
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
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_RubroTipo_Bus) };
         }
         
     }
    }
}
