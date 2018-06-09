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
     public class Aca_Profesor_Bus
    {
         Aca_Profesor_Data Odata;
         tb_sis_Log_Error_Vzen_Bus oLog;

         public Aca_Profesor_Bus() {
             Odata = new Aca_Profesor_Data();
             oLog = new tb_sis_Log_Error_Vzen_Bus();
         }
         
         public Aca_Profesor_Info Get_Profesor_Info(string cedula) {
             try
             {
                return  Odata.Get_Profesor_Info(cedula);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Profesor_Info", ex.Message), ex) { EntityType = typeof(Aca_Profesor_Bus) };
             }         
         }

         public List<Aca_Profesor_Info> Get_list_Profesor(int IdEmpresa)
         {
             List<Aca_Profesor_Info> listaProfesor = new List<Aca_Profesor_Info>();

             try
             {
                 listaProfesor=Odata.Get_list_Profesor(IdEmpresa);
                 return listaProfesor;

             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Profesor", ex.Message), ex) { EntityType = typeof(Aca_Profesor_Bus) };
             }
         }

         public bool GrabarDB(Aca_Profesor_Info info, ref decimal idProfesor,ref string mensaje) {             
             try{
                 
               return  Odata.GrabarDB(info, ref idProfesor, ref mensaje);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Profesor_Bus) };
             }
         }

         public bool ActualizarDB(Aca_Profesor_Info info,ref string mensaje) {
             try
             {
                 return Odata.ActualizarDB(info, ref mensaje);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Profesor_Bus) };
             }
         }

         public bool DeleteDB(Aca_Profesor_Info info, ref string mensaje)
         {
             try
             {
                 return Odata.AnularDB(info, ref mensaje);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DeleteDB", ex.Message), ex) { EntityType = typeof(Aca_Profesor_Bus) };
             }
         }
      
    }
}
