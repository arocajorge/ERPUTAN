﻿using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_OrdenPedidoDet_Bus
    {
        com_OrdenPedidoDet_Data odata = new com_OrdenPedidoDet_Data();

        public List<com_OrdenPedidoDet_Info> GetList(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdOrdenPedido);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_OrdenPedidoDet_Info> GetListRegularizacion(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                return odata.GetListRegularizacion(IdEmpresa, IdOrdenPedido);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<com_OrdenPedidoDet_Info> GetListPlantilla(int IdEmpresa, decimal IdPlantilla)
        {
            try
            {
                return odata.GetListPlantilla(IdEmpresa, IdPlantilla);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool RechazarComprador(List<com_OrdenPedidoDet_Info> Lista)
        {
            try
            {
                return odata.RechazarComprador(Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_OrdenPedidoDet_Info> GetListPorAprobar(int IdEmpresa, string IdUsuario, string Estado)
        {
            try
            {
                return odata.GetListPorAprobar(IdEmpresa, IdUsuario, Estado);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ActualizarEstadoAprobacion(List<com_OrdenPedidoDet_Info> Lista)
        {
            try
            {
                return odata.ActualizarEstadoAprobacion(Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ActualizarProducto(int IdEmpresa, decimal IdOrdenPedido, int Secuencia, decimal IdProducto, string IdUnidadMedida, string pr_descripcion)
        {
            try
            {
                return odata.ActualizarProducto(IdEmpresa,IdOrdenPedido,Secuencia,IdProducto,IdUnidadMedida,pr_descripcion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
