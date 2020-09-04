using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_SeguimientoOrdenCompraContable_Bus
    {
        com_SeguimientoOrdenCompraContable_Data odata = new com_SeguimientoOrdenCompraContable_Data();

        public List<com_SeguimientoOrdenCompraContable_Info> GetList(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
