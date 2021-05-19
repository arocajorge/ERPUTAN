using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_SeguimientoEntrega_Data
    {
        public List<com_SeguimientoEntrega_Info> GetList(int IdEmpresa, string IdUsuario, int IdSolicitante, int IdComprador, decimal IdProducto, decimal IdProveedor, DateTime FechaIni, DateTime FechaFin, decimal IdOrdenPedido)
        {
            try
            {
                List<com_SeguimientoEntrega_Info> Lista = new List<com_SeguimientoEntrega_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.SetCommandTimeOut(3000);
                    var lst = db.SPCOM_SeguimientoEntrega(IdEmpresa, IdUsuario, IdSolicitante, IdComprador, IdProducto, IdProveedor, FechaIni, FechaFin,IdOrdenPedido).ToList();

                    foreach (var item in lst)
                    {
                        Lista.Add(new com_SeguimientoEntrega_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdUsuario = item.IdUsuario,
                            IdOrdenPedido = item.IdOrdenPedido,
                            Secuencia = item.Secuencia,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            EstadoSolpe = item.EstadoSolpe,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            CodigoSucOrigen = item.CodigoSucOrigen,
                            NombreSucursalOrigen = item.NombreSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            CodigoSucDestino = item.CodigoSucDestino,
                            NombreSucursalDestino = item.NombreSucursalDestino,
                            EstadoDetalle = item.EstadoDetalle,
                            nom_solicitante = item.nom_solicitante,
                            op_Fecha = item.op_Fecha,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = item.opd_CantidadApro,
                            IdUsuarioCantidad = item.IdUsuarioCantidad,
                            FechaCantidad = item.FechaCantidad,
                            NombreUsuarioCantidad = item.NombreUsuarioCantidad,
                            NomUnidadMedida = item.NomUnidadMedida,
                            op_Observacion = item.op_Observacion,
                            ObservacionGA = item.ObservacionGA,
                            opd_Detalle = item.opd_Detalle,
                            IdSucursalOC = item.IdSucursalOC,
                            IdOrdenCompra = item.IdOrdenCompra,
                            SecuenciaOC = item.SecuenciaOC,
                            IdProveedor = item.IdProveedor,
                            pe_nombreCompleto = item.pe_nombreCompleto,
                            CodigoOC = item.CodigoOC,
                            CantidadOC = item.CantidadOC,
                            FechaOC = item.FechaOC,
                            FechaEntrega = item.FechaEntrega,
                            IdComprador = item.IdComprador,
                            NombreComprador = item.NombreComprador,
                            IB_UltIdNumMovi = item.IB_UltIdNumMovi,
                            IB_Cantidad = item.IB_Cantidad,
                            IB_Fecha = item.IB_Fecha,
                            AlertaEntrega = item.AlertaEntrega,
                            CantidadPendiente = item.CantidadPendiente,
                            DiasPendiente = item.DiasPendiente,
                            NombreSucursalTransferencia = item.NombreSucursalTransferencia,
                            NombreBodegaTransferencia = item.NombreBodegaTransferencia,
                            FechaTransferencia = item.FechaTransferencia,
                            FechaRecepcionTransferencia = item.FechaRecepcionTransferencia,
                            IdUsuarioGA = item.IdUsuarioGA
                        });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_SeguimientoEntrega_Info> GetListConCosto(int IdEmpresa, DateTime FechaDesde, DateTime FechaHasta)
        {
            List<com_SeguimientoEntrega_Info> Lista = new List<com_SeguimientoEntrega_Info>();

            using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DECLARE @IdEmpresa int = " + IdEmpresa.ToString() + ","
                                    + " @FechaDesde date = datefromparts(" + FechaDesde.Year.ToString() + "," + FechaDesde.Month.ToString() + "," + FechaDesde.Day.ToString() + "),"
                                    + " @FechaHasta date = datefromparts(" + FechaHasta.Year.ToString() + "," + FechaHasta.Month.ToString() + "," + FechaHasta.Day.ToString() + ")"
                                    + " select a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, CASE WHEN a.opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN a.opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN a.opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN a.opd_EstadoProceso ="
                                                              + " 'AJC' THEN 'PRECIO APROBADO' WHEN a.opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN a.opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN a.opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN"
                                                              + " a.opd_EstadoProceso = 'RGA' THEN 'COTIZACION RECHAZADA' WHEN a.opd_EstadoProceso = 'I' THEN 'INGRESADO EN BODEGA' END AS EstadoDetalle, b.op_Fecha, a.IdProducto, a.pr_descripcion,"
                                                              + " c.codigo as CodigoOrigen, c.Su_Descripcion as SucursalOrigen, d.codigo as CodigoDestino, d.Su_Descripcion as SucursalDestino, e.nom_solicitante, a.opd_Cantidad, a.opd_CantidadApro, a.IdUsuarioCantidad,"
                                                              + " f.Descripcion as NomUnidadMedida, b.op_Observacion, b.IdUsuarioAprobacion, b.ObservacionGA, a.opd_Detalle, a.FechaCotizacion, a.IdUsuarioCotizacion, h.IdUsuarioJC, j.pe_nombreCompleto,"
                                                              + " k.codigo+'-'+cast(h.oc_IdOrdenCompra as varchar(20)) as CodigoOC, l.do_Cantidad, l.do_precioFinal, l.do_subtotal, l.do_iva, l.do_total, m.oc_fecha, m.oc_fechaVencimiento, n.Descripcion as NomComprador,"
                                                              + " p.fa_Descripcion as Familia, q.CantidadIngresada, cm_fecha, IdNumMovi"
                                    + " from com_OrdenPedidoDet as a with (nolock)"
                                    + " join com_OrdenPedido as b with (nolock) on a.IdEmpresa = b.IdEmpresa and a.IdOrdenPedido = b.IdOrdenPedido and b.Estado = 1"
                                    + " left join tb_sucursal as c with (nolock) on a.IdEmpresa = c.IdEmpresa and a.IdSucursalOrigen = c.IdSucursal"
                                    + " left join tb_sucursal as d with (nolock) on a.IdEmpresa = d.IdEmpresa and a.IdSucursalDestino = d.IdSucursal"
                                    + " left join com_solicitante as e with (nolock) on b.IdEmpresa = e.IdEmpresa and b.IdSolicitante = e.IdSolicitante"
                                    + " left join in_UnidadMedida as f with (nolock) on a.IdUnidadMedida = f.IdUnidadMedida"
                                    + " left join com_CotizacionPedidoDet as g with (nolock) on a.IdEmpresa = g.opd_IdEmpresa and a.IdOrdenPedido = g.opd_IdOrdenPedido and a.Secuencia = g.opd_Secuencia and g.EstadoJC = 1"
                                    + " left join com_CotizacionPedido as h with (nolock) on h.IdEmpresa = g.IdEmpresa and h.IdCotizacion = g.IdCotizacion"
                                    + " left join cp_proveedor as i with (nolock) on h.IdEmpresa = i.IdEmpresa and h.IdProveedor = i.IdProveedor"
                                    + " left join tb_persona as j with (nolock) on j.IdPersona = i.IdPersona"
                                    + " left join tb_sucursal as k with (nolock) on h.IdEmpresa = k.IdEmpresa and h.IdSucursal = k.IdSucursal"
                                    + " left join com_ordencompra_local_det as l with (nolock) on l.IdEmpresa = h.IdEmpresa and l.IdSucursal = h.IdSucursal and l.IdOrdenCompra = h.oc_IdOrdenCompra and l.Secuencia = g.Secuencia and l.IdProducto = g.IdProducto"
                                    + " left join com_ordencompra_local as m with (nolock) on l.idempresa = m.IdEmpresa and l.IdSucursal = m.IdSucursal and l.IdOrdenCompra = m.IdOrdenCompra"
                                    + " left join com_comprador as n with (nolock) on h.IdEmpresa = n.IdEmpresa and h.IdComprador = n.IdComprador"
                                    + " left join in_Producto as o with (nolock) on o.IdEmpresa = a.IdEmpresa and o.IdProducto = isnull(a.IdProducto,g.IdProducto)"
                                    + " left join in_Familia as p with (nolock) on o.IdEmpresa = p.IdEmpresa and o.IdFamilia = p.IdFamilia"
                                    + " left join"
                                    + " ("
                                        + " select IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc, sum(a.dm_cantidad_sinConversion) CantidadIngresada, max(b.cm_fecha) cm_fecha, max(b.IdNumMovi) IdNumMovi"
                                        + " from in_Ing_Egr_Inven_det as a with (nolock)"
                                        + " join in_Ing_Egr_Inven as b with (nolock) on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi"
                                        + " where a.IdEmpresa = @IdEmpresa"
                                        + " group by IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc"
                                    + " ) q on q.IdEmpresa_oc =l.IdEmpresa and q.IdSucursal_oc = l.IdSucursal and q.IdOrdenCompra = l.IdOrdenCompra and q.Secuencia_oc = l.Secuencia"
                                    + " where a.IdEmpresa = @IdEmpresa and b.op_Fecha between @FechaDesde and @FechaHasta";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lista.Add(new com_SeguimientoEntrega_Info
                    {

                        IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                        IdOrdenPedido = Convert.ToDecimal(reader["IdOrdenPedido"]),
                        Secuencia = Convert.ToInt32(reader["Secuencia"]),
                        EstadoDetalle = Convert.ToString(reader["EstadoDetalle"]),
                        op_Fecha = Convert.ToDateTime(reader["op_Fecha"]),
                        IdProducto = reader["IdProducto"] == DBNull.Value ? null : (decimal?)(reader["IdProducto"]),
                        pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                        CodigoSucOrigen = Convert.ToString(reader["CodigoOrigen"]),
                        NombreSucursalOrigen = Convert.ToString(reader["SucursalOrigen"]),
                        CodigoSucDestino = Convert.ToString(reader["CodigoDestino"]),
                        NombreSucursalDestino = Convert.ToString(reader["SucursalDestino"]),
                        nom_solicitante = Convert.ToString(reader["nom_solicitante"]),
                        opd_Cantidad =  Convert.ToDouble(reader["opd_Cantidad"]),
                        opd_CantidadApro = Convert.ToDouble(reader["opd_CantidadApro"]),
                        IdUsuarioCantidad = Convert.ToString(reader["IdUsuarioCantidad"]),
                        NomUnidadMedida = Convert.ToString(reader["NomUnidadMedida"]),
                        op_Observacion = Convert.ToString(reader["op_Observacion"]),
                        IdUsuarioGA = Convert.ToString(reader["IdUsuarioAprobacion"]),
                        ObservacionGA = Convert.ToString(reader["ObservacionGA"]),
                        opd_Detalle = Convert.ToString(reader["opd_Detalle"]),
                        FechaCotizacion = reader["FechaCotizacion"] == DBNull.Value ? null : (DateTime?)(reader["FechaCotizacion"]),
                        pe_nombreCompleto = Convert.ToString(reader["pe_nombreCompleto"]),
                        CodigoOC = Convert.ToString(reader["CodigoOC"]),
                        CantidadOC = reader["do_Cantidad"] == DBNull.Value ? null : (double?)(reader["do_Cantidad"]),
                        do_precioFinal = reader["do_precioFinal"] == DBNull.Value ? null : (double?)(reader["do_precioFinal"]),
                        do_subtotal = reader["do_subtotal"] == DBNull.Value ? null : (double?)(reader["do_subtotal"]),
                        do_iva = reader["do_iva"] == DBNull.Value ? null : (double?)(reader["do_iva"]),
                        do_total = reader["do_total"] == DBNull.Value ? null : (double?)(reader["do_total"]),
                        FechaOC = reader["oc_fecha"] == DBNull.Value ? null : (DateTime?)(reader["oc_fecha"]),
                        FechaEntrega = reader["oc_fechaVencimiento"] == DBNull.Value ? null : (DateTime?)(reader["oc_fechaVencimiento"]),
                        NombreComprador = Convert.ToString(reader["NomComprador"]),
                        Familia = Convert.ToString(reader["Familia"]),
                        IB_Cantidad = reader["CantidadIngresada"] == DBNull.Value ? null : (double?)(reader["CantidadIngresada"]),
                        IB_Fecha = reader["cm_fecha"] == DBNull.Value ? null : (DateTime?)(reader["cm_fecha"]),
                        IB_UltIdNumMovi = reader["IdNumMovi"] == DBNull.Value ? null : (decimal?)(reader["IdNumMovi"])
                    });
                }
                reader.Close();

            }

            return Lista;
        }
    }
}
