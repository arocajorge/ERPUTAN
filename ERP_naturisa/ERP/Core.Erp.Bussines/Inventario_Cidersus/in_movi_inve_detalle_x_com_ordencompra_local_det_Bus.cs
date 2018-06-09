using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario_Cidersus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario_Cidersus
{
    public class in_movi_inve_detalle_x_com_ordencompra_local_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_movi_inve_detalle_x_com_ordencompra_local_det_Data Data = new in_movi_inve_detalle_x_com_ordencompra_local_det_Data();

        public Boolean GuardarDB(List<in_movi_inve_detalle_Info> Lst)
        {
            try
            {
                return Data.GuardarDB(Lst);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_com_ordencompra_local_det_Bus) };
            
            }
        
        
        }

        public in_movi_inve_detalle_x_com_ordencompra_local_det_Info Get_Info_in_movi_inve_detalle_x_com_ordencompra_local_det(in_movi_inve_detalle_Info MovInv)
        {
            try
            {
                return Data.Get_Info_in_movi_inve_detalle_x_com_ordencompra_local_det(MovInv );

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_com_ordencompra_local_det_Bus) };
            
            }
        }

    }
}
