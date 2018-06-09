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
   public   class Aca_ficha_medica_Bus
    {
       Aca_ficha_medica_Data da;
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       public Aca_ficha_medica_Bus() {
          da = new Aca_ficha_medica_Data();
       }


       
       public Boolean GrabarDB(Aca_ficha_medica_Info info,ref string msg) {
           try
           {
               Boolean resultado = da.GrabarDB(info, ref msg);
               return resultado;    
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_ficha_medica_Bus) };
           }              
       }

       public Boolean ActualizarDB(Aca_ficha_medica_Info info, ref string msg)
       {
           try
           {
               Boolean resultado = da.ActualizarDB(info, ref msg);
               return resultado;       
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_ficha_medica_Bus) };
           }
         
       }

       public Aca_ficha_medica_Info Get_ficha_medica(int IdInstitucion, decimal IdEstudiante){
           Aca_ficha_medica_Info infoFicha = new Aca_ficha_medica_Info();
           try
           {

               infoFicha = da.Get_ficha_medica(IdEstudiante, IdInstitucion);
               return infoFicha;   
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ficha_medica", ex.Message), ex) { EntityType = typeof(Aca_ficha_medica_Bus) };
           }              
       }

    }
}
