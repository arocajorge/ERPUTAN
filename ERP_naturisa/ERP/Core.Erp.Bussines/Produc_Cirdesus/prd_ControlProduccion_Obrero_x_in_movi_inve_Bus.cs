using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ControlProduccion_Obrero_x_in_movi_inve_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ControlProduccion_Obrero_x_in_movi_inve_Data data = new prd_ControlProduccion_Obrero_x_in_movi_inve_Data();
        public Boolean GuardarDB(prd_ControlProduccion_Obrero_x_in_movi_inve_Info Info)
        {
            try
            {
               return data.GuardarDB(Info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_ControlProduccion_Obrero_x_in_movi_inve_Bus) };
                
            }
        }
        public List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info> ConsultaGeneral(int IdEmpresa, Decimal IdControlProduccion, int IdSucursal)
        {
            try
            {
               return data.Get_List_ControlProduccion_x_Obrero_x_in_movi_inven(IdEmpresa, IdControlProduccion, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_ControlProduccion_Obrero_x_in_movi_inve_Bus) };
                
            }

        }
    }
}
