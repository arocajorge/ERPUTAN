using Core.Erp.Data.CuentasxCobrar_Grafinpren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt001_Bus
    {
        XCXC_GRAF_Rpt001_Data oData = new XCXC_GRAF_Rpt001_Data();

        public List<XCXC_GRAF_Rpt001_Info> Get_list_x_empresa(int IdEmpresa, int IdVendedor, DateTime Fecha_ini, DateTime Fecha_fin, List<string> lst_TipoCobro)
        {
            try
            {
                return oData.Get_list_x_empresa(IdEmpresa, IdVendedor, Fecha_ini, Fecha_fin, lst_TipoCobro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_x_empresa", ex.Message), ex) { EntityType = typeof(XCXC_GRAF_Rpt001_Bus) };
            }
        }
    }
}
