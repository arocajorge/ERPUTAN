using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_GestionProductivaTechos_CusTalme_Detalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_GestionProductivaTechos_CusTalme_Detalle_Data data = new prod_GestionProductivaTechos_CusTalme_Detalle_Data();

        public List<prod_GestionProductivaTechos_CusTalme_Detalle_Info> ConsultaGeneral(int Idempresa, decimal Idgestion)
        {
            try
            {
               return data.Get_List_GestionProductivaTechos_CusTalme_Detall(Idempresa,Idgestion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_Detalle_Bus) };

            }

        }
    }
}
