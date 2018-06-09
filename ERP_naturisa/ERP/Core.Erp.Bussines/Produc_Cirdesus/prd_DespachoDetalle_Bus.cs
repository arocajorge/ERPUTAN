using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_DespachoDetalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_DespachoDetalle_Data data = new prd_DespachoDetalle_Data();

        public List<prd_DespachoDetalle_Info> ObtenerDespachoDetalle(decimal IdDespacho, int idempresa, int IdSucursal)
        {
            try
            {
                return data.ObtenerDespachoDetalle(IdDespacho, idempresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDespachoDetalle", ex.Message), ex) { EntityType = typeof(prd_DespachoDetalle_Bus) };
                
            }

        }
        public List<prd_DespachoDetalle_Info> ObtenerDespachoDetalle_para_GuiaRemision(decimal IdDespacho, int idempresa, int IdSucursal)
        {
            try
            {
                return data.ObtenerDespachoDetalle_para_GuiaRemision(IdDespacho, idempresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDespachoDetalle", ex.Message), ex) { EntityType = typeof(prd_DespachoDetalle_Bus) };

            }

        }
        public Boolean grabarDB(List<prd_DespachoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdDespacho, ref string msg)
        {
            try
            {
                return data.grabarDB(lmDetalleInfo, idempresa, IdDespacho, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "lmDetalleInfo", ex.Message), ex) { EntityType = typeof(prd_DespachoDetalle_Bus) };
                
            }
        }

        public Boolean eliminarregistrotabla(List<prd_DespachoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdDespacho, ref string msg)
        {
            try
            {
                return data.eliminarregistrotabla(lmDetalleInfo, idempresa, IdDespacho, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(prd_DespachoDetalle_Bus) };
                
            }
        }
    }
}
