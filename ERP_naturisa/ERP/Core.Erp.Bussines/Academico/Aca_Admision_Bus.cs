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
 public   class Aca_Admision_Bus
    {

     private Aca_Admision_Data da;
     tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

     public Aca_Admision_Bus() {
         da = new Aca_Admision_Data();
     }

     public List<Aca_Admision_Info> Get_List_Admision(int IdInstitucion) {
         List<Aca_Admision_Info> lista= new List<Aca_Admision_Info>();
         try
         {
             lista = da.Get_List_Admision(IdInstitucion);
             return lista;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };
         }
         
     }

     public Aca_Admision_Info Get_Admision_x_Persona(string cedula, ref string estadoRegistroCedula, ref string mensaje)
     {
         Aca_Admision_Info admisionInfo=new Aca_Admision_Info();         
         try
         {
            admisionInfo = da.GetAdmision_x_Persona(cedula, ref estadoRegistroCedula, ref mensaje);
            return admisionInfo;           
           
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };
         }
         
     }

     public bool GrabarDB(Aca_Admision_Info info,ref decimal idAdmision,ref string mensaje){
         bool resultado=false;
         try
         {
             resultado = da.GrabarDB(info, ref idAdmision, ref mensaje);
             return resultado;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };
         }
         
     }

     public bool ActualizarDB(Aca_Admision_Info info,ref string mensaje) {
         bool resultado = false;
         try
         {
             resultado= da.ActualizarDB(info, ref mensaje);
             return resultado;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };
         }
         
     }

     public bool EliminarDB(Aca_Admision_Info info,ref string mensaje) {
         bool resultado = false;
         try
         {
             resultado = da.AnularDB(info, ref mensaje);
             return resultado;
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };
         }
         
     }
     public bool ExisteCedula(int idInstuticion, decimal idAdmision, string cedulaRuc, ref string mensaje)
     {
         try
         {            
             return da.ExisteCedula(idInstuticion, idAdmision, cedulaRuc, ref mensaje);
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCedula", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
         }
     }
    
    }
}
