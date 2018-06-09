using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cp_Aprobacion_Orden_Pago_Data oData = new cp_Aprobacion_Orden_Pago_Data();

        public Boolean Guardar_AprobacionOrdenPago(cp_Aprobacion_Orden_Pago_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                return oData.Guardar_AprobacionOrdenPago(Item, ref Id, ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_AprobacionOrdenPago", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Orden_Pago_Bus) };
            }
        }


    }
}
