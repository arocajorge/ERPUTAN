using Core.Erp.Data.MobileSCI;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.MobileSCI
{
    public class tbl_producto_x_tbl_bodega_Bus
    {
        tbl_producto_x_tbl_bodega_Data odata = new tbl_producto_x_tbl_bodega_Data();

        public List<tbl_producto_x_tbl_bodega_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Guardar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            try
            {
                return odata.Guardar(IdEmpresa, IdSucursal, IdBodega, IdProducto);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Anular(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            try
            {
                return odata.Anular(IdEmpresa, IdSucursal, IdBodega, IdProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
