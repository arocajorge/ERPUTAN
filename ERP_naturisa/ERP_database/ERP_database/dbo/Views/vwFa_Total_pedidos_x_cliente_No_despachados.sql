create view [dbo].[vwFa_Total_pedidos_x_cliente_No_despachados]
as
SELECT     fa_pedido.IdEmpresa, fa_pedido.IdCliente, SUM(fa_pedido_det.dp_total) AS dp_total
FROM         fa_pedido INNER JOIN
                      fa_pedido_det ON fa_pedido.IdEmpresa = fa_pedido_det.IdEmpresa AND fa_pedido.IdSucursal = fa_pedido_det.IdSucursal AND 
                      fa_pedido.IdBodega = fa_pedido_det.IdBodega AND fa_pedido.IdPedido = fa_pedido_det.IdPedido LEFT OUTER JOIN
                      fa_orden_Desp_det_x_fa_pedido_det ON fa_pedido_det.IdEmpresa = fa_orden_Desp_det_x_fa_pedido_det.pe_IdEmpresa AND 
                      fa_pedido_det.IdSucursal = fa_orden_Desp_det_x_fa_pedido_det.pe_IdSucursal AND 
                      fa_pedido_det.IdBodega = fa_orden_Desp_det_x_fa_pedido_det.pe_IdBodega AND fa_pedido_det.IdPedido = fa_orden_Desp_det_x_fa_pedido_det.pe_IdPedido AND 
                      fa_pedido_det.Secuencial = fa_orden_Desp_det_x_fa_pedido_det.pe_Secuencia
WHERE     (fa_orden_Desp_det_x_fa_pedido_det.od_IdEmpresa IS NULL) AND (fa_pedido.IdEstadoAprobacion <> 'R')
GROUP BY fa_pedido.IdEmpresa, fa_pedido.IdCliente