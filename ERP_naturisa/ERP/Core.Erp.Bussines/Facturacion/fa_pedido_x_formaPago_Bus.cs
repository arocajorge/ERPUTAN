using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
   public class fa_pedido_x_formaPago_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
       fa_pedido_x_formaPago_Data odata = new fa_pedido_x_formaPago_Data();

       public Boolean GuardarDB(List<fa_pedido_x_formaPago_Info> Lista, ref string mensajeE)
       {

           try
           {
               return odata.GuardarDB(Lista, ref mensajeE);
           }
           catch (Exception ex)
           {


               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_FormaPagoPedido", ex.Message), ex) { EntityType = typeof(fa_pedido_x_formaPago_Bus) };
            
           }


       }


       public List<fa_pedido_x_formaPago_Info> Get_List_pedido_x_formaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido)
       {

           try
           {
               return odata.Get_List_pedido_x_formaPago(IdEmpresa, IdSucursal,  IdBodega, IdPedido);

           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaLista_PedidoFormaPago", ex.Message), ex) { EntityType = typeof(fa_pedido_x_formaPago_Bus) };
           }
       }
    }
}
