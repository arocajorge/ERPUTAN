using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_GestionProductivaLaminado_CusTalme_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_GestionProductivaLaminado_CusTalme_Data oData = new prod_GestionProductivaLaminado_CusTalme_Data();

        public Boolean GuardarDB(prod_GestionProductivaLaminado_CusTalme_Info Info, ref decimal Id, ref string msj)
        {
            try
            {
              return oData.GuardarDB(Info, ref Id, ref msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaLaminado_CusTalme_Bus) };

            }

        }
        public List<prod_GestionProductivaLaminado_CusTalme_Info> ConulstaGenerla(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List_GestionProductivaLaminado_CusTalm(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConulstaGenerla", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaLaminado_CusTalme_Bus) };

            }

        }

        public Boolean Anular(int IdEmpresa, decimal Id)
        {
            try
            {
              return oData.AnularDB(IdEmpresa, Id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaLaminado_CusTalme_Bus) };

            }
        }


        public Boolean ModificarDB(prod_GestionProductivaLaminado_CusTalme_Info Info)
        {
            try
            {
                    return oData.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaLaminado_CusTalme_Bus) };

            }

        }


        public void EjecutarSpReporte(int IdEmpresa, decimal IdGestion, string IdUsuario, string nom_Pc)
        {
            try
            {
                 oData.EjecutarSpReporte(IdEmpresa, IdGestion, IdUsuario, nom_Pc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EjecutarSpReporte", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaLaminado_CusTalme_Bus) };

            }

        }
    }
}
