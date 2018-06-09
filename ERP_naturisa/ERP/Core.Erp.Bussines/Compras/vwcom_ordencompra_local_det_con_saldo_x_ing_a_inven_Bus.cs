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
  public  class vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Bus
    {

        vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data odata = new vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<in_movi_inve_detalle_Info> Get_List_movi_inve_detalle(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return odata.Get_List_movi_inve_detalle(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Bus) };

            }

        }
    }
}
