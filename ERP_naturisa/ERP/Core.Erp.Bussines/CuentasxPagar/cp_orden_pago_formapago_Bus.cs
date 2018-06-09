using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;


namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_orden_pago_formapago_Bus
    {
        cp_orden_pago_formapago_Data odata = new cp_orden_pago_formapago_Data();
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<cp_orden_pago_formapago_Info> Get_List_orden_pago_formapago()
       {
           try
           {
               return odata.Get_List_orden_pago_formapago();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_formapago", ex.Message), ex) { EntityType = typeof(cp_orden_pago_formapago_Bus) };
           }
       }

       public Boolean ValidarCodigoExiste(string Cod)
       {
           try
           {
               return odata.ValidarCodigoExiste(Cod);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cp_orden_pago_formapago_Bus) };
           }

       }

       public Boolean ModificarDB(List<cp_orden_pago_formapago_Info> lst)
       {
           try
           {
               return odata.ModificarDB(lst);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_formapago_Bus) };
           }
       }
       public Boolean GuardarDB(cp_orden_pago_formapago_Info Info)
       {
           try
           {
               return odata.GuardarDB(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_formapago_Bus) };
           }
       }

       public Boolean ModificarDB(cp_orden_pago_formapago_Info Info)
       {
           try
           {
               return odata.ModificarDB(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_formapago_Bus) };
           }
       }
    }
}
