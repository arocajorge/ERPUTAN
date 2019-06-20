using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_CotizacionPedido_Bus
    {
        com_CotizacionPedido_Data odata = new com_CotizacionPedido_Data();

        public bool GuardarDB(com_CotizacionPedido_Info info)
        {
            try
            {
                return odata.GuardarDB(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedido_Info> GetListAprobar(int IdEmpresa, string IdUsuario, string Cargo)
        {
            try
            {
                return odata.GetListAprobar(IdEmpresa, IdUsuario, Cargo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AprobarDB(com_CotizacionPedido_Info info, string Cargo)
        {
            try
            {
                return odata.AprobarDB(info,Cargo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool PasarDB(int IdEmpresa, decimal IdCotizacion, string IdUsuario)
        {
            try
            {
                return odata.PasarDB(IdEmpresa, IdCotizacion, IdUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public com_CotizacionPedido_Info GetInfoAprobar(int IdEmpresa, string IdUsuario, string Cargo)
        {
            try
            {
                return odata.GetInfoAprobar(IdEmpresa, IdUsuario, Cargo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public com_CotizacionPedido_Info GetInfoAprobar(int IdEmpresa, decimal IdCotizacion)
        {
            try
            {
                return odata.GetInfoAprobar(IdEmpresa, IdCotizacion);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
