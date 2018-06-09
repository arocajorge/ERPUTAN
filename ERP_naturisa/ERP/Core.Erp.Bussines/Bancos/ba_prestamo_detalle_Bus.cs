using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_prestamo_detalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_prestamo_detalle_Data oData = new ba_prestamo_detalle_Data();

        public Boolean GuardarPrestamoDetalle(List<ba_prestamo_detalle_Info> Lst)
        {
            try
            {
                    return oData.GuardarPrestamoDetalle(Lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarPrestamoDetalle", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }
        }

        public List<ba_prestamo_detalle_Info> Get_List_prestamo_detalle(int IdEmpresa, decimal IdPrestamo)
        {
            try
            {
                return oData.Get_List_prestamo_detalle(IdEmpresa, IdPrestamo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_prestamo_detalle", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }

        }

        public Boolean CancelarEstadoDetallePrestamo(ba_prestamo_detalle_Info info, ref string msg)
        {
            try
            {
                 return oData.CancelarEstadoDetallePrestamo(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CancelarEstadoDetallePrestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }

        }

        public Boolean ModificarDetallePrestamo(ba_prestamo_detalle_Info prI, ref string msg)
        {
            try
            {

                return oData.ModificarDetallePrestamo(prI, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDetallePrestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }
        }

        public Boolean AnularDetallePrestamo(List<ba_prestamo_detalle_Info> prI, ref string msg)
        {
            try
            {
                return oData.AnularDetallePrestamo(prI, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDetallePrestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }
        }

        public Boolean AnularDetallePrestamo(ba_prestamo_detalle_Info _Info)
        {
            try
            {
                return oData.AnularDetallePrestamo(_Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDetallePrestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }

        }
       
        public Boolean ReversaEstadoCanc(ba_prestamo_detalle_Info info, ref string msg)
        {
            try
            {
                    return oData.ReversaEstadoCanc(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ReversaEstadoCanc", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }

        }

        public List<ba_prestamo_detalle_Info> Get_List_EstadoCuenta(ba_prestamo_Info Item, ref string msg)
        {
            try
            {
                return oData.Get_List_EstadoCuenta(Item, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_EstadoCuenta", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }

        }

        public List<ba_prestamo_detalle_Info> Get_List_DetallePrestamosxCancelar(ba_prestamo_Info Item, ref string msg)
        {
            try
            {
                return oData.Get_List_DetallePrestamosxCancelar(Item, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_DetallePrestamosxCancelar", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }

        }
        public bool Eliminar(int idempresa, int idprestamo)
        {
            try
            {
                return oData.Eliminar(idempresa,idprestamo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_Bus) };
            }
        }
        public ba_prestamo_detalle_Bus()
        {

        }
    }
}
