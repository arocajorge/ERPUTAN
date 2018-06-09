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
   public  class Aca_Tarjeta_cred_Bus
    {
       string MensajeError="";

       Aca_Tarjeta_cred_Data Odata = new Aca_Tarjeta_cred_Data();

       public List<Aca_Tarjeta_cred_Info> Get_List_Tarjeta_cred()
       {
           try
           {

               return Odata.Get_List_Tarjeta_cred();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };

           }
       }

       public Boolean GrabarDB(Aca_Tarjeta_cred_Info info, ref Int32 IdTarjeta, ref string MensajeError)
       {
           try
           {

               return Odata.GrabarDB(info, ref IdTarjeta ,ref MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };

           }
       }

       public bool ActualizarDB(Aca_Tarjeta_cred_Info info, ref string mensaje)
       {
           try
           {
               return Odata.ActualizarDB(info, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_RubroTipo_Bus) };
           }

       }

       public bool EliminarDB(Aca_Tarjeta_cred_Info info, ref string mensaje)
       {
           try
           {
               return Odata.AnularDB(info, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_RubroTipo_Bus) };
           }

       }
    }
}
