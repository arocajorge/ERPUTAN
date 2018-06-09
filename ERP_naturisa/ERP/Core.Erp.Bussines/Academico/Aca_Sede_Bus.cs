using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
   public class Aca_Sede_Bus
    {
       Aca_Sede_Data da;
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       public Aca_Sede_Bus() {
           da = new Aca_Sede_Data();       
       }

    

       public List<Aca_Sede_Info> Get_List_Sede(int IdInstitucion) {
           try
           {
              return da.Get_List_Sede(IdInstitucion);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sede", ex.Message), ex) { EntityType = typeof(Aca_Sede_Bus) };

           }
           
       }

       public bool GrabarDB(Aca_Sede_Info info,ref int IdSede,ref string mensaje) {
           
           try
           {
               return da.GrabarDB(info, ref IdSede, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Sede_Bus) };
           }
           
       }

       public bool ActualizarDB(Aca_Sede_Info info,ref string mensaje) {
           try
           {
               return da.ActualizarDB(info,ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Sede_Bus) };
           }
           
       }

       public bool EliminarDB(Aca_Sede_Info info, ref string mensaje)
       {
           try
           {
               return da.AnularDB(info, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Sede_Bus) };
           }
           
       }
    }
}
