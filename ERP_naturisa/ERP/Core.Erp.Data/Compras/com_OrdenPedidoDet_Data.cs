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
    using System.Data.SqlClient;
    public class com_OrdenPedidoDet_Data
    {
        com_OrdenPedido_Data odata_c = new com_OrdenPedido_Data();
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

        public List<com_OrdenPedidoDet_Info> GetListRegularizacion(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                List<com_OrdenPedidoDet_Info> Lista = new List<com_OrdenPedidoDet_Info>();

                string query = "select a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, a.IdProducto, a.pr_descripcion, e.IdUnidadMedida, a.IdSucursalOrigen, a.IdSucursalDestino,"
                        + " a.IdPunto_cargo, a.opd_Detalle, e.do_Cantidad opd_Cantidad, e.do_Cantidad opd_CantidadApro, a.opd_EstadoProceso, CASE WHEN a.opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN a.opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN a.opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN a.opd_EstadoProceso = 'AJC' THEN"
                        + " 'PRECIO APROBADO' WHEN a.opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN a.opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN a.opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN a.opd_EstadoProceso"
                        + " = 'RGA' THEN 'COTIZACION RECHAZADA' WHEN a.opd_EstadoProceso = 'I' THEN 'INGRESADO EN BODEGA' END AS EstadoDetalle, d.Descripcion as nom_comprador,"
                        + " f.codigo +'-'+ cast( e.IdOrdenCompra as varchar) CodigoOrdenCompra, e.IdSucursal as IdSucursal_oc, e.IdOrdenCompra"
                        + " from com_ordenpedidodet as a inner join"
                        + " com_CotizacionPedidoDet as b on a.IdEmpresa = b.opd_IdEmpresa and a.IdOrdenPedido = b.opd_IdOrdenPedido and a.Secuencia = b.opd_Secuencia inner join"
                        + " com_CotizacionPedido as c on b.IdEmpresa = c.IdEmpresa and b.IdCotizacion = c.IdCotizacion inner join"
                        + " com_comprador as d on c.IdEmpresa = d.IdEmpresa and c.IdComprador = d.IdComprador inner join"
                        + " com_ordencompra_local_det as e on c.IdEmpresa = e.IdEmpresa and c.IdSucursal = e.IdSucursal and c.oc_IdOrdenCompra = e.IdOrdenCompra and b.Secuencia = e.Secuencia inner join"
                        + " tb_sucursal as f on e.IdEmpresa = f.IdEmpresa and e.IdSucursal = f.IdSucursal"
                        + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdOrdenPedido = " + IdOrdenPedido.ToString() + " and b.EstadoGA = 1 "
                        + " and not exists"
                        + " (select x1.IdEmpresa from com_OrdenPedidoDet as x1"
                        + " where x1.IdEmpresa = a.IdEmpresa and x1.IdOrdenPedidoReg = a.IdOrdenPedido and x1.SecuenciaReg = a.Secuencia)";

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int? IdPuntoCargo = null;
                        if (!string.IsNullOrEmpty(reader["IdPunto_cargo"].ToString()))
                            IdPuntoCargo = Convert.ToInt32(reader["IdPunto_cargo"]);

                        Lista.Add(new com_OrdenPedidoDet_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdOrdenPedido = Convert.ToDecimal(reader["IdOrdenPedido"]),
                            Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_descripcion = reader["pr_descripcion"].ToString(),
                            IdUnidadMedida = reader["IdUnidadMedida"].ToString(),
                            IdSucursalOrigen = Convert.ToInt32(reader["IdSucursalOrigen"]),
                            IdSucursalDestino = Convert.ToInt32(reader["IdSucursalDestino"]),
                            IdPunto_cargo = IdPuntoCargo,
                            opd_Detalle = (reader["pr_descripcion"] ?? "").ToString(),
                            opd_Cantidad = Convert.ToDouble(reader["opd_Cantidad"]),
                            opd_CantidadApro = Convert.ToDouble(reader["opd_CantidadApro"]),
                            opd_EstadoProceso = (reader["opd_EstadoProceso"] ?? "").ToString(),
                            EstadoDetalle = (reader["EstadoDetalle"] ?? "").ToString(),
                            NomComprador = (reader["nom_comprador"] ?? "").ToString(),
                            CodigoOrdenCompra = reader["CodigoOrdenCompra"].ToString(),
                            IdSucursal_oc = Convert.ToInt32(reader["IdSucursal_oc"]),
                            IdOrdenCompra = Convert.ToDecimal(reader["IdOrdenCompra"])
                        });
                    }
                    reader.Close();
                }

                return Lista;
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
                List<com_OrdenPedidoDet_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.com_OrdenPedidoPlantillaDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdPlantilla == IdPlantilla).Select(q => new com_OrdenPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        Secuencia = q.Secuencia,
                        IdProducto = q.IdProducto,
                        pr_descripcion = q.pr_descripcion,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdSucursalDestino = q.IdSucursalDestino,
                        IdSucursalOrigen = q.IdSucursalOrigen,
                        IdPunto_cargo = q.IdPunto_cargo,
                        opd_Cantidad = q.opd_Cantidad,
                        opd_Detalle = q.opd_Detalle,
                        IdUnidadMedida_Consumo = q.IdUnidadMedida,
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
                /*
                in_Producto_data odata = new in_Producto_data();                
                foreach (var item in Lista.Where(q => q.IdProducto != null).ToList())
                {
                    item.Stock = 0;//odata.GetStockProductoPorEmpresa(item.IdEmpresa, item.IdProducto ?? 0);
                }*/

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
                            Entity.IdUsuarioCantidad = item.IdUsuario;
                            Entity.FechaCantidad = DateTime.Now;
                        }
                    }
                    db.SaveChanges();
                    var Ordenes = Lista.GroupBy(q => new { q.IdEmpresa, q.IdOrdenPedido }).Select(q => new
                    {
                        IdEmpresa = q.Key.IdEmpresa,
                        IdOrdenPedido = q.Key.IdOrdenPedido
                    }).ToList();
                    foreach (var item in Ordenes)
                    {
                        odata_c.ValidarProceso(item.IdEmpresa, item.IdOrdenPedido);
                    }
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
                            det.IdUsuarioCotizacion = item.IdUsuario;
                            det.FechaCotizacion = DateTime.Now;
                        }
                        db.SaveChanges();
                    }
                    var Ordenes = Lista.GroupBy(q => new { q.IdEmpresa, q.IdOrdenPedido }).Select(q => new
                    {
                        IdEmpresa = q.Key.IdEmpresa,
                        IdOrdenPedido = q.Key.IdOrdenPedido
                    }).ToList();
                    foreach (var item in Ordenes)
                    {
                        odata_c.ValidarProceso(item.IdEmpresa, item.IdOrdenPedido);
                    }
                }
                return true;
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
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.Secuencia == Secuencia).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    Entity.IdProducto = IdProducto;
                    Entity.pr_descripcion = pr_descripcion;
                    Entity.IdUnidadMedida = IdUnidadMedida;
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
