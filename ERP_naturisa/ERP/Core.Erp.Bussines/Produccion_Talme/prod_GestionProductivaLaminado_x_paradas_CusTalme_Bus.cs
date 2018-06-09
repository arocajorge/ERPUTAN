using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_GestionProductivaLaminado_x_paradas_CusTalme_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        prod_GestionProductivaLaminado_x_paradas_CusTalme_Data oData = new prod_GestionProductivaLaminado_x_paradas_CusTalme_Data();

        public List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info> Get_List_GestionProductivaLaminado_x_paradas_CusTalme(int IdEmpresa, Decimal IdGestion)
        {
            try
            {
               return oData.Get_List_GestionProductivaLaminado_x_paradas_CusTalme(IdEmpresa, IdGestion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaLaminado_x_paradas_CusTalme_Bus) };

            }

        }
    }
}
