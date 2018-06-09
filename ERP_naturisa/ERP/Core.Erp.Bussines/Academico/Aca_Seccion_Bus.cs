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
   public class Aca_Seccion_Bus
    {
       private Aca_Seccion_Data da;
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       public Aca_Seccion_Bus() {
           da = new Aca_Seccion_Data();
       }
       public int GetIdSeccion(int IdCurso) {
           try
           {
               return da.GetIdSeccion(IdCurso);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdSeccion", ex.Message), ex) { EntityType = typeof(Aca_Seccion_Bus) };
           }
       }

       public List<Aca_Seccion_Info> Get_List_Seccion(int IdInstitucion, int IdJornada) {
           List<Aca_Seccion_Info> lista = new List<Aca_Seccion_Info>();
           try
           {
               lista= da.Get_List_Seccion(IdInstitucion, IdJornada);
               return lista;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Seccion", ex.Message), ex) { EntityType = typeof(Aca_Seccion_Bus) };
           }
           
       }

       public List<Aca_Seccion_Info> Get_Lista_Seccion(int IdInstitucion)
       {
           List<Aca_Seccion_Info> lista = new List<Aca_Seccion_Info>();
           try
           {
               lista = da.Get_List_Seccion(IdInstitucion);
               return lista;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Seccion", ex.Message), ex) { EntityType = typeof(Aca_Seccion_Bus) };
           }

       }

       public bool GrabarDB(Aca_Seccion_Info info,ref int IdSeccion,ref string mensaje) {
           bool resultado = false;
           try
           {
               resultado= da.GrabarDB(info, ref IdSeccion,ref mensaje);
               return resultado;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Seccion_Bus) };
           }
           
       }

       public bool ActualizarDB(Aca_Seccion_Info info,ref string mensaje) {
           bool resultado = false;
           try
           {
               resultado = da.ActualizarDB(info, ref mensaje);
               return resultado;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Seccion_Bus) };
           }
           
       }

       public bool EliminarDB(Aca_Seccion_Info info, ref string mensaje)
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
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Seccion_Bus) };
           }
           
       }
    }
}
