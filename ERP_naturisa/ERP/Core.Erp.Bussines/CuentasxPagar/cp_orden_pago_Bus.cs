using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;


namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_orden_pago_Bus
    {
      cp_orden_pago_Data oData = new cp_orden_pago_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      string mensaje = "";

      public Boolean GuardaDB(cp_orden_pago_Info InfoOP, ref decimal Id, ref string mensaje)
        {
            try
            {
                Boolean res=false;

                if (Validar_y_corregir_objeto(InfoOP, ref mensaje)==true)
                { 
                   res= oData.GuardaDB(InfoOP, ref Id, ref  mensaje);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
            }
        }

      public cp_orden_pago_Info Get_Info_orden_pago(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
      {
          try
          {
              return oData.Get_Info_orden_pago(IdEmpresa,  IdOrdenPago, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_orden_pago", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
          }
      
      
      }
      
      public Boolean ModificarDB(cp_orden_pago_Info Info, ref string mensaje)
      {
          try
          {
              Boolean Res = false;
              cp_orden_pago_det_Bus BusOp_det = new cp_orden_pago_det_Bus();

              Boolean res = false;

              if (Validar_y_corregir_objeto(Info, ref mensaje) == true)
              {

                  Res = oData.ModificarDB(Info, ref mensaje);
                  if (Res)
                  {
                      Res = BusOp_det.ModificarDB_Forma_Pago(Info.Detalle);
                  }

              }
              return Res;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
          }              
      }

      public Boolean AnularDB(cp_orden_pago_Info Info)
      {

          try
          {
              return oData.AnularDB(Info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
          }
      
      }

      public bool Eliminar_OrdenPago(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
      {
          try
          {
              return oData.Eliminar_OrdenPago(IdEmpresa,  IdOrdenPago, ref  mensaje);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_OrdenPago", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
          }
      
      
      }

      public List<cp_orden_pago_Info> Get_List_orden_pago(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, ref string mensaje)
      {
          try
          {
              return oData.Get_List_orden_pago(IdEmpresa, fechaIni, fechaFin, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
          }     
      }

      public List<vwcp_Anticipos_x_NotaCred_Saldo_Info> Get_List_Orden_Pago_Anticipos_con_Saldos_Pagados(int IdEmpresa, decimal IdProveedor, ref string mensaje)
      {
          try
          {
              return oData.Get_List_Orden_Pago_Anticipos_con_Saldos_Pagados(IdEmpresa, IdProveedor, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Orden_Pago_Anticipos_Saldos", ex.Message), ex) { EntityType = typeof(cp_orden_pago_Bus) };
          } 
      
      
      }

      private Boolean Validar_y_corregir_objeto(cp_orden_pago_Info orden_pago_Info, ref string msg)
      {
          try
          {
              #region 'Validaciones'
              /*--- validaciones */


              if (orden_pago_Info.IdEmpresa <= 0 )
              {
                  msg = "Error en la cabecera de fact uno de los PK es <=0";
                  return false;
              }


              if (orden_pago_Info.IdPersona <= 0)
              {
                  msg = "Erro en la cabecera  IdPersona es <=0";
                  return false;
              }

              if (orden_pago_Info.IdTipo_Persona == "")
              {
                  msg = "Erro en la cabecera  IdTipo_Persona en blanco";
                  return false;
              }


              if (orden_pago_Info.Detalle == null)
              {
                  msg = "la OP no tiene detalle ";
                  return false;
              }

              if (orden_pago_Info.Detalle.Count == 0)
              {
                  msg = "la OP no tiene detalle ";
                  return false;
              }

              if (orden_pago_Info.IdFormaPago == "" || orden_pago_Info.IdFormaPago == "Vacio" || orden_pago_Info.IdFormaPago==null)
              {
                  orden_pago_Info.IdFormaPago = "CHEQUE";
              }

              foreach (var item in orden_pago_Info.Detalle)
              {

                  if (item.IdFormaPago == "")
                  {
                      item.IdFormaPago = "CHEQUE";
                  }
              }

              
              /*--- corrigiendo data */

              #endregion

              return true;

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
          }
      }

      public bool Modificar_tipo_flujo(int IdEmpresa, decimal IdOrdenPago, Nullable<decimal> IdTipoFlujo)
      {
          try
          {
              return oData.Modificar_tipo_flujo(IdEmpresa, IdOrdenPago, IdTipoFlujo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_tipo_flujo", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
          }
      }
          
    }
}
