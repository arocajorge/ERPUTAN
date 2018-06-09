using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;
//DEREK MEJIA 10/03/2014
namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_conciliacion_det_Bus
    {
        cp_conciliacion_det_Data Data = new cp_conciliacion_det_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<cp_conciliacion_det_Info> Get_List_conciliacion_det(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return Data.Get_List_conciliacion_det(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_conciliacion_det", ex.Message), ex) { EntityType = typeof(cp_conciliacion_det_Bus) };
            }
        }

        public Boolean GrabarDB(List<cp_conciliacion_det_Info> Info)
        {
            try
            {
                return Data.GrabarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_det_Bus) };
            }
        }

        public List<cp_conciliacion_det_Info> Get_List_Conciliacion_x_cbte_cble(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return Data.Get_List_Conciliacion_x_cbte_cble(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_x_cbte_cble", ex.Message), ex) { EntityType = typeof(cp_conciliacion_det_Bus) };
            }
        }
    }
}
