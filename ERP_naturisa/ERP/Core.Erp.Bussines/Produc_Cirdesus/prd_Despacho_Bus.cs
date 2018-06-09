using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_Despacho_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Despacho_Data data = new prd_Despacho_Data();

        public List<prd_Despacho_Info> ObtenerDespachoCab(int idempresa)
        {
            try
            {
                return data.ObtenerDespachoCab(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDespachoCab", ex.Message), ex) { EntityType = typeof(prd_Despacho_Bus) };
                
            }
        }

        public Boolean GrabarCabeceraDB(prd_Despacho_Info info, List<prd_DespachoDetalle_Info> lmDetalleInfo, ref string msg, ref decimal idgenerada)
        {
            try
            {
                return data.GrabarCabeceraDB(info, lmDetalleInfo, ref msg, ref idgenerada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarCabeceraDB", ex.Message), ex) { EntityType = typeof(prd_Despacho_Bus) };
                
            }
        }

        public Boolean ModificarDB(prd_Despacho_Info info, ref string msg)
        {
            try
            {
                return data.ModificaDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_Despacho_Bus) };
                
            }
        }

        public Boolean AnularReactiva(prd_Despacho_Info info, ref string msg)
        {
            try
            {

                return data.AnularReactiva(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularReactiva", ex.Message), ex) { EntityType = typeof(prd_Despacho_Bus) };
                
            }
        }

    }
}
