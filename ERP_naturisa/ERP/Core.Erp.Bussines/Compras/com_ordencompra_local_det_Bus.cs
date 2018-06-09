using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.Compras
{
    public class com_ordencompra_local_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_ordencompra_local_det_Data data = new com_ordencompra_local_det_Data();

        string mensaje = "";


        public Boolean GuardarDB(List<com_ordencompra_local_det_Info> LstInfo,ref string msg)
        {
            try
            {
                return data.GuardarDB(LstInfo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }

        }

        public int GetSecuencia_x_OC(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {

                return data.GetSecuencia_x_OC(IdEmpresa, IdSucursal, IdOrdenCompra);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetSecuencia_x_OC", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
                
            }
        }

        public Boolean EliminarDetalle_OC(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, ref string msg)
        {
            try
            {
                  return data.EliminarDetalle_OC(IdEmpresa,IdSucursal,IdOrdenCompra ,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDetalle_OC", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        }

        public Boolean Eliminarregistrotabla(List<com_ordencompra_local_det_Info> lmDetalleInfo, ref string msg)
        {
            try
            {
                return data.Eliminarregistrotabla(lmDetalleInfo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        }

        public com_ordencompra_local_det_Info Get_Info_ordencompra_local_det(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int Secuencia)
          {

              try
              {
                  return data.Get_Info_ordencompra_local_det(IdEmpresa, IdSucursal, IdOrdenCompra, Secuencia);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ordencompra_local_det", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
              }
          }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
          {
              try
              {
                  return data.Get_List_ordencompra_local_det(IdEmpresa, IdSucursal, IdOrdenCompra);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
              }
          }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det(int IdEmpresa)
        {
            try
            {
                return data.Get_List_ordencompra_local_det(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det_Agrupado(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return data.Get_List_ordencompra_local_det_Agrupado(IdEmpresa,  IdSucursal,  IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_Agrupado", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        
        
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det_x_Proveedor(int IdEmpresa, int IdSucursal, decimal IdProveedor)
          {
              try
              {
                  return data.Get_List_ordencompra_local_det_x_Proveedor(IdEmpresa, IdSucursal, IdProveedor);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_x_Proveedor", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
              }
          }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det_x_Saldos_x_Proveedor(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
            try
            {
                return data.Get_List_ordencompra_local_det_x_Saldos_x_Proveedor(IdEmpresa, IdSucursal, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_x_Saldos_x_Proveedor", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_OC_local_det_x_Saldos_x_Proveedor_x_Obra_x_OT(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
            try
            {
                return data.Get_List_OC_local_det_x_Saldos_x_Proveedor_x_Obra_x_OT(IdEmpresa, IdSucursal, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_det_x_Saldos_x_Proveedor", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        }


        public List<in_movi_inve_detalle_Info> Get_List_movi_inve_detalle(int IdEmpresa, decimal IdProveedor)
          {
              try
              {
                  return data.Get_List_movi_inve_detalle(IdEmpresa, IdProveedor);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_movi_inve_detalle", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };

              }

          }


        public Boolean ModificarDB(List<com_ordencompra_local_det_Info> ListInfo, ref  string msg)
        {
            try
            {
                return data.ModificarDB(ListInfo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_det_Bus) };
            }
        }
    }
}
