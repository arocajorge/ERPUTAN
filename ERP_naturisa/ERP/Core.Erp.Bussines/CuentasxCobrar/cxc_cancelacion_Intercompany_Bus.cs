using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{    
    public class cxc_cancelacion_Intercompany_Bus
    {
        cxc_cancelacion_Intercompany_Data Data = new cxc_cancelacion_Intercompany_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<cxc_cancelacion_Intercompany_Info> Get_List_cancelacion_Intercompany(int IdEmpresa)
        {
            try
            {
              return Data.Get_List_cancelacion_Intercompany(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cancelacion_Intercompany", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Bus) };
            }

        }

        public Boolean GuardarDB(cxc_cancelacion_Intercompany_Info info)
        {
            try
            {
                 return Data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Bus) };
            }

        }

        public decimal GetId(decimal IdEmpresa) 
        {
            try
            {
                 return Data.GetId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Bus) };
            }

        }

        public List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info> Get_List_cancelacion_Intercompany_x_cxc_cobro_det(int IdEmpresa, decimal IdCancelacion) 
        {
            try
            {
              return Data.Get_List_cancelacion_Intercompany_x_cxc_cobro_det(IdEmpresa, IdCancelacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cancelacion_Intercompany_x_cxc_cobro_det", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Bus) };
            }

        }
    }
}
