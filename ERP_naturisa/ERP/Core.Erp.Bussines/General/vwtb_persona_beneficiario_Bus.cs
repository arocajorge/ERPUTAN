using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
   public class vwtb_persona_beneficiario_Bus
    {
       vwtb_persona_beneficiario_Data data = new vwtb_persona_beneficiario_Data();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";

       public List<vwtb_persona_beneficiario_Info> Get_List_PersonaBeneficiario(int IdEmpresa)
       {
           try
           {
               return data.Get_List_PersonaBeneficiario(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PersonaBeneficiario", ex.Message), ex) { EntityType = typeof(vwtb_persona_beneficiario_Bus) };
           
           }
       }

       public vwtb_persona_beneficiario_Info Get_Info_PersonaBeneficiario(int IdEmpresa, decimal IdProveedor, string IdTipo_Persona)
       {
           try
           {
               return data.Get_Info_PersonaBeneficiario(IdEmpresa, IdProveedor, IdTipo_Persona);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_PersonaBeneficiario", ex.Message), ex) { EntityType = typeof(vwtb_persona_beneficiario_Bus) };
           
           }
       }

       public List<vwtb_persona_beneficiario_Info> Get_List_PersonaBeneficiario(int IdEmpresa, string Persona)
       {
           try
           {
               return data.Get_List_PersonaBeneficiario(IdEmpresa, Persona);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PersonaBeneficiario", ex.Message), ex) { EntityType = typeof(vwtb_persona_beneficiario_Bus) };
           
           }
       }
    }
}
