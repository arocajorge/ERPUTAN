using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Det_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_Aprobacion_Orden_Pago_Det_Data oData = new cp_Aprobacion_Orden_Pago_Det_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<cp_Aprobacion_Orden_Pago_Det_Info> Get_List_Aprobacion_Orden_Pago_Det(int IdEmpresa, string Estado)
        {
            try
            {
                return oData.Get_List_Aprobacion_Orden_Pago_Det(IdEmpresa, Estado, param.IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_AprobacionOrdenPago", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Orden_Pago_Bus) };
            }
        }

        public Boolean GuardarDB(List<cp_Aprobacion_Orden_Pago_Det_Info> Lst, ref decimal Id, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Lst, ref Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_AprobacionOrdenPago", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Orden_Pago_Bus) };
            }
        }

    }
}
