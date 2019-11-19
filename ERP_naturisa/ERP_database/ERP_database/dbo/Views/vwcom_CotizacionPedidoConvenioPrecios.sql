CREATE VIEW [dbo].[vwcom_CotizacionPedidoConvenioPrecios]
AS
SELECT IdEmpresa, IdCotizacion, IdOrdenPedido
FROM     (SELECT dbo.com_CotizacionPedidoDet.IdEmpresa, dbo.com_CotizacionPedidoDet.IdCotizacion, dbo.com_OrdenPedidoDet.IdOrdenPedido, CASE WHEN com_ConvenioPreciosPorProducto.IdProducto IS NULL 
                                    THEN 0 ELSE 1 END AS Cont, 1 AS Contador
                  FROM      dbo.com_OrdenPedido INNER JOIN
                                    dbo.com_OrdenPedidoDet ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_OrdenPedidoDet.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = dbo.com_OrdenPedidoDet.IdOrdenPedido INNER JOIN
                                    dbo.com_CotizacionPedidoDet ON dbo.com_OrdenPedidoDet.IdEmpresa = dbo.com_CotizacionPedidoDet.opd_IdEmpresa AND dbo.com_OrdenPedidoDet.IdOrdenPedido = dbo.com_CotizacionPedidoDet.opd_IdOrdenPedido AND 
                                    dbo.com_OrdenPedidoDet.Secuencia = dbo.com_CotizacionPedidoDet.opd_Secuencia LEFT OUTER JOIN
                                    dbo.com_ConvenioPreciosPorProducto ON dbo.com_CotizacionPedidoDet.IdEmpresa = dbo.com_ConvenioPreciosPorProducto.IdEmpresa AND 
                                    dbo.com_CotizacionPedidoDet.IdProducto = dbo.com_ConvenioPreciosPorProducto.IdProducto
where SaltoPaso4 = 1) AS a 
GROUP BY IdEmpresa, IdCotizacion, IdOrdenPedido
HAVING (SUM(Cont) = SUM(Contador)) AND (SUM(Cont) > 0)