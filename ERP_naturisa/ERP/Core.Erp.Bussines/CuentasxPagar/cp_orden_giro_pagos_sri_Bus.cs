using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_orden_giro_pagos_sri_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       cp_orden_giro_pagos_sri_Data data = new cp_orden_giro_pagos_sri_Data();
      
       public Boolean GuardarDB(cp_orden_giro_pagos_sri_Info Info)
       {
           try
           {
                 return data.GuardarDB(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_pagos_sri_Bus) };
           }

       }

       public List<cp_orden_giro_pagos_sri_Info> Get_List_orden_giro_pagos_sri()
       {
           try
           {
              return data.Get_List_orden_giro_pagos_sri();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro_pagos_sri", ex.Message), ex) { EntityType = typeof(cp_orden_giro_pagos_sri_Bus) };
           }

       }

       public Boolean GuardarDB(List<cp_orden_giro_pagos_sri_Info> lst, int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro, ref string msg)
       {
           try
           {
               foreach(var item in lst)
               {
                   if(item.check == true)
                   {
                       item.IdEmpresa = IdEmpresa;
                       item.IdTipoCbte_Ogiro = IdTipoCbte_Ogiro;
                       item.IdCbteCble_Ogiro = IdCbteCble_Ogiro;

                       data.GuardarDB(item);
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_pagos_sri_Bus) };
           }
       }

       public bool ModificarDB(List<cp_orden_giro_pagos_sri_Info> lst, int IdEmpresa, Decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
       {
           try
           {
               data.EliminarDB(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
               return GuardarDB(lst, IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_pagos_sri_Bus) };
           }
       }

       public List<cp_orden_giro_pagos_sri_Info> Get_List_orden_giro_pagos_sri(int IdEmpresa=0, decimal IdCbteCble_Ogiro=0, int IdTipoCbte_Ogiro=0)
       {
           try
           {
                return data.Get_List_orden_giro_pagos_sri(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro_pagos_sri", ex.Message), ex) { EntityType = typeof(cp_orden_giro_pagos_sri_Bus) };

           }
          
       }

       public cp_orden_giro_pagos_sri_Bus(){}
    }
}
