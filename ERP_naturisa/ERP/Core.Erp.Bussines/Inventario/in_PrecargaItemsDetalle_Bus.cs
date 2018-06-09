using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_PrecargaItemsDetalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_PrecargaItemsDetalle_Data data = new in_PrecargaItemsDetalle_Data();

        public List<in_PrecargaItemsDetalle_Info> ObtenerOCDetalle(int IdPrecarga, int idempresa)
        {
            try
            {
                return data.Get_List_PrecargaItemsDetalle(IdPrecarga, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerOCDetalle", ex.Message), ex) { EntityType = typeof(in_PrecargaItemsDetalle_Bus) };

            }
        }

        public List<in_PrecargaItemsDetalle_Info> ObtenerTodas_Precarga_CAB_DET(int idempresa, int idsucursal)
        {
            try
            {
                return data.Get_List_PrecargaItemsDetalle_x_sucursal(idempresa, idsucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTodas_Precarga_CAB_DET", ex.Message), ex) { EntityType = typeof(in_PrecargaItemsDetalle_Bus) };

            }
        }

        public Boolean grabarDB(List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, int idempresa, int IdPrecarga, ref string msg)
        {
            try
            {
                return data.GrabarDB(lmDetalleInfo, idempresa, IdPrecarga, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "grabarDB", ex.Message), ex) { EntityType = typeof(in_PrecargaItemsDetalle_Bus) };

            }
        }

        public Boolean eliminarregistrotabla(List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, int idempresa, int IdPrecarga, ref string msg)
        {
            try
            {
                return data.EliminarDB(lmDetalleInfo, idempresa, IdPrecarga, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(in_PrecargaItemsDetalle_Bus) };

            }
        }

        public Boolean CambiaEstadoProcesado(List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, int idempresa)
        {
            try
            {
                return data.CambiaEstadoProcesado(lmDetalleInfo, idempresa);
            }
            catch (Exception ex)
            {
               
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CambiaEstadoProcesado", ex.Message), ex) { EntityType = typeof(in_PrecargaItemsDetalle_Bus) };

            }
        }
    }
}