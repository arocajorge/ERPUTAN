using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_cobro_x_ct_cbtecble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        cxc_cobro_x_ct_cbtecble_Data oData = new cxc_cobro_x_ct_cbtecble_Data();
        public cxc_cobro_x_ct_cbtecble_Info Get_Info_cobro_x_ct_cbtecble(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                return oData.Get_Info_cobro_x_ct_cbtecble(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_cobro_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_ct_cbtecble_Bus) };
            }
        }
        public cxc_cobro_x_ct_cbtecble_Info Get_List_cobro_x_ct_cbtecble_x_Reverso(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                return oData.Get_List_cobro_x_ct_cbtecble_x_Reverso(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_ct_cbtecble_x_Reverso", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_ct_cbtecble_Bus) };
            }
        }
    
    }
}
