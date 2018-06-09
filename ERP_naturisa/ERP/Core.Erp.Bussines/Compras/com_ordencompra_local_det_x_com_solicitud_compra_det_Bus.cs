using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
  public  class com_ordencompra_local_det_x_com_solicitud_compra_det_Bus
  {
        #region Declaración de variables
      string mensaje = "";
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      com_ordencompra_local_det_x_com_solicitud_compra_det_Data odata = new com_ordencompra_local_det_x_com_solicitud_compra_det_Data();

      #endregion
      
        public Boolean GrabarDB(List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> lista, ref string mensaje)
        {

            try
            {
                return odata.GrabarDB(lista, ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
        {

            try
            {
                return odata.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(IdEmpresa, IdSucursal, IdSolicitudCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
              
            }
        }


        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_OrdenCompra(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {

            try
            {
                return odata.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_OrdenCompra(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
              
            }
        }

        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> ConsultaDetalleSolicitud_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
        {
            try
            {
                return odata.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(IdEmpresa, IdSucursal, IdSolicitudCompra);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(List<com_solicitud_compra_det_aprobacion_Info> lista)
        {

            try
            {
                return odata.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(lista);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
            }
        
        }

        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_ordencompra_local_det_x_com_solicitud_compra_det(IdEmpresa);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_x_com_solicitud_compra_det", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia_SC)
        {
            try
            {
                return odata.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(IdEmpresa, IdSucursal, IdSolicitudCompra, Secuencia_SC);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
            }
        }

        public Boolean Eliminar_Detalle_OCDxSCD(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, ref string msg)
        {

            try
            {
                return odata.Eliminar_Detalle_OCDxSCD(IdEmpresa, IdSucursal, IdOrdenCompra, ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_Detalle_OCDxSCD", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_x_com_solicitud_compra_det_Bus) };
            }
        }

    }
}
