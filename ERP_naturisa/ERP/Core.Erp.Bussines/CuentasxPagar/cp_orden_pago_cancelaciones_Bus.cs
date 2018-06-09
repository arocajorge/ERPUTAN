using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_pago_cancelaciones_Bus
    {
        string mensaje = "";

        cp_orden_pago_cancelaciones_Data oData = new cp_orden_pago_cancelaciones_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        
        public Boolean GuardarDB(List<cp_orden_pago_cancelaciones_Info> Lst, int Id, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Lst, Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_OrdenPagoCancelacion", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }


        public Boolean GuardarDB(cp_orden_pago_cancelaciones_Info Info, int Id, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_OrdenPagoCancelacion", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }

        public Boolean ModificarDB(List<cp_orden_pago_cancelaciones_Info> info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }
        
        public List<cp_orden_pago_cancelaciones_Info> ConsultaGeneralOPCxIdCancelaciones(int IdEmpresa, decimal IdCancelacion, ref string mensaje)
        {
            try
            {
                return oData.Get_List_OPCxIdCancelaciones(IdEmpresa, IdCancelacion, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralOPCxIdCancelaciones", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }

        }

        public List<cp_orden_pago_cancelaciones_Info> ConsultaGeneralOPCxOP(int IdEmpresa, decimal IdOrdenPago,  ref string mensaje)
        {

            try
            {
                return oData.Get_List_OPCxOP(IdEmpresa, IdOrdenPago, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralOPCxOP", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        
        }

        public List<cp_orden_pago_cancelaciones_Info> ConsultaGeneral_Cancelacion_x_Pagos(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {

            try
            {
                return oData.Get_list_Cancelacion_x_Pagos(IdEmpresa_pago, IdTipoCbte_pago, IdCbteCble_pago, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral_Cancelacion_x_Pagos", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        
        }

        public List<cp_orden_pago_cancelaciones_Info> Get_List_OP_x_CbteCtble(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {
            try
            {
                return oData.Get_List_OP_x_CbteCtble(IdEmpresa_pago, IdTipoCbte_pago, IdCbteCble_pago, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral_Cancelacion_x_Pagos", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }

        public List<cp_orden_pago_cancelaciones_Info> ConsultaGeneral_Cancelacion_x_Pagos_Anticipos(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {

            try
            {
                return oData.Get_List_Cancelacion_x_Pagos_Anticipos(IdEmpresa_pago, IdTipoCbte_pago, IdCbteCble_pago, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral_Cancelacion_x_Pagos_Anticipos", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }

        }
      
        public Boolean Eliminar_OrdenPagoCancelaciones(cp_orden_pago_cancelaciones_Info Info, ref string mensaje)
        {
            try
            {
                return oData.Eliminar_OrdenPagoCancelaciones(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_OrdenPagoCancelaciones", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }

        public Boolean Eliminar_OrdenPagoCancelaciones_List(List<cp_orden_pago_cancelaciones_Info> Lst, int Id, ref string mensaje)
        {
            try
            {
                return oData.Eliminar_OrdenPagoCancelaciones_List(Lst, Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_OrdenPagoCancelaciones_List", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }

        public Boolean Eliminar_OrdenPagoCancelaciones(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {
            try
            {
                return oData.Eliminar_OrdenPagoCancelaciones(IdEmpresa_pago, IdTipoCbte_pago, IdCbteCble_pago, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_OrdenPagoCancelaciones", ex.Message), ex) { EntityType = typeof(cp_orden_pago_cancelaciones_Bus) };
            }
        }

    }
}
