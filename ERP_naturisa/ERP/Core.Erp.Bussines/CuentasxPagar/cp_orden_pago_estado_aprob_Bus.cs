using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_pago_estado_aprob_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_orden_pago_estado_aprob_Data data = new cp_orden_pago_estado_aprob_Data();

        public List<cp_orden_pago_estado_aprob_Info> Get_List_orden_pago_estado_aprob()
        {
            try
            {
                return data.Get_List_orden_pago_estado_aprob();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_estado_aprob", ex.Message), ex) { EntityType = typeof(cp_orden_pago_estado_aprob_Bus) };
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                return data.ValidarCodigoExiste(Cod);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cp_orden_pago_estado_aprob_Bus) };
            }

        }

        public Boolean ModificarDB(List<cp_orden_pago_estado_aprob_Info> lst)
        {
            try
            {
                return data.ModificarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_estado_aprob_Bus) };
            }
        }


        public Boolean GuardarDB(cp_orden_pago_estado_aprob_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OrdenPagoDetalle", ex.Message), ex) { EntityType = typeof(cp_orden_pago_estado_aprob_Bus) };
            }
        }

        public Boolean ModificarDB(cp_orden_pago_estado_aprob_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_estado_aprob_Bus) };
            }
        }

    }

    
}
