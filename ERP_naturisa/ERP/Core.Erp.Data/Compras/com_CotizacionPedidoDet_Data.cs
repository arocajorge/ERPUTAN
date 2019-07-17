using Core.Erp.Data.Inventario;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_CotizacionPedidoDet_Data
    {
        public List<com_CotizacionPedidoDet_Info> GetList(int IdEmpresa, decimal IdCotizacion, string Cargo)
        {
            try
            {
                List<com_CotizacionPedidoDet_Info> Lista = new List<com_CotizacionPedidoDet_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_CotizacionPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdCotizacion == IdCotizacion).Select(q => new com_CotizacionPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdCotizacion = q.IdCotizacion,
                        Secuencia = q.Secuencia,
                        opd_IdEmpresa = q.opd_IdEmpresa,
                        opd_IdOrdenPedido = q.opd_IdOrdenPedido,
                        opd_Secuencia = q.opd_Secuencia,
                        IdProducto = q.IdProducto,
                        cd_Cantidad = q.cd_Cantidad,
                        cd_precioCompra = q.cd_precioCompra,
                        cd_porc_des = q.cd_porc_des,
                        cd_descuento = q.cd_descuento,
                        cd_precioFinal = q.cd_precioFinal,
                        cd_subtotal = q.cd_subtotal,
                        IdCod_Impuesto = q.IdCod_Impuesto,
                        Por_Iva = q.Por_Iva,
                        cd_iva = q.cd_iva,
                        cd_total = q.cd_total,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdPunto_cargo = q.IdPunto_cargo,
                        EstadoGA = q.EstadoGA,
                        EstadoJC = q.EstadoJC,
                        pr_descripcion = q.pr_descripcion,
                        NomUnidadMedida = q.NomUnidadMedida,
                        nom_impuesto = q.nom_impuesto,
                        nom_punto_cargo = q.nom_punto_cargo,
                        A = true,
                        cd_DetallePorItem = q.cd_DetallePorItem,
                        op_Observacion = q.op_Observacion,
                        opd_Detalle = q.opd_Detalle,
                        FechaCantidad = q.FechaCantidad
                        
                    }).ToList();
                }

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    foreach (var item in Lista)
                    {
                        var MejorPrecio = db.SPINV_MejorPrecio(IdEmpresa, item.IdProducto).FirstOrDefault();
                        if (MejorPrecio != null)
                            item.MejorPrecio = MejorPrecio.MejorPrecio ?? 0;

                        double Diferencia = item.cd_precioFinal - item.MejorPrecio;
                        item.Color = Diferencia > 0 ? System.Drawing.Color.Red : System.Drawing.Color.Green;
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedidoDet_Info> GetListCotizacion(int IdEmpresa, string IdUsuario_com, DateTime FechaIni, DateTime FechaFin, bool MostrarAR)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                List<com_CotizacionPedidoDet_Info> Lista = new List<com_CotizacionPedidoDet_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Comprador = db.com_comprador.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario_com == IdUsuario_com).FirstOrDefault();
                    if(MostrarAR)
                    Lista = db.vwcom_OrdenPedidoDet_Cotizacion.Where(q => q.IdEmpresa == IdEmpresa && (q.IdUsuario_com  ?? IdUsuario_com)== IdUsuario_com && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_CotizacionPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        opd_IdEmpresa = q.IdEmpresa,
                        opd_IdOrdenPedido = q.IdOrdenPedido,
                        opd_Secuencia = q.Secuencia,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdPunto_cargo = q.IdPunto_cargo,

                        IdSucursalOrigen = q.IdSucursalOrigen,
                        IdSucursalDestino = q.IdSucursalDestino,

                        cd_Cantidad = q.opd_CantidadApro,
                        IdCod_Impuesto = q.IdCod_Impuesto_Iva,
                        pr_descripcion = q.pr_descripcion,
                        opd_Detalle = q.opd_Detalle,
                        IdProducto = q.IdProducto,
                        IdUnidadMedida_Consumo = q.IdUnidadMedida_Consumo,
                        Stock = q.Stock ?? 0,
                        nom_solicitante = q.nom_solicitante,

                        IdDepartamento = q.IdDepartamento,
                        IdSolicitante = q.IdSolicitante,
                        IdComprador = q.IdComprador ?? 0,

                        Add = q.IdProducto == null ? true : false,
                        Selec = q.IdProducto == null ? true : false,
                        Grupo = q.Grupo,
                        Adjunto = q.Adjunto,
                        
                        op_Observacion = q.op_Observacion,
                        op_Fecha = q.op_Fecha,
                        NombreArchivo = q.NombreArchivo,
                        opd_EstadoProceso = q.opd_EstadoProceso,
                        FechaCantidad = q.FechaCantidad,

                        IdProveedor = q.IdProveedor,
                        cd_precioCompra = q.cd_precioCompra ?? 0,
                        cd_porc_des = q.cd_porc_des ?? 0,
                        cd_descuento = q.cd_descuento ?? 0,
                        cd_precioFinal = q.cd_precioFinal ?? 0,
                        cd_subtotal = q.cd_subtotal ?? 0,
                        Por_Iva = q.Por_Iva ?? 0,
                        cd_iva = q.cd_iva ?? 0,
                        cd_total = q.cd_total ?? 0,
                        cd_DetallePorItem = q.cd_DetallePorItem
                    }).ToList();
                    else
                        Lista = db.vwcom_OrdenPedidoDet_Cotizacion.Where(q => q.IdEmpresa == IdEmpresa && q.opd_EstadoProceso == "A" && (q.IdUsuario_com ?? IdUsuario_com) == IdUsuario_com && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            opd_IdEmpresa = q.IdEmpresa,
                            opd_IdOrdenPedido = q.IdOrdenPedido,
                            opd_Secuencia = q.Secuencia,
                            IdUnidadMedida = q.IdUnidadMedida,
                            IdPunto_cargo = q.IdPunto_cargo,

                            IdSucursalOrigen = q.IdSucursalOrigen,
                            IdSucursalDestino = q.IdSucursalDestino,

                            cd_Cantidad = q.opd_CantidadApro,
                            IdCod_Impuesto = q.IdCod_Impuesto_Iva,
                            pr_descripcion = q.pr_descripcion,
                            opd_Detalle = q.opd_Detalle,
                            IdProducto = q.IdProducto,
                            IdUnidadMedida_Consumo = q.IdUnidadMedida_Consumo,
                            Stock = q.Stock ?? 0,
                            nom_solicitante = q.nom_solicitante,

                            IdDepartamento = q.IdDepartamento,
                            IdSolicitante = q.IdSolicitante,
                            IdComprador = q.IdComprador ?? 0,

                            Add = q.IdProducto == null ? true : false,
                            Selec = q.IdProducto == null ? true : false,
                            Grupo = q.Grupo,
                            Adjunto = q.Adjunto,

                            op_Observacion = q.op_Observacion,
                            op_Fecha = q.op_Fecha,
                            NombreArchivo = q.NombreArchivo,
                        opd_EstadoProceso = q.opd_EstadoProceso,
                            FechaCantidad = q.FechaCantidad,

                            IdProveedor = q.IdProveedor,
                            cd_precioCompra = q.cd_precioCompra ?? 0,
                            cd_porc_des = q.cd_porc_des ?? 0,
                            cd_descuento = q.cd_descuento ?? 0,
                            cd_precioFinal = q.cd_precioFinal ?? 0,
                            cd_subtotal = q.cd_subtotal ?? 0,
                            Por_Iva = q.Por_Iva ?? 0,
                            cd_iva = q.cd_iva ?? 0,
                            cd_total = q.cd_total ?? 0,
                            cd_DetallePorItem = q.cd_DetallePorItem

                        }).ToList();
                    Lista.ForEach(q => { q.op_Observacion = "Pedido #" + q.opd_IdOrdenPedido.ToString() + " " + q.op_Fecha.ToString("dd/MM/yyyy") + " " + q.op_Observacion; q.IdComprador = q.IdComprador == 0 ? Comprador.IdComprador : q.IdComprador; });    
                }
                
                /*
                in_Producto_data odata = new in_Producto_data();
                foreach (var item in Lista.Where(q => q.IdProducto != null).ToList())
                {
                    item.Stock = odata.GetStockProductoPorEmpresa(item.IdEmpresa, item.IdProducto ?? 0);
                }*/

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedidoDet_Info> GetListPedido(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                List<com_CotizacionPedidoDet_Info> Lista = new List<com_CotizacionPedidoDet_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_CotizacionPedidoDetAprobacion.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.IdUsuario == IdUsuario).Select(q => new com_CotizacionPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        opd_IdEmpresa = q.IdEmpresa,
                        opd_IdOrdenPedido = q.IdOrdenPedido,
                        opd_Secuencia = q.Secuencia,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdPunto_cargo = q.IdPunto_cargo,

                        IdSucursalOrigen = q.IdSucursalOrigen,
                        IdSucursalDestino = q.IdSucursalDestino,

                        cd_Cantidad = q.cd_cantidad,
                        IdCod_Impuesto = q.IdCod_Impuesto,
                        pr_descripcion = q.pr_descripcion,
                        IdProducto = q.IdProducto,
                        nom_solicitante = q.nom_solicitante,

                        IdDepartamento = q.IdDepartamento,
                        IdSolicitante = q.IdSolicitante,
                        EstadoDetalle = q.EstadoDetalle,

                        cd_precioCompra = q.cd_precioCompra ?? 0,
                        cd_descuento = q.cd_descuento ?? 0,
                        cd_porc_des = q.cd_porc_des ?? 0,
                        Por_Iva = q.Por_Iva ?? 0,
                        cd_iva = q.cd_iva ?? 0,
                        cd_subtotal = q.cd_subtotal ?? 0,
                        cd_total = q.cd_total ?? 0,
                        nom_punto_cargo = q.nom_punto_cargo,
                        NomUnidadMedida = q.nomUnidadMedida,

                        IdCotizacion = q.IdCotizacion ?? 0,
                        Secuencia = q.SecuenciaCot ?? 0,
                        cd_precioFinal = q.cd_precioFinal ?? 0,
                        opd_EstadoProceso = q.opd_EstadoProceso,
                        cd_DetallePorItem = q.cd_DetallePorItem,
                        A = true,
                        

                    }).ToList();

                }
                Lista.ForEach(q => q.op_Observacion = "Pedido #" + q.opd_IdOrdenPedido.ToString() + " " + q.op_Fecha.ToString("dd/MM/yyyy") + " " + q.op_Observacion);

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

        
    }
}
