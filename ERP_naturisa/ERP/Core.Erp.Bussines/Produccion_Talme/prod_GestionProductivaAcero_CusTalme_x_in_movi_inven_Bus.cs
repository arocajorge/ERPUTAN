using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Data Data = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Data();


        public Boolean GuardarDB(prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info Info)
        {
            try
            {
                return Data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus) };

            }

        }

        public List<prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info> ConsultaGenera(int IdEmpresa, int IdSucursal, Decimal IdgestionAceria)
        {
            try
            {
               return Data.Get_List_GestionProductivaAcero_CusTalme_x_in_movi_inve(IdEmpresa, IdSucursal, IdgestionAceria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGenera", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus) };

            }

        }
    }
}
