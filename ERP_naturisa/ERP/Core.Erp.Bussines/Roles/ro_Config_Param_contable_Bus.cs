/*CLASE: ro_Config_Param_contable_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 09-07-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
  public  class ro_Config_Param_contable_Bus
    {
      ro_Config_Param_contable_Data oData = new ro_Config_Param_contable_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";

      public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Provisiones(int IdEmpresa)
      {
          try
          {
              return oData.Get_List_Config_Param_contable_Provisiones(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaParametrosContables", ex.Message), ex) { EntityType = typeof(ro_Config_Param_contable_Bus) };

          }
      }


      public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Sueldo_x_pagar(int IdEmpresa)
      {
          try
          {
              return oData.Get_List_Config_Param_contable_Sueldo_x_pagar(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaParametrosContables", ex.Message), ex) { EntityType = typeof(ro_Config_Param_contable_Bus) };

          }
      }
      public Boolean GrabarParametrosContables(List<ro_Config_Param_contable_Info> lista, ref string msg)
      {

          try
          {
              return oData.GrabarDB(lista, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarParametrosContables", ex.Message), ex) { EntityType = typeof(ro_Config_Param_contable_Bus) };

          }


      }



      public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Contabilizar_provisiones(int idEmpresa, ref string msg)
      {
          try
          {
              return oData.Get_List_Config_Param_contable_Contabilizar_provisiones(idEmpresa, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorEmpresa", ex.Message), ex) { EntityType = typeof(ro_Config_Param_contable_Bus) };

          }
      }
      public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Contabilizar_Sueldo_x_pagar(int idEmpresa, ref string msg)
      {
          try
          {
              return oData.Get_List_Config_Param_contable_Contabilizar_Sueldo_x_pagar(idEmpresa, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorEmpresa", ex.Message), ex) { EntityType = typeof(ro_Config_Param_contable_Bus) };

          }
      }





    }
}
