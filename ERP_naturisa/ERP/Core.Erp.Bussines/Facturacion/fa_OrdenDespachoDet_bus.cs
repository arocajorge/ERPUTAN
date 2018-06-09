using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Facturacion
{
    
    public class fa_OrdenDespachoDet_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_orden_Desp_det_Data odata = new fa_orden_Desp_det_Data();

        public List<fa_orden_Desp_det_Info> Get_List_orden_Desp_det(fa_orden_Desp_Info Info)
        {
            try
            {
                  return odata.Get_List_orden_Desp_det(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxOrdDespacho", ex.Message), ex) { EntityType = typeof(fa_OrdenDespachoDet_bus) };
            }

       }

        public List<fa_orden_Desp_det_Info> Get_List_orden_Desp_x_Pedido(fa_pedido_Info Info)
        {
            try
            {
                return odata.Get_List_orden_Desp_x_Pedido(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxOrdDespachoxPedido", ex.Message), ex) { EntityType = typeof(fa_OrdenDespachoDet_bus) };
            
            }

        }

    }
}
