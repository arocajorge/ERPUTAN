using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class vwcxc_cobros_conciliados_Bus
    {
        vwcxc_cobros_conciliados_Data conciliadoData = new vwcxc_cobros_conciliados_Data();

        public List<vwcxc_cobros_conciliados_Info> Get_List_cobros_conciliados(int IdEmpresa, int IdSucursal, decimal IdConciliacion, string tipoConciliacion, ref string mensaje)
        {
            try
            {
                return conciliadoData.Get_List_cobros_conciliados(IdEmpresa, IdSucursal, IdConciliacion, tipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_conciliados", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_conciliados_Bus) };
            }   
        }



    }
}
