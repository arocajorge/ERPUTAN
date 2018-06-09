using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
namespace Core.Erp.Business.Roles
{
    
   public class ro_ConexionBiometrico_Bus
    {
       ro_ConexionBiometrico_Data Data = new ro_ConexionBiometrico_Data();


       public bool GrabarDB(ro_ConexionBiometrico_Info Info)
       {
           try
           {


               return Data.GrabarDB(Info);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_ConexionBiometrico_Bus) };

           }
       }

       public bool ModificarDB(ro_ConexionBiometrico_Info Info)
       {
           try
           {


               return Data.ModificarDB(Info);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_ConexionBiometrico_Bus) };

           }
       }

       public ro_ConexionBiometrico_Info Get_ro_ConexionBiometrico_Info(int IdEmpresa, int IdBiometrico)
       {
           try
           {

              

               return Data.Get_Info_ConexionBiometric(IdEmpresa,IdBiometrico);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ro_ConexionBiometrico_Info", ex.Message), ex) { EntityType = typeof(ro_ConexionBiometrico_Bus) };

           }
       }



       public List<ro_ConexionBiometrico_Info> Get_List_ro_ConexionBiometrico_Info(int IdEmpresa)
       {
           try
           {

             return Data.Get_List_ro_ConexionBiometrico_Info(IdEmpresa);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ro_ConexionBiometrico_Info", ex.Message), ex) { EntityType = typeof(ro_ConexionBiometrico_Bus) };

           }
       }



    }
}
