using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario_Cidersus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
namespace Core.Erp.Business.Inventario_Cidersus
{
    public class in_movi_inven_x_in_movi_inven_CusCidersus_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_movi_inven_x_in_movi_inven_CusCidersus_Data Data = new in_movi_inven_x_in_movi_inven_CusCidersus_Data();

        public Boolean GuardarTIMovim_EgresoConsumo(in_movi_inve_detalle_x_Producto_CusCider_Info Info)
        {
            try
            {
                return Data.GuardarTIMovim_EgresoConsumo(Info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarTIMovim_EgresoConsumo", ex.Message), ex) { EntityType = typeof(in_movi_inven_x_in_movi_inven_CusCidersus_Bus) };
                
            }
        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaTIMovim_EgresoConsumo(in_movi_inve_Info MovimientoPrinc)
        {
            try
            {
                return Data.ConsultaTIMovim_EgresoConsumo(MovimientoPrinc);

            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaTIMovim_EgresoConsumo", ex.Message), ex) { EntityType = typeof(in_movi_inven_x_in_movi_inven_CusCidersus_Bus) };
                
            }
        }

    }
}
