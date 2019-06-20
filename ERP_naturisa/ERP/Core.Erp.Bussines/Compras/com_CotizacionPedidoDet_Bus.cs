using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_CotizacionPedidoDet_Bus
    {
        com_CotizacionPedidoDet_Data odata = new com_CotizacionPedidoDet_Data();

        public List<com_CotizacionPedidoDet_Info> GetList(int IdEmpresa, decimal IdCotizacion, string Cargo)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdCotizacion, Cargo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedidoDet_Info> GetListCotizacion(int IdEmpresa, string IdUsuario_com)
        {
            try
            {
                return odata.GetListCotizacion(IdEmpresa, IdUsuario_com);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedidoDet_Info> GetListPedido(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                return odata.GetListPedido(IdEmpresa, IdOrdenPedido, IdUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
