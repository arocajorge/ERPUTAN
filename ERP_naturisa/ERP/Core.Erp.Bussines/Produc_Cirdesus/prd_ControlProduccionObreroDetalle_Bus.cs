using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ControlProduccionObreroDetalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ControlProduccionObreroDetalle_Data data = new prd_ControlProduccionObreroDetalle_Data();
        public List<prd_ControlProduccionObreroDetalle_Info> ObtenerCtrlPrdDetalle(decimal IdControlProduccion, int idempresa, int IdSucursal)
        {
            try
            {
                return data.ObtenerCtrlPrdDetalle(IdControlProduccion, idempresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCtrlPrdDetalle", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObreroDetalle_Bus) };
                
            }
        }

        public Boolean grabarDB(List<prd_ControlProduccionObreroDetalle_Info> lmDetalleInfo, int idempresa, decimal IdCtrlPrdObrero, ref string msg)
        {
            try
            {
                return data.grabarDB(lmDetalleInfo, idempresa, IdCtrlPrdObrero, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "grabarDB", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObreroDetalle_Bus) };
                
            }
        }

        public Boolean eliminarregistrotabla(List<prd_ControlProduccionObreroDetalle_Info> lmDetalleInfo, int idempresa, decimal IdCtrlPrdObrero, ref string msg)
        {
            try
            {
                return data.eliminarregistrotabla(lmDetalleInfo, idempresa, IdCtrlPrdObrero, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObreroDetalle_Bus) };
                
            }
        }
        public List<prd_ControlProduccionObreroDetalle_Info> ObtenerCtrlPrdDetallexFecha(decimal   IdControlProduccion, int idempresa, int IdSucursal, DateTime IdFecha)
        {
            try
            {
                return data.ObtenerCtrlPrdDetallexFecha(IdControlProduccion, idempresa, IdSucursal, IdFecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCtrlPrdDetallexFecha", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObreroDetalle_Bus) };
                
            }
        }
    }
}