using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_cotizacion_compra_det_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_cotizacion_compra_det_Data data = new com_cotizacion_compra_det_Data();

        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, int IdSucursal, string IdCategoria)
        {
            try
            {
                return data.Get_list_Cotizacion_detalle(IdEmpresa, IdSucursal, IdCategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cotizacion_detalle", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public Boolean eliminarDetalle_CotizaComp(int idempresa, decimal IdCotizacion, ref string msg)
        {
            try
            {
                 return data.EliminarDB(idempresa,  IdCotizacion, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDetalle_CotizaComp", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        
        }

        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, decimal IdCotizacion, int IdSucursal)
        {
            try
            {
                return data.Get_list_Cotizacion_detalle(IdEmpresa, IdSucursal, IdCotizacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }

        }

      
        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, ref string msg)
        {
            try
            {
                return data.Get_list_Cotizacion_detalle(IdEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cotizacion_detalle", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public Boolean GuardarDB(List<com_cotizacion_compra_det_Info> lista, ref string msg)
        {
            try
            {
                return data.GuardarDB(lista, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public Boolean ModificarDB(com_cotizacion_compra_det_Info info, ref string msg)
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarExisteCodigo", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return data.Get_list_Cotizacion_detalle(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cotizacion_detalle", ex.Message), ex) { EntityType = typeof(com_cotizacion_compra_Bus) };
            }
        }

    }
}
