CREATE VIEW [dbo].[vwcom_OrdenPedidoDet_PorOC]
AS
SELECT d.IdEmpresa AS IdEmpresa_oc, d.IdSucursal AS IdSucursal_oc, d.IdOrdenCompra, d.Secuencia AS Secuencia_oc, a.IdOrdenPedido, a.Secuencia AS Secuencia_pd, dbo.in_Ing_Egr_Inven_det.IdNumMovi
FROM     dbo.com_OrdenPedidoDet AS a INNER JOIN
                  dbo.com_CotizacionPedidoDet AS b ON a.IdEmpresa = b.opd_IdEmpresa AND a.IdOrdenPedido = b.opd_IdOrdenPedido AND a.Secuencia = b.opd_Secuencia INNER JOIN
                  dbo.com_CotizacionPedido AS c ON b.IdEmpresa = c.IdEmpresa AND b.IdCotizacion = c.IdCotizacion INNER JOIN
                  dbo.com_ordencompra_local_det AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.oc_IdOrdenCompra = d.IdOrdenCompra AND b.Secuencia = d.Secuencia LEFT JOIN
                  dbo.in_Ing_Egr_Inven_det ON d.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_oc AND d.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_oc AND d.IdOrdenCompra = dbo.in_Ing_Egr_Inven_det.IdOrdenCompra AND 
                  d.Secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia_oc
WHERE  (c.oc_IdOrdenCompra IS NOT NULL)
GROUP BY d.IdEmpresa, d.IdSucursal, d.IdOrdenCompra, d.Secuencia, a.IdOrdenPedido, a.Secuencia, dbo.in_Ing_Egr_Inven_det.IdNumMovi