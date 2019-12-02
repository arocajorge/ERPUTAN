using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_OrdenPedido_Bus
    {
        com_OrdenPedido_Data odata = new com_OrdenPedido_Data();

        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdUsuario, FechaIni, FechaFin);
            }
            catch (Exception)
            {
                throw;
            }
        }



        public bool GuardarDB(com_OrdenPedido_Info info)
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

        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdUsuario);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ModificarDB(com_OrdenPedido_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularDB(com_OrdenPedido_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public com_OrdenPedido_Info GetInfo(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, IdOrdenPedido);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ValidarProceso(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                return odata.ValidarProceso(IdEmpresa, IdOrdenPedido);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ValidarProceso(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int Secuencia)
        {
            try
            {
                return odata.ValidarProceso(IdEmpresa, IdSucursal, IdOrdenCompra, Secuencia);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool SaltarPaso2(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                return odata.SaltarPaso2(IdEmpresa, IdOrdenPedido, IdUsuario);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool SaltarPaso3(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                return odata.SaltarPaso3(IdEmpresa, IdOrdenPedido, IdUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool SaltarPaso4(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                return odata.SaltarPaso4(IdEmpresa, IdOrdenPedido, IdUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
