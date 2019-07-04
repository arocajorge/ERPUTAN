using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    using Core.Erp.Data.Inventario;
    using Core.Erp.Info.General;
    public class com_OrdenPedidoDet_Data
    {
        
        public List<com_OrdenPedidoDet_Info> GetList(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                List<com_OrdenPedidoDet_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).Select(q => new com_OrdenPedidoDet_Info
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
                        opd_Detalle = q.opd_Detalle,
                        IdUnidadMedida_Consumo = q.IdUnidadMedida_Consumo,
                        Stock = q.Stock,
                        Adjunto = q.Adjunto,
                        EstadoDetalle = q.EstadoDetalle,
                        NombreArchivo = q.NombreArchivo,
                        NomComprador = q.NomComprador
                    }).ToList();
                }
                in_Producto_data odata = new in_Producto_data();
                foreach (var item in Lista.Where(q => q.IdProducto != null).ToList())
                {
                    item.Stock = odata.GetStockProductoPorEmpresa(item.IdEmpresa, item.IdProducto ?? 0);
                }

                return Lista;
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
                List<com_OrdenPedidoDet_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_OrdenPedidoDet_Aprobacion.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && q.opd_EstadoProceso == Estado).Select(q => new com_OrdenPedidoDet_Info
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
                        opd_Detalle = q.opd_Detalle,
                        IdUnidadMedida_Consumo = q.IdUnidadMedida_Consumo,
                        Stock = q.Stock,
                        nom_solicitante = q.nom_solicitante,
                        Adjunto = q.Adjunto,

                        op_Observacion = q.op_Observacion,
                        op_Fecha = q.op_Fecha,
                        NombreArchivo = q.NombreArchivo
                        
                    }).ToList();
                }
                Lista.ForEach(q => q.op_Observacion = "Pedido #" + q.IdOrdenPedido.ToString() + " " + q.op_Fecha.ToString("dd/MM/yyyy") + " " + q.op_Observacion);
                in_Producto_data odata = new in_Producto_data();
                foreach (var item in Lista.Where(q => q.IdProducto != null).ToList())
                {
                    item.Stock = odata.GetStockProductoPorEmpresa(item.IdEmpresa, item.IdProducto ?? 0);
                }

                return Lista;
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
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    foreach (var item in Lista)
                    {
                        var Entity = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.IdOrdenPedido && q.Secuencia == item.Secuencia).FirstOrDefault();
                        if (Entity != null)
                        {
                            Entity.opd_CantidadApro = item.A == true ? item.opd_CantidadApro : 0;
                            Entity.opd_EstadoProceso = item.A == true ? "A" : "RA";
                        }
                    }
                    db.SaveChanges();
                    var Ordenes = Lista.GroupBy(q => new { q.IdEmpresa, q.IdOrdenPedido }).Select(q => new { IdEmpresa = q.Key.IdEmpresa, IdOrdenPedido = q.Key.IdOrdenPedido }).ToList();
                    foreach (var item in Ordenes)
                    {
                        var cab = db.com_OrdenPedido.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.IdOrdenPedido).FirstOrDefault();
                        if (cab != null)
                        {
                            cab.IdCatalogoEstado = Cl_Enumeradores.eCatalogoEstadoSolicitudPedido.EST_OP_PRO.ToString();
                        }
                    }
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RechazarComprador(List<com_OrdenPedidoDet_Info> Lista)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    foreach (var item in Lista)
                    {
                        var det = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.IdOrdenPedido && q.Secuencia == item.Secuencia).FirstOrDefault();
                        if (det != null)
                        {
                            det.opd_EstadoProceso = "RC";
                            det.opd_Detalle = "Com:"+item.opd_Detalle+" Sol:"+det.opd_Detalle;
                        }
                        db.SaveChanges();
                    }
                    var Ordenes = Lista.GroupBy(q => new { q.IdEmpresa, q.IdOrdenPedido }).Select(q => new { IdEmpresa = q.Key.IdEmpresa, IdOrdenPedido = q.Key.IdOrdenPedido }).ToList();
                    foreach (var item in Ordenes)
                    {
                        var cab = db.com_OrdenPedido.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.IdOrdenPedido).FirstOrDefault();
                        if (cab != null)
                        {
                            cab.IdCatalogoEstado = Cl_Enumeradores.eCatalogoEstadoSolicitudPedido.EST_OP_PRO.ToString();
                        }
                    }
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
