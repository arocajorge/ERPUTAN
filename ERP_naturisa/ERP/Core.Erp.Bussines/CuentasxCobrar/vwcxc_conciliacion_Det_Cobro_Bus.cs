using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class vwcxc_conciliacion_Det_Cobro_Bus
    {
        vwcxc_conciliacion_Det_Cobro_Data conciliaDetData = new vwcxc_conciliacion_Det_Cobro_Data();

        public List<vwcxc_conciliacion_Det_Cobro_Info> Get_List_conciliacion_Det_Cobro(int IdEmpresa, int IdSucursal, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                return conciliaDetData.Get_List_conciliacion_Det_Cobro(IdEmpresa, IdSucursal, IdConciliacion, ref mensaje);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_conciliacion_Det_Cobro", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }
        }

    }
}
