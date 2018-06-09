using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Business.ActivoFijo
{
    public class vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus
    {
        vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Data dataOcActivo = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Data();

        public List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info> Get_List_OC_Factura_ActivoFijo(int IdEmpresa, decimal IdProveedor, List<fa_catalogo_Info> lstNaturaleza)
        {
            try
            {
                return dataOcActivo.Get_List_OC_Factura_ActivoFijo(IdEmpresa, IdProveedor, lstNaturaleza);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OC_Factura_ActivoFijo", ex.Message), ex) { EntityType = typeof(vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus) };
            }
        }


        public vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus()
        {

        }
    }
}
