using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_pedido_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_pedido_det_Data data = new fa_pedido_det_Data();

        public List<fa_pedido_det_Info> Get_List_pedido_det(int idempresa, int idsucursal, int idbodega, decimal idpedido)
        {
            try
            {
              
                return data.Get_List_pedido_det(idempresa,idsucursal,idbodega,idpedido);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle", ex.Message), ex) { EntityType = typeof(fa_pedido_det_Bus) };
            
            }
        }

        public int GetIdPedido(int idempresa, int idsucursal, int idbodega, decimal idpedido)
        {
            try
            {
                return data.GetIdPedido(idempresa,  idsucursal,  idbodega, idpedido);
            }
            catch (Exception ex)
            {


                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getIdPedido_Secuencial", ex.Message), ex) { EntityType = typeof(fa_pedido_det_Bus) };
            }

        }


        public List<fa_pedido_det_Info> Get_List_pedido_det_x_Producto(int idempresa, int idsucursal, int idbodega, decimal idpedido, decimal IdProducto)
        {
            try
            {
                return data.Get_List_pedido_det_x_Producto(idempresa,idsucursal,idbodega,idpedido,IdProducto);
            }
            catch (Exception ex)
            {


                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle_x_Producto", ex.Message), ex) { EntityType = typeof(fa_pedido_det_Bus) };
            }
        }
   
        public Boolean GrabarListaDetalle(List<fa_pedido_det_Info> ListaDetalleNuevo, List<fa_pedido_det_Info> ListaDetalleAnterior, ref string msg)
        {
            try
            {
                //foreach (var item in ListaDetalleAnterior)
                //{
                //    fa_pedido_det_Data data = new fa_pedido_det_Data();
                //    data.EliminarItems(item, ref msg);
                //}
                //foreach (var item in ListaDetalleNuevo)
                //{
                //    fa_pedido_det_Data data = new fa_pedido_det_Data();
                //    data.GrabarItems(item, ref msg);
                //}
                return true;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarListaDetalle", ex.Message), ex) { EntityType = typeof(fa_pedido_det_Bus) };
            }
        }

        public Boolean EliminarDB(fa_pedido_det_Info info, ref  string msg)
        {
            try
            {
                return data.EliminarDB(info, ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarItems", ex.Message), ex) { EntityType = typeof(fa_pedido_det_Bus) };
            }

        
        }

        public Boolean VerificarOrdenDespacho(fa_pedido_Info info)
        {
            try
            {
                return data.VerificarOrdenDespacho(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarOrdenDespacho", ex.Message), ex) { EntityType = typeof(fa_pedido_det_Bus) };
            }

        }

       
        public fa_pedido_det_Bus() { }
    }
}
