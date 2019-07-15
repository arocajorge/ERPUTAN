using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_OrdenPedidoPlantilla_Bus
    {
        com_OrdenPedidoPlantilla_Data odata = new com_OrdenPedidoPlantilla_Data();

        public List<com_OrdenPedidoPlantilla_Info> GetList(int IdEmpresa, bool MostrarAnulados)
        {
            try
            {
                return odata.GetList(IdEmpresa, MostrarAnulados);
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
                return odata.GetInfo(IdEmpresa, IdPlantilla);
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
                return odata.GuardarDB(info);
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
                return odata.ModificarDB(info);
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
                return odata.AnularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
