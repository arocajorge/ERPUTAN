using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario
{
    public class in_ProductoPor_tb_bodega_Bus
    {
        in_ProductoPor_tb_bodega_Data odata = new in_ProductoPor_tb_bodega_Data();

        public List<in_ProductoPor_tb_bodega_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega, bool MostrarNoAsignados)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdSucursal, IdBodega, MostrarNoAsignados);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(int IdEmpresa, int IdSucursal, int IdBodega, List<in_ProductoPor_tb_bodega_Info> Lista)
        {
            try
            {
                return odata.GuardarDB(IdEmpresa, IdSucursal, IdBodega, Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string Validar(int IdEmpresa, int IdSucursal, int IdBodega, List<decimal> Lista)
        {
            try
            {
                return odata.Validar(IdEmpresa, IdSucursal, IdBodega, Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
