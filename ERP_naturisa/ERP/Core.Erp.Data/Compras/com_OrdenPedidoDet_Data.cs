using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedidoDet_Data
    {
        public List<com_OrdenPedidoDet_Info> GetList(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                List<com_OrdenPedidoDet_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).Select(q => new com_OrdenPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdOrdenPedido = q.IdOrdenPedido,
                        Secuencia = q.Secuencia,
                        IdProducto = q.IdProducto,
                        pr_descripcion = q.pr_descripcion,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdSucursalDestino = q.IdSucursalDestino,
                        IdSucursalOrigen = q.IdSucursalOrigen,
                        IdPunto_cargo = q.IdPunto_cargo,
                        opd_Cantidad = q.opd_Cantidad,
                        opd_CantidadApro = q.opd_CantidadApro,
                        opd_EstadoProceso = q.opd_EstadoProceso,
                        opd_Detalle = q.opd_Detalle
                    }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
