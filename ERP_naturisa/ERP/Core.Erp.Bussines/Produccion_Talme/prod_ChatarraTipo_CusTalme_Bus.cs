using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_ChatarraTipo_CusTalme_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_ChatarraTipo_CusTalme_Data Data = new prod_ChatarraTipo_CusTalme_Data();

        public List<prod_ChatarraTipo_CusTalme_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                  return Data.Get_List_ChatarraTipo_CusTalme(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prod_ChatarraTipo_CusTalme_Bus) };

            }

        }

        public Boolean GrabarDB(prod_ChatarraTipo_CusTalme_Info prI, ref int Id, ref string mensaje)
        {
            try
            {
                return Data.GrabarDB(prI, ref Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(prod_ChatarraTipo_CusTalme_Bus) };

            }
        }

        public Boolean ModificarDB(prod_ChatarraTipo_CusTalme_Info prI, ref string mensaje)
        {
            try
            {
                return Data.ModificarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prod_ChatarraTipo_CusTalme_Bus) };

            }
        }

        public Boolean Anular(prod_ChatarraTipo_CusTalme_Info info)
        {
            try
            {
                return Data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(prod_ChatarraTipo_CusTalme_Bus) };

            }
        }


    }
}
