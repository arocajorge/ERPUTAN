using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Business.General
{
   public  class tb_sis_Grupo_empresarial_Cliente_Bus
    {

       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       tb_sis_Grupo_empresarial_Cliente_Data OData = new tb_sis_Grupo_empresarial_Cliente_Data();



       public List<tb_sis_Grupo_empresarial_Cliente_Info> Get_List_Grupo_empresarial_Cliente(ref string mensaje)
       {
           try
           {
               return OData.Get_List_Grupo_empresarial_Cliente(ref mensaje);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Grupo_empresarial_Cliente_Bus) };
         
               
           }

       }

       public tb_sis_Grupo_empresarial_Cliente_Bus()
       {

       }
    }
}
