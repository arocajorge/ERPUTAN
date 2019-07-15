using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_ConvenioPreciosPorProducto_Data
    {
        public List<com_ConvenioPreciosPorProducto_Info> GetList(int IdEmpresa)
        {
            try
            {
                List<com_ConvenioPreciosPorProducto_Info> Lista;


                return new List<com_ConvenioPreciosPorProducto_Info>();
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
                com_ConvenioPreciosPorProducto_Info info;

                return new com_ConvenioPreciosPorProducto_Info();
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
                return true;
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
                return true;
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

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
