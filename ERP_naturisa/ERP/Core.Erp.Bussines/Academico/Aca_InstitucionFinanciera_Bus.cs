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
   public class Aca_InstitucionFinanciera_Bus
    {
       Aca_InstitucionFinanciera_Data da;
       tb_sis_Log_Error_Vzen_Bus oLog;
       
       public Aca_InstitucionFinanciera_Bus() {
           da = new Aca_InstitucionFinanciera_Data();
           oLog = new tb_sis_Log_Error_Vzen_Bus();
       }

       public List<Aca_InstitucionFinanciera_Info> Get_List_InstitucionFinanciera() {
           try
           {
               return da.Get_List_InstitucionFinanciero();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_InstitucionFinanciera", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_Bus) };
           }
       }

       public bool GrabarDB(Aca_InstitucionFinanciera_Info info, ref int idInstitucionFinanciera, ref string msj)
       {
           try
           {
               return da.GuardarDB(info, ref idInstitucionFinanciera, ref msj);
               
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_Bus) };
           }
           
       }

       public bool ActualizarDB(Aca_InstitucionFinanciera_Info info, ref string msj)
       {
           try
           {
           return da.ActualizarDB(info, ref msj);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_Bus) };
           }
           
       }

       public bool EliminarDB(Aca_InstitucionFinanciera_Info info, ref string msj)
       {

           try
           {
               return da.AnularDB(info, ref msj);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_Bus) };
           }
           
       }

    }
}
