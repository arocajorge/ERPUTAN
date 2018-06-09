using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_orden_pago_det_Bus
    {
      cp_orden_pago_det_Data oData = new cp_orden_pago_det_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      public Boolean GuardarDB(List<cp_orden_pago_det_Info> Lst, ref decimal Id, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Lst, ref Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
            }


        }

      public List<cp_orden_pago_det_Info> Get_List_OrdenPagoDetalle(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
      {
          try
          {
              return oData.Get_List_OrdenPagoDetalle(IdEmpresa, IdOrdenPago, ref  mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OrdenPagoDetalle", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      
      
      }

      public List<cp_orden_pago_det_Info> Get_List_OrdenPagoDetalle(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
      {
          try
          {
              return oData.Get_List_OrdenPagoDetalle(IdEmpresa_Ogiro, IdCbteCble_Ogiro, IdTipoCbte_Ogiro, ref  mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OrdenPagoDetalle", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      
      }

      public List<cp_orden_pago_det_Info> Get_list_orden_pago_con_cta_acreedora(int IdEmpresa, List<decimal> list_op)
      {
          try
          {
              return oData.Get_list_orden_pago_con_cta_acreedora(IdEmpresa, list_op);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_orden_pago_con_cta_acreedora", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      }

      public List<cp_orden_pago_det_Info> Get_info_orden_pago_con_cta_acreedora(int IdEmpresa, decimal IdOrdenPago)
      {
          try
          {
              return oData.Get_info_orden_pago_con_cta_acreedora(IdEmpresa, IdOrdenPago);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_orden_pago_con_cta_acreedora", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      }

      public Boolean ModificarDB(cp_orden_pago_det_Info Info)
      {
          try
          {
              return oData.ModificarDB(Info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      }



      public Boolean ModificarDB_Forma_Pago(List< cp_orden_pago_det_Info> Info_Detalle)
      {
          try
          {
              return oData.ModificarDB_Forma_Pago(Info_Detalle);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }

      }

      public Boolean ModificarDB(cp_orden_pago_det_Info Info, ref decimal Id, ref string mensaje)
      {
          try
          {
              return oData.ModificarDB(Info,ref Id,ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      }

      public Boolean ModificarDB(List<cp_orden_pago_det_Info> lista)
      {
          try
          {
              bool res=false;
              
              foreach (var item in lista)
              {
                  if (oData.ModificarDB(item.IdEmpresa, item.IdOrdenPago, item.Secuencia))
                  {
                      res = true;
                  }
                   
              }

              return res;
             
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_OrdenPagoCancelacion", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      }


      public cp_orden_pago_det_Info Get_Info_orden_pago(int IdEmpresa, decimal IdOrdenPago)
      {
          try
          {
              return oData.Get_Info_orden_pago(IdEmpresa,IdOrdenPago);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_OrdenPagoCancelacion", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
          }
      }

      

    }
}
