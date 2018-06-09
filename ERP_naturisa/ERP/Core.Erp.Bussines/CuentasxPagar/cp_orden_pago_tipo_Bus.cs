using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Business.CuentasxPagar
{
  public   class cp_orden_pago_tipo_Bus
    {
      cp_orden_pago_tipo_Data odata = new cp_orden_pago_tipo_Data();
      tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      

      public List<cp_orden_pago_tipo_Info> Get_List_orden_pago_tipo()
      {
          try
          {
              return data.Get_List_orden_pago_tipo();
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_tipo", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_Bus) };
          }
      }

      public List<cp_orden_pago_tipo_Info> Get_List_orden_pago_tipo_x_Empresa(int IdEmpresa)
      {
          try
          {
              return odata.Get_List_orden_pago_tipo_x_Empresa(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_tipo_x_Empresa", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_Bus) };
          }
      
      
      }
      cp_orden_pago_tipo_Data data = new cp_orden_pago_tipo_Data();
      
      public Boolean ValidarCodigoExiste(string Cod)
      {
          try
          {
              return data.ValidarCodigoExiste(Cod);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_Bus) };
          }

      }

      public Boolean ModificarDB(List<cp_orden_pago_tipo_Info> lst)
      {
          try
          {
              return data.ModificarDB(lst);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_Bus) };
          }
      }
      public Boolean GuardarDB(cp_orden_pago_tipo_Info Info)
      {
          try
          {
              return data.GuardarDB(Info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_Bus) };
          }
      }

      public Boolean ModificarDB(cp_orden_pago_tipo_Info Info)
      {
          try
          {
              return data.ModificarDB(Info);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_Bus) };
          }
      }
    }
}
