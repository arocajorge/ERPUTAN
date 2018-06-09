using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Business.Bancos
{
    public class ba_Conciliacion_det_IngEgr_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ba_Conciliacion_det_IngEgr_Data data = new ba_Conciliacion_det_IngEgr_Data();

        public List<ba_Conciliacion_det_IngEgr_Info> Get_List_Conciliacion_det_IngEgr(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Conciliacion_det_IngEgr(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_det_IngEgr", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public List<ct_Cbtecble_det_Info> Get_List_Conciliacion_det_IngEgr(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return data.Get_List_Conciliacion_det_IngEgr(IdEmpresa,IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_det_IngEgr", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public List<vwba_TransaccionesAConciliar_Info> Get_List_ConciIngEgr(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return data.Get_List_ConciIngEgr(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ConciIngEgr", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public Boolean GrabarDB(vwba_TransaccionesAConciliar_Info info)
        {
            try
            {
                return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public Boolean ModificarDB(ba_Conciliacion_det_IngEgr_Info info)
        {
            try
            {
                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public Boolean Anular(ba_Conciliacion_det_IngEgr_Info info)
        {
            try
            {
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return data.EliminarDB(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }
        /// <summary>
        /// Retorna true si el cbte esta en la conciliacion
        /// </summary>
        public Boolean Cbte_existe_en_conciliacion(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return data.Cbte_existe_en_conciliacion(IdEmpresa, IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cbte_existe_en_conciliacion", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }
        /// <summary>
        /// Retorna true si el cbte esta en la conciliacion
        /// </summary>
        public Boolean Cbte_existe_en_conciliacion(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, int Secuencia)
        {
            try
            {
                return data.Cbte_existe_en_conciliacion(IdEmpresa, IdTipoCbte, IdCbteCble, Secuencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cbte_existe_en_conciliacion", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_IngEgr_Bus) };
            }
        }

        public ba_Conciliacion_det_IngEgr_Bus()
        {
          
        }
    }
}
