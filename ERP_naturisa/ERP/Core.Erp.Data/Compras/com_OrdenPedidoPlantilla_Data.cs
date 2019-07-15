using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedidoPlantilla_Data
    {
        public List<com_OrdenPedidoPlantilla_Info> GetList(int IdEmpresa, bool MostrarAnulados)
        {
            try
            {
                return new List<com_OrdenPedidoPlantilla_Info>();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public com_OrdenPedidoPlantilla_Info GetInfo(int IdEmpresa, decimal IdPlantilla)
        {
            try
            {
                return new com_OrdenPedidoPlantilla_Info();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(com_OrdenPedidoPlantilla_Info info)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ModificarDB(com_OrdenPedidoPlantilla_Info info)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularDB(com_OrdenPedidoPlantilla_Info info)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
