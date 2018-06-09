using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
  public  class in_movi_inve_detalle_x_ct_cbtecble_det_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inve_detalle_x_ct_cbtecble_det_Data Data = new in_movi_inve_detalle_x_ct_cbtecble_det_Data();


        public List<in_movi_inve_detalle_x_ct_cbtecble_det_Info> Get_List_Info_x_Movi_Inven(int IdEmpresa, int idsucursal, int idbodega, int idmovi_inven_tipo, decimal idNum_Movi)
        {
            try
            {
                return Data.Get_List_Info_x_Movi_Inven(IdEmpresa, idsucursal, idbodega, idmovi_inven_tipo, idNum_Movi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_x_Movi_Inven", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_ct_cbtecble_det_Bus) };
            }

        }


        public Boolean GuardarDB(in_movi_inve_detalle_x_ct_cbtecble_det_Info Info)
        {
            try
            {
                return Data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_x_Movi_Inven", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_ct_cbtecble_det_Bus) };
            }

        }

    }
}
