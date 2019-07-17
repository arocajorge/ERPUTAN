using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_ConvenioPreciosPorProducto_Bus
    {
        com_ConvenioPreciosPorProducto_Data odata = new com_ConvenioPreciosPorProducto_Data();

        public List<com_ConvenioPreciosPorProducto_Info> GetList(int IdEmpresa)
        {
            try
            {
                return odata.GetList(IdEmpresa);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public com_ConvenioPreciosPorProducto_Info GetInfo(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, IdProducto);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(com_ConvenioPreciosPorProducto_Info info)
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

        public bool ModificarDB(com_ConvenioPreciosPorProducto_Info info)
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

        public bool EliminarDB(com_ConvenioPreciosPorProducto_Info info)
        {
            try
            {
                return odata.EliminarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
