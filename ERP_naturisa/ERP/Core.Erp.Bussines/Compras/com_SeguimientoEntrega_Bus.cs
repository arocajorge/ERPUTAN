using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_SeguimientoEntrega_Bus
    {
        com_SeguimientoEntrega_Data odata = new com_SeguimientoEntrega_Data();

        public List<com_SeguimientoEntrega_Info> GetList(int IdEmpresa, string IdUsuario, int IdSolicitante, int IdComprador, decimal IdProducto, decimal IdProveedor, DateTime FechaIni, DateTime FechaFin, decimal IdOrdenPedido)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdUsuario, IdSolicitante, IdComprador, IdProducto, IdProveedor, FechaIni, FechaFin, IdOrdenPedido);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_SeguimientoEntrega_Info> GetListConCosto(int IdEmpresa, DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                return odata.GetListConCosto(IdEmpresa, FechaDesde, FechaHasta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
