using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_TerminoPago_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_TerminoPago_Data data = new com_TerminoPago_Data();

        public List<com_TerminoPago_Info> Get_List_TerminoPago()
        {
            try
            {
                return data.Get_List_TerminoPago();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_pre_aprobacion_Bus) };
            }

        }

        public Boolean GuardarDB(com_TerminoPago_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_pre_aprobacion_Bus) };
            }
        }

        public bool ModificarDB(com_TerminoPago_Info info)
        {
            try
            {
                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_pre_aprobacion_Bus) };
            }
        }

        public Boolean AnularDB(com_TerminoPago_Info Info)
        {
            try
            {
                return data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_pre_aprobacion_Bus) };
            }
        }
    
    }
}
