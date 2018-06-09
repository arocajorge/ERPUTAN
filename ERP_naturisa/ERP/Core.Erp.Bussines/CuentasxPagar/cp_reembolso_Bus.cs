using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_reembolso_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       cp_reembolso_Data data = new cp_reembolso_Data();
       public Boolean GuardarDB(cp_reembolso_Info Info)
       {
           try
           {
                 return data.GuardarDB(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_reembolso_Bus) };
           }

       }

       public List<cp_reembolso_Info> Get_List_reembolso(int IdEmpresa)
       {
           try
           {
             return data.Get_List_reembolso(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_reembolso", ex.Message), ex) { EntityType = typeof(cp_reembolso_Bus) };
           }

       }

       public List<cp_reembolso_Info> Get_List_reembolso(int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro)
       {
           try
           {
            return data.Get_List_reembolso(IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_proveedor_codigo_SRI", ex.Message), ex) { EntityType = typeof(cp_reembolso_Bus) };
           }

       }

      

       public Boolean GuardarDBLst(List<cp_reembolso_Info> lst, int IdEmpresa,int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro, ref string mensaje)
       {
           try
           {
               foreach (var item in lst)
               {
                   item.IdEmpresa = IdEmpresa;
                   item.IdTipoCbte_Ogiro = IdTipoCbte_Ogiro;
                   item.IdCbteCble_Ogiro = IdCbteCble_Ogiro;

                   data.GuardarDB(item);
               }
               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDBLst", ex.Message), ex) { EntityType = typeof(cp_reembolso_Bus) };
           }
       }

       public bool Eliminar(int IdEmpresa, Decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
       {
           try
           {
             return data.EliminarDB(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_reembolso_Bus) };
           }

       }

       public bool ModificarLst(List<cp_reembolso_Info> lst,int IdEmpresa, Decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
       {
           try
           {
               Eliminar(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
               return GuardarDBLst(lst, IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarLst", ex.Message), ex) { EntityType = typeof(cp_reembolso_Bus) };
           }
       }

       public cp_reembolso_Bus(){}
    }
}
