using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_GeneracionOCompra_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
            
        com_GeneracionOCompra_Data Data = new com_GeneracionOCompra_Data();

        public Boolean AnularDB(com_GeneracionOCompra_Info Info, ref string msg)
        {
            try
            {
                return Data.AnularDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_GeneracionOCompra_Bus) };
            }
        }

        public Boolean GrabarDB(com_GeneracionOCompra_Info info, ref decimal id, ref string msg)
        {
            try
            {
                return Data.GrabarDB(info, ref id,ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_GeneracionOCompra_Bus) };
            }
        }

        public Boolean ModificarDB(com_GeneracionOCompra_Info info, ref string msg)
        {
            try
            {
                return Data.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_GeneracionOCompra_Bus) };
            }
        }

        public List<com_GeneracionOCompra_Info> Get_List_GeneracionOCompra(int idempresa)
        {
            try
            {
                return Data.Get_List_GeneracionOCompra(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_GeneracionOCompra", ex.Message), ex) { EntityType = typeof(com_GeneracionOCompra_Bus) };
            }
        }

        public com_GeneracionOCompra_Info Get_Info_GeneracionOCompra(int IdEmpresa, int IdTransaccion)
        {
            try
            {
                return Data.Get_Info_GeneracionOCompra(IdEmpresa, IdTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_GeneracionOCompra", ex.Message), ex) { EntityType = typeof(com_GeneracionOCompra_Bus) };
            }
        }

        public int getId(int IdEmpresa)
        {
            try
            {
                return Data.GetId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_GeneracionOCompra_Bus) };
            }

        }
    }
}
