using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        prod_CompraChatarra_CusTalme_x__in_movi_inven_Data Data = new prod_CompraChatarra_CusTalme_x__in_movi_inven_Data();

        public Boolean GuardarDB(prod_CompraChatarra_CusTalme_x__in_movi_inven_Info Info)
        {
            try
            {
               return Data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus) };

            }

        }


        public prod_CompraChatarra_CusTalme_x__in_movi_inven_Info ObtenerObjeto(int IdEmpresa, decimal IdLiquidacion)
        {
            try
            {
                 return Data.Get_Info_CompraChatarra_CusTalme_x__in_movi_inve(IdEmpresa, IdLiquidacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus) };

            }

        }


    }
}
