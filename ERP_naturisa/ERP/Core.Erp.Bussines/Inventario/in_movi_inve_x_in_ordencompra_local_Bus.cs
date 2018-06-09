using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_movi_inve_x_in_ordencompra_local_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inve_x_in_ordencompra_local_Data data = new in_movi_inve_x_in_ordencompra_local_Data();

        public Boolean GrabarDB(in_movi_inve_Info prI, ref string mensaje)
        {
            try
            {
                return data.GrabarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_x_in_ordencompra_local_Bus) };

            }
        }

        public Boolean GrabarDB(List<in_movi_inve_Info> lmcabmovin, ref string mensaje)
        {
            try
            {
                return data.GrabarDB(lmcabmovin, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarLoteDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_x_in_ordencompra_local_Bus) };

            }
        }
    }
}
