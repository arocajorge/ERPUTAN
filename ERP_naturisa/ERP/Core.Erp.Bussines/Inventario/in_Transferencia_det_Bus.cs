using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario
{
    public class in_Transferencia_det_Bus
    {
        in_Transferencia_det_Data odata = new in_Transferencia_det_Data();

        public List<in_transferencia_det_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdTransferencia)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdSucursal, IdBodega, IdTransferencia);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_transferencia_det_Info> GetList(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
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
