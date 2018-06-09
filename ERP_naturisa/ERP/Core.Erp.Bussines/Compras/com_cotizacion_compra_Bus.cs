using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_cotizacion_compra_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_cotizacion_compra_Data data = new com_cotizacion_compra_Data();

        public List<com_cotizacion_compra_Info> Get_List_cotizacion_compra(int IdEmpresa)
        {
            try
            {
                return data.Get_List_cotizacion_compra(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cotizacion_compra", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }

        }

        public com_cotizacion_compra_Info Get_Info_cotizacion_compra(int IdEmpresa, string CodObra)
        {
            try
            {
                return data.Get_Info_cotizacion_compra(IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_cotizacion_compra", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public List<com_cotizacion_compra_Info> Get_List_cotizacion_compra(int IdEmpresa, ref string msg)
        {
            try
            {
                return data.Get_List_cotizacion_compra(IdEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cotizacion_compra", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public Boolean GuardarDB(com_cotizacion_compra_Info info, ref string msg)
        {
            try
            {
                return data.GuardarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }
        public Boolean ModificarDB(com_cotizacion_compra_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }
        public Boolean VerificarExisteCodigo(string CodCotiza)
        {
            try
            {
                return data.VerificarExisteCodigo(CodCotiza);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }
        public decimal getId(int IdEmpresa)
        {
            try
            {
                return data.GetId(IdEmpresa);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public bool AnularDB(com_cotizacion_compra_Info Info)
        {
            try
            {
                return data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }
    }
}
