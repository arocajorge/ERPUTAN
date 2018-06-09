using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;
//9-5-2013
namespace Core.Erp.Business.Bancos
{
    public class ba_IngrEgre_x_Cbte_depos_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_IngrEgre_x_Cbte_depos_Data data = new ba_IngrEgre_x_Cbte_depos_Data();

        public Boolean GrabarDB(List<ba_IngrEgre_x_Cbte_depos_Info> lista)
        {
            try
            {
                return data.GrabarDB(lista);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_IngrEgre_x_Cbte_depos_Bus) };
            }
        }

        public Boolean EliminarCobrosDepositados(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, string TipoIngEgr)
        {
            try
            {
                return data.EliminarCobrosDepositados(IdEmpresa, IdCbteCble, IdTipocbte, TipoIngEgr);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarCobrosDepositados", ex.Message), ex) { EntityType = typeof(ba_IngrEgre_x_Cbte_depos_Bus) };
            }

        }
        
        public ba_IngrEgre_x_Cbte_depos_Bus()
        {
            
        }

    }
}
