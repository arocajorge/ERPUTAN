using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_orden_Desp_det_x_fa_pedido_det_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        

        fa_orden_Desp_det_x_fa_pedido_det_Data odata = new fa_orden_Desp_det_x_fa_pedido_det_Data();

        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> Get_List_fa_orden_Desp_det_x_fa_pedido_det(fa_orden_Desp_Info info)
        {
            try
            {
               return odata.Get_List_fa_orden_Desp_det_x_fa_pedido_det(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_det_x_fa_pedido_det_Bus) };
            }
        }

        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Producto(fa_orden_Desp_Info info)
        {
            try
            {
                 return odata.Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Producto(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDespachoPedidoxProducto", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_det_x_fa_pedido_det_Bus) };
            }
        }

        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Pedido(fa_orden_Desp_Info info)
        {
            try
            {
                return odata.Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Pedido(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDespachoPedidoxPedido", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_det_x_fa_pedido_det_Bus) };
            }

        }
    }
}
